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
    public partial class TransactionDatesView : Form {
        //handles
        private TransactionList transactions;
        public TransactionDatesView(SeasonPersonStint season) {
            InitializeComponent();

            //setup transaction grid
            transactionGrid.AutoGenerateColumns = false;
            transactionGrid.Columns.Add(Helpers.MakeColumn("Player ID", "PlayerId"));
            transactionGrid.Columns.Add(Helpers.MakeColumn("Date", "TransactionDate", format: "MMM dd"));
            transactionGrid.Columns.Add(Helpers.MakeColumn("First Name", "NameFirst"));
            transactionGrid.Columns.Add(Helpers.MakeColumn("Last Name", "NameLast"));
            transactionGrid.Columns.Add(Helpers.MakeColumn("Left Team", "LeaveTeam"));
            transactionGrid.Columns.Add(Helpers.MakeColumn("Joined Team", "JoinTeam"));

            if (season != null) {
                label1.Text = $"Transaction dates for {season.Season.YearId} Season";
                transactions = new TransactionList(season);
                transactionGrid.DataSource = transactions.GetTransactions();
            }
        }



        //*****
        //Events
        //*****

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void clipboardBtn_Click(object sender, EventArgs e) {
            if (transactionGrid.Rows.Count != 0) {
                transactionGrid.SelectAll();
                DataObject dataObj = transactionGrid.GetClipboardContent();
                Clipboard.SetDataObject(dataObj, true);
                MessageBox.Show("Transaction list copied to clipboard.");
            }
        }
    }
}
