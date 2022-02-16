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


        public SeasonRosters(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //Columns with a period in the DataPropertyName have special processing in the DataBindingComplete event

            //setup pitching grid
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
        }

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
                    fieldingResults = new FieldingStintList(teamRecord.TeamId, teamRecord.LgId, season);
                }
                else {
                    fieldingResults = new FieldingStintList(teamRecord.TeamId, teamRecord.LgId, teamRecord.YearId);
                }
                fieldingGrid.DataSource = fieldingResults.GetResults();
            }
        }

        //DataBindEvent; processes columns with a DataPropertyName with a period in it, meant to point to data inside the source's child objects
        private void pitchingGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            for (int row = 0; row < fieldingGrid.Rows.Count; row++) {
                for (int cell = 0; cell < fieldingGrid.Rows[row].Cells.Count; cell++) {
                    DataGridViewCell thisCell = fieldingGrid.Rows[row].Cells[cell];
                    if (thisCell.Value == null) {
                        if (thisCell.OwningColumn.DataPropertyName.Contains(".")) {
                            string[] DataPropArgs = thisCell.OwningColumn.DataPropertyName.Split(".");
                            Object thisRowSource = fieldingGrid.Rows[row].DataBoundItem;
                            PropertyInfo childObjectInfo = thisRowSource.GetType().GetProperty(DataPropArgs[0]);
                            if (childObjectInfo != null) {
                                var childObjectValue = childObjectInfo.GetValue(thisRowSource);
                                if (childObjectValue.GetType().GetProperty(DataPropArgs[1]) != null) {
                                    thisCell.Value = childObjectValue.GetType().GetProperty(DataPropArgs[1]).GetValue(childObjectValue);
                                }
                                else { //code ends up here if the column's DataSource second half does not match the name of a property in the child object
                                    if (row == 0) {
                                        MessageBox.Show($"Data field {DataPropArgs[1]} not found");
                                    }
                                }
                            }
                            else {//code ends up here if the column's DataSource first half does not match the name of a child object in the source
                                if (row == 0) {
                                    MessageBox.Show($"Child object {DataPropArgs[0]} not found");
                                }
                            }
                        }
                    }
                }
            }
        } //end DataBindingComplete
    }
}
