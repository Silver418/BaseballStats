namespace BaseballView {
    partial class SeasonRosters {
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
            controlPnl = new Panel();
            searchBtn = new Button();
            closeBtn = new Button();
            rosterGrid = new DataGridView();
            bioPnl = new FlowLayoutPanel();
            teamIdPnl = new Panel();
            teamIdLbl = new Label();
            label10 = new Label();
            yearPnl = new Panel();
            yearLbl = new Label();
            label2 = new Label();
            lgPnl = new Panel();
            leagueLbl = new Label();
            label4 = new Label();
            divPnl = new Panel();
            divLbl = new Label();
            label6 = new Label();
            teamNamePnl = new Panel();
            teamNameLbl = new Label();
            label8 = new Label();
            gamesPnl = new Panel();
            gamesLbl = new Label();
            label3 = new Label();
            statsPnl = new Panel();
            tabControl1 = new TabControl();
            fieldingTab = new TabPage();
            fieldingWrap = new Panel();
            desigHitterTab = new TabPage();
            desigHitterWrap = new SplitContainer();
            desigHitterGrid = new DataGridView();
            detailsBtn = new Button();
            desigDetailGrid = new DataGridView();
            calculationPnl = new Panel();
            copyRosterBtn = new Button();
            calcMStartsBtn = new Button();
            pitcherNud = new NumericUpDown();
            lineupsNud = new NumericUpDown();
            gamesNud = new NumericUpDown();
            label7 = new Label();
            label5 = new Label();
            label1 = new Label();
            controlPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rosterGrid).BeginInit();
            bioPnl.SuspendLayout();
            teamIdPnl.SuspendLayout();
            yearPnl.SuspendLayout();
            lgPnl.SuspendLayout();
            divPnl.SuspendLayout();
            teamNamePnl.SuspendLayout();
            gamesPnl.SuspendLayout();
            statsPnl.SuspendLayout();
            tabControl1.SuspendLayout();
            fieldingTab.SuspendLayout();
            fieldingWrap.SuspendLayout();
            desigHitterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)desigHitterWrap).BeginInit();
            desigHitterWrap.Panel1.SuspendLayout();
            desigHitterWrap.Panel2.SuspendLayout();
            desigHitterWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)desigHitterGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desigDetailGrid).BeginInit();
            calculationPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pitcherNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lineupsNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gamesNud).BeginInit();
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
            headerLbl.Size = new Size(175, 31);
            headerLbl.TabIndex = 4;
            headerLbl.Text = "View Season Rosters";
            // 
            // controlPnl
            // 
            controlPnl.AutoScroll = true;
            controlPnl.AutoSize = true;
            controlPnl.Controls.Add(searchBtn);
            controlPnl.Controls.Add(closeBtn);
            controlPnl.Dock = DockStyle.Bottom;
            controlPnl.Location = new Point(0, 544);
            controlPnl.Name = "controlPnl";
            controlPnl.Size = new Size(970, 56);
            controlPnl.TabIndex = 9;
            // 
            // searchBtn
            // 
            searchBtn.Anchor = AnchorStyles.Top;
            searchBtn.Location = new Point(349, 6);
            searchBtn.Margin = new Padding(10);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(115, 40);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "&Search Team";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Anchor = AnchorStyles.Top;
            closeBtn.Location = new Point(483, 6);
            closeBtn.Margin = new Padding(10);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(115, 40);
            closeBtn.TabIndex = 2;
            closeBtn.Text = "&Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // rosterGrid
            // 
            rosterGrid.AllowUserToAddRows = false;
            rosterGrid.AllowUserToDeleteRows = false;
            rosterGrid.AllowUserToResizeColumns = false;
            rosterGrid.AllowUserToResizeRows = false;
            rosterGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            rosterGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rosterGrid.Dock = DockStyle.Fill;
            rosterGrid.Location = new Point(5, 5);
            rosterGrid.MinimumSize = new Size(600, 250);
            rosterGrid.Name = "rosterGrid";
            rosterGrid.ReadOnly = true;
            rosterGrid.RowTemplate.Height = 25;
            rosterGrid.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
            rosterGrid.ShowCellToolTips = false;
            rosterGrid.Size = new Size(946, 378);
            rosterGrid.TabIndex = 12;
            // 
            // bioPnl
            // 
            bioPnl.AutoScroll = true;
            bioPnl.AutoSize = true;
            bioPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bioPnl.BorderStyle = BorderStyle.FixedSingle;
            bioPnl.Controls.Add(teamIdPnl);
            bioPnl.Controls.Add(yearPnl);
            bioPnl.Controls.Add(lgPnl);
            bioPnl.Controls.Add(divPnl);
            bioPnl.Controls.Add(teamNamePnl);
            bioPnl.Controls.Add(gamesPnl);
            bioPnl.Dock = DockStyle.Top;
            bioPnl.Location = new Point(0, 31);
            bioPnl.Name = "bioPnl";
            bioPnl.Padding = new Padding(5);
            bioPnl.Size = new Size(970, 54);
            bioPnl.TabIndex = 13;
            // 
            // teamIdPnl
            // 
            teamIdPnl.AutoSize = true;
            teamIdPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            teamIdPnl.Controls.Add(teamIdLbl);
            teamIdPnl.Controls.Add(label10);
            teamIdPnl.Location = new Point(8, 8);
            teamIdPnl.Name = "teamIdPnl";
            teamIdPnl.Size = new Size(68, 15);
            teamIdPnl.TabIndex = 8;
            // 
            // teamIdLbl
            // 
            teamIdLbl.AutoSize = true;
            teamIdLbl.Location = new Point(65, 0);
            teamIdLbl.Name = "teamIdLbl";
            teamIdLbl.Size = new Size(0, 15);
            teamIdLbl.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 0;
            label10.Text = "Team ID:";
            // 
            // yearPnl
            // 
            yearPnl.AutoSize = true;
            yearPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            yearPnl.Controls.Add(yearLbl);
            yearPnl.Controls.Add(label2);
            yearPnl.Location = new Point(82, 8);
            yearPnl.Name = "yearPnl";
            yearPnl.Size = new Size(38, 15);
            yearPnl.TabIndex = 9;
            // 
            // yearLbl
            // 
            yearLbl.AutoSize = true;
            yearLbl.Location = new Point(35, 0);
            yearLbl.Name = "yearLbl";
            yearLbl.Size = new Size(0, 15);
            yearLbl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 0;
            label2.Text = "Year:";
            // 
            // lgPnl
            // 
            lgPnl.AutoSize = true;
            lgPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            lgPnl.Controls.Add(leagueLbl);
            lgPnl.Controls.Add(label4);
            lgPnl.Location = new Point(126, 8);
            lgPnl.Name = "lgPnl";
            lgPnl.Size = new Size(58, 15);
            lgPnl.TabIndex = 10;
            // 
            // leagueLbl
            // 
            leagueLbl.AutoSize = true;
            leagueLbl.Location = new Point(55, 0);
            leagueLbl.Name = "leagueLbl";
            leagueLbl.Size = new Size(0, 15);
            leagueLbl.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "League:";
            // 
            // divPnl
            // 
            divPnl.AutoSize = true;
            divPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            divPnl.Controls.Add(divLbl);
            divPnl.Controls.Add(label6);
            bioPnl.SetFlowBreak(divPnl, true);
            divPnl.Location = new Point(190, 8);
            divPnl.Name = "divPnl";
            divPnl.Size = new Size(63, 15);
            divPnl.TabIndex = 11;
            // 
            // divLbl
            // 
            divLbl.AutoSize = true;
            divLbl.Location = new Point(60, 0);
            divLbl.Name = "divLbl";
            divLbl.Size = new Size(0, 15);
            divLbl.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 0;
            label6.Text = "Division:";
            // 
            // teamNamePnl
            // 
            teamNamePnl.AutoSize = true;
            teamNamePnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            teamNamePnl.Controls.Add(teamNameLbl);
            teamNamePnl.Controls.Add(label8);
            teamNamePnl.Location = new Point(8, 29);
            teamNamePnl.Name = "teamNamePnl";
            teamNamePnl.Size = new Size(83, 15);
            teamNamePnl.TabIndex = 12;
            // 
            // teamNameLbl
            // 
            teamNameLbl.AutoSize = true;
            teamNameLbl.Location = new Point(80, 0);
            teamNameLbl.Name = "teamNameLbl";
            teamNameLbl.Size = new Size(0, 15);
            teamNameLbl.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 0;
            label8.Text = "Team Name:";
            // 
            // gamesPnl
            // 
            gamesPnl.AutoSize = true;
            gamesPnl.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gamesPnl.Controls.Add(gamesLbl);
            gamesPnl.Controls.Add(label3);
            gamesPnl.Location = new Point(97, 29);
            gamesPnl.Name = "gamesPnl";
            gamesPnl.Size = new Size(53, 15);
            gamesPnl.TabIndex = 20;
            // 
            // gamesLbl
            // 
            gamesLbl.AutoSize = true;
            gamesLbl.Location = new Point(50, 0);
            gamesLbl.Name = "gamesLbl";
            gamesLbl.Size = new Size(0, 15);
            gamesLbl.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Games:";
            // 
            // statsPnl
            // 
            statsPnl.Controls.Add(tabControl1);
            statsPnl.Dock = DockStyle.Fill;
            statsPnl.Location = new Point(0, 122);
            statsPnl.Name = "statsPnl";
            statsPnl.Size = new Size(970, 422);
            statsPnl.TabIndex = 14;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(fieldingTab);
            tabControl1.Controls.Add(desigHitterTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(970, 422);
            tabControl1.TabIndex = 0;
            // 
            // fieldingTab
            // 
            fieldingTab.AutoScroll = true;
            fieldingTab.Controls.Add(fieldingWrap);
            fieldingTab.Location = new Point(4, 24);
            fieldingTab.Name = "fieldingTab";
            fieldingTab.Padding = new Padding(3);
            fieldingTab.Size = new Size(962, 394);
            fieldingTab.TabIndex = 1;
            fieldingTab.Text = "Season Roster";
            fieldingTab.UseVisualStyleBackColor = true;
            // 
            // fieldingWrap
            // 
            fieldingWrap.Controls.Add(rosterGrid);
            fieldingWrap.Dock = DockStyle.Fill;
            fieldingWrap.Location = new Point(3, 3);
            fieldingWrap.Name = "fieldingWrap";
            fieldingWrap.Padding = new Padding(5);
            fieldingWrap.Size = new Size(956, 388);
            fieldingWrap.TabIndex = 8;
            // 
            // desigHitterTab
            // 
            desigHitterTab.AutoScroll = true;
            desigHitterTab.Controls.Add(desigHitterWrap);
            desigHitterTab.Location = new Point(4, 24);
            desigHitterTab.Name = "desigHitterTab";
            desigHitterTab.Padding = new Padding(3);
            desigHitterTab.Size = new Size(962, 394);
            desigHitterTab.TabIndex = 0;
            desigHitterTab.Text = "Designated Hitters Details";
            desigHitterTab.UseVisualStyleBackColor = true;
            // 
            // desigHitterWrap
            // 
            desigHitterWrap.Dock = DockStyle.Fill;
            desigHitterWrap.Location = new Point(3, 3);
            desigHitterWrap.Name = "desigHitterWrap";
            desigHitterWrap.Orientation = Orientation.Horizontal;
            // 
            // desigHitterWrap.Panel1
            // 
            desigHitterWrap.Panel1.Controls.Add(desigHitterGrid);
            desigHitterWrap.Panel1MinSize = 100;
            // 
            // desigHitterWrap.Panel2
            // 
            desigHitterWrap.Panel2.Controls.Add(detailsBtn);
            desigHitterWrap.Panel2.Controls.Add(desigDetailGrid);
            desigHitterWrap.Panel2MinSize = 100;
            desigHitterWrap.Size = new Size(956, 388);
            desigHitterWrap.SplitterDistance = 263;
            desigHitterWrap.TabIndex = 7;
            // 
            // desigHitterGrid
            // 
            desigHitterGrid.AllowUserToAddRows = false;
            desigHitterGrid.AllowUserToDeleteRows = false;
            desigHitterGrid.AllowUserToResizeRows = false;
            desigHitterGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            desigHitterGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            desigHitterGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            desigHitterGrid.Dock = DockStyle.Fill;
            desigHitterGrid.Location = new Point(0, 0);
            desigHitterGrid.Margin = new Padding(5);
            desigHitterGrid.MinimumSize = new Size(600, 250);
            desigHitterGrid.Name = "desigHitterGrid";
            desigHitterGrid.ReadOnly = true;
            desigHitterGrid.RowTemplate.Height = 25;
            desigHitterGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            desigHitterGrid.ShowCellToolTips = false;
            desigHitterGrid.Size = new Size(956, 263);
            desigHitterGrid.TabIndex = 5;
            desigHitterGrid.SelectionChanged += desigHitterGrid_SelectionChanged;
            desigHitterGrid.DoubleClick += details_Click;
            desigHitterGrid.KeyDown += desigHitterGrid_KeyDown;
            // 
            // detailsBtn
            // 
            detailsBtn.Enabled = false;
            detailsBtn.Location = new Point(3, 10);
            detailsBtn.Margin = new Padding(10);
            detailsBtn.Name = "detailsBtn";
            detailsBtn.Size = new Size(115, 40);
            detailsBtn.TabIndex = 7;
            detailsBtn.Text = "Show &Details";
            detailsBtn.UseVisualStyleBackColor = true;
            detailsBtn.Click += details_Click;
            // 
            // desigDetailGrid
            // 
            desigDetailGrid.AllowUserToAddRows = false;
            desigDetailGrid.AllowUserToDeleteRows = false;
            desigDetailGrid.AllowUserToResizeRows = false;
            desigDetailGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            desigDetailGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            desigDetailGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            desigDetailGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            desigDetailGrid.Location = new Point(120, 0);
            desigDetailGrid.Margin = new Padding(5);
            desigDetailGrid.MinimumSize = new Size(600, 100);
            desigDetailGrid.Name = "desigDetailGrid";
            desigDetailGrid.ReadOnly = true;
            desigDetailGrid.RowTemplate.Height = 25;
            desigDetailGrid.ShowCellToolTips = false;
            desigDetailGrid.Size = new Size(835, 121);
            desigDetailGrid.TabIndex = 6;
            // 
            // calculationPnl
            // 
            calculationPnl.Controls.Add(copyRosterBtn);
            calculationPnl.Controls.Add(calcMStartsBtn);
            calculationPnl.Controls.Add(pitcherNud);
            calculationPnl.Controls.Add(lineupsNud);
            calculationPnl.Controls.Add(gamesNud);
            calculationPnl.Controls.Add(label7);
            calculationPnl.Controls.Add(label5);
            calculationPnl.Controls.Add(label1);
            calculationPnl.Dock = DockStyle.Top;
            calculationPnl.Location = new Point(0, 85);
            calculationPnl.Name = "calculationPnl";
            calculationPnl.Padding = new Padding(5);
            calculationPnl.Size = new Size(970, 37);
            calculationPnl.TabIndex = 0;
            // 
            // copyRosterBtn
            // 
            copyRosterBtn.Enabled = false;
            copyRosterBtn.Location = new Point(700, 5);
            copyRosterBtn.Name = "copyRosterBtn";
            copyRosterBtn.Size = new Size(150, 23);
            copyRosterBtn.TabIndex = 7;
            copyRosterBtn.Text = "Copy &Roster to Clipboard";
            copyRosterBtn.UseVisualStyleBackColor = true;
            copyRosterBtn.Click += copyRosterBtn_Click;
            // 
            // calcMStartsBtn
            // 
            calcMStartsBtn.Enabled = false;
            calcMStartsBtn.Location = new Point(538, 6);
            calcMStartsBtn.Name = "calcMStartsBtn";
            calcMStartsBtn.Size = new Size(150, 23);
            calcMStartsBtn.TabIndex = 3;
            calcMStartsBtn.Text = "Calculate &Modified Starts";
            calcMStartsBtn.UseVisualStyleBackColor = true;
            calcMStartsBtn.Click += button1_Click;
            // 
            // pitcherNud
            // 
            pitcherNud.Enabled = false;
            pitcherNud.Location = new Point(469, 5);
            pitcherNud.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            pitcherNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            pitcherNud.Name = "pitcherNud";
            pitcherNud.Size = new Size(45, 23);
            pitcherNud.TabIndex = 2;
            pitcherNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            pitcherNud.KeyDown += MStartsInput_KeyDown;
            // 
            // lineupsNud
            // 
            lineupsNud.Enabled = false;
            lineupsNud.Location = new Point(263, 5);
            lineupsNud.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            lineupsNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            lineupsNud.Name = "lineupsNud";
            lineupsNud.Size = new Size(45, 23);
            lineupsNud.TabIndex = 1;
            lineupsNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            lineupsNud.KeyDown += MStartsInput_KeyDown;
            // 
            // gamesNud
            // 
            gamesNud.Enabled = false;
            gamesNud.Location = new Point(127, 5);
            gamesNud.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            gamesNud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            gamesNud.Name = "gamesNud";
            gamesNud.Size = new Size(55, 23);
            gamesNud.TabIndex = 0;
            gamesNud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            gamesNud.KeyDown += MStartsInput_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(321, 7);
            label7.Margin = new Padding(3);
            label7.Name = "label7";
            label7.Size = new Size(141, 15);
            label7.TabIndex = 6;
            label7.Text = "# Pitcher Rotation Slots:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(195, 7);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 5;
            label5.Text = "# Lineups:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 7);
            label1.Margin = new Padding(3);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 4;
            label1.Text = "Games Per Season:";
            // 
            // SeasonRosters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statsPnl);
            Controls.Add(controlPnl);
            Controls.Add(calculationPnl);
            Controls.Add(bioPnl);
            Controls.Add(headerLbl);
            Name = "SeasonRosters";
            Size = new Size(970, 600);
            controlPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rosterGrid).EndInit();
            bioPnl.ResumeLayout(false);
            bioPnl.PerformLayout();
            teamIdPnl.ResumeLayout(false);
            teamIdPnl.PerformLayout();
            yearPnl.ResumeLayout(false);
            yearPnl.PerformLayout();
            lgPnl.ResumeLayout(false);
            lgPnl.PerformLayout();
            divPnl.ResumeLayout(false);
            divPnl.PerformLayout();
            teamNamePnl.ResumeLayout(false);
            teamNamePnl.PerformLayout();
            gamesPnl.ResumeLayout(false);
            gamesPnl.PerformLayout();
            statsPnl.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            fieldingTab.ResumeLayout(false);
            fieldingWrap.ResumeLayout(false);
            desigHitterTab.ResumeLayout(false);
            desigHitterWrap.Panel1.ResumeLayout(false);
            desigHitterWrap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)desigHitterWrap).EndInit();
            desigHitterWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)desigHitterGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)desigDetailGrid).EndInit();
            calculationPnl.ResumeLayout(false);
            calculationPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pitcherNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)lineupsNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)gamesNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLbl;
        private Panel controlPnl;
        private Button closeBtn;
        private Button searchBtn;
        private DataGridView rosterGrid;
        private FlowLayoutPanel bioPnl;
        private Panel teamIdPnl;
        private Label teamIdLbl;
        private Label label10;
        private Panel yearPnl;
        private Label yearLbl;
        private Label label2;
        private Panel lgPnl;
        private Label leagueLbl;
        private Label label4;
        private Panel divPnl;
        private Label divLbl;
        private Label label6;
        private Panel teamNamePnl;
        private Label teamNameLbl;
        private Label label8;
        private Panel gamesPnl;
        private Label gamesLbl;
        private Label label3;
        private Panel statsPnl;
        private TabControl tabControl1;
        private TabPage fieldingTab;
        private Panel fieldingWrap;
        private TabPage desigHitterTab;
        private DataGridView desigHitterGrid;
        private SplitContainer desigHitterWrap;
        private Button detailsBtn;
        private DataGridView desigDetailGrid;
        private Panel calculationPnl;
        private NumericUpDown pitcherNud;
        private NumericUpDown lineupsNud;
        private NumericUpDown gamesNud;
        private Label label7;
        private Label label5;
        private Label label1;
        private Button calcMStartsBtn;
        private Button copyRosterBtn;
    }
}
