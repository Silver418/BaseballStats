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
    public partial class StintEdit : UserControl {
        //handle to container of the this control (so the Close button can remove this control)
        private Panel myHome { get; set; }

        public StintEdit(Panel containing) {
            InitializeComponent();
            myHome = containing;

        }

        //*****
        //Helper Methods
        //*****


        //*****
        //Events
        //*****
        private void closeBtn_Click(object sender, EventArgs e) {
            if (myHome is TabPage) {
                myHome.Parent.Controls.Remove(myHome);
            }
            else {
                myHome.Controls.Remove(this);
            }

        }
    }
}
