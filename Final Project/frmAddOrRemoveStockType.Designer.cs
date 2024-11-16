namespace Final_Project
{
    partial class frmAddOrRemoveStockType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlAddNewStock = new Panel();
            txtBoxNewStockName = new TextBox();
            txtBoxNewMinimumLevel = new TextBox();
            txtBoxNewStockPrice = new TextBox();
            txtBoxNewMaximumLevel = new TextBox();
            txtBoxNewStockDescription = new TextBox();
            lblAddNewStock = new Label();
            btnAddNewStock = new Button();
            pnlConfirmation = new Panel();
            btnReturn = new Button();
            lblStockTo = new Label();
            lblStockName = new Label();
            lblStockDescription = new Label();
            lblMinimumLevel = new Label();
            lblMaximumLevel = new Label();
            lblPrice = new Label();
            lblConfirmation = new Label();
            btnConfirmed = new Button();
            pnlAddNewStock.SuspendLayout();
            pnlConfirmation.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddNewStock
            // 
            pnlAddNewStock.BackColor = Color.DarkCyan;
            pnlAddNewStock.Controls.Add(txtBoxNewStockName);
            pnlAddNewStock.Controls.Add(txtBoxNewMinimumLevel);
            pnlAddNewStock.Controls.Add(txtBoxNewStockPrice);
            pnlAddNewStock.Controls.Add(txtBoxNewMaximumLevel);
            pnlAddNewStock.Controls.Add(txtBoxNewStockDescription);
            pnlAddNewStock.Controls.Add(lblAddNewStock);
            pnlAddNewStock.Controls.Add(btnAddNewStock);
            pnlAddNewStock.Dock = DockStyle.Top;
            pnlAddNewStock.Location = new Point(0, 0);
            pnlAddNewStock.Name = "pnlAddNewStock";
            pnlAddNewStock.Size = new Size(783, 560);
            pnlAddNewStock.TabIndex = 3;
            // 
            // txtBoxNewStockName
            // 
            txtBoxNewStockName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockName.Location = new Point(281, 112);
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
            lblAddNewStock.Location = new Point(303, 32);
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
            // pnlConfirmation
            // 
            pnlConfirmation.BackColor = Color.DarkCyan;
            pnlConfirmation.Controls.Add(btnReturn);
            pnlConfirmation.Controls.Add(lblStockTo);
            pnlConfirmation.Controls.Add(lblStockName);
            pnlConfirmation.Controls.Add(lblStockDescription);
            pnlConfirmation.Controls.Add(lblMinimumLevel);
            pnlConfirmation.Controls.Add(lblMaximumLevel);
            pnlConfirmation.Controls.Add(lblPrice);
            pnlConfirmation.Controls.Add(lblConfirmation);
            pnlConfirmation.Controls.Add(btnConfirmed);
            pnlConfirmation.Dock = DockStyle.Top;
            pnlConfirmation.Location = new Point(0, 560);
            pnlConfirmation.Name = "pnlConfirmation";
            pnlConfirmation.Size = new Size(783, 560);
            pnlConfirmation.TabIndex = 4;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(153, 417);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(220, 50);
            btnReturn.TabIndex = 13;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblStockTo
            // 
            lblStockTo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockTo.ForeColor = SystemColors.Control;
            lblStockTo.Location = new Point(166, 126);
            lblStockTo.Name = "lblStockTo";
            lblStockTo.Size = new Size(179, 32);
            lblStockTo.TabIndex = 12;
            lblStockTo.Text = "Stock To ";
            // 
            // lblStockName
            // 
            lblStockName.AutoSize = true;
            lblStockName.Font = new Font("Segoe UI", 14.25F);
            lblStockName.ForeColor = SystemColors.Control;
            lblStockName.Location = new Point(166, 171);
            lblStockName.Name = "lblStockName";
            lblStockName.Size = new Size(115, 25);
            lblStockName.TabIndex = 11;
            lblStockName.Text = "Stock Name:";
            // 
            // lblStockDescription
            // 
            lblStockDescription.AutoSize = true;
            lblStockDescription.Font = new Font("Segoe UI", 14.25F);
            lblStockDescription.ForeColor = SystemColors.Control;
            lblStockDescription.Location = new Point(166, 211);
            lblStockDescription.Name = "lblStockDescription";
            lblStockDescription.Size = new Size(161, 25);
            lblStockDescription.TabIndex = 10;
            lblStockDescription.Text = "Stock Description:";
            // 
            // lblMinimumLevel
            // 
            lblMinimumLevel.AutoSize = true;
            lblMinimumLevel.Font = new Font("Segoe UI", 14.25F);
            lblMinimumLevel.ForeColor = SystemColors.Control;
            lblMinimumLevel.Location = new Point(166, 331);
            lblMinimumLevel.Name = "lblMinimumLevel";
            lblMinimumLevel.Size = new Size(145, 25);
            lblMinimumLevel.TabIndex = 9;
            lblMinimumLevel.Text = "Minimum Level:";
            // 
            // lblMaximumLevel
            // 
            lblMaximumLevel.AutoSize = true;
            lblMaximumLevel.Font = new Font("Segoe UI", 14.25F);
            lblMaximumLevel.ForeColor = SystemColors.Control;
            lblMaximumLevel.Location = new Point(166, 291);
            lblMaximumLevel.Name = "lblMaximumLevel";
            lblMaximumLevel.Size = new Size(148, 25);
            lblMaximumLevel.TabIndex = 8;
            lblMaximumLevel.Text = "Maximum Level:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14.25F);
            lblPrice.ForeColor = SystemColors.Control;
            lblPrice.Location = new Point(166, 251);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 25);
            lblPrice.TabIndex = 7;
            lblPrice.Text = "Price:";
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmation.ForeColor = SystemColors.Control;
            lblConfirmation.Location = new Point(166, 57);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(451, 32);
            lblConfirmation.TabIndex = 5;
            lblConfirmation.Text = "Please Confirm Details Below Are Correct";
            // 
            // btnConfirmed
            // 
            btnConfirmed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmed.Location = new Point(438, 417);
            btnConfirmed.Name = "btnConfirmed";
            btnConfirmed.Size = new Size(220, 50);
            btnConfirmed.TabIndex = 6;
            btnConfirmed.Text = "Confirm";
            btnConfirmed.UseVisualStyleBackColor = true;
            btnConfirmed.Click += btnConfirmed_Click;
            // 
            // frmAddOrRemoveStockType
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 521);
            Controls.Add(pnlConfirmation);
            Controls.Add(pnlAddNewStock);
            Name = "frmAddOrRemoveStockType";
            Text = "AddOrRemoveStockType";
            pnlAddNewStock.ResumeLayout(false);
            pnlAddNewStock.PerformLayout();
            pnlConfirmation.ResumeLayout(false);
            pnlConfirmation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlAddNewStock;
        private TextBox txtBoxNewStockName;
        private TextBox txtBoxNewMinimumLevel;
        private TextBox txtBoxNewStockPrice;
        private TextBox txtBoxNewMaximumLevel;
        private TextBox txtBoxNewStockDescription;
        private Label lblAddNewStock;
        private Button btnAddNewStock;
        private Panel pnlConfirmation;
        private Label lblConfirmation;
        private Button btnConfirmed;
        private Label lblStockTo;
        private Label lblStockName;
        private Label lblStockDescription;
        private Label lblMinimumLevel;
        private Label lblMaximumLevel;
        private Label lblPrice;
        private Button btnReturn;
    }
}