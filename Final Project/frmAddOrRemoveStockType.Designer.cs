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
            txtBoxNewDeliveryTime = new TextBox();
            txtBoxNewStockCheckFrequency = new TextBox();
            txtBoxNewOrderQuantity = new TextBox();
            lblError = new Label();
            txtBoxNewStockName = new TextBox();
            txtBoxNewMinimumLevel = new TextBox();
            txtBoxNewStockPrice = new TextBox();
            txtBoxNewMaximumLevel = new TextBox();
            txtBoxNewStockDescription = new TextBox();
            lblAddNewStock = new Label();
            btnAddNewStock = new Button();
            pnlConfirmation = new Panel();
            lblSuccess = new Label();
            btnReturn = new Button();
            lblStockTo = new Label();
            lblStockName = new Label();
            lblStockDescription = new Label();
            lblMinimumLevel = new Label();
            lblMaximumLevel = new Label();
            lblPrice = new Label();
            lblConfirmation = new Label();
            btnConfirmed = new Button();
            pnlRemoveStock = new Panel();
            lblErrorRemoveStock = new Label();
            txtBoxRemoveStockName = new TextBox();
            lblRemoveStock = new Label();
            btnRemoveStock = new Button();
            pnlAddNewStock.SuspendLayout();
            pnlConfirmation.SuspendLayout();
            pnlRemoveStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddNewStock
            // 
            pnlAddNewStock.BackColor = Color.DarkCyan;
            pnlAddNewStock.Controls.Add(txtBoxNewDeliveryTime);
            pnlAddNewStock.Controls.Add(txtBoxNewStockCheckFrequency);
            pnlAddNewStock.Controls.Add(txtBoxNewOrderQuantity);
            pnlAddNewStock.Controls.Add(lblError);
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
            // txtBoxNewDeliveryTime
            // 
            txtBoxNewDeliveryTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewDeliveryTime.Location = new Point(410, 277);
            txtBoxNewDeliveryTime.Name = "txtBoxNewDeliveryTime";
            txtBoxNewDeliveryTime.PlaceholderText = "Delivery Time (Days)";
            txtBoxNewDeliveryTime.Size = new Size(221, 33);
            txtBoxNewDeliveryTime.TabIndex = 18;
            // 
            // txtBoxNewStockCheckFrequency
            // 
            txtBoxNewStockCheckFrequency.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockCheckFrequency.Location = new Point(152, 277);
            txtBoxNewStockCheckFrequency.Name = "txtBoxNewStockCheckFrequency";
            txtBoxNewStockCheckFrequency.PlaceholderText = "Frequency Of Check";
            txtBoxNewStockCheckFrequency.Size = new Size(221, 33);
            txtBoxNewStockCheckFrequency.TabIndex = 17;
            // 
            // txtBoxNewOrderQuantity
            // 
            txtBoxNewOrderQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewOrderQuantity.Location = new Point(410, 167);
            txtBoxNewOrderQuantity.Name = "txtBoxNewOrderQuantity";
            txtBoxNewOrderQuantity.PlaceholderText = "Order Quantity";
            txtBoxNewOrderQuantity.Size = new Size(221, 33);
            txtBoxNewOrderQuantity.TabIndex = 16;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblError.ForeColor = Color.Coral;
            lblError.Location = new Point(139, 348);
            lblError.Name = "lblError";
            lblError.Size = new Size(505, 61);
            lblError.TabIndex = 15;
            lblError.Text = "Error message goes here";
            lblError.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBoxNewStockName
            // 
            txtBoxNewStockName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockName.Location = new Point(152, 115);
            txtBoxNewStockName.Name = "txtBoxNewStockName";
            txtBoxNewStockName.PlaceholderText = "Stock Name";
            txtBoxNewStockName.Size = new Size(221, 33);
            txtBoxNewStockName.TabIndex = 0;
            // 
            // txtBoxNewMinimumLevel
            // 
            txtBoxNewMinimumLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewMinimumLevel.Location = new Point(410, 224);
            txtBoxNewMinimumLevel.Name = "txtBoxNewMinimumLevel";
            txtBoxNewMinimumLevel.PlaceholderText = "Minimum Level";
            txtBoxNewMinimumLevel.Size = new Size(221, 33);
            txtBoxNewMinimumLevel.TabIndex = 4;
            // 
            // txtBoxNewStockPrice
            // 
            txtBoxNewStockPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockPrice.Location = new Point(152, 167);
            txtBoxNewStockPrice.Name = "txtBoxNewStockPrice";
            txtBoxNewStockPrice.PlaceholderText = "Price";
            txtBoxNewStockPrice.Size = new Size(221, 33);
            txtBoxNewStockPrice.TabIndex = 2;
            // 
            // txtBoxNewMaximumLevel
            // 
            txtBoxNewMaximumLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewMaximumLevel.Location = new Point(152, 224);
            txtBoxNewMaximumLevel.Name = "txtBoxNewMaximumLevel";
            txtBoxNewMaximumLevel.PlaceholderText = "Maximum Level";
            txtBoxNewMaximumLevel.Size = new Size(221, 33);
            txtBoxNewMaximumLevel.TabIndex = 3;
            // 
            // txtBoxNewStockDescription
            // 
            txtBoxNewStockDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNewStockDescription.Location = new Point(410, 115);
            txtBoxNewStockDescription.Name = "txtBoxNewStockDescription";
            txtBoxNewStockDescription.PlaceholderText = "Stock Description";
            txtBoxNewStockDescription.Size = new Size(221, 33);
            txtBoxNewStockDescription.TabIndex = 1;
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
            btnAddNewStock.Location = new Point(283, 425);
            btnAddNewStock.Name = "btnAddNewStock";
            btnAddNewStock.Size = new Size(220, 50);
            btnAddNewStock.TabIndex = 5;
            btnAddNewStock.Text = "Add New Stock";
            btnAddNewStock.UseVisualStyleBackColor = true;
            btnAddNewStock.Click += btnAddNewStock_Click;
            // 
            // pnlConfirmation
            // 
            pnlConfirmation.BackColor = Color.DarkCyan;
            pnlConfirmation.Controls.Add(lblSuccess);
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
            // lblSuccess
            // 
            lblSuccess.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSuccess.ForeColor = Color.Coral;
            lblSuccess.Location = new Point(34, 467);
            lblSuccess.Name = "lblSuccess";
            lblSuccess.Size = new Size(711, 84);
            lblSuccess.TabIndex = 14;
            lblSuccess.Text = "Success message goes here";
            lblSuccess.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(153, 397);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(220, 50);
            btnReturn.TabIndex = 13;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // lblStockTo
            // 
            lblStockTo.AutoSize = true;
            lblStockTo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockTo.ForeColor = SystemColors.Control;
            lblStockTo.Location = new Point(187, 126);
            lblStockTo.Name = "lblStockTo";
            lblStockTo.Size = new Size(95, 30);
            lblStockTo.TabIndex = 12;
            lblStockTo.Text = "Stock To ";
            // 
            // lblStockName
            // 
            lblStockName.AutoSize = true;
            lblStockName.Font = new Font("Segoe UI", 14.25F);
            lblStockName.ForeColor = SystemColors.Control;
            lblStockName.Location = new Point(187, 171);
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
            lblStockDescription.Location = new Point(187, 211);
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
            lblMinimumLevel.Location = new Point(187, 331);
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
            lblMaximumLevel.Location = new Point(187, 291);
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
            lblPrice.Location = new Point(187, 251);
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
            btnConfirmed.Location = new Point(438, 397);
            btnConfirmed.Name = "btnConfirmed";
            btnConfirmed.Size = new Size(220, 50);
            btnConfirmed.TabIndex = 6;
            btnConfirmed.Text = "Confirm";
            btnConfirmed.UseVisualStyleBackColor = true;
            btnConfirmed.Click += btnConfirmed_Click;
            // 
            // pnlRemoveStock
            // 
            pnlRemoveStock.BackColor = Color.DarkCyan;
            pnlRemoveStock.Controls.Add(lblErrorRemoveStock);
            pnlRemoveStock.Controls.Add(txtBoxRemoveStockName);
            pnlRemoveStock.Controls.Add(lblRemoveStock);
            pnlRemoveStock.Controls.Add(btnRemoveStock);
            pnlRemoveStock.Dock = DockStyle.Top;
            pnlRemoveStock.Location = new Point(0, 1120);
            pnlRemoveStock.Name = "pnlRemoveStock";
            pnlRemoveStock.Size = new Size(783, 560);
            pnlRemoveStock.TabIndex = 5;
            // 
            // lblErrorRemoveStock
            // 
            lblErrorRemoveStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorRemoveStock.ForeColor = Color.Coral;
            lblErrorRemoveStock.Location = new Point(139, 225);
            lblErrorRemoveStock.Name = "lblErrorRemoveStock";
            lblErrorRemoveStock.Size = new Size(505, 61);
            lblErrorRemoveStock.TabIndex = 15;
            lblErrorRemoveStock.Text = "Error message goes here";
            lblErrorRemoveStock.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtBoxRemoveStockName
            // 
            txtBoxRemoveStockName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxRemoveStockName.Location = new Point(283, 173);
            txtBoxRemoveStockName.Name = "txtBoxRemoveStockName";
            txtBoxRemoveStockName.PlaceholderText = "Stock Name";
            txtBoxRemoveStockName.Size = new Size(220, 33);
            txtBoxRemoveStockName.TabIndex = 12;
            // 
            // lblRemoveStock
            // 
            lblRemoveStock.AutoSize = true;
            lblRemoveStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRemoveStock.ForeColor = SystemColors.Control;
            lblRemoveStock.Location = new Point(309, 97);
            lblRemoveStock.Name = "lblRemoveStock";
            lblRemoveStock.Size = new Size(164, 32);
            lblRemoveStock.TabIndex = 1;
            lblRemoveStock.Text = "Remove Stock";
            // 
            // btnRemoveStock
            // 
            btnRemoveStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveStock.Location = new Point(283, 300);
            btnRemoveStock.Name = "btnRemoveStock";
            btnRemoveStock.Size = new Size(220, 50);
            btnRemoveStock.TabIndex = 0;
            btnRemoveStock.Text = "Remove Stock";
            btnRemoveStock.UseVisualStyleBackColor = true;
            btnRemoveStock.Click += btnRemoveStock_Click;
            // 
            // frmAddOrRemoveStockType
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 521);
            Controls.Add(pnlRemoveStock);
            Controls.Add(pnlConfirmation);
            Controls.Add(pnlAddNewStock);
            Name = "frmAddOrRemoveStockType";
            Text = "AddOrRemoveStockType";
            pnlAddNewStock.ResumeLayout(false);
            pnlAddNewStock.PerformLayout();
            pnlConfirmation.ResumeLayout(false);
            pnlConfirmation.PerformLayout();
            pnlRemoveStock.ResumeLayout(false);
            pnlRemoveStock.PerformLayout();
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
        private Label lblSuccess;
        private Label lblError;
        private Panel pnlRemoveStock;
        private Label lblErrorRemoveStock;
        private TextBox txtBoxRemoveStockName;
        private Label lblRemoveStock;
        private Button btnRemoveStock;
        private TextBox txtBoxNewOrderQuantity;
        private TextBox txtBoxNewStockCheckFrequency;
        private TextBox txtBoxNewDeliveryTime;
    }
}