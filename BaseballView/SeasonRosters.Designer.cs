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
            this.yearId = new System.Windows.Forms.Label();
            this.teamId = new System.Windows.Forms.Label();
            this.lgId = new System.Windows.Forms.Label();
            this.controlPnl.SuspendLayout();
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
            // yearId
            // 
            this.yearId.AutoSize = true;
            this.yearId.Location = new System.Drawing.Point(73, 140);
            this.yearId.Name = "yearId";
            this.yearId.Padding = new System.Windows.Forms.Padding(3);
            this.yearId.Size = new System.Drawing.Size(44, 21);
            this.yearId.TabIndex = 4;
            this.yearId.Text = "label1";
            // 
            // teamId
            // 
            this.teamId.AutoSize = true;
            this.teamId.Location = new System.Drawing.Point(73, 161);
            this.teamId.Name = "teamId";
            this.teamId.Padding = new System.Windows.Forms.Padding(3);
            this.teamId.Size = new System.Drawing.Size(44, 21);
            this.teamId.TabIndex = 10;
            this.teamId.Text = "label2";
            // 
            // lgId
            // 
            this.lgId.AutoSize = true;
            this.lgId.Location = new System.Drawing.Point(73, 182);
            this.lgId.Name = "lgId";
            this.lgId.Padding = new System.Windows.Forms.Padding(3);
            this.lgId.Size = new System.Drawing.Size(44, 21);
            this.lgId.TabIndex = 11;
            this.lgId.Text = "label3";
            // 
            // SeasonRosters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lgId);
            this.Controls.Add(this.teamId);
            this.Controls.Add(this.yearId);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "SeasonRosters";
            this.Size = new System.Drawing.Size(970, 600);
            this.controlPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLbl;
        private Panel controlPnl;
        private Button closeBtn;
        private Button searchBtn;
        private Label yearId;
        private Label teamId;
        private Label lgId;
    }
}
