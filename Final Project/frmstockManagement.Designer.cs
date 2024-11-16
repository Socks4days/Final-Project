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
            pnlAddOrDepleteFromStock = new Panel();
            lblErrorStockLevel = new Label();
            txtBoxAmountOfStockToChange = new TextBox();
            btnRemoveFromStock = new Button();
            label1 = new Label();
            btnAddToStock = new Button();
            pnlLookupStock.SuspendLayout();
            pnlAddNewStock.SuspendLayout();
            pnlAddOrDepleteFromStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLookupStock
            // 
            pnlLookupStock.BackColor = Color.DarkCyan;
            pnlLookupStock.Controls.Add(lblErrorStockLookup);
            pnlLookupStock.Controls.Add(btnSearch);
            pnlLookupStock.Controls.Add(lblEnterStockId);
            pnlLookupStock.Controls.Add(txtBoxEnterStockId);
            pnlLookupStock.Controls.Add(lblTitle);
            pnlLookupStock.Dock = DockStyle.Top;
            pnlLookupStock.Location = new Point(0, 0);
            pnlLookupStock.Name = "pnlLookupStock";
            pnlLookupStock.Size = new Size(783, 560);
            pnlLookupStock.TabIndex = 1;
            // 
            // lblErrorStockLookup
            // 
            lblErrorStockLookup.Anchor = AnchorStyles.None;
            lblErrorStockLookup.Font = new Font("Segoe UI", 16F);
            lblErrorStockLookup.ForeColor = Color.Coral;
            lblErrorStockLookup.Location = new Point(59, 416);
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
            btnSearch.Location = new Point(319, 357);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 42);
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
            lblEnterStockId.Location = new Point(279, 243);
            lblEnterStockId.Name = "lblEnterStockId";
            lblEnterStockId.Size = new Size(225, 21);
            lblEnterStockId.TabIndex = 2;
            lblEnterStockId.Text = "Enter a stock id to view options";
            // 
            // txtBoxEnterStockId
            // 
            txtBoxEnterStockId.Anchor = AnchorStyles.None;
            txtBoxEnterStockId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxEnterStockId.Location = new Point(249, 296);
            txtBoxEnterStockId.Name = "txtBoxEnterStockId";
            txtBoxEnterStockId.PlaceholderText = "Enter Stock Id:";
            txtBoxEnterStockId.Size = new Size(285, 32);
            txtBoxEnterStockId.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(282, 161);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(221, 32);
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
            pnlAddNewStock.Location = new Point(0, 560);
            pnlAddNewStock.Name = "pnlAddNewStock";
            pnlAddNewStock.Size = new Size(783, 560);
            pnlAddNewStock.TabIndex = 2;
            // 
            // txtBoxNewStockName
            // 
            txtBoxNewStockName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockName.Location = new Point(276, 112);
            txtBoxNewStockName.Name = "txtBoxNewStockName";
            txtBoxNewStockName.PlaceholderText = "Stock Name";
            txtBoxNewStockName.Size = new Size(221, 33);
            txtBoxNewStockName.TabIndex = 12;
            // 
            // txtBoxNewMinimumLevel
            // 
            txtBoxNewMinimumLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewMinimumLevel.Location = new Point(410, 224);
            txtBoxNewMinimumLevel.Name = "txtBoxNewMinimumLevel";
            txtBoxNewMinimumLevel.PlaceholderText = "Minimum Level";
            txtBoxNewMinimumLevel.Size = new Size(221, 33);
            txtBoxNewMinimumLevel.TabIndex = 6;
            // 
            // txtBoxNewStockPrice
            // 
            txtBoxNewStockPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockPrice.Location = new Point(410, 168);
            txtBoxNewStockPrice.Name = "txtBoxNewStockPrice";
            txtBoxNewStockPrice.PlaceholderText = "Price";
            txtBoxNewStockPrice.Size = new Size(221, 33);
            txtBoxNewStockPrice.TabIndex = 5;
            // 
            // txtBoxNewMaximumLevel
            // 
            txtBoxNewMaximumLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewMaximumLevel.Location = new Point(152, 224);
            txtBoxNewMaximumLevel.Name = "txtBoxNewMaximumLevel";
            txtBoxNewMaximumLevel.PlaceholderText = "Maximum Level";
            txtBoxNewMaximumLevel.Size = new Size(221, 33);
            txtBoxNewMaximumLevel.TabIndex = 4;
            // 
            // txtBoxNewStockDescription
            // 
            txtBoxNewStockDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockDescription.Location = new Point(152, 168);
            txtBoxNewStockDescription.Name = "txtBoxNewStockDescription";
            txtBoxNewStockDescription.PlaceholderText = "Stock Description";
            txtBoxNewStockDescription.Size = new Size(221, 33);
            txtBoxNewStockDescription.TabIndex = 2;
            // 
            // lblAddNewStock
            // 
            lblAddNewStock.AutoSize = true;
            lblAddNewStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddNewStock.ForeColor = SystemColors.Control;
            lblAddNewStock.Location = new Point(279, 32);
            lblAddNewStock.Name = "lblAddNewStock";
            lblAddNewStock.Size = new Size(176, 32);
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
            // pnlAddOrDepleteFromStock
            // 
            pnlAddOrDepleteFromStock.BackColor = Color.DarkCyan;
            pnlAddOrDepleteFromStock.Controls.Add(lblErrorStockLevel);
            pnlAddOrDepleteFromStock.Controls.Add(txtBoxAmountOfStockToChange);
            pnlAddOrDepleteFromStock.Controls.Add(btnRemoveFromStock);
            pnlAddOrDepleteFromStock.Controls.Add(label1);
            pnlAddOrDepleteFromStock.Controls.Add(btnAddToStock);
            pnlAddOrDepleteFromStock.Dock = DockStyle.Top;
            pnlAddOrDepleteFromStock.Location = new Point(0, 1120);
            pnlAddOrDepleteFromStock.Name = "pnlAddOrDepleteFromStock";
            pnlAddOrDepleteFromStock.Size = new Size(783, 560);
            pnlAddOrDepleteFromStock.TabIndex = 3;
            // 
            // lblErrorStockLevel
            // 
            lblErrorStockLevel.Anchor = AnchorStyles.None;
            lblErrorStockLevel.Font = new Font("Segoe UI", 16F);
            lblErrorStockLevel.ForeColor = Color.Coral;
            lblErrorStockLevel.Location = new Point(59, 253);
            lblErrorStockLevel.Name = "lblErrorStockLevel";
            lblErrorStockLevel.Size = new Size(664, 119);
            lblErrorStockLevel.TabIndex = 8;
            lblErrorStockLevel.Text = "Error message goes here";
            lblErrorStockLevel.TextAlign = ContentAlignment.TopCenter;
            lblErrorStockLevel.Visible = false;
            // 
            // txtBoxAmountOfStockToChange
            // 
            txtBoxAmountOfStockToChange.Anchor = AnchorStyles.None;
            txtBoxAmountOfStockToChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAmountOfStockToChange.Location = new Point(281, 184);
            txtBoxAmountOfStockToChange.Name = "txtBoxAmountOfStockToChange";
            txtBoxAmountOfStockToChange.PlaceholderText = "Enter Amount:";
            txtBoxAmountOfStockToChange.Size = new Size(220, 32);
            txtBoxAmountOfStockToChange.TabIndex = 4;
            // 
            // btnRemoveFromStock
            // 
            btnRemoveFromStock.Anchor = AnchorStyles.None;
            btnRemoveFromStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveFromStock.Location = new Point(423, 375);
            btnRemoveFromStock.Name = "btnRemoveFromStock";
            btnRemoveFromStock.Size = new Size(220, 50);
            btnRemoveFromStock.TabIndex = 3;
            btnRemoveFromStock.Text = "Remove From Stock";
            btnRemoveFromStock.UseVisualStyleBackColor = true;
            btnRemoveFromStock.Click += btnRemoveFromStock_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(275, 107);
            label1.Name = "label1";
            label1.Size = new Size(232, 32);
            label1.TabIndex = 2;
            label1.Text = "Change Stock Levels";
            // 
            // btnAddToStock
            // 
            btnAddToStock.Anchor = AnchorStyles.None;
            btnAddToStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToStock.Location = new Point(139, 375);
            btnAddToStock.Name = "btnAddToStock";
            btnAddToStock.Size = new Size(220, 50);
            btnAddToStock.TabIndex = 0;
            btnAddToStock.Text = "Add To Stock";
            btnAddToStock.UseVisualStyleBackColor = true;
            btnAddToStock.Click += btnAddToStock_Click;
            // 
            // frmStockManagement
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 513);
            Controls.Add(pnlAddOrDepleteFromStock);
            Controls.Add(pnlAddNewStock);
            Controls.Add(pnlLookupStock);
            Name = "frmStockManagement";
            Text = "Stock Management";
            pnlLookupStock.ResumeLayout(false);
            pnlLookupStock.PerformLayout();
            pnlAddNewStock.ResumeLayout(false);
            pnlAddNewStock.PerformLayout();
            pnlAddOrDepleteFromStock.ResumeLayout(false);
            pnlAddOrDepleteFromStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlLookupStock;
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
        private Panel pnlAddOrDepleteFromStock;
        private Button btnRemoveFromStock;
        private Label label1;
        private Button btnAddToStock;
        private TextBox txtBoxAmountOfStockToChange;
        private Label lblErrorStockLevel;
        private Label lblErrorStockLookup;
    }
}
