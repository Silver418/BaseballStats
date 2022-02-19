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
            


            //    Helpers.MakeColumn("Team", ""));
            resultsGrid.DataSource = singlePlayerStints;

            DataGridViewTextBoxColumn teamCol = new DataGridViewTextBoxColumn();
            teamCol.Name = "Team";
            resultsGrid.Columns.Add(teamCol);

            //Helpers.ParseDataSourceWithChild(resultsGrid);
            //MessageBox.Show("bob");
            foreach (DataGridViewRow row in resultsGrid.Rows) {
                row.Cells[4].Value = "bob";
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
