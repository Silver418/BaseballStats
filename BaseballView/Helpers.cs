using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballView {
    public static class Helpers {
        public static DataGridViewTextBoxColumn MakeColumn(string name, string dataSource = "", string tooltip = "", string format = "") {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.SortMode = DataGridViewColumnSortMode.NotSortable;
            column.Name = name;
            if (!dataSource.Equals("")) {
                column.DataPropertyName = dataSource;
            }
            if (!tooltip.Equals("")) { 
                column.ToolTipText = tooltip;
            }
            if (!format.Equals("")) {
                column.DefaultCellStyle.Format = format;
            }

            return column;
        }

        //helper method for a processing a DataGridView's data sources that stores display data inside child objects
        //pass the DataGridView handle to this method sometime after the data is bound.
        //DataBindingComplete event is the best timing I've found for minimizing # of unnecessary calls
        public static void ParseDataSourceWithChild(DataGridView grid) {
            for (int row = 0; row < grid.Rows.Count; row++) {
                for (int cell = 0; cell < grid.Rows[row].Cells.Count; cell++) {
                    DataGridViewCell thisCell = grid.Rows[row].Cells[cell];
                    if (thisCell.Value == null) {
                        if (thisCell.OwningColumn.DataPropertyName.Contains(".")) {
                            string[] DataPropArgs = thisCell.OwningColumn.DataPropertyName.Split(".");
                            Object thisRowSource = grid.Rows[row].DataBoundItem;
                            PropertyInfo childObjectInfo = thisRowSource.GetType().GetProperty(DataPropArgs[0]);
                            if (childObjectInfo != null) {
                                var childObjectValue = childObjectInfo.GetValue(thisRowSource);
                                if (childObjectValue.GetType().GetProperty(DataPropArgs[1]) != null) {
                                    thisCell.Value = childObjectValue.GetType().GetProperty(DataPropArgs[1]).GetValue(childObjectValue);
                                }
                                else { //code ends up here if the column's DataSource second half does not match the name of a property in the child object
                                    if (row == 0) {
                                        MessageBox.Show($"Data field {DataPropArgs[1]} not found");
                                    }
                                }
                            }
                            else {//code ends up here if the column's DataSource first half does not match the name of a child object in the source
                                if (row == 0) {
                                    MessageBox.Show($"Child object {DataPropArgs[0]} not found");
                                }
                            }
                        }
                    }
                }
            }
        }
    } //end Helpers class
} //end BaseballView namespace