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
            this.controlPnl.Location = new System.Drawing.Point(0, 544);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(970, 56);
            this.controlPnl.TabIndex = 8;
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
            // StintEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.headerLbl);
            this.Name = "StintEdit";
            this.Size = new System.Drawing.Size(970, 600);
            this.controlPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLbl;
        private Panel controlPnl;
        private Button closeBtn;
    }
}
