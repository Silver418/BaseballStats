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

        //counter for how many times the DataBindingComplete event fires. We want to manipulate all values on the 3rd event only
        //this is very hacky, but is the least bad way I've found to run an initial value editing exactly once without getting overwritten
        int dataBindingCount = 0;


        public SingleStintPlayers(SeasonPersonStint sps, int yearId) {
            InitializeComponent();
            this.sps = sps;
            //multiStinters = sps.GetPlayers();
            singlePlayerStints = Queries.GetSingleStintPlayers(yearId);

            //set up grid of single-stint players
            resultsGrid.AutoGenerateColumns = false;
            resultsGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("# Stints", "Count"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("Team", "Teams"));
            resultsGrid.Columns.Add(Helpers.MakeColumn("Editable"));

            resultsGrid.DataSource = singlePlayerStints;
        }

        //**********
        //Helper Methods
        //**********

        //checks whether the players listed in the Single Stinter list already appear in the editable stint list passed
        //to this form by the parent form & marks the "Editable" column appropriately.
        //This goes through both lists entirely; best to use it only once, at initial setup.
        private void CheckAllSingleStinters() {
            int sIndex = 0; //index for our loop through the Single Stinters list. (also maps to the resultsGrid rows)
            int mIndex = 0; //index for our loop through the Multi Stinters list
            List<PersonStint> multiStinters = sps.GetPlayers();

            while (sIndex < singlePlayerStints.Count && mIndex < multiStinters.Count) {
                int comparison = String.Compare(singlePlayerStints[sIndex].PlayerId, multiStinters[mIndex].PlayerId);
                
                if (comparison == 0) { //player IDs equal; single-stint player already exists in editable multi-stint list
                    resultsGrid.Rows[sIndex].Cells["Editable"].Value = true.ToString();
                    sIndex++;
                    mIndex++;
                }
                else if (comparison < 0) { //single stint PlayerID < multi stint Player ID: no matches found, no further matches possible
                    resultsGrid.Rows[sIndex].Cells["Editable"].Value = false.ToString();
                    sIndex++;
                }
                else { //single stint Player ID > multi stint Player ID: no match found, but remaining multi records might be a match
                    mIndex++;
                }
            }
            // likely to run out of multi-stinters before single stinters. This labels the remaining records
            for (; sIndex < singlePlayerStints.Count; sIndex++) {
                resultsGrid.Rows[sIndex].Cells["Editable"].Value = false.ToString();
            }
        }

        //add selected PersonStint record from the single stint players list to the parent form's editable multi-stint player list
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
        private void resultsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dataBindingCount++;
            if (dataBindingCount == 3) { //Event unavoidably fires 3 times on initial load & overwrites previous work. Only working on last one to avoid large performance hit
                CheckAllSingleStinters();//<--actual work here
                //set autosizing after data binding to avoid huge slowdown during binding
                resultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                resultsGrid.ClearSelection();
            }
        }

        private void addBtn_Click(object sender, EventArgs e) {
            if (resultsGrid.SelectedRows.Count > 0) {
                int result = 0;
                if (resultsGrid.SelectedRows.Count == 1) {
                    result = AddPersonStint((DataGridViewRow)resultsGrid.SelectedRows[0]);
                }
                else {
                    foreach (DataGridViewRow row in resultsGrid.SelectedRows) {
                        result += AddPersonStint(row);
                    }
                }
                if (result > 0) {
                    MessageBox.Show($"{result} record(s) added for editing." +
                        $"\nReturn to the Stint Editing form to enter dates for new stints.");
                }
                else {
                    MessageBox.Show("All selected records are already editable.");
                }
            }
            else {
                MessageBox.Show("No records selected.");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e) {

        }
    }
}
