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
    public partial class SeasonDatesEdit : UserControl {
        //handle to container of the this control (so the Close button can remove this control)
        private Panel myHome { get; set; }


        public SeasonDatesEdit(Panel containing) {
            InitializeComponent();
            myHome = containing;

            //setup Seasons grid
            seasonGrid.AutoGenerateColumns = false;
            seasonGrid.Columns.Add(Helpers.MakeColumn("Year", "YearId"));
            seasonGrid.Columns.Add(Helpers.MakeColumn("Season Start", "SeasonStart", format: "MMM dd"));
            seasonGrid.Columns.Add(Helpers.MakeColumn("Season End", "SeasonEnd", format: "MMM dd"));
            seasonGrid.Columns.Add(Helpers.MakeColumn("Season Length", "SeasonDuration", "Length in Days"));

            RefreshDateGrid();
        }

        //**********
        //Helper methods
        //**********
        private void RefreshDateGrid() {
            SeasonDateList dates = Queries.GetAllSeasons();
            seasonGrid.DataSource = dates.GetResults();
        }

        private void SetEditSeason() {
            SeasonDateRecord season = Queries.GetSeason((long)seasonGrid.SelectedRows[0].Cells["Year"].Value);
            yearPicker.Value = season.SeasonStart;
            startPicker.Value = season.SeasonStart;
            endPicker.Value = season.SeasonEnd;
            ActiveControl = startPicker;
        }

        private void inputEnterKey(KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
        }

        private void SaveRecord() {
            if (startPicker.Value < endPicker.Value) {
                SeasonDateRecord existing = Queries.GetSeason(yearPicker.Value.Year);
                if (existing != null) { //record already exists, confirm replacement


                    DialogResult confirmBox = MessageBox.Show($"Data for {yearPicker.Value.Year} already exists." +
                        $"\nReplace data {existing.SeasonStart.ToString("MMM dd")} - {existing.SeasonEnd.ToString("MMM dd")}" +
                        $"\nwith new dates {startPicker.Value.ToString("MMM dd")} - {endPicker.Value.ToString("MMM dd")}?",
                        "Replace Data?", MessageBoxButtons.YesNo);

                    if (confirmBox == DialogResult.Yes) {
                        Queries.SaveYear(startPicker.Value, endPicker.Value);
                        RefreshDateGrid();
                    }
                    else {
                        startPicker.Value = existing.SeasonStart;
                        endPicker.Value = existing.SeasonEnd;
                    }
                    this.ActiveControl = yearPicker;

                }
                else { //record does not exist, add new record
                    Queries.SaveYear(startPicker.Value, endPicker.Value);
                    RefreshDateGrid();
                    this.ActiveControl = yearPicker;
                }

            }
            else {
                MessageBox.Show("Season start date must be before end date.");
            }
        }

        //**********
        //Events
        //**********
        private void yearPicker_ValueChanged(object sender, EventArgs e) {
            if (startPicker.Value.Day == 29 && startPicker.Value.Month == 2 && DateTime.IsLeapYear(startPicker.Value.Year)) {
                startPicker.Value = new DateTime(yearPicker.Value.Year, startPicker.Value.Month, 28);
            }
            else {
                startPicker.Value = new DateTime(yearPicker.Value.Year, startPicker.Value.Month, startPicker.Value.Day);
            }

            if (endPicker.Value.Day == 29 && endPicker.Value.Month == 2 && DateTime.IsLeapYear(endPicker.Value.Year)) {
                endPicker.Value = new DateTime(yearPicker.Value.Year, endPicker.Value.Month, 28);
            }
            else {
                endPicker.Value = new DateTime(yearPicker.Value.Year, endPicker.Value.Month, endPicker.Value.Day);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            if (myHome is TabPage) {
                myHome.Parent.Controls.Remove(myHome);
            }
            else {
                myHome.Controls.Remove(this);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e) {
            SaveRecord();
        }

        private void deleteBtn_Click(object sender, EventArgs e) {
            string message = "";
            if (seasonGrid.SelectedRows.Count == 1) {
                message = $"Delete data for {seasonGrid.SelectedRows[0].Cells["Year"].Value}?";

            }
            else if (seasonGrid.SelectedRows.Count > 1) {
                message = $"Delete data for {seasonGrid.SelectedRows.Count} records?";
            }

            if (!message.Equals("")) {
                DialogResult doTheThing = MessageBox.Show(message, "Delete?", MessageBoxButtons.YesNo);

                if (doTheThing == DialogResult.Yes) {
                    int rowsAffected = 0;
                    foreach (DataGridViewRow row in seasonGrid.SelectedRows) {
                        long year = (long)row.Cells["Year"].Value;
                        rowsAffected += Queries.DeleteSeason(year);
                    }
                    RefreshDateGrid();
                    MessageBox.Show($"Removed {rowsAffected} record(s).");
                }

            }
            else {
                MessageBox.Show("No rows selected.");
            }
        }

        private void seasonGrid_SelectionChanged(object sender, EventArgs e) {
            if (seasonGrid.SelectedRows.Count == 1) {
                editBtn.Enabled = true;
            }
            else {
                editBtn.Enabled = false;
            }
        }

        private void editBtn_Click(object sender, EventArgs e) {
            SetEditSeason();
        }

        private void seasonGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            SetEditSeason();
        }

        private void seasonGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (seasonGrid.SelectedRows.Count == 1) {
                    SetEditSeason();
                }
            }
        }

        private void recordInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SaveRecord();
            }
        }
    }
}
