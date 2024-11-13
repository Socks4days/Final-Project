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
            pnlAddStock = new Panel();
            txtBoxAddStock = new TextBox();
            lblAddStock = new Label();
            btnBack = new Button();
            btnAddStock = new Button();
            pnlManageStock = new Panel();
            btnSearch = new Button();
            lblEnterStockId = new Label();
            txtBoxEnterStockId = new TextBox();
            lblTitle = new Label();
            pnlAddNewStock = new Panel();
            txtBoxNewStockName = new TextBox();
            txtBoxNewMinimumLevel = new TextBox();
            txtBoxNewStockPrice = new TextBox();
            txtBoxNewMaximumLevel = new TextBox();
            txtBoxNewStockDescription = new TextBox();
            lblAddNewStock = new Label();
            btnAddNewStock = new Button();
            panel1 = new Panel();
            pnlAddStock.SuspendLayout();
            pnlManageStock.SuspendLayout();
            pnlAddNewStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddStock
            // 
            pnlAddStock.BackColor = Color.SteelBlue;
            pnlAddStock.Controls.Add(txtBoxAddStock);
            pnlAddStock.Controls.Add(lblAddStock);
            pnlAddStock.Controls.Add(btnBack);
            pnlAddStock.Controls.Add(btnAddStock);
            pnlAddStock.Dock = DockStyle.Top;
            pnlAddStock.Location = new Point(0, 0);
            pnlAddStock.Name = "pnlAddStock";
            pnlAddStock.Size = new Size(779, 450);
            pnlAddStock.TabIndex = 0;
            // 
            // txtBoxAddStock
            // 
            txtBoxAddStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAddStock.Location = new Point(291, 203);
            txtBoxAddStock.Name = "txtBoxAddStock";
            txtBoxAddStock.Size = new Size(216, 38);
            txtBoxAddStock.TabIndex = 3;
            // 
            // lblAddStock
            // 
            lblAddStock.AutoSize = true;
            lblAddStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddStock.ForeColor = SystemColors.Control;
            lblAddStock.Location = new Point(324, 128);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(153, 41);
            lblAddStock.TabIndex = 2;
            lblAddStock.Text = "Add Stock";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(330, 276);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(147, 36);
            btnAddStock.TabIndex = 0;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // pnlManageStock
            // 
            pnlManageStock.BackColor = Color.DarkCyan;
            pnlManageStock.Controls.Add(btnSearch);
            pnlManageStock.Controls.Add(lblEnterStockId);
            pnlManageStock.Controls.Add(txtBoxEnterStockId);
            pnlManageStock.Controls.Add(lblTitle);
            pnlManageStock.Dock = DockStyle.Top;
            pnlManageStock.Location = new Point(0, 450);
            pnlManageStock.Name = "pnlManageStock";
            pnlManageStock.Size = new Size(779, 450);
            pnlManageStock.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(317, 302);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 42);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search  🔎";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblEnterStockId
            // 
            lblEnterStockId.AutoSize = true;
            lblEnterStockId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterStockId.ForeColor = SystemColors.Control;
            lblEnterStockId.Location = new Point(247, 188);
            lblEnterStockId.Name = "lblEnterStockId";
            lblEnterStockId.Size = new Size(285, 28);
            lblEnterStockId.TabIndex = 2;
            lblEnterStockId.Text = "Enter a stock id to view options";
            // 
            // txtBoxEnterStockId
            // 
            txtBoxEnterStockId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEnterStockId.Location = new Point(247, 241);
            txtBoxEnterStockId.Name = "txtBoxEnterStockId";
            txtBoxEnterStockId.PlaceholderText = "Enter Stock Id:";
            txtBoxEnterStockId.Size = new Size(285, 38);
            txtBoxEnterStockId.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(250, 106);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(275, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Stock Management";
            // 
            // pnlAddNewStock
            // 
            pnlAddNewStock.BackColor = Color.SteelBlue;
            pnlAddNewStock.Controls.Add(txtBoxNewStockName);
            pnlAddNewStock.Controls.Add(txtBoxNewMinimumLevel);
            pnlAddNewStock.Controls.Add(txtBoxNewStockPrice);
            pnlAddNewStock.Controls.Add(txtBoxNewMaximumLevel);
            pnlAddNewStock.Controls.Add(txtBoxNewStockDescription);
            pnlAddNewStock.Controls.Add(lblAddNewStock);
            pnlAddNewStock.Controls.Add(btnAddNewStock);
            pnlAddNewStock.Dock = DockStyle.Top;
            pnlAddNewStock.Location = new Point(0, 900);
            pnlAddNewStock.Name = "pnlAddNewStock";
            pnlAddNewStock.Size = new Size(779, 450);
            pnlAddNewStock.TabIndex = 2;
            // 
            // txtBoxNewStockName
            // 
            txtBoxNewStockName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockName.Location = new Point(276, 112);
            txtBoxNewStockName.Name = "txtBoxNewStockName";
            txtBoxNewStockName.PlaceholderText = "Stock Name";
            txtBoxNewStockName.Size = new Size(221, 39);
            txtBoxNewStockName.TabIndex = 12;
            // 
            // txtBoxNewMinimumLevel
            // 
            txtBoxNewMinimumLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewMinimumLevel.Location = new Point(410, 224);
            txtBoxNewMinimumLevel.Name = "txtBoxNewMinimumLevel";
            txtBoxNewMinimumLevel.PlaceholderText = "Minimum Level";
            txtBoxNewMinimumLevel.Size = new Size(221, 39);
            txtBoxNewMinimumLevel.TabIndex = 6;
            // 
            // txtBoxNewStockPrice
            // 
            txtBoxNewStockPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockPrice.Location = new Point(410, 168);
            txtBoxNewStockPrice.Name = "txtBoxNewStockPrice";
            txtBoxNewStockPrice.PlaceholderText = "Price";
            txtBoxNewStockPrice.Size = new Size(221, 39);
            txtBoxNewStockPrice.TabIndex = 5;
            // 
            // txtBoxNewMaximumLevel
            // 
            txtBoxNewMaximumLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewMaximumLevel.Location = new Point(152, 224);
            txtBoxNewMaximumLevel.Name = "txtBoxNewMaximumLevel";
            txtBoxNewMaximumLevel.PlaceholderText = "Maximum Level";
            txtBoxNewMaximumLevel.Size = new Size(221, 39);
            txtBoxNewMaximumLevel.TabIndex = 4;
            // 
            // txtBoxNewStockDescription
            // 
            txtBoxNewStockDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockDescription.Location = new Point(152, 168);
            txtBoxNewStockDescription.Name = "txtBoxNewStockDescription";
            txtBoxNewStockDescription.PlaceholderText = "Stock Description";
            txtBoxNewStockDescription.Size = new Size(221, 39);
            txtBoxNewStockDescription.TabIndex = 2;
            // 
            // lblAddNewStock
            // 
            lblAddNewStock.AutoSize = true;
            lblAddNewStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddNewStock.ForeColor = SystemColors.Control;
            lblAddNewStock.Location = new Point(302, 32);
            lblAddNewStock.Name = "lblAddNewStock";
            lblAddNewStock.Size = new Size(221, 41);
            lblAddNewStock.TabIndex = 1;
            lblAddNewStock.Text = "Add New Stock";
            // 
            // btnAddNewStock
            // 
            btnAddNewStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewStock.Location = new Point(279, 321);
            btnAddNewStock.Name = "btnAddNewStock";
            btnAddNewStock.Size = new Size(220, 50);
            btnAddNewStock.TabIndex = 0;
            btnAddNewStock.Text = "Add New Stock";
            btnAddNewStock.UseVisualStyleBackColor = true;
            btnAddNewStock.Click += btnAddNewStock_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 1350);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 439);
            panel1.TabIndex = 3;
            // 
            // frmStockManagement
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 455);
            Controls.Add(panel1);
            Controls.Add(pnlAddNewStock);
            Controls.Add(pnlManageStock);
            Controls.Add(pnlAddStock);
            Name = "frmStockManagement";
            Text = "Stock Management";
            pnlAddStock.ResumeLayout(false);
            pnlAddStock.PerformLayout();
            pnlManageStock.ResumeLayout(false);
            pnlManageStock.PerformLayout();
            pnlAddNewStock.ResumeLayout(false);
            pnlAddNewStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAddStock;
        private TextBox txtBoxAddStock;
        private Label lblAddStock;
        private Button btnBack;
        private Button btnAddStock;
        private Panel pnlManageStock;
        private Label lblTitle;
        private Button btnSearch;
        private Label lblEnterStockId;
        private TextBox txtBoxEnterStockId;
        private Panel pnlAddNewStock;
        private TextBox txtBoxNewStockDescription;
        private Label lblAddNewStock;
        private Button btnAddNewStock;
        private TextBox txtBoxNewMinimumLevel;
        private TextBox txtBoxNewStockPrice;
        private TextBox txtBoxNewMaximumLevel;
        private TextBox txtBoxNewStockName;
        private Panel panel1;
    }
}
