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
            this.gridWrap.Location = new System.Drawing.Point(0, 106);
            this.gridWrap.Name = "gridWrap";
            this.gridWrap.Padding = new System.Windows.Forms.Padding(10);
            this.gridWrap.Size = new System.Drawing.Size(800, 264);
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
            this.resultsGrid.Size = new System.Drawing.Size(780, 244);
            this.resultsGrid.TabIndex = 4;
            this.resultsGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.resultsGrid_DataBindingComplete);
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
            this.btnsWrap.Controls.Add(this.removeBtn);
            this.btnsWrap.Controls.Add(this.addBtn);
            this.btnsWrap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsWrap.Location = new System.Drawing.Point(0, 21);
            this.btnsWrap.Margin = new System.Windows.Forms.Padding(5);
            this.btnsWrap.Name = "btnsWrap";
            this.btnsWrap.Padding = new System.Windows.Forms.Padding(10);
            this.btnsWrap.Size = new System.Drawing.Size(800, 85);
            this.btnsWrap.TabIndex = 14;
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
            this.gridWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.controlPnl.ResumeLayout(false);
            this.btnsWrap.ResumeLayout(false);
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
    }
}