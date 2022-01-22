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
    public partial class TeamYearSearch : Form {
        TeamYearSearchList teamResults;
        public long YearIdResult { get; private set; } = 0;
        public string TeamIdResult { get; private set; } = "";
        public string LgIdResult { get; private set; } = "";

        public TeamYearSearch() {
            InitializeComponent();

            //results grid setup
            resultsGrid.AutoGenerateColumns = false;
            addColumn("Team ID", "TeamId");
            addColumn("Year", "YearId");
            addColumn("League", "LgId");
            addColumn("Division", "DivId");
            addColumn("Team Name", "Name");
            addColumn("Park", "Park");
        }

        //**********
        //Helper functions
        private void searchPlayer() {
            //prep search terms
            string termTeamName = teamInput.Text.Trim().ToLower();
            string termLgId = lgInput.Text.Trim().ToLower();
            long termYear = (long)yearInput.Value;

            if (termTeamName != "" || termLgId != "" || termYear > 0) {
                teamResults = Queries.TeamYearByName(termTeamName, termLgId, termYear);

                if (teamResults.Count > 0) {
                    resultCountLbl.Text = $"Results: {teamResults.Count.ToString()}";
                    resultsGrid.DataSource = teamResults.GetResults();
                    ActiveControl = resultsGrid;
                }
                else {
                    MessageBox.Show("No results found.");
                }
            }
            else {
                MessageBox.Show("No search terms entered.");
            }
        }

        private void addColumn(string columnName, string dataSource) {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = columnName;
            col.DataPropertyName = dataSource;
            resultsGrid.Columns.Add(col);
        }

        private void selectTeam() {
            if (resultsGrid.SelectedRows.Count == 1) {
                int rowIndex = resultsGrid.CurrentCell.RowIndex;

                TeamIdResult = resultsGrid.Rows[rowIndex].Cells["Team ID"].Value.ToString() ?? "";
                YearIdResult = (long)resultsGrid.Rows[rowIndex].Cells["Year"].Value;
                LgIdResult = resultsGrid.Rows[rowIndex].Cells["League"].Value.ToString() ?? "";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Select exactly 1 row.");
            }
        }

        private void enterSearch(KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                searchPlayer();
            }
        }

        //**********
        //Events
        private void selectBtn_Click(object sender, EventArgs e) {
            selectTeam();
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            searchPlayer();
        }

        private void CancelBtn_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void searchInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                searchPlayer();
            }
        }

        private void yearInput_Enter(object sender, EventArgs e) {
            yearInput.Select(0, yearInput.Text.Length);
        }

        private void resultsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            selectTeam();
        }

        private void resultsGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                selectTeam();
            }

        }
    }
}
