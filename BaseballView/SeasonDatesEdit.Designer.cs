namespace BaseballView {
    partial class SeasonDatesEdit {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.headerLbl = new System.Windows.Forms.Label();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.entryPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.yearPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startPnl = new System.Windows.Forms.Panel();
            this.startPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endPnl = new System.Windows.Forms.Panel();
            this.endPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.testStart = new System.Windows.Forms.Label();
            this.testEnd = new System.Windows.Forms.Label();
            this.entryPnl.SuspendLayout();
            this.yearPnl.SuspendLayout();
            this.startPnl.SuspendLayout();
            this.endPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLbl.Location = new System.Drawing.Point(0, 0);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(5);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Padding = new System.Windows.Forms.Padding(5);
            this.headerLbl.Size = new System.Drawing.Size(121, 31);
            this.headerLbl.TabIndex = 2;
            this.headerLbl.Text = "Season Dates";
            // 
            // yearPicker
            // 
            this.yearPicker.CustomFormat = "yyyy";
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.Location = new System.Drawing.Point(45, 0);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.Size = new System.Drawing.Size(50, 23);
            this.yearPicker.TabIndex = 3;
            this.yearPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.yearPicker.ValueChanged += new System.EventHandler(this.yearPicker_ValueChanged);
            // 
            // entryPnl
            // 
            this.entryPnl.AutoScroll = true;
            this.entryPnl.AutoSize = true;
            this.entryPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.entryPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entryPnl.Controls.Add(this.yearPnl);
            this.entryPnl.Controls.Add(this.startPnl);
            this.entryPnl.Controls.Add(this.endPnl);
            this.entryPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.entryPnl.Location = new System.Drawing.Point(0, 31);
            this.entryPnl.Name = "entryPnl";
            this.entryPnl.Padding = new System.Windows.Forms.Padding(5);
            this.entryPnl.Size = new System.Drawing.Size(606, 44);
            this.entryPnl.TabIndex = 4;
            // 
            // yearPnl
            // 
            this.yearPnl.AutoSize = true;
            this.yearPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yearPnl.Controls.Add(this.yearPicker);
            this.yearPnl.Controls.Add(this.label1);
            this.yearPnl.Location = new System.Drawing.Point(8, 8);
            this.yearPnl.Name = "yearPnl";
            this.yearPnl.Size = new System.Drawing.Size(98, 26);
            this.yearPnl.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Year:";
            // 
            // startPnl
            // 
            this.startPnl.AutoSize = true;
            this.startPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startPnl.Controls.Add(this.startPicker);
            this.startPnl.Controls.Add(this.label2);
            this.startPnl.Location = new System.Drawing.Point(112, 8);
            this.startPnl.Name = "startPnl";
            this.startPnl.Size = new System.Drawing.Size(153, 26);
            this.startPnl.TabIndex = 11;
            // 
            // startPicker
            // 
            this.startPicker.CustomFormat = "MMM-dd";
            this.startPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startPicker.Location = new System.Drawing.Point(80, 0);
            this.startPicker.Name = "startPicker";
            this.startPicker.ShowUpDown = true;
            this.startPicker.Size = new System.Drawing.Size(70, 23);
            this.startPicker.TabIndex = 3;
            this.startPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.startPicker.ValueChanged += new System.EventHandler(this.startPicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Start Date:";
            // 
            // endPnl
            // 
            this.endPnl.AutoSize = true;
            this.endPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.endPnl.Controls.Add(this.endPicker);
            this.endPnl.Controls.Add(this.label3);
            this.endPnl.Location = new System.Drawing.Point(271, 8);
            this.endPnl.Name = "endPnl";
            this.endPnl.Size = new System.Drawing.Size(153, 26);
            this.endPnl.TabIndex = 12;
            // 
            // endPicker
            // 
            this.endPicker.CustomFormat = "MMM-dd";
            this.endPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endPicker.Location = new System.Drawing.Point(80, 0);
            this.endPicker.Name = "endPicker";
            this.endPicker.ShowUpDown = true;
            this.endPicker.Size = new System.Drawing.Size(70, 23);
            this.endPicker.TabIndex = 3;
            this.endPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.endPicker.ValueChanged += new System.EventHandler(this.endPicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "End Date:";
            // 
            // testStart
            // 
            this.testStart.AutoSize = true;
            this.testStart.Location = new System.Drawing.Point(29, 87);
            this.testStart.Name = "testStart";
            this.testStart.Size = new System.Drawing.Size(38, 15);
            this.testStart.TabIndex = 5;
            this.testStart.Text = "label4";
            // 
            // testEnd
            // 
            this.testEnd.AutoSize = true;
            this.testEnd.Location = new System.Drawing.Point(171, 87);
            this.testEnd.Name = "testEnd";
            this.testEnd.Size = new System.Drawing.Size(38, 15);
            this.testEnd.TabIndex = 6;
            this.testEnd.Text = "label5";
            // 
            // SeasonDatesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testEnd);
            this.Controls.Add(this.testStart);
            this.Controls.Add(this.entryPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "SeasonDatesEdit";
            this.Size = new System.Drawing.Size(606, 377);
            this.entryPnl.ResumeLayout(false);
            this.entryPnl.PerformLayout();
            this.yearPnl.ResumeLayout(false);
            this.yearPnl.PerformLayout();
            this.startPnl.ResumeLayout(false);
            this.startPnl.PerformLayout();
            this.endPnl.ResumeLayout(false);
            this.endPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLbl;
        private DateTimePicker yearPicker;
        private FlowLayoutPanel entryPnl;
        private Panel yearPnl;
        private Label label1;
        private Panel startPnl;
        private DateTimePicker startPicker;
        private Label label2;
        private Panel endPnl;
        private DateTimePicker endPicker;
        private Label label3;
        private Label testStart;
        private Label testEnd;
    }
}
