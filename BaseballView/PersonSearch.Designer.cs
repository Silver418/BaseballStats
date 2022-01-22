namespace BaseballView {
    partial class PersonSearch {
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.nameFirstInput = new System.Windows.Forms.TextBox();
            this.nameLastInput = new System.Windows.Forms.TextBox();
            this.nameSearchBtn = new System.Windows.Forms.Button();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.selectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlPnl = new System.Windows.Forms.Panel();
            this.gridWrap = new System.Windows.Forms.Panel();
            this.resultCountLbl = new System.Windows.Forms.Label();
            this.searchInputPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.controlPnl.SuspendLayout();
            this.gridWrap.SuspendLayout();
            this.searchInputPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Search";
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
            this.CancelBtn.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // nameFirstInput
            // 
            this.nameFirstInput.Location = new System.Drawing.Point(81, 2);
            this.nameFirstInput.Name = "nameFirstInput";
            this.nameFirstInput.Size = new System.Drawing.Size(100, 23);
            this.nameFirstInput.TabIndex = 1;
            this.nameFirstInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyDown);
            // 
            // nameLastInput
            // 
            this.nameLastInput.Location = new System.Drawing.Point(270, 2);
            this.nameLastInput.Name = "nameLastInput";
            this.nameLastInput.Size = new System.Drawing.Size(100, 23);
            this.nameLastInput.TabIndex = 2;
            this.nameLastInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchInput_KeyDown);
            // 
            // nameSearchBtn
            // 
            this.nameSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nameSearchBtn.Location = new System.Drawing.Point(761, 8);
            this.nameSearchBtn.Name = "nameSearchBtn";
            this.nameSearchBtn.Size = new System.Drawing.Size(115, 40);
            this.nameSearchBtn.TabIndex = 3;
            this.nameSearchBtn.Text = "Sea&rch";
            this.nameSearchBtn.UseVisualStyleBackColor = true;
            this.nameSearchBtn.Click += new System.EventHandler(this.nameSearchBtn_Click);
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
            this.resultsGrid.Size = new System.Drawing.Size(864, 295);
            this.resultsGrid.TabIndex = 4;
            this.resultsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.resultsGrid_CellMouseDoubleClick);
            this.resultsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resultsGrid_KeyDown);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name:";
            // 
            // controlPnl
            // 
            this.controlPnl.Controls.Add(this.selectBtn);
            this.controlPnl.Controls.Add(this.CancelBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(0, 411);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(884, 80);
            this.controlPnl.TabIndex = 9;
            // 
            // gridWrap
            // 
            this.gridWrap.Controls.Add(this.resultsGrid);
            this.gridWrap.Controls.Add(this.resultCountLbl);
            this.gridWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWrap.Location = new System.Drawing.Point(0, 81);
            this.gridWrap.Name = "gridWrap";
            this.gridWrap.Padding = new System.Windows.Forms.Padding(10);
            this.gridWrap.Size = new System.Drawing.Size(884, 330);
            this.gridWrap.TabIndex = 10;
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
            // searchInputPnl
            // 
            this.searchInputPnl.Controls.Add(this.label2);
            this.searchInputPnl.Controls.Add(this.nameFirstInput);
            this.searchInputPnl.Controls.Add(this.label3);
            this.searchInputPnl.Controls.Add(this.nameLastInput);
            this.searchInputPnl.Controls.Add(this.nameSearchBtn);
            this.searchInputPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchInputPnl.Location = new System.Drawing.Point(0, 21);
            this.searchInputPnl.Name = "searchInputPnl";
            this.searchInputPnl.Padding = new System.Windows.Forms.Padding(5);
            this.searchInputPnl.Size = new System.Drawing.Size(884, 60);
            this.searchInputPnl.TabIndex = 8;
            // 
            // PersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.gridWrap);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.searchInputPnl);
            this.Controls.Add(this.label1);
            this.Name = "PersonSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Person Search";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.controlPnl.ResumeLayout(false);
            this.gridWrap.ResumeLayout(false);
            this.gridWrap.PerformLayout();
            this.searchInputPnl.ResumeLayout(false);
            this.searchInputPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button CancelBtn;
        private TextBox nameFirstInput;
        private TextBox nameLastInput;
        private Button nameSearchBtn;
        private DataGridView resultsGrid;
        private Button selectBtn;
        private Label label2;
        private Label label3;
        private Panel controlPnl;
        private Panel gridWrap;
        private Panel searchInputPnl;
        private Label resultCountLbl;
    }
}