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
    public partial class PersonSearch : Form {
        PersonSearchList playerResults;

        public string ReturnValueTest { get; private set; } = "";

        public PersonSearch() {
            InitializeComponent();

            //results grid setup
            resultsGrid.AutoGenerateColumns = false;
            addColumn("Player ID", "playerId");
            addColumn("First Name", "NameFirst");
            addColumn("Last Name", "NameLast");
            addColumn("Given Name", "NameGiven");
            addColumn("Born", "BirthDate");
            addColumn("Died", "DeathDate");
            addColumn("Debut", "Debut");
            addColumn("Final Game", "FinalGame");
            addColumn("Bats", "BatHand");
            addColumn("Throws", "ThrowHand");

            ActiveControl = nameFirstInput;
        } //end constructor

        //**********
        //helper methods
        private void addColumn(string columnName, string dataSource) {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = columnName;
            col.DataPropertyName = dataSource;
            resultsGrid.Columns.Add(col);
        }

        private void selectPlayer() {
            if (resultsGrid.SelectedRows.Count == 1) {
                int rowIndex = resultsGrid.CurrentCell.RowIndex;

                ReturnValueTest = resultsGrid.Rows[rowIndex].Cells["Player ID"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("Select exactly 1 row.");
            }
        }

        private void searchPlayer() {
            string termNameFirst = nameFirstInput.Text.ToLower().Trim();
            string termNameLast = nameLastInput.Text.ToLower().Trim();

            if (!termNameFirst.Equals("") || !termNameLast.Equals("")) {
                playerResults = Queries.PeopleByName(nameFirstInput.Text, nameLastInput.Text);

                if (playerResults.Count > 0) {
                    resultCountLbl.Text = $"Results: {playerResults.Count}";
                    resultsGrid.DataSource = playerResults.getResults();
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

        //**********
        //Events
        private void Cancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void nameSearchBtn_Click(object sender, EventArgs e) {
            searchPlayer();
        }

        private void selectBtn_Click(object sender, EventArgs e) {
            selectPlayer();
        }

        private void resultsGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                selectPlayer();
            }
        }

        private void searchInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Return) {
                e.Handled = true;
                e.SuppressKeyPress = true;
                searchPlayer();
            }
        }

        private void resultsGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) {
            selectPlayer();
        }
    } //end PersonSearch form
} //end BaseballView namespace
