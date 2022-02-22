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
        int dataBindingCount = 0; //counter for how many times the DataBindingComplete event fires. We want to manipulate all values on the 3rd event only
        //this is very hacky, but is the least bad way I've found to run an initial value editing exactly once without getting overwritten

        public SingleStintPlayers(SeasonPersonStint sps, int yearId) {
            InitializeComponent();
            this.sps = sps;
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
            List<PersonStint> multiStinters = sps.GetPlayers();
            int sIndex = 0; //index for our loop through the Single Stinters list. (also maps to the resultsGrid rows)
            int mIndex = 0; //index for our loop through the Multi Stinters list

            while (sIndex < singlePlayerStints.Count && mIndex < multiStinters.Count) {
                int comparison = String.Compare(singlePlayerStints[sIndex].PlayerId, multiStinters[mIndex].PlayerId);

                if (comparison == 0) { //player IDs equal; single-stint player already exists in editable multi-stint list
                    resultsGrid.Rows[sIndex].Cells["Editable"].Value = true.ToString();
                    sIndex++;
                    mIndex++;
                } else if (comparison < 0) { //single stint PlayerID < multi stint Player ID: no matches found, no further matches possible
                    resultsGrid.Rows[sIndex].Cells["Editable"].Value = false.ToString();
                    sIndex++;
                } else { //single stint Player ID > multi stint Player ID: no match found, but remaining multi records might be a match
                    mIndex++;
                }

                // likely to run out of multi-stinters before single stinters. This labels the remaining records
                for (; sIndex < singlePlayerStints.Count; sIndex++) {
                    resultsGrid.Rows[sIndex].Cells["Editable"].Value = false.ToString();
                }
            }
        }

        //**********
        //Events
        //**********
        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void resultsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dataBindingCount++;
            if (dataBindingCount == 3) {
                CheckAllSingleStinters();

                //set autosizing after data binding to avoid huge slowdown during binding
                resultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                resultsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                //and then turn it back off again, because this event unavoidably fires more than once
                //and we don't want the autosizing to be on when it overwrites the entire value set with the same info the second time
            }
        }
    }
}
