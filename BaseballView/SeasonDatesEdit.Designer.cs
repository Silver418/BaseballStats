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
            this.saveBtn = new System.Windows.Forms.Button();
            this.controlPnl = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.gridWrap = new System.Windows.Forms.Panel();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.seasonGrid = new System.Windows.Forms.DataGridView();
            this.entryPnl.SuspendLayout();
            this.yearPnl.SuspendLayout();
            this.startPnl.SuspendLayout();
            this.endPnl.SuspendLayout();
            this.controlPnl.SuspendLayout();
            this.gridWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seasonGrid)).BeginInit();
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
            this.yearPicker.MinDate = new System.DateTime(1786, 1, 1, 0, 0, 0, 0);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.ShowUpDown = true;
            this.yearPicker.Size = new System.Drawing.Size(50, 23);
            this.yearPicker.TabIndex = 3;
            this.yearPicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.yearPicker.ValueChanged += new System.EventHandler(this.yearPicker_ValueChanged);
            this.yearPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recordInput_KeyDown);
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
            this.entryPnl.Controls.Add(this.saveBtn);
            this.entryPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.entryPnl.Location = new System.Drawing.Point(0, 31);
            this.entryPnl.Name = "entryPnl";
            this.entryPnl.Padding = new System.Windows.Forms.Padding(5);
            this.entryPnl.Size = new System.Drawing.Size(970, 45);
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
            this.startPicker.Value = new System.DateTime(2000, 3, 1, 0, 0, 0, 0);
            this.startPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recordInput_KeyDown);
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
            this.endPicker.Value = new System.DateTime(2000, 10, 31, 0, 0, 0, 0);
            this.endPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.recordInput_KeyDown);
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
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(437, 10);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "&Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // controlPnl
            // 
            this.controlPnl.AutoScroll = true;
            this.controlPnl.AutoSize = true;
            this.controlPnl.Controls.Add(this.closeBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(0, 544);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(970, 56);
            this.controlPnl.TabIndex = 7;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeBtn.Location = new System.Drawing.Point(430, 6);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(115, 40);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "&Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // gridWrap
            // 
            this.gridWrap.AutoScroll = true;
            this.gridWrap.Controls.Add(this.editBtn);
            this.gridWrap.Controls.Add(this.deleteBtn);
            this.gridWrap.Controls.Add(this.seasonGrid);
            this.gridWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWrap.Location = new System.Drawing.Point(0, 76);
            this.gridWrap.Name = "gridWrap";
            this.gridWrap.Padding = new System.Windows.Forms.Padding(5);
            this.gridWrap.Size = new System.Drawing.Size(970, 468);
            this.gridWrap.TabIndex = 8;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(425, 108);
            this.editBtn.Margin = new System.Windows.Forms.Padding(10);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(115, 40);
            this.editBtn.TabIndex = 7;
            this.editBtn.Text = "&Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(425, 15);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(10);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(115, 40);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "&Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // seasonGrid
            // 
            this.seasonGrid.AllowUserToAddRows = false;
            this.seasonGrid.AllowUserToDeleteRows = false;
            this.seasonGrid.AllowUserToResizeRows = false;
            this.seasonGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.seasonGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.seasonGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.seasonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonGrid.Location = new System.Drawing.Point(5, 5);
            this.seasonGrid.Margin = new System.Windows.Forms.Padding(10);
            this.seasonGrid.MinimumSize = new System.Drawing.Size(400, 250);
            this.seasonGrid.Name = "seasonGrid";
            this.seasonGrid.ReadOnly = true;
            this.seasonGrid.RowTemplate.Height = 25;
            this.seasonGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.seasonGrid.Size = new System.Drawing.Size(400, 526);
            this.seasonGrid.TabIndex = 5;
            this.seasonGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.seasonGrid_CellMouseDoubleClick);
            this.seasonGrid.SelectionChanged += new System.EventHandler(this.seasonGrid_SelectionChanged);
            this.seasonGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.seasonGrid_KeyDown);
            // 
            // SeasonDatesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridWrap);
            this.Controls.Add(this.entryPnl);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "SeasonDatesEdit";
            this.Size = new System.Drawing.Size(970, 600);
            this.entryPnl.ResumeLayout(false);
            this.entryPnl.PerformLayout();
            this.yearPnl.ResumeLayout(false);
            this.yearPnl.PerformLayout();
            this.startPnl.ResumeLayout(false);
            this.startPnl.PerformLayout();
            this.endPnl.ResumeLayout(false);
            this.endPnl.PerformLayout();
            this.controlPnl.ResumeLayout(false);
            this.gridWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seasonGrid)).EndInit();
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
        private Button saveBtn;
        private Panel controlPnl;
        private Button closeBtn;
        private Panel gridWrap;
        private DataGridView seasonGrid;
        private Button deleteBtn;
        private Button editBtn;
    }
}
