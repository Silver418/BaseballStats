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
        //results from team search popup
        private long yearId { get; set; }
        private string teamId { get; set; }
        private string lgId { get; set; }

        //handle to active data
        private SeasonDateRecord? season;
        private PitchingStintList pitchingResults;


        public SeasonRosters(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //Columns with a period in the DataPropertyName have special processing in the DataBindingComplete event

            //setup pitching grid
            pitchingGrid.AutoGenerateColumns = false;
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Player ID", "MyPitching.PlayerId"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("First Name", "MyPitching.NameFirst"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Last Name", "MyPitching.NameLast"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("G", "MyPitching.G", "Games Played"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("GS", "MyPitching.Gs", "Games Started"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Start Date", "MyStint.StintStart", format: "MMM dd"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("End Date", "MyStint.StintEnd", format: "MMM dd"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("Days", "MyStint.StintDuration", format: "#"));
            pitchingGrid.Columns.Add(Helpers.MakeColumn("StintX", "MyStint.StintX", "Proportion of season taken by this stint", "0.000;0.000;#"));
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
                yearId = form.YearIdResult;
                teamId = form.TeamIdResult;
                lgId = form.LgIdResult;

                yearIdLbl.Text = yearId.ToString();
                teamIdLbl.Text = teamId;
                lgIdLbl.Text = lgId;

                season = Queries.GetSeason(yearId);
                if (season != null) {
                    pitchingResults = new PitchingStintList(teamId, lgId, season);
                }
                else {
                    pitchingResults = new PitchingStintList(teamId, lgId, yearId);
                }
                pitchingGrid.DataSource = pitchingResults.GetResults();
            }
        }

        //DataBindEvent; processes columns with a DataPropertyName with a period in it, meant to point to data inside the source's child objects
        private void pitchingGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            for (int row = 0; row < pitchingGrid.Rows.Count; row++) {
                for (int cell = 0; cell < pitchingGrid.Rows[row].Cells.Count; cell++) {
                    DataGridViewCell thisCell = pitchingGrid.Rows[row].Cells[cell];
                    if (thisCell.Value == null) {
                        if (thisCell.OwningColumn.DataPropertyName.Contains(".")) {
                            string[] DataPropArgs = thisCell.OwningColumn.DataPropertyName.Split(".");
                            Object thisRowSource = pitchingGrid.Rows[row].DataBoundItem;
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
