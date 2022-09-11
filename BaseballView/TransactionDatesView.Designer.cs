namespace BaseballView {
    partial class TransactionDatesView {
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
            this.transactionGrid = new System.Windows.Forms.DataGridView();
            this.controlPnl = new System.Windows.Forms.Panel();
            this.clipboardBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).BeginInit();
            this.controlPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridWrap
            // 
            this.gridWrap.Controls.Add(this.transactionGrid);
            this.gridWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWrap.Location = new System.Drawing.Point(0, 36);
            this.gridWrap.Name = "gridWrap";
            this.gridWrap.Padding = new System.Windows.Forms.Padding(10);
            this.gridWrap.Size = new System.Drawing.Size(800, 445);
            this.gridWrap.TabIndex = 13;
            // 
            // transactionGrid
            // 
            this.transactionGrid.AllowUserToAddRows = false;
            this.transactionGrid.AllowUserToDeleteRows = false;
            this.transactionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.transactionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transactionGrid.Location = new System.Drawing.Point(10, 10);
            this.transactionGrid.Name = "transactionGrid";
            this.transactionGrid.ReadOnly = true;
            this.transactionGrid.RowTemplate.Height = 25;
            this.transactionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionGrid.ShowCellToolTips = false;
            this.transactionGrid.Size = new System.Drawing.Size(780, 425);
            this.transactionGrid.TabIndex = 4;
            // 
            // controlPnl
            // 
            this.controlPnl.Controls.Add(this.clipboardBtn);
            this.controlPnl.Controls.Add(this.CloseBtn);
            this.controlPnl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlPnl.Location = new System.Drawing.Point(0, 481);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(800, 80);
            this.controlPnl.TabIndex = 14;
            // 
            // clipboardBtn
            // 
            this.clipboardBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clipboardBtn.Location = new System.Drawing.Point(247, 16);
            this.clipboardBtn.Margin = new System.Windows.Forms.Padding(5);
            this.clipboardBtn.Name = "clipboardBtn";
            this.clipboardBtn.Size = new System.Drawing.Size(115, 50);
            this.clipboardBtn.TabIndex = 7;
            this.clipboardBtn.Text = "Copy &Transactions to Clipboard";
            this.clipboardBtn.UseVisualStyleBackColor = true;
            this.clipboardBtn.Click += new System.EventHandler(this.clipboardBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseBtn.Location = new System.Drawing.Point(422, 15);
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
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Transactions for Season";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Only players with completed stint records are shown.";
            // 
            // TransactionDatesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.gridWrap);
            this.Controls.Add(this.controlPnl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionDatesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TransactionDatesView";
            this.gridWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transactionGrid)).EndInit();
            this.controlPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel gridWrap;
        private DataGridView transactionGrid;
        private Panel controlPnl;
        private Button CloseBtn;
        private Label label1;
        private Button clipboardBtn;
        private Label label2;
    }
}