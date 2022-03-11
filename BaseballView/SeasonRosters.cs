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
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Player ID", "MyFielding.PlayerId"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("First Name", "MyFielding.NameFirst"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Last Name", "MyFielding.NameLast"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Position", "MyFielding.Pos"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("G", "MyFielding.G", "Games Played"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("GS", "MyFielding.Gs", "Games Started"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Start Date", "MyStint.StintStart", format: "MMM dd"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("End Date", "MyStint.StintEnd", format: "MMM dd"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("Days", "MyStint.StintDuration", format: "#"));
            fieldingGrid.Columns.Add(Helpers.MakeColumn("StintX", "MyStint.StintX", "Proportion of season taken by this stint", "0.000;#;#"));

            //setup designated hitter grid
            desigHitterGrid.AutoGenerateColumns = false;
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Position", "Pos"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("G DH", "GDh", "Games Played as Designated Hitter"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("G Def", "GDefense", "Games Played in a Defensive Position"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("Total Stints", "Count", format: "#"));
            desigHitterGrid.Columns.Add(Helpers.MakeColumn("StintX Sum", "StintXSum", "Sum of StintX for this player's stint with this team", "0.000;#;#"));

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
            if(desigHitterGrid.SelectedRows.Count == 1) {
                DesignatedStintRecord source = (DesignatedStintRecord)desigHitterGrid.SelectedRows[0].DataBoundItem;
                desigDetailGrid.DataSource = source.StintRecords;
            }
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
                Helpers.ParseDataSourceWithChild(fieldingGrid);
                desigHitterGrid.DataSource = dhResults.GetResults();
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
    }
}
