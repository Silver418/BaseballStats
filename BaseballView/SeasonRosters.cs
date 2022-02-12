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

        public SeasonRosters(Panel containing) {
            InitializeComponent();
            myHome = containing;
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
                yearId.Text = form.YearIdResult.ToString();
                teamId.Text = form.TeamIdResult;
                lgId.Text = form.LgIdResult;
            }
        }
    }
}
