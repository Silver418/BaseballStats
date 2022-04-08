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
    public partial class SeasonRosters : UserControl {
        //handle to container of the this control (so the Close button can remove this control)
        private Panel myHome { get; set; }
        //handle to active data
        private TeamYearSearchRecord teamRecord;
        private SeasonDateRecord? season;
        private FieldingStintList fieldingResults;
        private DesignatedStintList dhResults;


        public SeasonRosters(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //Columns with a period in the DataPropertyName have special processing in the DataBindingComplete event

            //setup grid for stints from fielding data
            fieldingGrid.AutoGenerateColumns = false;
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Position", "Pos"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("G", "G", "Games Played"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("GS", "Gs", "Games Started"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Start Date", "StintStart", format: "MMM dd"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("End Date", "StintEnd", format: "MMM dd"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Days", "StintDuration", format: "#"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("StintX", "StintX", "Proportion of season taken by this stint", "0.000;#;#"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Modified Starts", format: "0.000"));

            //setup designated hitter grid
            desigHitterGrid.AutoGenerateColumns = false;
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Position", "Pos"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("G Def", "GDefense", "Games Played in a Defensive Position"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("G DH", "GDh", "Games Played as Designated Hitter"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Total Stints", "Count", format: "#"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("StintX Sum", "StintXSum", "Sum of StintX for this player's stint with this team", "0.000;#;#"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Modified Starts", format: "0.000"));


            //setup designated hitter details grid
            desigDetailGrid.AutoGenerateColumns = false;
            desigDetailGrid.Columns.Add(Helpers.MakeColumn("Stint #", "StintId"));
            desigDetailGrid.Columns.Add(Helpers.MakeColumn("Team", "TeamName"));
            desigDetailGrid.Columns.Add(Helpers.MakeColumn("Start Date", "StintStart", format: "MMM dd"));
            desigDetailGrid.Columns.Add(Helpers.MakeColumn("End Date", "StintEnd", format: "MMM dd"));
            desigDetailGrid.Columns.Add(Helpers.MakeColumn("Days", "StintDuration", format: "#"));
            desigDetailGrid.Columns.Add(Helpers.MakeColumn("StintX", "StintX", "Proportion of season taken by this stint", "0.000;0.000;#"));
        }

        //**********
        //Helper Methods
        //**********

        public void GetDesigDetails() {
            if (desigHitterGrid.SelectedRows.Count == 1) {
                DesignatedStintRecord source = (DesignatedStintRecord)desigHitterGrid.SelectedRows[0].DataBoundItem;
                desigDetailGrid.DataSource = source.StintRecords;
            }
        }

        public void CalcMStarts() {
            if (fieldingResults != null && gamesNud.Value > 0 && lineupsNud.Value > 0 && pitcherNud.Value > 0) {
                //prep one-time inputs
                decimal teamGames = gamesNud.Value;
                decimal lineups = lineupsNud.Value;
                decimal pitcherSlots = pitcherNud.Value;
                foreach (DataGridViewRow row in fieldingGrid.Rows) {
                    //prep per-row input
                    decimal playerStarts = Convert.ToDecimal(row.Cells["GS"].Value);

                    //mStarts calcs
                    decimal mStarts = 0;

                    if (((string)row.Cells["Position"].Value).Equals("P")) {
                        mStarts = playerStarts / teamGames * pitcherSlots;
                    }
                    else {
                        mStarts = playerStarts / teamGames * lineups;
                    }
                    if ((decimal)row.Cells["StintX"].Value > 0) {
                        mStarts /= (decimal)row.Cells["StintX"].Value;
                    }

                    row.Cells["Modified Starts"].Value = mStarts;
                }
            }
            if (dhResults != null && gamesNud.Value > 0 && lineupsNud.Value > 0 && pitcherNud.Value > 0) {
                //prep one-time inputs
                decimal teamGames = gamesNud.Value;
                decimal lineups = lineupsNud.Value;
                foreach (DataGridViewRow row in desigHitterGrid.Rows) {
                    //prep per-row input
                    decimal playerDhGames = Convert.ToDecimal(row.Cells["G Dh"].Value);

                    //mStarts calcs
                    decimal mStarts = playerDhGames / teamGames * lineups;
                    if ((decimal)row.Cells["StintX Sum"].Value > 0) {
                        mStarts /= (decimal)row.Cells["StintX Sum"].Value;
                    }

                    row.Cells["Modified Starts"].Value = mStarts;
                }
            }
        }

        public void EnableProcessingButtons() {
            gamesNud.Enabled = true;
            lineupsNud.Enabled = true;
            pitcherNud.Enabled = true;
            calcMStartsBtn.Enabled = true;
            copyRosterBtn.Enabled = true;
        }


        //**********
        //Events
        //**********
        private void closeBtn_Click(object sender, EventArgs e) {
            if (myHome is TabPage) {
                myHome.Parent.Controls.Remove(myHome);
            }
            else {
                myHome.Controls.Remove(this);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            TeamYearSearch form = new TeamYearSearch();
            var result = form.ShowDialog();
            if (result == DialogResult.OK) {
                teamRecord = Queries.TeamYearByID(form.TeamIdResult, form.LgIdResult, form.YearIdResult);

                //team bio info
                yearLbl.Text = teamRecord.YearId.ToString();
                teamIdLbl.Text = teamRecord.TeamId;
                leagueLbl.Text = teamRecord.LgId;
                teamNameLbl.Text = teamRecord.Name;
                divLbl.Text = teamRecord.DivId;
                gamesLbl.Text = teamRecord.G.ToString();


                season = Queries.GetSeason(teamRecord.YearId);
                if (season != null) {
                    fieldingResults = new FieldingStintList(teamRecord.TeamId, teamRecord.LgId, season, true);
                    dhResults = new DesignatedStintList(teamRecord.TeamId, teamRecord.LgId, season);
                }
                else {
                    fieldingResults = new FieldingStintList(teamRecord.TeamId, teamRecord.LgId, teamRecord.YearId, true);
                    dhResults = new DesignatedStintList(teamRecord.TeamId, teamRecord.LgId, teamRecord.YearId);
                }
                fieldingGrid.DataSource = fieldingResults.GetResults();
                //Helpers.ParseDataSourceWithChild(fieldingGrid);   //currently not used due to added interface properties in FieldingStintRecord.
                desigHitterGrid.DataSource = dhResults.GetResults();

                EnableProcessingButtons();
            }
        }

        private void desigHitterGrid_SelectionChanged(object sender, EventArgs e) {
            if (desigHitterGrid.SelectedRows.Count == 1) {
                detailsBtn.Enabled = true;
            }
            else {
                detailsBtn.Enabled = false;
            }
        }

        private void details_Click(object sender, EventArgs e) {
            GetDesigDetails();
        }

        private void desigHitterGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                GetDesigDetails();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            CalcMStarts();
        }

        private void MStartsInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                CalcMStarts();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void copyRosterBtn_Click(object sender, EventArgs e) {
            fieldingGrid.SelectAll();
            DataObject dataObj = fieldingGrid.GetClipboardContent();
            Clipboard.SetDataObject(dataObj, true);
            tabControl1.SelectTab(0);
            MessageBox.Show("Roster contents copied to clipboard.");
        }
    }
}
