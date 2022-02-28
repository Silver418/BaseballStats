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
        List<PersonStint> singlePlayerStints; //players who have only one stint this season
        //List<PersonStint> multiStinters; //stints currently displayed on the calling StintEdit form

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
            resultsGrid.Columns.Add(Helpers.MakeColumn("Editable"));

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
            if (!ct.IsCancellationRequested) {
                SetProgress(current, max);
            }
        }

        private void ClearProgress() {
            Invoke(() => progressLbl.Text = "");
        }
        private void ClearProgress(CancellationToken ct) {

        }

        private void DisableButtons() {
            Invoke(() => {
                addBtn.Enabled = false;
                removeBtn.Enabled = false;
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
            });
        }
        private void EnableButtons(CancellationToken ct) {
            if (!ct.IsCancellationRequested) {
                EnableButtons();
            }
        }

        //checks whether the players listed in the Single Stinter list already appear in the editable stint list passed
        //to this form by the parent form & marks the "Editable" column appropriately.
        //This goes through both lists entirely; best to use it only once, at initial setup.
        private async void CheckAllSingleStinters(CancellationToken ct) {
            if (resultsGrid.Rows[0].Cells["Editable"].Value == null){ //check whether we've alraedy made these changes; if so, don't bother
                int sIndex = 0; //index for our loop through the Single Stinters list. (also maps to the resultsGrid rows)
                int mIndex = 0; //index for our loop through the Multi Stinters list
                List<PersonStint> multiStinters = sps.GetPlayers();

                await Task.Run(() => {
                    try {
                        while (sIndex < singlePlayerStints.Count && mIndex < multiStinters.Count) {
                            if (ct.IsCancellationRequested) return;
                            SetProgress(sIndex, singlePlayerStints.Count, ct);
                            int comparison = String.Compare(singlePlayerStints[sIndex].PlayerId, multiStinters[mIndex].PlayerId);
                            if (comparison == 0) { //player IDs equal; single-stint player already exists in editable multi-stint list
                                Invoke(() => resultsGrid.Rows[sIndex].Cells["Editable"].Value = true.ToString());
                                sIndex++;
                                mIndex++;
                            }
                            else if (comparison < 0) { //single stint PlayerID < multi stint Player ID: no matches found, no further matches possible
                                if (ct.IsCancellationRequested) return;
                                Invoke(() => resultsGrid.Rows[sIndex].Cells["Editable"].Value = false.ToString());
                                sIndex++;
                            }
                            else { //single stint Player ID > multi stint Player ID: no match found, but remaining multi records might be a match
                                mIndex++;
                            }
                        }
                        // likely to run out of multi-stinters before single stinters. This labels the remaining records
                        for (; sIndex < singlePlayerStints.Count; sIndex++) {
                            if (ct.IsCancellationRequested) return;
                            SetProgress(sIndex, singlePlayerStints.Count, ct);
                            Invoke(() => resultsGrid.Rows[sIndex].Cells["Editable"].Value = false.ToString());
                        }
                        //cleanup
                        ClearProgress();
                        Invoke(() => resultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells);
                    }
                    catch (OperationCanceledException ex) { }
                    catch (ObjectDisposedException ex) { }
                });
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
            if (personRow.Cells["Editable"].Value.Equals(false.ToString())) {
                PersonStint personStint = (PersonStint)personRow.DataBoundItem;

                int result = sps.AddPersonStint(personStint);
                if (result == 1) {
                    personRow.Cells["Editable"].Value = true.ToString();
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

        //adds "true" or "false" to each PlayerStint's row to show whether they are already in the parent form's editable stint list
        private async void resultsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            resultsGrid.ClearSelection();
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            await Task.Run(() => CheckAllSingleStinters(ct), ct);
        }

        private async void addBtn_Click(object sender, EventArgs e) {
            cts = new CancellationTokenSource();
            CancellationToken ct = cts.Token;
            await Task.Run(() => AddOperation(ct));
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
                                if (sps.RemovePersonStint(((PersonStint)ourRows[i].DataBoundItem).PlayerId)) {
                                    affectedRows++;
                                    ourRows[i].Cells["Editable"].Value = false.ToString();
                                }
                            }
                            ClearProgress();
                            MessageBox.Show($"{affectedRows} records deleted.");
                            EnableButtons(ct);
                        }
                        catch (OperationCanceledException oce) {
                        }
                    }, ct);
                }
            }
            else {
                MessageBox.Show("No records selected.");
            }
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
                if (ct.IsCancellationRequested) return;
                singlePlayerStints = Queries.GetSingleStintPlayers(sps.Season.YearId).Result;
            }, ct);
            Invoke(() => resultsGrid.DataSource = singlePlayerStints);
        }

        private async void SingleStintPlayers_FormClosing(object sender, FormClosingEventArgs e) {
            if (cts != null) {
                cts.Cancel();
                cts.Dispose();
            }
        }
    }
}
