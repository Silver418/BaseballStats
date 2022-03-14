namespace BaseballView {
    partial class StintEdit {
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
            this.controlPnl = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.yearEntryPnl = new System.Windows.Forms.Panel();
            this.seasonYearLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seasonDaysLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.seasonEndLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seasonStartLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.yearFilterPnl = new System.Windows.Forms.Panel();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.filterTeamCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filterIncompleteChk = new System.Windows.Forms.CheckBox();
            this.filterBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.yearPnl = new System.Windows.Forms.Panel();
            this.playerSelectPnl = new System.Windows.Forms.Panel();
            this.singleStintsBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.editPlayerBtn = new System.Windows.Forms.Button();
            this.playerDataGrid = new System.Windows.Forms.DataGridView();
            this.stintEditPnl = new System.Windows.Forms.Panel();
            this.stintCancelBtn = new System.Windows.Forms.Button();
            this.stintSaveBtn = new System.Windows.Forms.Button();
            this.stintEditGrid = new System.Windows.Forms.DataGridView();
            this.stintHeader = new System.Windows.Forms.Label();
            this.personStintWrap = new System.Windows.Forms.SplitContainer();
            this.progressLbl = new System.Windows.Forms.Label();
            this.controlPnl.SuspendLayout();
            this.yearEntryPnl.SuspendLayout();
            this.yearFilterPnl.SuspendLayout();
            this.yearPnl.SuspendLayout();
            this.playerSelectPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGrid)).BeginInit();
            this.stintEditPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stintEditGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personStintWrap)).BeginInit();
            this.personStintWrap.Panel1.SuspendLayout();
            this.personStintWrap.Panel2.SuspendLayout();
            this.personStintWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLbl
            // 
            this.headerLbl.AutoSize = true;
            this.headerLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.headerLbl.Location = new System.Drawing.Point(3, 3);
            this.headerLbl.Margin = new System.Windows.Forms.Padding(5);
            this.headerLbl.Name = "headerLbl";
            this.headerLbl.Padding = new System.Windows.Forms.Padding(5);
            this.headerLbl.Size = new System.Drawing.Size(155, 31);
            this.headerLbl.TabIndex = 3;
            this.headerLbl.Text = "Edit Season Stints";
            // 
            // controlPnl
            // 
            this.controlPnl.AutoScroll = true;
            this.controlPnl.AutoSize = true;
            this.controlPnl.Controls.Add(this.closeBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(3, 541);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(964, 56);
            this.controlPnl.TabIndex = 8;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeBtn.Location = new System.Drawing.Point(427, 6);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(115, 40);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "&Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // yearEntryPnl
            // 
            this.yearEntryPnl.AutoSize = true;
            this.yearEntryPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yearEntryPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearEntryPnl.Controls.Add(this.seasonYearLbl);
            this.yearEntryPnl.Controls.Add(this.label8);
            this.yearEntryPnl.Controls.Add(this.seasonDaysLbl);
            this.yearEntryPnl.Controls.Add(this.label7);
            this.yearEntryPnl.Controls.Add(this.seasonEndLbl);
            this.yearEntryPnl.Controls.Add(this.label4);
            this.yearEntryPnl.Controls.Add(this.seasonStartLbl);
            this.yearEntryPnl.Controls.Add(this.label2);
            this.yearEntryPnl.Controls.Add(this.yearPicker);
            this.yearEntryPnl.Controls.Add(this.label1);
            this.yearEntryPnl.Controls.Add(this.searchBtn);
            this.yearEntryPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.yearEntryPnl.Location = new System.Drawing.Point(0, 0);
            this.yearEntryPnl.Name = "yearEntryPnl";
            this.yearEntryPnl.Size = new System.Drawing.Size(201, 110);
            this.yearEntryPnl.TabIndex = 10;
            // 
            // seasonYearLbl
            // 
            this.seasonYearLbl.AutoSize = true;
            this.seasonYearLbl.Location = new System.Drawing.Point(85, 30);
            this.seasonYearLbl.Name = "seasonYearLbl";
            this.seasonYearLbl.Size = new System.Drawing.Size(0, 15);
            this.seasonYearLbl.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Season:";
            // 
            // seasonDaysLbl
            // 
            this.seasonDaysLbl.AutoSize = true;
            this.seasonDaysLbl.Location = new System.Drawing.Point(85, 90);
            this.seasonDaysLbl.Name = "seasonDaysLbl";
            this.seasonDaysLbl.Size = new System.Drawing.Size(0, 15);
            this.seasonDaysLbl.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Season Days:";
            // 
            // seasonEndLbl
            // 
            this.seasonEndLbl.AutoSize = true;
            this.seasonEndLbl.Location = new System.Drawing.Point(85, 70);
            this.seasonEndLbl.Name = "seasonEndLbl";
            this.seasonEndLbl.Size = new System.Drawing.Size(0, 15);
            this.seasonEndLbl.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Season End:";
            // 
            // seasonStartLbl
            // 
            this.seasonStartLbl.AutoSize = true;
            this.seasonStartLbl.Location = new System.Drawing.Point(85, 50);
            this.seasonStartLbl.Name = "seasonStartLbl";
            this.seasonStartLbl.Size = new System.Drawing.Size(0, 15);
            this.seasonStartLbl.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Season Start:";
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
            this.yearPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.yearPicker_KeyDown);
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
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(108, 2);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(86, 23);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // yearFilterPnl
            // 
            this.yearFilterPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearFilterPnl.Controls.Add(this.clearFilterBtn);
            this.yearFilterPnl.Controls.Add(this.filterTeamCmb);
            this.yearFilterPnl.Controls.Add(this.label6);
            this.yearFilterPnl.Controls.Add(this.filterIncompleteChk);
            this.yearFilterPnl.Controls.Add(this.filterBtn);
            this.yearFilterPnl.Controls.Add(this.label3);
            this.yearFilterPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yearFilterPnl.Location = new System.Drawing.Point(201, 0);
            this.yearFilterPnl.Name = "yearFilterPnl";
            this.yearFilterPnl.Size = new System.Drawing.Size(763, 110);
            this.yearFilterPnl.TabIndex = 11;
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFilterBtn.Enabled = false;
            this.clearFilterBtn.Location = new System.Drawing.Point(636, 10);
            this.clearFilterBtn.Margin = new System.Windows.Forms.Padding(10);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(115, 40);
            this.clearFilterBtn.TabIndex = 9;
            this.clearFilterBtn.Text = "Clear Filter";
            this.clearFilterBtn.UseVisualStyleBackColor = true;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            // 
            // filterTeamCmb
            // 
            this.filterTeamCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTeamCmb.Enabled = false;
            this.filterTeamCmb.FormattingEnabled = true;
            this.filterTeamCmb.Location = new System.Drawing.Point(5, 77);
            this.filterTeamCmb.Name = "filterTeamCmb";
            this.filterTeamCmb.Size = new System.Drawing.Size(267, 23);
            this.filterTeamCmb.TabIndex = 8;
            this.filterTeamCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTeamCmb_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Players who played for team:";
            // 
            // filterIncompleteChk
            // 
            this.filterIncompleteChk.AutoSize = true;
            this.filterIncompleteChk.Enabled = false;
            this.filterIncompleteChk.Location = new System.Drawing.Point(5, 30);
            this.filterIncompleteChk.Name = "filterIncompleteChk";
            this.filterIncompleteChk.Size = new System.Drawing.Size(267, 19);
            this.filterIncompleteChk.TabIndex = 6;
            this.filterIncompleteChk.Text = "Show only players with incomplete stint dates";
            this.filterIncompleteChk.UseVisualStyleBackColor = true;
            // 
            // filterBtn
            // 
            this.filterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBtn.Enabled = false;
            this.filterBtn.Location = new System.Drawing.Point(637, 59);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(10);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(115, 40);
            this.filterBtn.TabIndex = 5;
            this.filterBtn.Text = "Apply &Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filters";
            // 
            // yearPnl
            // 
            this.yearPnl.Controls.Add(this.yearFilterPnl);
            this.yearPnl.Controls.Add(this.yearEntryPnl);
            this.yearPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.yearPnl.Location = new System.Drawing.Point(3, 34);
            this.yearPnl.Name = "yearPnl";
            this.yearPnl.Size = new System.Drawing.Size(964, 110);
            this.yearPnl.TabIndex = 12;
            // 
            // playerSelectPnl
            // 
            this.playerSelectPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerSelectPnl.Controls.Add(this.singleStintsBtn);
            this.playerSelectPnl.Controls.Add(this.label5);
            this.playerSelectPnl.Controls.Add(this.editPlayerBtn);
            this.playerSelectPnl.Controls.Add(this.playerDataGrid);
            this.playerSelectPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerSelectPnl.Location = new System.Drawing.Point(0, 0);
            this.playerSelectPnl.Name = "playerSelectPnl";
            this.playerSelectPnl.Size = new System.Drawing.Size(964, 234);
            this.playerSelectPnl.TabIndex = 13;
            // 
            // singleStintsBtn
            // 
            this.singleStintsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.singleStintsBtn.Enabled = false;
            this.singleStintsBtn.Location = new System.Drawing.Point(837, 90);
            this.singleStintsBtn.Margin = new System.Windows.Forms.Padding(10);
            this.singleStintsBtn.Name = "singleStintsBtn";
            this.singleStintsBtn.Size = new System.Drawing.Size(115, 40);
            this.singleStintsBtn.TabIndex = 5;
            this.singleStintsBtn.Text = "Single S&tint Players";
            this.singleStintsBtn.UseVisualStyleBackColor = true;
            this.singleStintsBtn.Click += new System.EventHandler(this.singleStintsBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Players";
            // 
            // editPlayerBtn
            // 
            this.editPlayerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPlayerBtn.Enabled = false;
            this.editPlayerBtn.Location = new System.Drawing.Point(837, 30);
            this.editPlayerBtn.Margin = new System.Windows.Forms.Padding(10);
            this.editPlayerBtn.Name = "editPlayerBtn";
            this.editPlayerBtn.Size = new System.Drawing.Size(115, 40);
            this.editPlayerBtn.TabIndex = 3;
            this.editPlayerBtn.Text = "&Edit";
            this.editPlayerBtn.UseVisualStyleBackColor = true;
            this.editPlayerBtn.Click += new System.EventHandler(this.editPlayerBtn_Click);
            // 
            // playerDataGrid
            // 
            this.playerDataGrid.AllowUserToResizeRows = false;
            this.playerDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.playerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerDataGrid.Enabled = false;
            this.playerDataGrid.Location = new System.Drawing.Point(3, 30);
            this.playerDataGrid.Name = "playerDataGrid";
            this.playerDataGrid.RowTemplate.Height = 25;
            this.playerDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.playerDataGrid.ShowCellToolTips = false;
            this.playerDataGrid.Size = new System.Drawing.Size(821, 199);
            this.playerDataGrid.TabIndex = 0;
            this.playerDataGrid.SelectionChanged += new System.EventHandler(this.playerDataGrid_SelectionChanged);
            this.playerDataGrid.DoubleClick += new System.EventHandler(this.playerDataGrid_DoubleClick);
            this.playerDataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playerDataGrid_KeyDown);
            // 
            // stintEditPnl
            // 
            this.stintEditPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stintEditPnl.Controls.Add(this.stintCancelBtn);
            this.stintEditPnl.Controls.Add(this.stintSaveBtn);
            this.stintEditPnl.Controls.Add(this.stintEditGrid);
            this.stintEditPnl.Controls.Add(this.stintHeader);
            this.stintEditPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stintEditPnl.Location = new System.Drawing.Point(0, 0);
            this.stintEditPnl.Name = "stintEditPnl";
            this.stintEditPnl.Size = new System.Drawing.Size(964, 159);
            this.stintEditPnl.TabIndex = 14;
            // 
            // stintCancelBtn
            // 
            this.stintCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stintCancelBtn.Enabled = false;
            this.stintCancelBtn.Location = new System.Drawing.Point(837, 90);
            this.stintCancelBtn.Margin = new System.Windows.Forms.Padding(10);
            this.stintCancelBtn.Name = "stintCancelBtn";
            this.stintCancelBtn.Size = new System.Drawing.Size(115, 40);
            this.stintCancelBtn.TabIndex = 7;
            this.stintCancelBtn.Text = "C&ancel";
            this.stintCancelBtn.UseVisualStyleBackColor = true;
            this.stintCancelBtn.Click += new System.EventHandler(this.stintCancelBtn_Click);
            // 
            // stintSaveBtn
            // 
            this.stintSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stintSaveBtn.Enabled = false;
            this.stintSaveBtn.Location = new System.Drawing.Point(837, 30);
            this.stintSaveBtn.Margin = new System.Windows.Forms.Padding(10);
            this.stintSaveBtn.Name = "stintSaveBtn";
            this.stintSaveBtn.Size = new System.Drawing.Size(115, 40);
            this.stintSaveBtn.TabIndex = 5;
            this.stintSaveBtn.Text = "Calculate && &Save";
            this.stintSaveBtn.UseVisualStyleBackColor = true;
            this.stintSaveBtn.Click += new System.EventHandler(this.stintSaveBtn_Click);
            // 
            // stintEditGrid
            // 
            this.stintEditGrid.AllowUserToResizeRows = false;
            this.stintEditGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stintEditGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.stintEditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stintEditGrid.Enabled = false;
            this.stintEditGrid.Location = new System.Drawing.Point(5, 30);
            this.stintEditGrid.Name = "stintEditGrid";
            this.stintEditGrid.RowTemplate.Height = 25;
            this.stintEditGrid.ShowCellToolTips = false;
            this.stintEditGrid.Size = new System.Drawing.Size(819, 121);
            this.stintEditGrid.TabIndex = 6;
            this.stintEditGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stintEditGrid_CellContentClick);
            this.stintEditGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stintEditGrid_CellContentClick);
            this.stintEditGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.stintEditGrid_DataBindingComplete);
            this.stintEditGrid.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.stintEditGrid_DataError);
            // 
            // stintHeader
            // 
            this.stintHeader.AutoSize = true;
            this.stintHeader.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stintHeader.Location = new System.Drawing.Point(3, 7);
            this.stintHeader.Name = "stintHeader";
            this.stintHeader.Size = new System.Drawing.Size(183, 20);
            this.stintHeader.TabIndex = 5;
            this.stintHeader.Text = "Stints for Selected Player";
            // 
            // personStintWrap
            // 
            this.personStintWrap.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.personStintWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personStintWrap.Location = new System.Drawing.Point(3, 144);
            this.personStintWrap.Name = "personStintWrap";
            this.personStintWrap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // personStintWrap.Panel1
            // 
            this.personStintWrap.Panel1.Controls.Add(this.playerSelectPnl);
            this.personStintWrap.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.personStintWrap.Panel1MinSize = 100;
            // 
            // personStintWrap.Panel2
            // 
            this.personStintWrap.Panel2.Controls.Add(this.stintEditPnl);
            this.personStintWrap.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.personStintWrap.Panel2MinSize = 100;
            this.personStintWrap.Size = new System.Drawing.Size(964, 397);
            this.personStintWrap.SplitterDistance = 234;
            this.personStintWrap.TabIndex = 3;
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.progressLbl.Location = new System.Drawing.Point(386, 11);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(0, 20);
            this.progressLbl.TabIndex = 13;
            // 
            // StintEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.personStintWrap);
            this.Controls.Add(this.yearPnl);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "StintEdit";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(970, 600);
            this.controlPnl.ResumeLayout(false);
            this.yearEntryPnl.ResumeLayout(false);
            this.yearEntryPnl.PerformLayout();
            this.yearFilterPnl.ResumeLayout(false);
            this.yearFilterPnl.PerformLayout();
            this.yearPnl.ResumeLayout(false);
            this.yearPnl.PerformLayout();
            this.playerSelectPnl.ResumeLayout(false);
            this.playerSelectPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerDataGrid)).EndInit();
            this.stintEditPnl.ResumeLayout(false);
            this.stintEditPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stintEditGrid)).EndInit();
            this.personStintWrap.Panel1.ResumeLayout(false);
            this.personStintWrap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personStintWrap)).EndInit();
            this.personStintWrap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLbl;
        private Panel controlPnl;
        private Button closeBtn;
        private Panel yearEntryPnl;
        private Label seasonEndLbl;
        private Label label4;
        private Label seasonStartLbl;
        private Label label2;
        private DateTimePicker yearPicker;
        private Label label1;
        private Button searchBtn;
        private Panel yearFilterPnl;
        private Panel yearPnl;
        private Panel playerSelectPnl;
        private Panel stintEditPnl;
        private SplitContainer personStintWrap;
        private Button editPlayerBtn;
        private DataGridView playerDataGrid;
        private Label label5;
        private Button stintCancelBtn;
        private Button stintSaveBtn;
        private DataGridView stintEditGrid;
        private Label stintHeader;
        private Label seasonDaysLbl;
        private Label label7;
        private Label seasonYearLbl;
        private Label label8;
        private Label label3;
        private Label label6;
        private CheckBox filterIncompleteChk;
        private Button filterBtn;
        private ComboBox filterTeamCmb;
        private Button clearFilterBtn;
        private Button singleStintsBtn;
        private Label progressLbl;
    }
}
