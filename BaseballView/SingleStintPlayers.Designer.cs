namespace BaseballView {
    partial class SingleStintPlayers {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridWrap = new System.Windows.Forms.Panel();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.controlPnl = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsWrap = new System.Windows.Forms.Panel();
            this.clearFilterBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.filterTeamCmb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressLbl = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.gridWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.controlPnl.SuspendLayout();
            this.btnsWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridWrap
            // 
            this.gridWrap.Controls.Add(this.resultsGrid);
            this.gridWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWrap.Location = new System.Drawing.Point(0, 128);
            this.gridWrap.Name = "gridWrap";
            this.gridWrap.Padding = new System.Windows.Forms.Padding(10);
            this.gridWrap.Size = new System.Drawing.Size(800, 242);
            this.gridWrap.TabIndex = 12;
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.Location = new System.Drawing.Point(10, 10);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.RowTemplate.Height = 25;
            this.resultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsGrid.ShowCellToolTips = false;
            this.resultsGrid.Size = new System.Drawing.Size(780, 222);
            this.resultsGrid.TabIndex = 4;
            this.resultsGrid.SelectionChanged += new System.EventHandler(this.resultsGrid_SelectionChanged);
            // 
            // controlPnl
            // 
            this.controlPnl.Controls.Add(this.CloseBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(0, 370);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(800, 80);
            this.controlPnl.TabIndex = 11;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseBtn.Location = new System.Drawing.Point(343, 16);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(115, 50);
            this.CloseBtn.TabIndex = 6;
            this.CloseBtn.Text = "&Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Players with One Stint";
            // 
            // btnsWrap
            // 
            this.btnsWrap.Controls.Add(this.clearFilterBtn);
            this.btnsWrap.Controls.Add(this.filterBtn);
            this.btnsWrap.Controls.Add(this.filterTeamCmb);
            this.btnsWrap.Controls.Add(this.label6);
            this.btnsWrap.Controls.Add(this.label3);
            this.btnsWrap.Controls.Add(this.progressLbl);
            this.btnsWrap.Controls.Add(this.removeBtn);
            this.btnsWrap.Controls.Add(this.addBtn);
            this.btnsWrap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsWrap.Location = new System.Drawing.Point(0, 21);
            this.btnsWrap.Margin = new System.Windows.Forms.Padding(5);
            this.btnsWrap.Name = "btnsWrap";
            this.btnsWrap.Padding = new System.Windows.Forms.Padding(10);
            this.btnsWrap.Size = new System.Drawing.Size(800, 107);
            this.btnsWrap.TabIndex = 14;
            // 
            // clearFilterBtn
            // 
            this.clearFilterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearFilterBtn.Location = new System.Drawing.Point(563, 10);
            this.clearFilterBtn.Margin = new System.Windows.Forms.Padding(10);
            this.clearFilterBtn.Name = "clearFilterBtn";
            this.clearFilterBtn.Size = new System.Drawing.Size(115, 40);
            this.clearFilterBtn.TabIndex = 19;
            this.clearFilterBtn.Text = "Clear Filter";
            this.clearFilterBtn.UseVisualStyleBackColor = true;
            this.clearFilterBtn.Click += new System.EventHandler(this.clearFilterBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterBtn.Location = new System.Drawing.Point(563, 54);
            this.filterBtn.Margin = new System.Windows.Forms.Padding(10);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(115, 40);
            this.filterBtn.TabIndex = 18;
            this.filterBtn.Text = "Apply &Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // filterTeamCmb
            // 
            this.filterTeamCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTeamCmb.FormattingEnabled = true;
            this.filterTeamCmb.Location = new System.Drawing.Point(283, 56);
            this.filterTeamCmb.Name = "filterTeamCmb";
            this.filterTeamCmb.Size = new System.Drawing.Size(267, 23);
            this.filterTeamCmb.TabIndex = 17;
            this.filterTeamCmb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTeamCmb_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Players who played for team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(283, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Filters";
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.progressLbl.Location = new System.Drawing.Point(15, 80);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(0, 20);
            this.progressLbl.TabIndex = 9;
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(150, 15);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(125, 60);
            this.removeBtn.TabIndex = 7;
            this.removeBtn.Text = "&Remove Selected Players from Editing";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 15);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(125, 60);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "&Add Selected Players for Editing";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // SingleStintPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridWrap);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.btnsWrap);
            this.Controls.Add(this.label1);
            this.Name = "SingleStintPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SingleStintPlayers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SingleStintPlayers_FormClosing);
            this.Shown += new System.EventHandler(this.SingleStintPlayers_Shown);
            this.gridWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.controlPnl.ResumeLayout(false);
            this.btnsWrap.ResumeLayout(false);
            this.btnsWrap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel gridWrap;
        private DataGridView resultsGrid;
        private Panel controlPnl;
        private Button CloseBtn;
        private Label label1;
        private Panel btnsWrap;
        private Button removeBtn;
        private Button addBtn;
        private Label progressLbl;
        private Label label3;
        private Label label6;
        private ComboBox filterTeamCmb;
        private Button filterBtn;
        private Button clearFilterBtn;
    }
}