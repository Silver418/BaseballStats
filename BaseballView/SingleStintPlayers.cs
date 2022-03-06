using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballView {
    public partial class SingleStintPlayers : Form {
        SeasonPersonStint sps; //stints currently displayed on the calling StintEdit form
        PersonSingleStintList singlePlayerStints;

        CancellationTokenSource cts = null;


        public SingleStintPlayers(SeasonPersonStint sps, SortedDictionary<string, string> teamOptions) {
            InitializeComponent();
            this.sps = sps;

            //set up grid of single-stint players
            resultsGrid.AutoGenerateColumns = false;
            resultsGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("# Stints", "Count"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("Team", "Teams"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("Editable", "IsAlreadyEditable"));

            //team options filter
            filterTeamCmb.DataSource = teamOptions.ToList();
            filterTeamCmb.ValueMember = "Key";
            filterTeamCmb.DisplayMember = "Value";
        }

        //**********
        //Helper Methods
        //**********

        private void SetProgress(int current, int max) {
            Invoke(() => progressLbl.Text = $"Working: {current} of {max} records");
        }
        private void SetProgress(int current, int max, CancellationToken ct) {
            try { //Checking IsCancellationRequested & IsDisposed didn't reliably prevent exceptions. :(
                Invoke(() => progressLbl.Text = $"Working: {current} of {max} records");
            }
            catch (ObjectDisposedException ex){
            }
            
            //Things which do not avoid the ObjectDisposedException:
            /*if (!progressLbl.IsDisposed) {
                Invoke(() => progressLbl.Text = $"Working: {current} of {max} records");
            }*/

            /*if (!ct.IsCancellationRequested) {
                Invoke(() => progressLbl.Text = $"Working: {current} of {max} records");
            }*/
        }

        private void ClearProgress() {
            Invoke(() => progressLbl.Text = "");
        }
        private void ClearProgress(CancellationToken ct) {
            Invoke(() => progressLbl.Text = "");
        }

        private void DisableButtons() {
            Invoke(() => {
                addBtn.Enabled = false;
                removeBtn.Enabled = false;
                clearFilterBtn.Enabled = false;
                filterBtn.Enabled = false;
                filterTeamCmb.Enabled = false;
            });
        }

        private void DisableButtons(CancellationToken ct) {
            if (!ct.IsCancellationRequested) {
                DisableButtons();
            }
        }

        private void EnableButtons() {
            Invoke(() => {
                addBtn.Enabled = true;
                removeBtn.Enabled = true;
                clearFilterBtn.Enabled = true;
                filterBtn.Enabled = true;
                filterTeamCmb.Enabled = true;
            });
        }
        private void EnableButtons(CancellationToken ct) {
            if (!ct.IsCancellationRequested) {
                EnableButtons();
            }
        }

        //add selected set of PersonStintRecords to parent form's editable list
        private void AddOperation(CancellationToken ct) {
            try {
                DataGridViewSelectedRowCollection ourRows = resultsGrid.SelectedRows;
                if (ourRows.Count > 0) {
                    int result = 0;
                    DisableButtons(ct);

                    if (ourRows.Count == 1) {
                        result = AddPersonStint(ourRows[0]);
                    }
                    else { //multi-entry operation: requires cancellation checks
                        for (int i = 0; i < ourRows.Count; i++) {
                            ct.ThrowIfCancellationRequested();
                            SetProgress(i + 1, ourRows.Count, ct);
                            result += AddPersonStint(ourRows[i]);
                        }
                        ClearProgress(ct);
                    }
                    if (result > 0) {
                        MessageBox.Show($"{result} record(s) added for editing." +
                            $"\nReturn to the Stint Editing form to enter dates for new stints.");
                    }
                    else {
                        MessageBox.Show("All selected records are already editable.");
                    }

                    EnableButtons(ct);
                }
                else {
                    MessageBox.Show("No records selected.");
                }
            }
            catch (OperationCanceledException oce) {
            }
        }

        //add one PersonStint record from the single stint players list to the parent form's editable multi-stint player list
        private int AddPersonStint(DataGridViewRow personRow) {
            PersonSingleStintRecord personStint = (PersonSingleStintRecord)personRow.DataBoundItem;
            if (!personStint.IsAlreadyEditable) {

                int result = sps.AddPersonStint((PersonStint)personStint);
                if (result == 1) {
                    personStint.IsAlreadyEditable = true;
                }
                return result;
            }
            else
                return 0;
        }

        //**********
        //Events
        //**********
        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async void addBtn_Click(object sender, EventArgs e) {
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            await Task.Run(() => AddOperation(ct));
            resultsGrid.Refresh();
            resultsGrid.Update();
            cts = null;
        }

        private async void removeBtn_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection ourRows = resultsGrid.SelectedRows;
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;

            if (ourRows.Count > 0) {
                DialogResult doTheThing = MessageBox.Show("WARNING: Removing a single-stint player will delete any dates and StintX values for that player." +
                    $"\n\nAttempt to delete {ourRows.Count} records?", "Delete?", MessageBoxButtons.YesNo);
                if (doTheThing == DialogResult.Yes) {

                    await Task.Run(() => {
                        try {
                            int affectedRows = 0;
                            DisableButtons(ct);
                            for (int i = 0; i < ourRows.Count; i++) {
                                ct.ThrowIfCancellationRequested();
                                SetProgress(i + 1, ourRows.Count, ct);
                                PersonSingleStintRecord personStint = (PersonSingleStintRecord)ourRows[i].DataBoundItem;

                                if (sps.RemovePersonStint(personStint.PlayerId)) {
                                    affectedRows++;
                                    personStint.IsAlreadyEditable = false;
                                }
                            }
                            ClearProgress();
                            MessageBox.Show($"{affectedRows} records deleted.");
                            EnableButtons(ct);
                            Invoke(() => {
                                resultsGrid.Refresh();
                                resultsGrid.Update();
                            });
                        }
                        catch (OperationCanceledException oce) {
                        }
                    }, ct);
                }
            }
            else {
                MessageBox.Show("No records selected.");
            }
            cts = null;
        }

        private void resultsGrid_SelectionChanged(object sender, EventArgs e) {
            if (resultsGrid.SelectedRows.Count > 0) {
                EnableButtons();
            }
            else {
                DisableButtons();
            }
        }

        private async void SingleStintPlayers_Shown(object sender, EventArgs e) {
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            
            Invoke(() => progressLbl.Text = "Working; please wait.");
            await Task.Run(() => {
                try {
                    ct.ThrowIfCancellationRequested();
                    singlePlayerStints = new PersonSingleStintList();
                    singlePlayerStints.ProgressChanged += SingleStintProgressChanged;
                    singlePlayerStints.Populate(sps.Season.YearId, sps.GetPlayers(), ct);
                    Invoke(() => resultsGrid.DataSource = singlePlayerStints.SingleStinters);
                }
                catch (OperationCanceledException oce) {
                }
                catch (InvalidOperationException ex) { }
            }, ct);
            cts = null;
        }

        private void SingleStintProgressChanged(int progress, int max) {
            if (progress == max) {
                ClearProgress();
            }
            else {
                SetProgress(progress, max);
            }
        }

        private void SingleStintPlayers_FormClosing(object sender, FormClosingEventArgs e) {
            if (cts != null) {
                cts.Cancel();
                cts.Dispose();
            }
        }
    }
}