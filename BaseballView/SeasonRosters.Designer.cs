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
            this.yearIdLbl = new System.Windows.Forms.Label();
            this.teamIdLbl = new System.Windows.Forms.Label();
            this.lgIdLbl = new System.Windows.Forms.Label();
            this.pitchingGrid = new System.Windows.Forms.DataGridView();
            this.controlPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pitchingGrid)).BeginInit();
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
            // yearIdLbl
            // 
            this.yearIdLbl.AutoSize = true;
            this.yearIdLbl.Location = new System.Drawing.Point(44, 53);
            this.yearIdLbl.Name = "yearIdLbl";
            this.yearIdLbl.Padding = new System.Windows.Forms.Padding(3);
            this.yearIdLbl.Size = new System.Drawing.Size(44, 21);
            this.yearIdLbl.TabIndex = 4;
            this.yearIdLbl.Text = "label1";
            // 
            // teamIdLbl
            // 
            this.teamIdLbl.AutoSize = true;
            this.teamIdLbl.Location = new System.Drawing.Point(44, 74);
            this.teamIdLbl.Name = "teamIdLbl";
            this.teamIdLbl.Padding = new System.Windows.Forms.Padding(3);
            this.teamIdLbl.Size = new System.Drawing.Size(44, 21);
            this.teamIdLbl.TabIndex = 10;
            this.teamIdLbl.Text = "label2";
            // 
            // lgIdLbl
            // 
            this.lgIdLbl.AutoSize = true;
            this.lgIdLbl.Location = new System.Drawing.Point(44, 95);
            this.lgIdLbl.Name = "lgIdLbl";
            this.lgIdLbl.Padding = new System.Windows.Forms.Padding(3);
            this.lgIdLbl.Size = new System.Drawing.Size(44, 21);
            this.lgIdLbl.TabIndex = 11;
            this.lgIdLbl.Text = "label3";
            // 
            // pitchingGrid
            // 
            this.pitchingGrid.AllowUserToAddRows = false;
            this.pitchingGrid.AllowUserToDeleteRows = false;
            this.pitchingGrid.AllowUserToResizeColumns = false;
            this.pitchingGrid.AllowUserToResizeRows = false;
            this.pitchingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.pitchingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pitchingGrid.Location = new System.Drawing.Point(3, 119);
            this.pitchingGrid.Name = "pitchingGrid";
            this.pitchingGrid.ReadOnly = true;
            this.pitchingGrid.RowTemplate.Height = 25;
            this.pitchingGrid.Size = new System.Drawing.Size(897, 268);
            this.pitchingGrid.TabIndex = 12;
            this.pitchingGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.pitchingGrid_DataBindingComplete);
            // 
            // SeasonRosters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pitchingGrid);
            this.Controls.Add(this.lgIdLbl);
            this.Controls.Add(this.teamIdLbl);
            this.Controls.Add(this.yearIdLbl);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "SeasonRosters";
            this.Size = new System.Drawing.Size(970, 600);
            this.controlPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pitchingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLbl;
        private Panel controlPnl;
        private Button closeBtn;
        private Button searchBtn;
        private Label yearIdLbl;
        private Label teamIdLbl;
        private Label lgIdLbl;
        private DataGridView pitchingGrid;
    }
}
