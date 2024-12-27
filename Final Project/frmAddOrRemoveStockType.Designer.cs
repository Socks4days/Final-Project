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
			pnlAddNewStock.BackColor = Color.FromArgb(200, 200, 200);
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
			pnlAddNewStock.Size = new Size(967, 711);
			pnlAddNewStock.TabIndex = 3;
			// 
			// txtBoxNewDeliveryTime
			// 
			txtBoxNewDeliveryTime.Anchor = AnchorStyles.None;
			txtBoxNewDeliveryTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewDeliveryTime.Location = new Point(502, 379);
			txtBoxNewDeliveryTime.Name = "txtBoxNewDeliveryTime";
			txtBoxNewDeliveryTime.PlaceholderText = "Delivery Time (Days)";
			txtBoxNewDeliveryTime.Size = new Size(221, 32);
			txtBoxNewDeliveryTime.TabIndex = 18;
			// 
			// txtBoxNewStockCheckFrequency
			// 
			txtBoxNewStockCheckFrequency.Anchor = AnchorStyles.None;
			txtBoxNewStockCheckFrequency.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockCheckFrequency.Location = new Point(244, 379);
			txtBoxNewStockCheckFrequency.Name = "txtBoxNewStockCheckFrequency";
			txtBoxNewStockCheckFrequency.PlaceholderText = "Frequency Of Check";
			txtBoxNewStockCheckFrequency.Size = new Size(221, 32);
			txtBoxNewStockCheckFrequency.TabIndex = 17;
			// 
			// txtBoxNewOrderQuantity
			// 
			txtBoxNewOrderQuantity.Anchor = AnchorStyles.None;
			txtBoxNewOrderQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewOrderQuantity.Location = new Point(502, 269);
			txtBoxNewOrderQuantity.Name = "txtBoxNewOrderQuantity";
			txtBoxNewOrderQuantity.PlaceholderText = "Order Quantity";
			txtBoxNewOrderQuantity.Size = new Size(221, 32);
			txtBoxNewOrderQuantity.TabIndex = 16;
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.Gold;
			lblError.Location = new Point(231, 450);
			lblError.Name = "lblError";
			lblError.Size = new Size(505, 61);
			lblError.TabIndex = 15;
			lblError.Text = "Error message goes here";
			lblError.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtBoxNewStockName
			// 
			txtBoxNewStockName.Anchor = AnchorStyles.None;
			txtBoxNewStockName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockName.Location = new Point(244, 217);
			txtBoxNewStockName.Name = "txtBoxNewStockName";
			txtBoxNewStockName.PlaceholderText = "Stock Name";
			txtBoxNewStockName.Size = new Size(221, 32);
			txtBoxNewStockName.TabIndex = 0;
			// 
			// txtBoxNewMinimumLevel
			// 
			txtBoxNewMinimumLevel.Anchor = AnchorStyles.None;
			txtBoxNewMinimumLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewMinimumLevel.Location = new Point(502, 326);
			txtBoxNewMinimumLevel.Name = "txtBoxNewMinimumLevel";
			txtBoxNewMinimumLevel.PlaceholderText = "Minimum Level";
			txtBoxNewMinimumLevel.Size = new Size(221, 32);
			txtBoxNewMinimumLevel.TabIndex = 4;
			// 
			// txtBoxNewStockPrice
			// 
			txtBoxNewStockPrice.Anchor = AnchorStyles.None;
			txtBoxNewStockPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockPrice.Location = new Point(244, 269);
			txtBoxNewStockPrice.Name = "txtBoxNewStockPrice";
			txtBoxNewStockPrice.PlaceholderText = "Price";
			txtBoxNewStockPrice.Size = new Size(221, 32);
			txtBoxNewStockPrice.TabIndex = 2;
			// 
			// txtBoxNewMaximumLevel
			// 
			txtBoxNewMaximumLevel.Anchor = AnchorStyles.None;
			txtBoxNewMaximumLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewMaximumLevel.Location = new Point(244, 326);
			txtBoxNewMaximumLevel.Name = "txtBoxNewMaximumLevel";
			txtBoxNewMaximumLevel.PlaceholderText = "Maximum Level";
			txtBoxNewMaximumLevel.Size = new Size(221, 32);
			txtBoxNewMaximumLevel.TabIndex = 3;
			// 
			// txtBoxNewStockDescription
			// 
			txtBoxNewStockDescription.Anchor = AnchorStyles.None;
			txtBoxNewStockDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockDescription.Location = new Point(502, 217);
			txtBoxNewStockDescription.Name = "txtBoxNewStockDescription";
			txtBoxNewStockDescription.PlaceholderText = "Stock Description";
			txtBoxNewStockDescription.Size = new Size(221, 32);
			txtBoxNewStockDescription.TabIndex = 1;
			// 
			// lblAddNewStock
			// 
			lblAddNewStock.Anchor = AnchorStyles.None;
			lblAddNewStock.AutoSize = true;
			lblAddNewStock.Font = new Font("Segoe UI", 24F);
			lblAddNewStock.ForeColor = SystemColors.Control;
			lblAddNewStock.Location = new Point(375, 109);
			lblAddNewStock.Name = "lblAddNewStock";
			lblAddNewStock.Size = new Size(238, 45);
			lblAddNewStock.TabIndex = 1;
			lblAddNewStock.Text = "Add New Stock";
			// 
			// btnAddNewStock
			// 
			btnAddNewStock.Anchor = AnchorStyles.None;
			btnAddNewStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddNewStock.Location = new Point(375, 527);
			btnAddNewStock.Name = "btnAddNewStock";
			btnAddNewStock.Size = new Size(220, 50);
			btnAddNewStock.TabIndex = 5;
			btnAddNewStock.Text = "Add New Stock";
			btnAddNewStock.UseVisualStyleBackColor = true;
			btnAddNewStock.Click += btnAddNewStock_Click;
			// 
			// pnlConfirmation
			// 
			pnlConfirmation.BackColor = Color.FromArgb(200, 200, 200);
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
			pnlConfirmation.Location = new Point(0, 711);
			pnlConfirmation.Name = "pnlConfirmation";
			pnlConfirmation.Size = new Size(967, 711);
			pnlConfirmation.TabIndex = 4;
			// 
			// lblSuccess
			// 
			lblSuccess.Anchor = AnchorStyles.None;
			lblSuccess.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSuccess.ForeColor = Color.Coral;
			lblSuccess.Location = new Point(128, 518);
			lblSuccess.Name = "lblSuccess";
			lblSuccess.Size = new Size(711, 84);
			lblSuccess.TabIndex = 14;
			lblSuccess.Text = "Success message goes here";
			lblSuccess.TextAlign = ContentAlignment.TopCenter;
			// 
			// btnReturn
			// 
			btnReturn.Anchor = AnchorStyles.None;
			btnReturn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnReturn.Location = new Point(247, 448);
			btnReturn.Name = "btnReturn";
			btnReturn.Size = new Size(220, 50);
			btnReturn.TabIndex = 13;
			btnReturn.Text = "Return";
			btnReturn.UseVisualStyleBackColor = true;
			btnReturn.Click += btnReturn_Click;
			// 
			// lblStockTo
			// 
			lblStockTo.Anchor = AnchorStyles.None;
			lblStockTo.AutoSize = true;
			lblStockTo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblStockTo.ForeColor = SystemColors.Control;
			lblStockTo.Location = new Point(281, 177);
			lblStockTo.Name = "lblStockTo";
			lblStockTo.Size = new Size(95, 30);
			lblStockTo.TabIndex = 12;
			lblStockTo.Text = "Stock To ";
			// 
			// lblStockName
			// 
			lblStockName.Anchor = AnchorStyles.None;
			lblStockName.AutoSize = true;
			lblStockName.Font = new Font("Segoe UI", 14F);
			lblStockName.ForeColor = SystemColors.Control;
			lblStockName.Location = new Point(281, 222);
			lblStockName.Name = "lblStockName";
			lblStockName.Size = new Size(115, 25);
			lblStockName.TabIndex = 11;
			lblStockName.Text = "Stock Name:";
			// 
			// lblStockDescription
			// 
			lblStockDescription.Anchor = AnchorStyles.None;
			lblStockDescription.AutoSize = true;
			lblStockDescription.Font = new Font("Segoe UI", 14F);
			lblStockDescription.ForeColor = SystemColors.Control;
			lblStockDescription.Location = new Point(281, 262);
			lblStockDescription.Name = "lblStockDescription";
			lblStockDescription.Size = new Size(161, 25);
			lblStockDescription.TabIndex = 10;
			lblStockDescription.Text = "Stock Description:";
			// 
			// lblMinimumLevel
			// 
			lblMinimumLevel.Anchor = AnchorStyles.None;
			lblMinimumLevel.AutoSize = true;
			lblMinimumLevel.Font = new Font("Segoe UI", 14F);
			lblMinimumLevel.ForeColor = SystemColors.Control;
			lblMinimumLevel.Location = new Point(281, 382);
			lblMinimumLevel.Name = "lblMinimumLevel";
			lblMinimumLevel.Size = new Size(145, 25);
			lblMinimumLevel.TabIndex = 9;
			lblMinimumLevel.Text = "Minimum Level:";
			// 
			// lblMaximumLevel
			// 
			lblMaximumLevel.Anchor = AnchorStyles.None;
			lblMaximumLevel.AutoSize = true;
			lblMaximumLevel.Font = new Font("Segoe UI", 14F);
			lblMaximumLevel.ForeColor = SystemColors.Control;
			lblMaximumLevel.Location = new Point(281, 342);
			lblMaximumLevel.Name = "lblMaximumLevel";
			lblMaximumLevel.Size = new Size(148, 25);
			lblMaximumLevel.TabIndex = 8;
			lblMaximumLevel.Text = "Maximum Level:";
			// 
			// lblPrice
			// 
			lblPrice.Anchor = AnchorStyles.None;
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Segoe UI", 14F);
			lblPrice.ForeColor = SystemColors.Control;
			lblPrice.Location = new Point(281, 302);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(58, 25);
			lblPrice.TabIndex = 7;
			lblPrice.Text = "Price:";
			// 
			// lblConfirmation
			// 
			lblConfirmation.Anchor = AnchorStyles.None;
			lblConfirmation.AutoSize = true;
			lblConfirmation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblConfirmation.ForeColor = SystemColors.Control;
			lblConfirmation.Location = new Point(260, 108);
			lblConfirmation.Name = "lblConfirmation";
			lblConfirmation.Size = new Size(358, 25);
			lblConfirmation.TabIndex = 5;
			lblConfirmation.Text = "Please Confirm Details Below Are Correct";
			// 
			// btnConfirmed
			// 
			btnConfirmed.Anchor = AnchorStyles.None;
			btnConfirmed.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnConfirmed.Location = new Point(532, 448);
			btnConfirmed.Name = "btnConfirmed";
			btnConfirmed.Size = new Size(220, 50);
			btnConfirmed.TabIndex = 6;
			btnConfirmed.Text = "Confirm";
			btnConfirmed.UseVisualStyleBackColor = true;
			btnConfirmed.Click += btnConfirmed_Click;
			// 
			// pnlRemoveStock
			// 
			pnlRemoveStock.BackColor = Color.FromArgb(200, 200, 200);
			pnlRemoveStock.Controls.Add(lblErrorRemoveStock);
			pnlRemoveStock.Controls.Add(txtBoxRemoveStockName);
			pnlRemoveStock.Controls.Add(lblRemoveStock);
			pnlRemoveStock.Controls.Add(btnRemoveStock);
			pnlRemoveStock.Dock = DockStyle.Top;
			pnlRemoveStock.Location = new Point(0, 1422);
			pnlRemoveStock.Name = "pnlRemoveStock";
			pnlRemoveStock.Size = new Size(967, 711);
			pnlRemoveStock.TabIndex = 5;
			// 
			// lblErrorRemoveStock
			// 
			lblErrorRemoveStock.Anchor = AnchorStyles.None;
			lblErrorRemoveStock.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblErrorRemoveStock.ForeColor = Color.Gold;
			lblErrorRemoveStock.Location = new Point(231, 357);
			lblErrorRemoveStock.Name = "lblErrorRemoveStock";
			lblErrorRemoveStock.Size = new Size(505, 61);
			lblErrorRemoveStock.TabIndex = 15;
			lblErrorRemoveStock.Text = "Error message goes here";
			lblErrorRemoveStock.TextAlign = ContentAlignment.TopCenter;
			// 
			// txtBoxRemoveStockName
			// 
			txtBoxRemoveStockName.Anchor = AnchorStyles.None;
			txtBoxRemoveStockName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxRemoveStockName.Location = new Point(375, 305);
			txtBoxRemoveStockName.Name = "txtBoxRemoveStockName";
			txtBoxRemoveStockName.PlaceholderText = "Stock Name";
			txtBoxRemoveStockName.Size = new Size(220, 32);
			txtBoxRemoveStockName.TabIndex = 12;
			// 
			// lblRemoveStock
			// 
			lblRemoveStock.Anchor = AnchorStyles.None;
			lblRemoveStock.AutoSize = true;
			lblRemoveStock.Font = new Font("Segoe UI", 24F);
			lblRemoveStock.ForeColor = SystemColors.Control;
			lblRemoveStock.Location = new Point(375, 128);
			lblRemoveStock.Name = "lblRemoveStock";
			lblRemoveStock.Size = new Size(220, 45);
			lblRemoveStock.TabIndex = 1;
			lblRemoveStock.Text = "Remove Stock";
			// 
			// btnRemoveStock
			// 
			btnRemoveStock.Anchor = AnchorStyles.None;
			btnRemoveStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRemoveStock.Location = new Point(375, 432);
			btnRemoveStock.Name = "btnRemoveStock";
			btnRemoveStock.Size = new Size(220, 50);
			btnRemoveStock.TabIndex = 0;
			btnRemoveStock.Text = "Remove Stock";
			btnRemoveStock.UseVisualStyleBackColor = true;
			btnRemoveStock.Click += btnRemoveStock_Click;
			// 
			// frmAddOrRemoveStockType
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(984, 711);
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