using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballView {
    public static class Helpers {
        public static DataGridViewTextBoxColumn MakeColumn(string name, string dataSource, string tooltip = "", string format = "") {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.Name = name;
            column.DataPropertyName = dataSource;
            if (!tooltip.Equals("")) { 
                column.ToolTipText = tooltip;
            }
            if (!format.Equals("")) {
                column.DefaultCellStyle.Format = format;
            }

            return column;
        }

    } //end Helpers class
} //end BaseballView namespace