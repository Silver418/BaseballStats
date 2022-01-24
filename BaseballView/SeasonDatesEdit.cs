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
        public SeasonDatesEdit() {
            InitializeComponent();
        }

        private void startPicker_ValueChanged(object sender, EventArgs e) {
            testStart.Text = startPicker.Value.ToString("yyyy-MM-dd");
        }

        private void endPicker_ValueChanged(object sender, EventArgs e) {
            testEnd.Text = endPicker.Value.ToString("yyyy-MM-dd");
        }

        private void yearPicker_ValueChanged(object sender, EventArgs e) {
            if (startPicker.Value.Day == 29 && startPicker.Value.Month == 2 && DateTime.IsLeapYear(startPicker.Value.Year) ) {
                startPicker.Value = new DateTime(yearPicker.Value.Year, startPicker.Value.Month, 28);
            } else {
                startPicker.Value = new DateTime(yearPicker.Value.Year, startPicker.Value.Month, startPicker.Value.Day);
            }

            if (endPicker.Value.Day == 29 && endPicker.Value.Month == 2 && DateTime.IsLeapYear(endPicker.Value.Year)) {
                endPicker.Value = new DateTime(yearPicker.Value.Year, endPicker.Value.Month, 28);
            }
            else {
                endPicker.Value = new DateTime(yearPicker.Value.Year, endPicker.Value.Month, endPicker.Value.Day);
            }
        }
    }
}
