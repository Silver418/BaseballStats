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
    public partial class StintEdit : UserControl {
        //handle to container of the this control (so the Close button can remove this control)
        private Panel myHome { get; set; }
        //storage to active data
        SeasonPersonStint sps;
        string activePlayer = "";
        string stintDefaultHeader = "Stints for Selected Player";
        //team filter vars
        string teamDefaultKey = "000000DEFAULT"; //default key for the "select all" team selection filter option
        string teamDefaultText = "<Show All Teams>"; //default text for ^
        SortedDictionary<string, string> teamOptions; //used for filters; will also pass this to child form (single stint editing) rather than rebuild
        //vars for primary/ignorable stints
        string primaryStintStr = "Primary Stint"; //string for name of the primary stint column in the stint editing grid
        string ignoreStintStr = "Ignore Stint"; //string for name of the ignorable stint column in the stint editing grid

        public StintEdit(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //setup Player grid
            playerDataGrid.AutoGenerateColumns = false;
            playerDataGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            playerDataGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            playerDataGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            playerDataGrid.Columns.Add(Helpers.MakeColumn("Total Stints", "Count"));
            playerDataGrid.Columns.Add(Helpers.MakeColumn("Complete?", "IsComplete", "Whether all stints for this player have dates saved"));
            playerDataGrid.Columns.Add(Helpers.MakeColumn("Teams", "Teams", "Teams played for this season"));

            //setup Stint grid
            stintEditGrid.AutoGenerateColumns = false;
            stintEditGrid.Columns.Add(Helpers.MakeColumn("Stint #", "StintId"));
            stintEditGrid.Columns.Add(Helpers.MakeColumn("Team", "TeamName"));
            stintEditGrid.Columns.Add(Helpers.MakeColumn("Start Date", "StintStart", format: "MMM dd"));
            stintEditGrid.Columns.Add(Helpers.MakeColumn("End Date", "StintEnd", format: "MMM dd"));
            stintEditGrid.Columns.Add(Helpers.MakeColumn("Days", "StintDuration", format: "#"));
            stintEditGrid.Columns.Add(Helpers.MakeColumn("StintX", "StintX", "Proportion of season taken by this stint", "0.000;0.000;#"));

            DataGridViewCheckBoxColumn ignoreCol = new DataGridViewCheckBoxColumn()
            { Name = ignoreStintStr, DataPropertyName = "IgnoreStint" };
            stintEditGrid.Columns.Add(ignoreCol);

            DataGridViewCheckBoxColumn primaryCol = new DataGridViewCheckBoxColumn()
            { Name = primaryStintStr, DataPropertyName = "PrimaryStint" };
            stintEditGrid.Columns.Add(primaryCol);

            DisablePrimaryStint();
        }

        //*****
        //Helper Methods
        //*****

        //pull year from the year picker, pull its records, populate player grid
        private async void GetSeason() {
            SeasonDateRecord foundSeason = Queries.GetSeason(yearPicker.Value.Year);
            if (foundSeason != null) {
                //save season record & display start/end dates
                progressLbl.Text = "Working; please wait.";
                await Task.Run(() => sps = new SeasonPersonStint(foundSeason)); //awaited for responsiveness during potentially long task
                progressLbl.Text = "";

                seasonYearLbl.Text = sps.Season.YearId.ToString();
                seasonStartLbl.Text = sps.Season.SeasonStart.ToString("MMM dd");
                seasonEndLbl.Text = sps.Season.SeasonEnd.ToString("MMM dd");
                seasonDaysLbl.Text = sps.Season.SeasonDuration.ToString();

                //retrieve player data & populate player grid
                playerDataGrid.DataSource = sps.GetPlayers();
                playerDataGrid.Enabled = true;
                singleStintsBtn.Enabled = true;

                //enable & populate filter controls
                SetupFilter();

                //clear & lock stint editing grid until a player is selected
                stintEditGrid.DataSource = null;
                stintEditGrid.Enabled = false;
                stintSaveBtn.Enabled = false;
                stintCancelBtn.Enabled = false;
                stintHeader.Text = stintDefaultHeader;

                ActiveControl = playerDataGrid;
            }
            else {
                MessageBox.Show("No matching season record found.\nUse \"Edit Season Dates\" to enter season data.");
            }
        }

        //choose a selected player from the player grid & move their stints to the stint editing grid
        private void SelectPlayer() {
            if (playerDataGrid.SelectedRows.Count == 1) {
                string id = playerDataGrid.SelectedRows[0].Cells["Player ID"].Value.ToString() ?? "";
                List<StintRecord>? stints = sps.GetPlayerStints(id);

                if (stints != null) {
                    activePlayer = id;
                    stintEditGrid.DataSource = stints;
                    stintEditGrid.Enabled = true;
                    stintSaveBtn.Enabled = true;
                    stintCancelBtn.Enabled = true;
                    stintHeader.Text = $"Stints for {playerDataGrid.SelectedRows[0].Cells["First Name"].Value.ToString()} {playerDataGrid.SelectedRows[0].Cells["Last Name"].Value.ToString()}";

                    ActiveControl = stintEditGrid;
                }
            }
        }

        //populate team list in team filter box & enable filter buttons
        private void SetupFilter() {
            if (sps != null) { //check that season has been selected
                //build options for combobox
                teamOptions = sps.GetTeams();
                teamOptions.TryAdd(teamDefaultKey, teamDefaultText);
                filterTeamCmb.DataSource = teamOptions.ToList();
                filterTeamCmb.ValueMember = "Key";
                filterTeamCmb.DisplayMember = "Value";

                //enable filter controls
                filterIncompleteChk.Checked = false;
                filterIncompleteChk.Enabled = true;
                filterTeamCmb.SelectedIndex = 0;
                filterTeamCmb.Enabled = true;
                filterBtn.Enabled = true;
                clearFilterBtn.Enabled = true;
            }
        }

        //apply the currently selected filter
        private void ApplyFilter() {
            if (sps != null) {//check that season has been selected
                if (filterTeamCmb.SelectedValue.ToString().Equals(teamDefaultKey)) {
                    playerDataGrid.DataSource = sps.FilterPlayers(filterIncompleteChk.Checked);
                }
                else {
                    playerDataGrid.DataSource = sps.FilterPlayers(filterIncompleteChk.Checked, filterTeamCmb.SelectedValue.ToString() ?? "");
                }
            }
        }

        private void DisablePrimaryStint() {
            stintEditGrid.Columns[primaryStintStr].ReadOnly = true;
            stintEditGrid.Columns[primaryStintStr].DefaultCellStyle.BackColor = Color.DarkGray;
            foreach (DataGridViewRow row in stintEditGrid.Rows) {
                row.Cells[primaryStintStr].Value = false;
            }
        }

        private void EnablePrimaryStint() {
            stintEditGrid.Columns[primaryStintStr].ReadOnly = false;
            stintEditGrid.Columns[primaryStintStr].DefaultCellStyle.BackColor = Color.White;
        }

        //*****
        //Events
        //*****
        private void closeBtn_Click(object sender, EventArgs e) {
            if (myHome is TabPage) {
                myHome.Parent.Controls.Remove(myHome);
            }
            else {
                myHome.Controls.Remove(this);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            GetSeason();
        }

        private void yearPicker_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                GetSeason();
            }
        }

        private void editPlayerBtn_Click(object sender, EventArgs e) {
            SelectPlayer();
        }

        private void playerDataGrid_SelectionChanged(object sender, EventArgs e) {
            if (playerDataGrid.SelectedRows.Count == 1) {
                editPlayerBtn.Enabled = true;
            }
            else {
                editPlayerBtn.Enabled = false;
            }
        }

        //enter on the player grid
        private void playerDataGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SelectPlayer();
            }
        }

        //double click a player on player grid
        private void playerDataGrid_DoubleClick(object sender, EventArgs e) {
            SelectPlayer();
        }

        //save button for editing stints
        private void stintSaveBtn_Click(object sender, EventArgs e) {
            (bool validated, int recordsUpdated) = sps.ValidateSavePlayer(activePlayer);
            stintEditGrid.Refresh();
            stintEditGrid.Update();
            playerDataGrid.Refresh();
            playerDataGrid.Update();
            if (validated) {
                MessageBox.Show($"Dates valid. {recordsUpdated} records altered.");
                ActiveControl = playerDataGrid;
            }
            else {
                MessageBox.Show("Invalid dates entered.");
                ActiveControl = stintEditGrid;
            }
        }

        //cancel button for editing a player's stints
        private void stintCancelBtn_Click(object sender, EventArgs e) {
            //cancel any changes to the stint, revert to approved copy
            sps.RevertStintsPlayer(activePlayer);
            stintEditGrid.DataSource = sps.GetPlayerStints(activePlayer);
            stintEditGrid.Refresh();
            stintEditGrid.Update();
        }

        //incorrect format entered for stint editing grid input
        private void stintEditGrid_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            stintEditGrid.CancelEdit();
            e.Cancel = true;
        }

        //apply filter button
        private void filterBtn_Click(object sender, EventArgs e) {
            ApplyFilter();
        }

        //"enter" on team filter box
        private void filterTeamCmb_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                ApplyFilter();
            }
        }

        //clear filter button
        private void clearFilterBtn_Click(object sender, EventArgs e) {
            filterIncompleteChk.Checked = false;
            filterTeamCmb.SelectedIndex = 0;
            ApplyFilter();
        }

        //popup form for editing which single-stint players appear in the editing list
        private void singleStintsBtn_Click(object sender, EventArgs e) {
            SingleStintPlayers form = new SingleStintPlayers(sps, teamOptions);
            form.ShowDialog();
            playerDataGrid.DataSource = null;
            playerDataGrid.DataSource = sps.GetPlayers();
        }

        //handling for editing the Ignorable Stint & Primary Stints by click
        private void stintEditGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;

            string columnName = stintEditGrid.Columns[e.ColumnIndex].Name;

            //ignorable stint column handling
            if (columnName.Equals(ignoreStintStr)) {
                DataGridViewCheckBoxCell thisCell = (DataGridViewCheckBoxCell)stintEditGrid.Rows[e.RowIndex].Cells[columnName];

                thisCell.Value = !(bool)thisCell.Value; //flip column value
                if ((bool)thisCell.Value == true) { //if we just checked the box
                    //unchecks this stint's matching Primary Stint box (a stint cannot be Ignored & Primary at the same time)
                    EnablePrimaryStint();
                    stintEditGrid.Rows[e.RowIndex].Cells[primaryStintStr].Value = false;
                }
                else { //if we just unchecked the box
                    bool atLeastOne = false;
                    foreach (DataGridViewRow row in stintEditGrid.Rows) {
                        if ((bool)row.Cells[columnName].Value == true) {
                            atLeastOne = true;
                        }
                    }
                    if (atLeastOne) { //unlock primary stint column if at least one is checked

                        EnablePrimaryStint();
                    }
                    else { //lock & clears the Primary Stint column if no Ignore Stint boxes are checked
                        DisablePrimaryStint();
                    }
                }
            }

            //primary stint column handling
            else if (columnName.Equals(primaryStintStr)) {
                DataGridViewCheckBoxCell thisCell = (DataGridViewCheckBoxCell)stintEditGrid.Rows[e.RowIndex].Cells[columnName];
                if (thisCell.ReadOnly == true) return;

                if ((bool)thisCell.Value == false) { //checkbox starts out as false, we want to set it to true
                    //make sure the matching "Ignore Stint" box is not checked (else cancel the change)
                    if ((bool)stintEditGrid.Rows[e.RowIndex].Cells[ignoreStintStr].Value == true) {
                        stintEditGrid.EndEdit();
                        thisCell.Value = false;
                    }
                    else {
                        // uncheck all other stints' Primary Stint box (like a radio button)
                        foreach (DataGridViewRow row in stintEditGrid.Rows) {
                            if (row.Cells[primaryStintStr] != thisCell) {
                                row.Cells[primaryStintStr].Value = false;
                            } else {
                                thisCell.Value = true;
                            }
                        }
                    }
                }
                else {
                    thisCell.Value = false;
                }
            }
        }

        //if any stints are marked as "Ignore", enable the Primary Stint column; else, disable it
        private void stintEditGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            bool anyIgnores = false;
            foreach (DataGridViewRow row in stintEditGrid.Rows) {
                if ((bool)row.Cells[ignoreStintStr].Value) {
                    anyIgnores = true;
                }
            }
            if (anyIgnores) {
                EnablePrimaryStint();
            }
            else {
                DisablePrimaryStint();
            }
        }
    }
}
