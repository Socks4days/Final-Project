namespace Final_Project
{
    partial class frmAddOrRetireStockType
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
			lblNewDescription = new Label();
			lblNewStockName = new Label();
			lblNewOrderQuantity = new Label();
			lblNewPrice = new Label();
			lblNewMinimumLevel = new Label();
			lblNewMaximumLevel = new Label();
			lblNewDeliveryTime = new Label();
			lblNewStockCheckFrequency = new Label();
			txtBoxNewDeliveryTime = new TextBox();
			txtBoxNewStockCheckFrequency = new TextBox();
			txtBoxNewOrderQuantity = new TextBox();
			lblError = new Label();
			txtBoxNewStockName = new TextBox();
			txtBoxNewMinimumLevel = new TextBox();
			txtBoxNewStockPrice = new TextBox();
			txtBoxNewMaximumLevel = new TextBox();
			txtBoxNewStockDescription = new TextBox();
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
			pnlRetireStock = new Panel();
			lblStockToRetire = new Label();
			lblErrorRetireStock = new Label();
			txtBoxRetireStockName = new TextBox();
			btnRetireStock = new Button();
			pnlAddNewStock.SuspendLayout();
			pnlConfirmation.SuspendLayout();
			pnlRetireStock.SuspendLayout();
			SuspendLayout();
			// 
			// pnlAddNewStock
			// 
			pnlAddNewStock.BackColor = Color.FromArgb(200, 200, 200);
			pnlAddNewStock.Controls.Add(lblNewDescription);
			pnlAddNewStock.Controls.Add(lblNewStockName);
			pnlAddNewStock.Controls.Add(lblNewOrderQuantity);
			pnlAddNewStock.Controls.Add(lblNewPrice);
			pnlAddNewStock.Controls.Add(lblNewMinimumLevel);
			pnlAddNewStock.Controls.Add(lblNewMaximumLevel);
			pnlAddNewStock.Controls.Add(lblNewDeliveryTime);
			pnlAddNewStock.Controls.Add(lblNewStockCheckFrequency);
			pnlAddNewStock.Controls.Add(txtBoxNewDeliveryTime);
			pnlAddNewStock.Controls.Add(txtBoxNewStockCheckFrequency);
			pnlAddNewStock.Controls.Add(txtBoxNewOrderQuantity);
			pnlAddNewStock.Controls.Add(lblError);
			pnlAddNewStock.Controls.Add(txtBoxNewStockName);
			pnlAddNewStock.Controls.Add(txtBoxNewMinimumLevel);
			pnlAddNewStock.Controls.Add(txtBoxNewStockPrice);
			pnlAddNewStock.Controls.Add(txtBoxNewMaximumLevel);
			pnlAddNewStock.Controls.Add(txtBoxNewStockDescription);
			pnlAddNewStock.Controls.Add(btnAddNewStock);
			pnlAddNewStock.Dock = DockStyle.Top;
			pnlAddNewStock.Location = new Point(0, 0);
			pnlAddNewStock.Name = "pnlAddNewStock";
			pnlAddNewStock.Size = new Size(967, 711);
			pnlAddNewStock.TabIndex = 3;
			// 
			// lblNewDescription
			// 
			lblNewDescription.Anchor = AnchorStyles.None;
			lblNewDescription.AutoSize = true;
			lblNewDescription.Font = new Font("Segoe UI", 14F);
			lblNewDescription.ForeColor = Color.Black;
			lblNewDescription.Location = new Point(502, 116);
			lblNewDescription.Name = "lblNewDescription";
			lblNewDescription.Size = new Size(112, 25);
			lblNewDescription.TabIndex = 26;
			lblNewDescription.Text = "Description:";
			// 
			// lblNewStockName
			// 
			lblNewStockName.Anchor = AnchorStyles.None;
			lblNewStockName.AutoSize = true;
			lblNewStockName.Font = new Font("Segoe UI", 14F);
			lblNewStockName.ForeColor = Color.Black;
			lblNewStockName.Location = new Point(247, 116);
			lblNewStockName.Name = "lblNewStockName";
			lblNewStockName.Size = new Size(66, 25);
			lblNewStockName.TabIndex = 25;
			lblNewStockName.Text = "Name:";
			// 
			// lblNewOrderQuantity
			// 
			lblNewOrderQuantity.Anchor = AnchorStyles.None;
			lblNewOrderQuantity.AutoSize = true;
			lblNewOrderQuantity.Font = new Font("Segoe UI", 14F);
			lblNewOrderQuantity.ForeColor = Color.Black;
			lblNewOrderQuantity.Location = new Point(502, 195);
			lblNewOrderQuantity.Name = "lblNewOrderQuantity";
			lblNewOrderQuantity.Size = new Size(142, 25);
			lblNewOrderQuantity.TabIndex = 24;
			lblNewOrderQuantity.Text = "Order Quantity:";
			// 
			// lblNewPrice
			// 
			lblNewPrice.Anchor = AnchorStyles.None;
			lblNewPrice.AutoSize = true;
			lblNewPrice.Font = new Font("Segoe UI", 14F);
			lblNewPrice.ForeColor = Color.Black;
			lblNewPrice.Location = new Point(247, 195);
			lblNewPrice.Name = "lblNewPrice";
			lblNewPrice.Size = new Size(58, 25);
			lblNewPrice.TabIndex = 23;
			lblNewPrice.Text = "Price:";
			// 
			// lblNewMinimumLevel
			// 
			lblNewMinimumLevel.Anchor = AnchorStyles.None;
			lblNewMinimumLevel.AutoSize = true;
			lblNewMinimumLevel.Font = new Font("Segoe UI", 14F);
			lblNewMinimumLevel.ForeColor = Color.Black;
			lblNewMinimumLevel.Location = new Point(502, 274);
			lblNewMinimumLevel.Name = "lblNewMinimumLevel";
			lblNewMinimumLevel.Size = new Size(145, 25);
			lblNewMinimumLevel.TabIndex = 22;
			lblNewMinimumLevel.Text = "Minimum Level:";
			// 
			// lblNewMaximumLevel
			// 
			lblNewMaximumLevel.Anchor = AnchorStyles.None;
			lblNewMaximumLevel.AutoSize = true;
			lblNewMaximumLevel.Font = new Font("Segoe UI", 14F);
			lblNewMaximumLevel.ForeColor = Color.Black;
			lblNewMaximumLevel.Location = new Point(247, 274);
			lblNewMaximumLevel.Name = "lblNewMaximumLevel";
			lblNewMaximumLevel.Size = new Size(148, 25);
			lblNewMaximumLevel.TabIndex = 21;
			lblNewMaximumLevel.Text = "Maximum Level:";
			// 
			// lblNewDeliveryTime
			// 
			lblNewDeliveryTime.Anchor = AnchorStyles.None;
			lblNewDeliveryTime.AutoSize = true;
			lblNewDeliveryTime.Font = new Font("Segoe UI", 14F);
			lblNewDeliveryTime.ForeColor = Color.Black;
			lblNewDeliveryTime.Location = new Point(502, 351);
			lblNewDeliveryTime.Name = "lblNewDeliveryTime";
			lblNewDeliveryTime.Size = new Size(187, 25);
			lblNewDeliveryTime.TabIndex = 20;
			lblNewDeliveryTime.Text = "Delivery Time (Days):";
			// 
			// lblNewStockCheckFrequency
			// 
			lblNewStockCheckFrequency.Anchor = AnchorStyles.None;
			lblNewStockCheckFrequency.AutoSize = true;
			lblNewStockCheckFrequency.Font = new Font("Segoe UI", 14F);
			lblNewStockCheckFrequency.ForeColor = Color.Black;
			lblNewStockCheckFrequency.Location = new Point(247, 351);
			lblNewStockCheckFrequency.Name = "lblNewStockCheckFrequency";
			lblNewStockCheckFrequency.Size = new Size(208, 25);
			lblNewStockCheckFrequency.TabIndex = 19;
			lblNewStockCheckFrequency.Text = "Stock Check Frequency:";
			// 
			// txtBoxNewDeliveryTime
			// 
			txtBoxNewDeliveryTime.Anchor = AnchorStyles.None;
			txtBoxNewDeliveryTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewDeliveryTime.Location = new Point(502, 379);
			txtBoxNewDeliveryTime.Name = "txtBoxNewDeliveryTime";
			txtBoxNewDeliveryTime.Size = new Size(221, 32);
			txtBoxNewDeliveryTime.TabIndex = 18;
			// 
			// txtBoxNewStockCheckFrequency
			// 
			txtBoxNewStockCheckFrequency.Anchor = AnchorStyles.None;
			txtBoxNewStockCheckFrequency.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockCheckFrequency.Location = new Point(246, 379);
			txtBoxNewStockCheckFrequency.Name = "txtBoxNewStockCheckFrequency";
			txtBoxNewStockCheckFrequency.Size = new Size(221, 32);
			txtBoxNewStockCheckFrequency.TabIndex = 17;
			// 
			// txtBoxNewOrderQuantity
			// 
			txtBoxNewOrderQuantity.Anchor = AnchorStyles.None;
			txtBoxNewOrderQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewOrderQuantity.Location = new Point(502, 223);
			txtBoxNewOrderQuantity.Name = "txtBoxNewOrderQuantity";
			txtBoxNewOrderQuantity.Size = new Size(221, 32);
			txtBoxNewOrderQuantity.TabIndex = 16;
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.BackColor = Color.FromArgb(255, 209, 209);
			lblError.BorderStyle = BorderStyle.FixedSingle;
			lblError.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblError.ForeColor = Color.FromArgb(250, 0, 0);
			lblError.Location = new Point(231, 450);
			lblError.Name = "lblError";
			lblError.Size = new Size(505, 61);
			lblError.TabIndex = 15;
			lblError.Text = "Error message goes here";
			lblError.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtBoxNewStockName
			// 
			txtBoxNewStockName.Anchor = AnchorStyles.None;
			txtBoxNewStockName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockName.Location = new Point(246, 144);
			txtBoxNewStockName.Name = "txtBoxNewStockName";
			txtBoxNewStockName.Size = new Size(221, 32);
			txtBoxNewStockName.TabIndex = 0;
			// 
			// txtBoxNewMinimumLevel
			// 
			txtBoxNewMinimumLevel.Anchor = AnchorStyles.None;
			txtBoxNewMinimumLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewMinimumLevel.Location = new Point(502, 302);
			txtBoxNewMinimumLevel.Name = "txtBoxNewMinimumLevel";
			txtBoxNewMinimumLevel.Size = new Size(221, 32);
			txtBoxNewMinimumLevel.TabIndex = 4;
			// 
			// txtBoxNewStockPrice
			// 
			txtBoxNewStockPrice.Anchor = AnchorStyles.None;
			txtBoxNewStockPrice.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockPrice.Location = new Point(246, 223);
			txtBoxNewStockPrice.Name = "txtBoxNewStockPrice";
			txtBoxNewStockPrice.Size = new Size(221, 32);
			txtBoxNewStockPrice.TabIndex = 2;
			// 
			// txtBoxNewMaximumLevel
			// 
			txtBoxNewMaximumLevel.Anchor = AnchorStyles.None;
			txtBoxNewMaximumLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewMaximumLevel.Location = new Point(247, 302);
			txtBoxNewMaximumLevel.Name = "txtBoxNewMaximumLevel";
			txtBoxNewMaximumLevel.Size = new Size(221, 32);
			txtBoxNewMaximumLevel.TabIndex = 3;
			// 
			// txtBoxNewStockDescription
			// 
			txtBoxNewStockDescription.Anchor = AnchorStyles.None;
			txtBoxNewStockDescription.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxNewStockDescription.Location = new Point(502, 144);
			txtBoxNewStockDescription.Name = "txtBoxNewStockDescription";
			txtBoxNewStockDescription.Size = new Size(221, 32);
			txtBoxNewStockDescription.TabIndex = 1;
			// 
			// btnAddNewStock
			// 
			btnAddNewStock.Anchor = AnchorStyles.None;
			btnAddNewStock.BackColor = Color.FromArgb(33, 150, 243);
			btnAddNewStock.FlatAppearance.BorderSize = 0;
			btnAddNewStock.FlatStyle = FlatStyle.Flat;
			btnAddNewStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddNewStock.ForeColor = Color.White;
			btnAddNewStock.Location = new Point(375, 527);
			btnAddNewStock.Name = "btnAddNewStock";
			btnAddNewStock.Size = new Size(220, 50);
			btnAddNewStock.TabIndex = 5;
			btnAddNewStock.Text = "Add New Stock";
			btnAddNewStock.UseVisualStyleBackColor = false;
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
			lblSuccess.BackColor = Color.FromArgb(209, 255, 209);
			lblSuccess.BorderStyle = BorderStyle.FixedSingle;
			lblSuccess.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblSuccess.ForeColor = Color.FromArgb(0, 150, 0);
			lblSuccess.Location = new Point(128, 518);
			lblSuccess.Name = "lblSuccess";
			lblSuccess.Size = new Size(711, 84);
			lblSuccess.TabIndex = 14;
			lblSuccess.Text = "Success message goes here";
			lblSuccess.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnReturn
			// 
			btnReturn.Anchor = AnchorStyles.None;
			btnReturn.BackColor = Color.FromArgb(33, 150, 243);
			btnReturn.FlatAppearance.BorderSize = 0;
			btnReturn.FlatStyle = FlatStyle.Flat;
			btnReturn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnReturn.ForeColor = Color.White;
			btnReturn.Location = new Point(247, 448);
			btnReturn.Name = "btnReturn";
			btnReturn.Size = new Size(220, 50);
			btnReturn.TabIndex = 13;
			btnReturn.Text = "Return";
			btnReturn.UseVisualStyleBackColor = false;
			btnReturn.Click += btnReturn_Click;
			// 
			// lblStockTo
			// 
			lblStockTo.Anchor = AnchorStyles.None;
			lblStockTo.AutoSize = true;
			lblStockTo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblStockTo.ForeColor = Color.Black;
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
			lblStockName.ForeColor = Color.Black;
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
			lblStockDescription.ForeColor = Color.Black;
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
			lblMinimumLevel.ForeColor = Color.Black;
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
			lblMaximumLevel.ForeColor = Color.Black;
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
			lblPrice.ForeColor = Color.Black;
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
			lblConfirmation.Font = new Font("Segoe UI", 24F);
			lblConfirmation.ForeColor = Color.Black;
			lblConfirmation.Location = new Point(182, 105);
			lblConfirmation.Name = "lblConfirmation";
			lblConfirmation.Size = new Size(603, 45);
			lblConfirmation.TabIndex = 5;
			lblConfirmation.Text = "Please Confirm Details Below Are Correct";
			// 
			// btnConfirmed
			// 
			btnConfirmed.Anchor = AnchorStyles.None;
			btnConfirmed.BackColor = Color.FromArgb(33, 150, 243);
			btnConfirmed.FlatAppearance.BorderSize = 0;
			btnConfirmed.FlatStyle = FlatStyle.Flat;
			btnConfirmed.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnConfirmed.ForeColor = Color.White;
			btnConfirmed.Location = new Point(532, 448);
			btnConfirmed.Name = "btnConfirmed";
			btnConfirmed.Size = new Size(220, 50);
			btnConfirmed.TabIndex = 6;
			btnConfirmed.Text = "Confirm";
			btnConfirmed.UseVisualStyleBackColor = false;
			btnConfirmed.Click += btnConfirmed_Click;
			// 
			// pnlRetireStock
			// 
			pnlRetireStock.BackColor = Color.FromArgb(200, 200, 200);
			pnlRetireStock.Controls.Add(lblStockToRetire);
			pnlRetireStock.Controls.Add(lblErrorRetireStock);
			pnlRetireStock.Controls.Add(txtBoxRetireStockName);
			pnlRetireStock.Controls.Add(btnRetireStock);
			pnlRetireStock.Dock = DockStyle.Top;
			pnlRetireStock.Location = new Point(0, 1422);
			pnlRetireStock.Name = "pnlRetireStock";
			pnlRetireStock.Size = new Size(967, 711);
			pnlRetireStock.TabIndex = 5;
			// 
			// lblStockToRetire
			// 
			lblStockToRetire.Anchor = AnchorStyles.None;
			lblStockToRetire.AutoSize = true;
			lblStockToRetire.Font = new Font("Segoe UI", 14F);
			lblStockToRetire.ForeColor = Color.Black;
			lblStockToRetire.Location = new Point(375, 237);
			lblStockToRetire.Name = "lblStockToRetire";
			lblStockToRetire.Size = new Size(164, 25);
			lblStockToRetire.TabIndex = 16;
			lblStockToRetire.Text = "Enter Stock Name:";
			// 
			// lblErrorRetireStock
			// 
			lblErrorRetireStock.Anchor = AnchorStyles.None;
			lblErrorRetireStock.BackColor = Color.FromArgb(255, 209, 209);
			lblErrorRetireStock.BorderStyle = BorderStyle.FixedSingle;
			lblErrorRetireStock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			lblErrorRetireStock.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorRetireStock.Location = new Point(231, 319);
			lblErrorRetireStock.Name = "lblErrorRetireStock";
			lblErrorRetireStock.Size = new Size(505, 61);
			lblErrorRetireStock.TabIndex = 15;
			lblErrorRetireStock.Text = "Error message goes here";
			lblErrorRetireStock.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// txtBoxRetireStockName
			// 
			txtBoxRetireStockName.Anchor = AnchorStyles.None;
			txtBoxRetireStockName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxRetireStockName.Location = new Point(375, 267);
			txtBoxRetireStockName.Name = "txtBoxRetireStockName";
			txtBoxRetireStockName.Size = new Size(220, 32);
			txtBoxRetireStockName.TabIndex = 12;
			// 
			// btnRetireStock
			// 
			btnRetireStock.Anchor = AnchorStyles.None;
			btnRetireStock.BackColor = Color.FromArgb(33, 150, 243);
			btnRetireStock.FlatAppearance.BorderSize = 0;
			btnRetireStock.FlatStyle = FlatStyle.Flat;
			btnRetireStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRetireStock.ForeColor = Color.White;
			btnRetireStock.Location = new Point(375, 400);
			btnRetireStock.Name = "btnRetireStock";
			btnRetireStock.Size = new Size(220, 50);
			btnRetireStock.TabIndex = 0;
			btnRetireStock.Text = "Retire Stock";
			btnRetireStock.UseVisualStyleBackColor = false;
			btnRetireStock.Click += btnRetireStock_Click;
			// 
			// frmAddOrRetireStockType
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(984, 711);
			Controls.Add(pnlRetireStock);
			Controls.Add(pnlConfirmation);
			Controls.Add(pnlAddNewStock);
			Name = "frmAddOrRetireStockType";
			Text = "AddOrRemoveStockType";
			pnlAddNewStock.ResumeLayout(false);
			pnlAddNewStock.PerformLayout();
			pnlConfirmation.ResumeLayout(false);
			pnlConfirmation.PerformLayout();
			pnlRetireStock.ResumeLayout(false);
			pnlRetireStock.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel pnlAddNewStock;
        private TextBox txtBoxNewStockName;
        private TextBox txtBoxNewMinimumLevel;
        private TextBox txtBoxNewStockPrice;
        private TextBox txtBoxNewMaximumLevel;
        private TextBox txtBoxNewStockDescription;
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
        private Panel pnlRetireStock;
        private Label lblErrorRetireStock;
        private TextBox txtBoxRetireStockName;
        private Label lblRemoveStock;
        private Button btnRetireStock;
        private TextBox txtBoxNewOrderQuantity;
        private TextBox txtBoxNewStockCheckFrequency;
        private TextBox txtBoxNewDeliveryTime;
		private Label lblStockToRetire;
		private Label lblNewDescription;
		private Label lblNewStockName;
		private Label lblNewOrderQuantity;
		private Label lblNewPrice;
		private Label lblNewMinimumLevel;
		private Label lblNewMaximumLevel;
		private Label lblNewDeliveryTime;
		private Label lblNewStockCheckFrequency;
	}
}