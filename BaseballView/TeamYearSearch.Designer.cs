namespace BaseballView {
    partial class TeamYearSearch {
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchInputPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.teamInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lgInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.yearInput = new System.Windows.Forms.NumericUpDown();
            this.searchBtn = new System.Windows.Forms.Button();
            this.gridWrap = new System.Windows.Forms.Panel();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.resultCountLbl = new System.Windows.Forms.Label();
            this.controlPnl = new System.Windows.Forms.Panel();
            this.selectBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.searchInputPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).BeginInit();
            this.gridWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.controlPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team Search by Year";
            // 
            // searchInputPnl
            // 
            this.searchInputPnl.Controls.Add(this.label2);
            this.searchInputPnl.Controls.Add(this.teamInput);
            this.searchInputPnl.Controls.Add(this.label3);
            this.searchInputPnl.Controls.Add(this.lgInput);
            this.searchInputPnl.Controls.Add(this.label4);
            this.searchInputPnl.Controls.Add(this.yearInput);
            this.searchInputPnl.Controls.Add(this.searchBtn);
            this.searchInputPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputPnl.Location = new System.Drawing.Point(0, 21);
            this.searchInputPnl.Name = "searchInputPnl";
            this.searchInputPnl.Padding = new System.Windows.Forms.Padding(5);
            this.searchInputPnl.Size = new System.Drawing.Size(884, 61);
            this.searchInputPnl.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Team Name:";
            // 
            // teamInput
            // 
            this.teamInput.Location = new System.Drawing.Point(87, 2);
            this.teamInput.Name = "teamInput";
            this.teamInput.Size = new System.Drawing.Size(151, 23);
            this.teamInput.TabIndex = 0;
            this.teamInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "League Abbr.:";
            // 
            // lgInput
            // 
            this.lgInput.Location = new System.Drawing.Point(330, 2);
            this.lgInput.Name = "lgInput";
            this.lgInput.Size = new System.Drawing.Size(48, 23);
            this.lgInput.TabIndex = 1;
            this.lgInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Year:";
            // 
            // yearInput
            // 
            this.yearInput.Location = new System.Drawing.Point(87, 30);
            this.yearInput.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.yearInput.Name = "yearInput";
            this.yearInput.Size = new System.Drawing.Size(67, 23);
            this.yearInput.TabIndex = 2;
            this.yearInput.Enter += new System.EventHandler(this.yearInput_Enter);
            this.yearInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyDown);
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBtn.Location = new System.Drawing.Point(757, 8);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(115, 40);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Sea&rch";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // gridWrap
            // 
            this.gridWrap.Controls.Add(this.resultsGrid);
            this.gridWrap.Controls.Add(this.resultCountLbl);
            this.gridWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWrap.Location = new System.Drawing.Point(0, 82);
            this.gridWrap.Name = "gridWrap";
            this.gridWrap.Padding = new System.Windows.Forms.Padding(10);
            this.gridWrap.Size = new System.Drawing.Size(884, 288);
            this.gridWrap.TabIndex = 11;
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGrid.Location = new System.Drawing.Point(10, 25);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.RowTemplate.Height = 25;
            this.resultsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultsGrid.Size = new System.Drawing.Size(864, 253);
            this.resultsGrid.TabIndex = 4;
            this.resultsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.resultsGrid_CellMouseDoubleClick);
            this.resultsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultsGrid_KeyDown);
            // 
            // resultCountLbl
            // 
            this.resultCountLbl.AutoSize = true;
            this.resultCountLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultCountLbl.Location = new System.Drawing.Point(10, 10);
            this.resultCountLbl.Name = "resultCountLbl";
            this.resultCountLbl.Size = new System.Drawing.Size(47, 15);
            this.resultCountLbl.TabIndex = 5;
            this.resultCountLbl.Text = "Results:";
            // 
            // controlPnl
            // 
            this.controlPnl.Controls.Add(this.selectBtn);
            this.controlPnl.Controls.Add(this.CancelBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(0, 370);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(884, 80);
            this.controlPnl.TabIndex = 10;
            // 
            // selectBtn
            // 
            this.selectBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.selectBtn.Location = new System.Drawing.Point(323, 16);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(5);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(115, 50);
            this.selectBtn.TabIndex = 5;
            this.selectBtn.Text = "&Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelBtn.Location = new System.Drawing.Point(448, 16);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(115, 50);
            this.CancelBtn.TabIndex = 6;
            this.CancelBtn.Text = "&Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TeamYearSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.gridWrap);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.searchInputPnl);
            this.Controls.Add(this.label1);
            this.Name = "TeamYearSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Team Search by Year";
            this.searchInputPnl.ResumeLayout(false);
            this.searchInputPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearInput)).EndInit();
            this.gridWrap.ResumeLayout(false);
            this.gridWrap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.controlPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel searchInputPnl;
        private Label label2;
        private TextBox teamInput;
        private Label label3;
        private TextBox lgInput;
        private Label label4;
        private Button searchBtn;
        private Panel gridWrap;
        private DataGridView resultsGrid;
        private Label resultCountLbl;
        private Panel controlPnl;
        private Button selectBtn;
        private Button CancelBtn;
        private NumericUpDown yearInput;
    }
}