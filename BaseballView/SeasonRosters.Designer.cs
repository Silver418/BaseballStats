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
        private void InitializeComponent() {
            this.headerLbl = new System.Windows.Forms.Label();
            this.controlPnl = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.fieldingGrid = new System.Windows.Forms.DataGridView();
            this.bioPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.teamIdPnl = new System.Windows.Forms.Panel();
            this.teamIdLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.yearPnl = new System.Windows.Forms.Panel();
            this.yearLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lgPnl = new System.Windows.Forms.Panel();
            this.leagueLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.divPnl = new System.Windows.Forms.Panel();
            this.divLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teamNamePnl = new System.Windows.Forms.Panel();
            this.teamNameLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gamesPnl = new System.Windows.Forms.Panel();
            this.gamesLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statsPnl = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fieldingTab = new System.Windows.Forms.TabPage();
            this.fieldingWrap = new System.Windows.Forms.Panel();
            this.desigHitterTab = new System.Windows.Forms.TabPage();
            this.desigHitterWrap = new System.Windows.Forms.SplitContainer();
            this.desigHitterGrid = new System.Windows.Forms.DataGridView();
            this.detailsBtn = new System.Windows.Forms.Button();
            this.desigDetailGrid = new System.Windows.Forms.DataGridView();
            this.controlPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldingGrid)).BeginInit();
            this.bioPnl.SuspendLayout();
            this.teamIdPnl.SuspendLayout();
            this.yearPnl.SuspendLayout();
            this.lgPnl.SuspendLayout();
            this.divPnl.SuspendLayout();
            this.teamNamePnl.SuspendLayout();
            this.gamesPnl.SuspendLayout();
            this.statsPnl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.fieldingTab.SuspendLayout();
            this.fieldingWrap.SuspendLayout();
            this.desigHitterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desigHitterWrap)).BeginInit();
            this.desigHitterWrap.Panel1.SuspendLayout();
            this.desigHitterWrap.Panel2.SuspendLayout();
            this.desigHitterWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.desigHitterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desigDetailGrid)).BeginInit();
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
            this.headerLbl.Size = new System.Drawing.Size(175, 31);
            this.headerLbl.TabIndex = 4;
            this.headerLbl.Text = "View Season Rosters";
            // 
            // controlPnl
            // 
            this.controlPnl.AutoScroll = true;
            this.controlPnl.AutoSize = true;
            this.controlPnl.Controls.Add(this.searchBtn);
            this.controlPnl.Controls.Add(this.closeBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(0, 544);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(970, 56);
            this.controlPnl.TabIndex = 9;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBtn.Location = new System.Drawing.Point(349, 6);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(115, 40);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "&Search Team";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.closeBtn.Location = new System.Drawing.Point(483, 6);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(115, 40);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "&Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // fieldingGrid
            // 
            this.fieldingGrid.AllowUserToAddRows = false;
            this.fieldingGrid.AllowUserToDeleteRows = false;
            this.fieldingGrid.AllowUserToResizeColumns = false;
            this.fieldingGrid.AllowUserToResizeRows = false;
            this.fieldingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.fieldingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldingGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldingGrid.Location = new System.Drawing.Point(5, 5);
            this.fieldingGrid.MinimumSize = new System.Drawing.Size(600, 250);
            this.fieldingGrid.Name = "fieldingGrid";
            this.fieldingGrid.ReadOnly = true;
            this.fieldingGrid.RowTemplate.Height = 25;
            this.fieldingGrid.ShowCellToolTips = false;
            this.fieldingGrid.Size = new System.Drawing.Size(946, 415);
            this.fieldingGrid.TabIndex = 12;
            // 
            // bioPnl
            // 
            this.bioPnl.AutoScroll = true;
            this.bioPnl.AutoSize = true;
            this.bioPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bioPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bioPnl.Controls.Add(this.teamIdPnl);
            this.bioPnl.Controls.Add(this.yearPnl);
            this.bioPnl.Controls.Add(this.lgPnl);
            this.bioPnl.Controls.Add(this.divPnl);
            this.bioPnl.Controls.Add(this.teamNamePnl);
            this.bioPnl.Controls.Add(this.gamesPnl);
            this.bioPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.bioPnl.Location = new System.Drawing.Point(0, 31);
            this.bioPnl.Name = "bioPnl";
            this.bioPnl.Padding = new System.Windows.Forms.Padding(5);
            this.bioPnl.Size = new System.Drawing.Size(970, 54);
            this.bioPnl.TabIndex = 13;
            // 
            // teamIdPnl
            // 
            this.teamIdPnl.AutoSize = true;
            this.teamIdPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teamIdPnl.Controls.Add(this.teamIdLbl);
            this.teamIdPnl.Controls.Add(this.label10);
            this.teamIdPnl.Location = new System.Drawing.Point(8, 8);
            this.teamIdPnl.Name = "teamIdPnl";
            this.teamIdPnl.Size = new System.Drawing.Size(68, 15);
            this.teamIdPnl.TabIndex = 8;
            // 
            // teamIdLbl
            // 
            this.teamIdLbl.AutoSize = true;
            this.teamIdLbl.Location = new System.Drawing.Point(65, 0);
            this.teamIdLbl.Name = "teamIdLbl";
            this.teamIdLbl.Size = new System.Drawing.Size(0, 15);
            this.teamIdLbl.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Team ID:";
            // 
            // yearPnl
            // 
            this.yearPnl.AutoSize = true;
            this.yearPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yearPnl.Controls.Add(this.yearLbl);
            this.yearPnl.Controls.Add(this.label2);
            this.yearPnl.Location = new System.Drawing.Point(82, 8);
            this.yearPnl.Name = "yearPnl";
            this.yearPnl.Size = new System.Drawing.Size(38, 15);
            this.yearPnl.TabIndex = 9;
            // 
            // yearLbl
            // 
            this.yearLbl.AutoSize = true;
            this.yearLbl.Location = new System.Drawing.Point(35, 0);
            this.yearLbl.Name = "yearLbl";
            this.yearLbl.Size = new System.Drawing.Size(0, 15);
            this.yearLbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Year:";
            // 
            // lgPnl
            // 
            this.lgPnl.AutoSize = true;
            this.lgPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lgPnl.Controls.Add(this.leagueLbl);
            this.lgPnl.Controls.Add(this.label4);
            this.lgPnl.Location = new System.Drawing.Point(126, 8);
            this.lgPnl.Name = "lgPnl";
            this.lgPnl.Size = new System.Drawing.Size(58, 15);
            this.lgPnl.TabIndex = 10;
            // 
            // leagueLbl
            // 
            this.leagueLbl.AutoSize = true;
            this.leagueLbl.Location = new System.Drawing.Point(55, 0);
            this.leagueLbl.Name = "leagueLbl";
            this.leagueLbl.Size = new System.Drawing.Size(0, 15);
            this.leagueLbl.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "League:";
            // 
            // divPnl
            // 
            this.divPnl.AutoSize = true;
            this.divPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.divPnl.Controls.Add(this.divLbl);
            this.divPnl.Controls.Add(this.label6);
            this.bioPnl.SetFlowBreak(this.divPnl, true);
            this.divPnl.Location = new System.Drawing.Point(190, 8);
            this.divPnl.Name = "divPnl";
            this.divPnl.Size = new System.Drawing.Size(63, 15);
            this.divPnl.TabIndex = 11;
            // 
            // divLbl
            // 
            this.divLbl.AutoSize = true;
            this.divLbl.Location = new System.Drawing.Point(60, 0);
            this.divLbl.Name = "divLbl";
            this.divLbl.Size = new System.Drawing.Size(0, 15);
            this.divLbl.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Division:";
            // 
            // teamNamePnl
            // 
            this.teamNamePnl.AutoSize = true;
            this.teamNamePnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teamNamePnl.Controls.Add(this.teamNameLbl);
            this.teamNamePnl.Controls.Add(this.label8);
            this.teamNamePnl.Location = new System.Drawing.Point(8, 29);
            this.teamNamePnl.Name = "teamNamePnl";
            this.teamNamePnl.Size = new System.Drawing.Size(83, 15);
            this.teamNamePnl.TabIndex = 12;
            // 
            // teamNameLbl
            // 
            this.teamNameLbl.AutoSize = true;
            this.teamNameLbl.Location = new System.Drawing.Point(80, 0);
            this.teamNameLbl.Name = "teamNameLbl";
            this.teamNameLbl.Size = new System.Drawing.Size(0, 15);
            this.teamNameLbl.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Team Name:";
            // 
            // gamesPnl
            // 
            this.gamesPnl.AutoSize = true;
            this.gamesPnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gamesPnl.Controls.Add(this.gamesLbl);
            this.gamesPnl.Controls.Add(this.label3);
            this.gamesPnl.Location = new System.Drawing.Point(97, 29);
            this.gamesPnl.Name = "gamesPnl";
            this.gamesPnl.Size = new System.Drawing.Size(53, 15);
            this.gamesPnl.TabIndex = 20;
            // 
            // gamesLbl
            // 
            this.gamesLbl.AutoSize = true;
            this.gamesLbl.Location = new System.Drawing.Point(50, 0);
            this.gamesLbl.Name = "gamesLbl";
            this.gamesLbl.Size = new System.Drawing.Size(0, 15);
            this.gamesLbl.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Games:";
            // 
            // statsPnl
            // 
            this.statsPnl.Controls.Add(this.tabControl1);
            this.statsPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPnl.Location = new System.Drawing.Point(0, 85);
            this.statsPnl.Name = "statsPnl";
            this.statsPnl.Size = new System.Drawing.Size(970, 459);
            this.statsPnl.TabIndex = 14;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fieldingTab);
            this.tabControl1.Controls.Add(this.desigHitterTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 459);
            this.tabControl1.TabIndex = 0;
            // 
            // fieldingTab
            // 
            this.fieldingTab.AutoScroll = true;
            this.fieldingTab.Controls.Add(this.fieldingWrap);
            this.fieldingTab.Location = new System.Drawing.Point(4, 24);
            this.fieldingTab.Name = "fieldingTab";
            this.fieldingTab.Padding = new System.Windows.Forms.Padding(3);
            this.fieldingTab.Size = new System.Drawing.Size(962, 431);
            this.fieldingTab.TabIndex = 1;
            this.fieldingTab.Text = "Defense Positions";
            this.fieldingTab.UseVisualStyleBackColor = true;
            // 
            // fieldingWrap
            // 
            this.fieldingWrap.Controls.Add(this.fieldingGrid);
            this.fieldingWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldingWrap.Location = new System.Drawing.Point(3, 3);
            this.fieldingWrap.Name = "fieldingWrap";
            this.fieldingWrap.Padding = new System.Windows.Forms.Padding(5);
            this.fieldingWrap.Size = new System.Drawing.Size(956, 425);
            this.fieldingWrap.TabIndex = 8;
            // 
            // desigHitterTab
            // 
            this.desigHitterTab.AutoScroll = true;
            this.desigHitterTab.Controls.Add(this.desigHitterWrap);
            this.desigHitterTab.Location = new System.Drawing.Point(4, 24);
            this.desigHitterTab.Name = "desigHitterTab";
            this.desigHitterTab.Padding = new System.Windows.Forms.Padding(3);
            this.desigHitterTab.Size = new System.Drawing.Size(962, 431);
            this.desigHitterTab.TabIndex = 0;
            this.desigHitterTab.Text = "Designated Hitters";
            this.desigHitterTab.UseVisualStyleBackColor = true;
            // 
            // desigHitterWrap
            // 
            this.desigHitterWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desigHitterWrap.Location = new System.Drawing.Point(3, 3);
            this.desigHitterWrap.Name = "desigHitterWrap";
            this.desigHitterWrap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // desigHitterWrap.Panel1
            // 
            this.desigHitterWrap.Panel1.Controls.Add(this.desigHitterGrid);
            this.desigHitterWrap.Panel1MinSize = 100;
            // 
            // desigHitterWrap.Panel2
            // 
            this.desigHitterWrap.Panel2.Controls.Add(this.detailsBtn);
            this.desigHitterWrap.Panel2.Controls.Add(this.desigDetailGrid);
            this.desigHitterWrap.Panel2MinSize = 100;
            this.desigHitterWrap.Size = new System.Drawing.Size(956, 425);
            this.desigHitterWrap.SplitterDistance = 318;
            this.desigHitterWrap.TabIndex = 7;
            // 
            // desigHitterGrid
            // 
            this.desigHitterGrid.AllowUserToAddRows = false;
            this.desigHitterGrid.AllowUserToDeleteRows = false;
            this.desigHitterGrid.AllowUserToResizeRows = false;
            this.desigHitterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.desigHitterGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.desigHitterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desigHitterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desigHitterGrid.Location = new System.Drawing.Point(0, 0);
            this.desigHitterGrid.Margin = new System.Windows.Forms.Padding(5);
            this.desigHitterGrid.MinimumSize = new System.Drawing.Size(600, 250);
            this.desigHitterGrid.Name = "desigHitterGrid";
            this.desigHitterGrid.ReadOnly = true;
            this.desigHitterGrid.RowTemplate.Height = 25;
            this.desigHitterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.desigHitterGrid.ShowCellToolTips = false;
            this.desigHitterGrid.Size = new System.Drawing.Size(956, 318);
            this.desigHitterGrid.TabIndex = 5;
            this.desigHitterGrid.SelectionChanged += new System.EventHandler(this.desigHitterGrid_SelectionChanged);
            this.desigHitterGrid.DoubleClick += new System.EventHandler(this.details_Click);
            this.desigHitterGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.desigHitterGrid_KeyDown);
            // 
            // detailsBtn
            // 
            this.detailsBtn.Enabled = false;
            this.detailsBtn.Location = new System.Drawing.Point(3, 10);
            this.detailsBtn.Margin = new System.Windows.Forms.Padding(10);
            this.detailsBtn.Name = "detailsBtn";
            this.detailsBtn.Size = new System.Drawing.Size(115, 40);
            this.detailsBtn.TabIndex = 7;
            this.detailsBtn.Text = "Show &Details";
            this.detailsBtn.UseVisualStyleBackColor = true;
            this.detailsBtn.Click += new System.EventHandler(this.details_Click);
            // 
            // desigDetailGrid
            // 
            this.desigDetailGrid.AllowUserToAddRows = false;
            this.desigDetailGrid.AllowUserToDeleteRows = false;
            this.desigDetailGrid.AllowUserToResizeRows = false;
            this.desigDetailGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desigDetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.desigDetailGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.desigDetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.desigDetailGrid.Location = new System.Drawing.Point(120, 0);
            this.desigDetailGrid.Margin = new System.Windows.Forms.Padding(5);
            this.desigDetailGrid.MinimumSize = new System.Drawing.Size(600, 100);
            this.desigDetailGrid.Name = "desigDetailGrid";
            this.desigDetailGrid.ReadOnly = true;
            this.desigDetailGrid.RowTemplate.Height = 25;
            this.desigDetailGrid.ShowCellToolTips = false;
            this.desigDetailGrid.Size = new System.Drawing.Size(835, 100);
            this.desigDetailGrid.TabIndex = 6;
            // 
            // SeasonRosters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statsPnl);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.bioPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "SeasonRosters";
            this.Size = new System.Drawing.Size(970, 600);
            this.controlPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldingGrid)).EndInit();
            this.bioPnl.ResumeLayout(false);
            this.bioPnl.PerformLayout();
            this.teamIdPnl.ResumeLayout(false);
            this.teamIdPnl.PerformLayout();
            this.yearPnl.ResumeLayout(false);
            this.yearPnl.PerformLayout();
            this.lgPnl.ResumeLayout(false);
            this.lgPnl.PerformLayout();
            this.divPnl.ResumeLayout(false);
            this.divPnl.PerformLayout();
            this.teamNamePnl.ResumeLayout(false);
            this.teamNamePnl.PerformLayout();
            this.gamesPnl.ResumeLayout(false);
            this.gamesPnl.PerformLayout();
            this.statsPnl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.fieldingTab.ResumeLayout(false);
            this.fieldingWrap.ResumeLayout(false);
            this.desigHitterTab.ResumeLayout(false);
            this.desigHitterWrap.Panel1.ResumeLayout(false);
            this.desigHitterWrap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.desigHitterWrap)).EndInit();
            this.desigHitterWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.desigHitterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desigDetailGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLbl;
        private Panel controlPnl;
        private Button closeBtn;
        private Button searchBtn;
        private DataGridView fieldingGrid;
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
    }
}
