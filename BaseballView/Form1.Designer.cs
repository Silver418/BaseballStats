namespace BaseballView {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.topBarPnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navWrap = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.reportsHeader = new System.Windows.Forms.ToolStripLabel();
            this.navPlayerStats = new System.Windows.Forms.ToolStripLabel();
            this.navTeamYearStats = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.navHeader = new System.Windows.Forms.ToolStripLabel();
            this.navSeasonDates = new System.Windows.Forms.ToolStripLabel();
            this.navStintEdit = new System.Windows.Forms.ToolStripLabel();
            this.contentTabs = new System.Windows.Forms.TabControl();
            this.topBarPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.navWrap.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBarPnl
            // 
            this.topBarPnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarPnl.Controls.Add(this.label1);
            this.topBarPnl.Location = new System.Drawing.Point(12, 12);
            this.topBarPnl.Name = "topBarPnl";
            this.topBarPnl.Size = new System.Drawing.Size(1085, 50);
            this.topBarPnl.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baseball Statistics Browser";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 68);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.navWrap);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.contentTabs);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Size = new System.Drawing.Size(1085, 611);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 1;
            // 
            // navWrap
            // 
            this.navWrap.Controls.Add(this.toolStrip1);
            this.navWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navWrap.Location = new System.Drawing.Point(0, 0);
            this.navWrap.Name = "navWrap";
            this.navWrap.Padding = new System.Windows.Forms.Padding(5);
            this.navWrap.Size = new System.Drawing.Size(171, 607);
            this.navWrap.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsHeader,
            this.navPlayerStats,
            this.navTeamYearStats,
            this.toolStripSeparator1,
            this.navHeader,
            this.navSeasonDates,
            this.navStintEdit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(5, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.toolStrip1.Size = new System.Drawing.Size(161, 597);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // reportsHeader
            // 
            this.reportsHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportsHeader.Name = "reportsHeader";
            this.reportsHeader.Size = new System.Drawing.Size(140, 20);
            this.reportsHeader.Text = "Statistic Reports";
            this.reportsHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navPlayerStats
            // 
            this.navPlayerStats.IsLink = true;
            this.navPlayerStats.Name = "navPlayerStats";
            this.navPlayerStats.Size = new System.Drawing.Size(140, 15);
            this.navPlayerStats.Text = "Player Statistics";
            this.navPlayerStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navPlayerStats.VisitedLinkColor = System.Drawing.Color.Blue;
            this.navPlayerStats.Click += new System.EventHandler(this.navPlayerStats_Click);
            // 
            // navTeamYearStats
            // 
            this.navTeamYearStats.IsLink = true;
            this.navTeamYearStats.Name = "navTeamYearStats";
            this.navTeamYearStats.Size = new System.Drawing.Size(140, 15);
            this.navTeamYearStats.Text = "Team Statistics by Year";
            this.navTeamYearStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navTeamYearStats.VisitedLinkColor = System.Drawing.Color.Blue;
            this.navTeamYearStats.Click += new System.EventHandler(this.navTeamYearStats_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // navHeader
            // 
            this.navHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.navHeader.Name = "navHeader";
            this.navHeader.Size = new System.Drawing.Size(140, 20);
            this.navHeader.Text = "Season Rosters";
            this.navHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navSeasonDates
            // 
            this.navSeasonDates.IsLink = true;
            this.navSeasonDates.Name = "navSeasonDates";
            this.navSeasonDates.Size = new System.Drawing.Size(140, 15);
            this.navSeasonDates.Text = "Season Dates";
            this.navSeasonDates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navSeasonDates.VisitedLinkColor = System.Drawing.Color.Blue;
            this.navSeasonDates.Click += new System.EventHandler(this.navSeasonDates_Click);
            // 
            // navStintEdit
            // 
            this.navStintEdit.IsLink = true;
            this.navStintEdit.Name = "navStintEdit";
            this.navStintEdit.Size = new System.Drawing.Size(140, 15);
            this.navStintEdit.Text = "Edit Season Stints";
            this.navStintEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.navStintEdit.VisitedLinkColor = System.Drawing.Color.Blue;
            this.navStintEdit.Click += new System.EventHandler(this.navStintEdit_Click);
            // 
            // contentTabs
            // 
            this.contentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTabs.Location = new System.Drawing.Point(0, 0);
            this.contentTabs.Name = "contentTabs";
            this.contentTabs.SelectedIndex = 0;
            this.contentTabs.Size = new System.Drawing.Size(902, 607);
            this.contentTabs.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 691);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.topBarPnl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baseball Stats Browser";
            this.topBarPnl.ResumeLayout(false);
            this.topBarPnl.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.navWrap.ResumeLayout(false);
            this.navWrap.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topBarPnl;
        private SplitContainer splitContainer1;
        private Label label1;
        private Panel navWrap;
        private ToolStrip toolStrip1;
        private ToolStripLabel reportsHeader;
        private ToolStripLabel navPlayerStats;
        private TabControl contentTabs;
        private ToolStripLabel navTeamYearStats;
        private ToolStripLabel navSeasonDates;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel navHeader;
        private ToolStripLabel navStintEdit;
    }
}