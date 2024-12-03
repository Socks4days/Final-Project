namespace Final_Project
{
    partial class frmStockManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlLookupStock = new Panel();
            lblErrorStockLookup = new Label();
            btnSearch = new Button();
            lblEnterStockId = new Label();
            txtBoxEnterStockName = new TextBox();
            lblTitle = new Label();
            pnlLookupStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLookupStock
            // 
            pnlLookupStock.BackColor = Color.DarkCyan;
            pnlLookupStock.Controls.Add(lblErrorStockLookup);
            pnlLookupStock.Controls.Add(btnSearch);
            pnlLookupStock.Controls.Add(lblEnterStockId);
            pnlLookupStock.Controls.Add(txtBoxEnterStockName);
            pnlLookupStock.Controls.Add(lblTitle);
            pnlLookupStock.Dock = DockStyle.Top;
            pnlLookupStock.Location = new Point(0, 0);
            pnlLookupStock.Name = "pnlLookupStock";
            pnlLookupStock.Size = new Size(800, 520);
            pnlLookupStock.TabIndex = 1;
            // 
            // lblErrorStockLookup
            // 
            lblErrorStockLookup.Anchor = AnchorStyles.None;
            lblErrorStockLookup.Font = new Font("Segoe UI", 16F);
            lblErrorStockLookup.ForeColor = Color.Coral;
            lblErrorStockLookup.Location = new Point(68, 328);
            lblErrorStockLookup.Name = "lblErrorStockLookup";
            lblErrorStockLookup.Size = new Size(664, 119);
            lblErrorStockLookup.TabIndex = 9;
            lblErrorStockLookup.Text = "Error message goes here";
            lblErrorStockLookup.TextAlign = ContentAlignment.TopCenter;
            lblErrorStockLookup.Visible = false;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.None;
            btnSearch.Font = new Font("Segoe UI", 12F);
            btnSearch.Location = new Point(290, 262);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(220, 50);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search  🔎";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblEnterStockId
            // 
            lblEnterStockId.Anchor = AnchorStyles.None;
            lblEnterStockId.AutoSize = true;
            lblEnterStockId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterStockId.ForeColor = SystemColors.Control;
            lblEnterStockId.Location = new Point(290, 162);
            lblEnterStockId.Name = "lblEnterStockId";
            lblEnterStockId.Size = new Size(225, 21);
            lblEnterStockId.TabIndex = 2;
            lblEnterStockId.Text = "Enter a stock id to view options";
            // 
            // txtBoxEnterStockName
            // 
            txtBoxEnterStockName.Anchor = AnchorStyles.None;
            txtBoxEnterStockName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEnterStockName.Location = new Point(258, 208);
            txtBoxEnterStockName.Name = "txtBoxEnterStockName";
            txtBoxEnterStockName.PlaceholderText = "Enter Stock Name:";
            txtBoxEnterStockName.Size = new Size(285, 32);
            txtBoxEnterStockName.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(290, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Management";
            // 
            // frmStockManagement
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 521);
            Controls.Add(pnlLookupStock);
            Name = "frmStockManagement";
            Text = "Stock Management";
            pnlLookupStock.ResumeLayout(false);
            pnlLookupStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLookupStock;
        private Label lblTitle;
        private Button btnSearch;
        private Label lblEnterStockId;
        private TextBox txtBoxEnterStockName;
        private Label lblErrorStockLookup;
    }
}
