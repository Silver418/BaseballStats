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
        private void InitializeComponent()
        {
            headerLbl = new Label();
            yearPicker = new DateTimePicker();
            entryPnl = new FlowLayoutPanel();
            yearPnl = new Panel();
            label1 = new Label();
            startPnl = new Panel();
            startPicker = new DateTimePicker();
            label2 = new Label();
            endPnl = new Panel();
            endPicker = new DateTimePicker();
            label3 = new Label();
            saveBtn = new Button();
            controlPnl = new Panel();
            closeBtn = new Button();
            gridWrap = new Panel();
            editBtn = new Button();
            deleteBtn = new Button();
            seasonGrid = new DataGridView();
            entryPnl.SuspendLayout();
            yearPnl.SuspendLayout();
            startPnl.SuspendLayout();
            endPnl.SuspendLayout();
            controlPnl.SuspendLayout();
            gridWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seasonGrid).BeginInit();
            SuspendLayout();
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.Dock = DockStyle.Top;
            headerLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            headerLbl.Location = new Point(0, 0);
            headerLbl.Margin = new Padding(5);
            headerLbl.Name = "headerLbl";
            headerLbl.Padding = new Padding(5);
            headerLbl.Size = new Size(121, 31);
            headerLbl.TabIndex = 2;
            headerLbl.Text = "Season Dates";
            // 
            // yearPicker
            // 
            yearPicker.CustomFormat = "yyyy";
            yearPicker.Format = DateTimePickerFormat.Custom;
            yearPicker.Location = new Point(45, 0);
            yearPicker.MinDate = new DateTime(1786, 1, 1, 0, 0, 0, 0);
            yearPicker.Name = "yearPicker";
            yearPicker.ShowUpDown = true;
            yearPicker.Size = new Size(50, 23);
            yearPicker.TabIndex = 3;
            yearPicker.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            yearPicker.ValueChanged += yearPicker_ValueChanged;
            yearPicker.KeyDown += recordInput_KeyDown;
            // 
            // entryPnl
            // 
            entryPnl.AutoScroll = true;
            entryPnl.AutoSize = true;
            entryPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            entryPnl.BorderStyle = BorderStyle.FixedSingle;
            entryPnl.Controls.Add(yearPnl);
            entryPnl.Controls.Add(startPnl);
            entryPnl.Controls.Add(endPnl);
            entryPnl.Controls.Add(saveBtn);
            entryPnl.Dock = DockStyle.Top;
            entryPnl.Location = new Point(0, 31);
            entryPnl.Name = "entryPnl";
            entryPnl.Padding = new Padding(5);
            entryPnl.Size = new Size(970, 45);
            entryPnl.TabIndex = 4;
            // 
            // yearPnl
            // 
            yearPnl.AutoSize = true;
            yearPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            yearPnl.Controls.Add(yearPicker);
            yearPnl.Controls.Add(label1);
            yearPnl.Location = new Point(8, 8);
            yearPnl.Name = "yearPnl";
            yearPnl.Size = new Size(98, 26);
            yearPnl.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 4);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Year:";
            // 
            // startPnl
            // 
            startPnl.AutoSize = true;
            startPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            startPnl.Controls.Add(startPicker);
            startPnl.Controls.Add(label2);
            startPnl.Location = new Point(112, 8);
            startPnl.Name = "startPnl";
            startPnl.Size = new Size(153, 26);
            startPnl.TabIndex = 11;
            // 
            // startPicker
            // 
            startPicker.CustomFormat = "MMM-dd";
            startPicker.Format = DateTimePickerFormat.Custom;
            startPicker.Location = new Point(80, 0);
            startPicker.Name = "startPicker";
            startPicker.ShowUpDown = true;
            startPicker.Size = new Size(70, 23);
            startPicker.TabIndex = 3;
            startPicker.Value = new DateTime(2000, 3, 1, 0, 0, 0, 0);
            startPicker.KeyDown += recordInput_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 0;
            label2.Text = "Start Date:";
            // 
            // endPnl
            // 
            endPnl.AutoSize = true;
            endPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            endPnl.Controls.Add(endPicker);
            endPnl.Controls.Add(label3);
            endPnl.Location = new Point(271, 8);
            endPnl.Name = "endPnl";
            endPnl.Size = new Size(153, 26);
            endPnl.TabIndex = 12;
            // 
            // endPicker
            // 
            endPicker.CustomFormat = "MMM-dd";
            endPicker.Format = DateTimePickerFormat.Custom;
            endPicker.Location = new Point(80, 0);
            endPicker.Name = "endPicker";
            endPicker.ShowUpDown = true;
            endPicker.Size = new Size(70, 23);
            endPicker.TabIndex = 3;
            endPicker.Value = new DateTime(2000, 10, 31, 0, 0, 0, 0);
            endPicker.KeyDown += recordInput_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(5, 4);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "End Date:";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(437, 10);
            saveBtn.Margin = new Padding(10, 5, 5, 5);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 13;
            saveBtn.Text = "&Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // controlPnl
            // 
            controlPnl.AutoScroll = true;
            controlPnl.AutoSize = true;
            controlPnl.Controls.Add(closeBtn);
            controlPnl.Dock = DockStyle.Bottom;
            controlPnl.Location = new Point(0, 544);
            controlPnl.Name = "controlPnl";
            controlPnl.Size = new Size(970, 56);
            controlPnl.TabIndex = 7;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top;
            closeBtn.Location = new Point(430, 6);
            closeBtn.Margin = new Padding(10);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(115, 40);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "&Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // gridWrap
            // 
            gridWrap.AutoScroll = true;
            gridWrap.Controls.Add(editBtn);
            gridWrap.Controls.Add(deleteBtn);
            gridWrap.Controls.Add(seasonGrid);
            gridWrap.Dock = DockStyle.Fill;
            gridWrap.Location = new Point(0, 76);
            gridWrap.Name = "gridWrap";
            gridWrap.Padding = new Padding(5);
            gridWrap.Size = new Size(970, 468);
            gridWrap.TabIndex = 8;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(425, 108);
            editBtn.Margin = new Padding(10);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(115, 40);
            editBtn.TabIndex = 7;
            editBtn.Text = "&Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(425, 15);
            deleteBtn.Margin = new Padding(10);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(115, 40);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "&Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // seasonGrid
            // 
            seasonGrid.AllowUserToAddRows = false;
            seasonGrid.AllowUserToDeleteRows = false;
            seasonGrid.AllowUserToResizeRows = false;
            seasonGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            seasonGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            seasonGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            seasonGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seasonGrid.Location = new Point(5, 5);
            seasonGrid.Margin = new Padding(10);
            seasonGrid.MinimumSize = new Size(400, 250);
            seasonGrid.Name = "seasonGrid";
            seasonGrid.ReadOnly = true;
            seasonGrid.RowTemplate.Height = 25;
            seasonGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            seasonGrid.Size = new Size(400, 463);
            seasonGrid.TabIndex = 5;
            seasonGrid.CellMouseDoubleClick += seasonGrid_CellMouseDoubleClick;
            seasonGrid.SelectionChanged += seasonGrid_SelectionChanged;
            seasonGrid.KeyDown += seasonGrid_KeyDown;
            // 
            // SeasonDatesEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridWrap);
            Controls.Add(entryPnl);
            Controls.Add(controlPnl);
            Controls.Add(headerLbl);
            Name = "SeasonDatesEdit";
            Size = new Size(970, 600);
            entryPnl.ResumeLayout(false);
            entryPnl.PerformLayout();
            yearPnl.ResumeLayout(false);
            yearPnl.PerformLayout();
            startPnl.ResumeLayout(false);
            startPnl.PerformLayout();
            endPnl.ResumeLayout(false);
            endPnl.PerformLayout();
            controlPnl.ResumeLayout(false);
            gridWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)seasonGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
