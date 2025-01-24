namespace Final_Project
{
	partial class frmStaffManagement
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
			pnlOrderInfo = new Panel();
			btnEditPosition = new Button();
			btnEditStaffMember = new Button();
			lblInstructions = new Label();
			lstViewOrders = new ListView();
			cHeaderStaffForename = new ColumnHeader();
			cHeaderStaffSurname = new ColumnHeader();
			cHeaderPosition = new ColumnHeader();
			cHeaderActive = new ColumnHeader();
			pnlEditStockItem = new Panel();
			btnCancelStockEdit = new Button();
			txtBoxStockCheckFrequency = new TextBox();
			txtBoxDeliveryTime = new TextBox();
			lblStockCheckFrequency = new Label();
			lblDeliveryTimeDays = new Label();
			txtBoxDescription = new TextBox();
			txtBoxMaximumLevel = new TextBox();
			txtBoxMinimumLevel = new TextBox();
			txtBoxOrderQuantity = new TextBox();
			txtBoxPrice = new TextBox();
			lblErrorStockEdit = new Label();
			txtBoxName = new TextBox();
			btnConfirmEditStockItem = new Button();
			lblDescription = new Label();
			lblPrice = new Label();
			lblMinimumLevel = new Label();
			lblOrderQuantity = new Label();
			lblMaximumLevel = new Label();
			lblName = new Label();
			pnlOrderInfo.SuspendLayout();
			pnlEditStockItem.SuspendLayout();
			SuspendLayout();
			// 
			// pnlOrderInfo
			// 
			pnlOrderInfo.BackColor = SystemColors.ScrollBar;
			pnlOrderInfo.Controls.Add(btnEditPosition);
			pnlOrderInfo.Controls.Add(btnEditStaffMember);
			pnlOrderInfo.Controls.Add(lblInstructions);
			pnlOrderInfo.Controls.Add(lstViewOrders);
			pnlOrderInfo.Dock = DockStyle.Top;
			pnlOrderInfo.Location = new Point(0, 0);
			pnlOrderInfo.Name = "pnlOrderInfo";
			pnlOrderInfo.Size = new Size(982, 680);
			pnlOrderInfo.TabIndex = 6;
			// 
			// btnEditPosition
			// 
			btnEditPosition.Anchor = AnchorStyles.Bottom;
			btnEditPosition.BackColor = Color.FromArgb(150, 12, 150);
			btnEditPosition.FlatAppearance.BorderSize = 0;
			btnEditPosition.FlatStyle = FlatStyle.Flat;
			btnEditPosition.Font = new Font("Segoe UI", 14F);
			btnEditPosition.ForeColor = SystemColors.Control;
			btnEditPosition.Location = new Point(551, 604);
			btnEditPosition.Name = "btnEditPosition";
			btnEditPosition.Size = new Size(220, 50);
			btnEditPosition.TabIndex = 17;
			btnEditPosition.Text = "Edit Staff Position";
			btnEditPosition.UseVisualStyleBackColor = false;
			// 
			// btnEditStaffMember
			// 
			btnEditStaffMember.Anchor = AnchorStyles.Bottom;
			btnEditStaffMember.BackColor = Color.FromArgb(150, 12, 150);
			btnEditStaffMember.FlatAppearance.BorderSize = 0;
			btnEditStaffMember.FlatStyle = FlatStyle.Flat;
			btnEditStaffMember.Font = new Font("Segoe UI", 14F);
			btnEditStaffMember.ForeColor = SystemColors.Control;
			btnEditStaffMember.Location = new Point(211, 604);
			btnEditStaffMember.Name = "btnEditStaffMember";
			btnEditStaffMember.Size = new Size(220, 50);
			btnEditStaffMember.TabIndex = 16;
			btnEditStaffMember.Text = "Edit Staff Member";
			btnEditStaffMember.UseVisualStyleBackColor = false;
			// 
			// lblInstructions
			// 
			lblInstructions.Anchor = AnchorStyles.Bottom;
			lblInstructions.AutoSize = true;
			lblInstructions.FlatStyle = FlatStyle.Flat;
			lblInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructions.ForeColor = SystemColors.ControlText;
			lblInstructions.Location = new Point(273, 558);
			lblInstructions.Name = "lblInstructions";
			lblInstructions.Size = new Size(436, 25);
			lblInstructions.TabIndex = 15;
			lblInstructions.Text = "Select a staff member to manage their information";
			// 
			// lstViewOrders
			// 
			lstViewOrders.Anchor = AnchorStyles.Top;
			lstViewOrders.BackColor = Color.FromArgb(200, 12, 200);
			lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderStaffForename, cHeaderStaffSurname, cHeaderPosition, cHeaderActive });
			lstViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrders.ForeColor = Color.Black;
			lstViewOrders.FullRowSelect = true;
			lstViewOrders.GridLines = true;
			lstViewOrders.Location = new Point(16, 27);
			lstViewOrders.Name = "lstViewOrders";
			lstViewOrders.Size = new Size(942, 518);
			lstViewOrders.TabIndex = 0;
			lstViewOrders.UseCompatibleStateImageBehavior = false;
			lstViewOrders.View = View.Details;
			// 
			// cHeaderStaffForename
			// 
			cHeaderStaffForename.Text = "Forename";
			cHeaderStaffForename.Width = 250;
			// 
			// cHeaderStaffSurname
			// 
			cHeaderStaffSurname.Text = "Surname";
			cHeaderStaffSurname.Width = 250;
			// 
			// cHeaderPosition
			// 
			cHeaderPosition.Text = "Position";
			cHeaderPosition.Width = 250;
			// 
			// cHeaderActive
			// 
			cHeaderActive.Text = "Active";
			cHeaderActive.Width = 150;
			// 
			// pnlEditStockItem
			// 
			pnlEditStockItem.BackColor = Color.FromArgb(200, 200, 200);
			pnlEditStockItem.Controls.Add(btnCancelStockEdit);
			pnlEditStockItem.Controls.Add(txtBoxStockCheckFrequency);
			pnlEditStockItem.Controls.Add(txtBoxDeliveryTime);
			pnlEditStockItem.Controls.Add(lblStockCheckFrequency);
			pnlEditStockItem.Controls.Add(lblDeliveryTimeDays);
			pnlEditStockItem.Controls.Add(txtBoxDescription);
			pnlEditStockItem.Controls.Add(txtBoxMaximumLevel);
			pnlEditStockItem.Controls.Add(txtBoxMinimumLevel);
			pnlEditStockItem.Controls.Add(txtBoxOrderQuantity);
			pnlEditStockItem.Controls.Add(txtBoxPrice);
			pnlEditStockItem.Controls.Add(lblErrorStockEdit);
			pnlEditStockItem.Controls.Add(txtBoxName);
			pnlEditStockItem.Controls.Add(btnConfirmEditStockItem);
			pnlEditStockItem.Controls.Add(lblDescription);
			pnlEditStockItem.Controls.Add(lblPrice);
			pnlEditStockItem.Controls.Add(lblMinimumLevel);
			pnlEditStockItem.Controls.Add(lblOrderQuantity);
			pnlEditStockItem.Controls.Add(lblMaximumLevel);
			pnlEditStockItem.Controls.Add(lblName);
			pnlEditStockItem.Dock = DockStyle.Top;
			pnlEditStockItem.Location = new Point(0, 680);
			pnlEditStockItem.Name = "pnlEditStockItem";
			pnlEditStockItem.Size = new Size(982, 680);
			pnlEditStockItem.TabIndex = 7;
			// 
			// btnCancelStockEdit
			// 
			btnCancelStockEdit.Anchor = AnchorStyles.None;
			btnCancelStockEdit.BackColor = Color.FromArgb(33, 150, 243);
			btnCancelStockEdit.FlatAppearance.BorderSize = 0;
			btnCancelStockEdit.FlatStyle = FlatStyle.Flat;
			btnCancelStockEdit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCancelStockEdit.ForeColor = Color.White;
			btnCancelStockEdit.Location = new Point(236, 513);
			btnCancelStockEdit.Name = "btnCancelStockEdit";
			btnCancelStockEdit.Size = new Size(220, 50);
			btnCancelStockEdit.TabIndex = 9;
			btnCancelStockEdit.Text = "Cancel";
			btnCancelStockEdit.UseVisualStyleBackColor = false;
			// 
			// txtBoxStockCheckFrequency
			// 
			txtBoxStockCheckFrequency.Anchor = AnchorStyles.None;
			txtBoxStockCheckFrequency.BorderStyle = BorderStyle.None;
			txtBoxStockCheckFrequency.Font = new Font("Segoe UI", 14F);
			txtBoxStockCheckFrequency.Location = new Point(552, 337);
			txtBoxStockCheckFrequency.Name = "txtBoxStockCheckFrequency";
			txtBoxStockCheckFrequency.Size = new Size(220, 25);
			txtBoxStockCheckFrequency.TabIndex = 7;
			// 
			// txtBoxDeliveryTime
			// 
			txtBoxDeliveryTime.Anchor = AnchorStyles.None;
			txtBoxDeliveryTime.BorderStyle = BorderStyle.None;
			txtBoxDeliveryTime.Font = new Font("Segoe UI", 14F);
			txtBoxDeliveryTime.Location = new Point(236, 337);
			txtBoxDeliveryTime.Name = "txtBoxDeliveryTime";
			txtBoxDeliveryTime.Size = new Size(220, 25);
			txtBoxDeliveryTime.TabIndex = 6;
			// 
			// lblStockCheckFrequency
			// 
			lblStockCheckFrequency.Anchor = AnchorStyles.None;
			lblStockCheckFrequency.AutoSize = true;
			lblStockCheckFrequency.Font = new Font("Segoe UI", 14F);
			lblStockCheckFrequency.ForeColor = Color.Black;
			lblStockCheckFrequency.Location = new Point(552, 309);
			lblStockCheckFrequency.Name = "lblStockCheckFrequency";
			lblStockCheckFrequency.Size = new Size(159, 25);
			lblStockCheckFrequency.TabIndex = 33;
			lblStockCheckFrequency.Text = "Check Frequency:";
			// 
			// lblDeliveryTimeDays
			// 
			lblDeliveryTimeDays.Anchor = AnchorStyles.None;
			lblDeliveryTimeDays.AutoSize = true;
			lblDeliveryTimeDays.Font = new Font("Segoe UI", 14F);
			lblDeliveryTimeDays.ForeColor = Color.Black;
			lblDeliveryTimeDays.Location = new Point(236, 309);
			lblDeliveryTimeDays.Name = "lblDeliveryTimeDays";
			lblDeliveryTimeDays.Size = new Size(130, 25);
			lblDeliveryTimeDays.TabIndex = 32;
			lblDeliveryTimeDays.Text = "Delivery Time:";
			// 
			// txtBoxDescription
			// 
			txtBoxDescription.Anchor = AnchorStyles.None;
			txtBoxDescription.BorderStyle = BorderStyle.None;
			txtBoxDescription.Font = new Font("Segoe UI", 14F);
			txtBoxDescription.Location = new Point(552, 145);
			txtBoxDescription.Name = "txtBoxDescription";
			txtBoxDescription.Size = new Size(220, 25);
			txtBoxDescription.TabIndex = 1;
			// 
			// txtBoxMaximumLevel
			// 
			txtBoxMaximumLevel.Anchor = AnchorStyles.None;
			txtBoxMaximumLevel.BorderStyle = BorderStyle.None;
			txtBoxMaximumLevel.Font = new Font("Segoe UI", 14F);
			txtBoxMaximumLevel.Location = new Point(552, 209);
			txtBoxMaximumLevel.Name = "txtBoxMaximumLevel";
			txtBoxMaximumLevel.Size = new Size(220, 25);
			txtBoxMaximumLevel.TabIndex = 3;
			// 
			// txtBoxMinimumLevel
			// 
			txtBoxMinimumLevel.Anchor = AnchorStyles.None;
			txtBoxMinimumLevel.BorderStyle = BorderStyle.None;
			txtBoxMinimumLevel.Font = new Font("Segoe UI", 14F);
			txtBoxMinimumLevel.Location = new Point(236, 209);
			txtBoxMinimumLevel.Name = "txtBoxMinimumLevel";
			txtBoxMinimumLevel.Size = new Size(220, 25);
			txtBoxMinimumLevel.TabIndex = 2;
			// 
			// txtBoxOrderQuantity
			// 
			txtBoxOrderQuantity.Anchor = AnchorStyles.None;
			txtBoxOrderQuantity.BorderStyle = BorderStyle.None;
			txtBoxOrderQuantity.Font = new Font("Segoe UI", 14F);
			txtBoxOrderQuantity.Location = new Point(236, 273);
			txtBoxOrderQuantity.Name = "txtBoxOrderQuantity";
			txtBoxOrderQuantity.Size = new Size(220, 25);
			txtBoxOrderQuantity.TabIndex = 4;
			// 
			// txtBoxPrice
			// 
			txtBoxPrice.Anchor = AnchorStyles.None;
			txtBoxPrice.BorderStyle = BorderStyle.None;
			txtBoxPrice.Font = new Font("Segoe UI", 14F);
			txtBoxPrice.Location = new Point(552, 273);
			txtBoxPrice.Name = "txtBoxPrice";
			txtBoxPrice.Size = new Size(220, 25);
			txtBoxPrice.TabIndex = 5;
			// 
			// lblErrorStockEdit
			// 
			lblErrorStockEdit.Anchor = AnchorStyles.None;
			lblErrorStockEdit.BackColor = Color.FromArgb(255, 209, 209);
			lblErrorStockEdit.BorderStyle = BorderStyle.FixedSingle;
			lblErrorStockEdit.FlatStyle = FlatStyle.Flat;
			lblErrorStockEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblErrorStockEdit.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorStockEdit.Location = new Point(128, 396);
			lblErrorStockEdit.Name = "lblErrorStockEdit";
			lblErrorStockEdit.Size = new Size(726, 83);
			lblErrorStockEdit.TabIndex = 17;
			lblErrorStockEdit.Text = "Error message goes here";
			lblErrorStockEdit.TextAlign = ContentAlignment.MiddleCenter;
			lblErrorStockEdit.Visible = false;
			// 
			// txtBoxName
			// 
			txtBoxName.Anchor = AnchorStyles.None;
			txtBoxName.BorderStyle = BorderStyle.None;
			txtBoxName.Font = new Font("Segoe UI", 14F);
			txtBoxName.Location = new Point(236, 145);
			txtBoxName.Name = "txtBoxName";
			txtBoxName.Size = new Size(220, 25);
			txtBoxName.TabIndex = 0;
			// 
			// btnConfirmEditStockItem
			// 
			btnConfirmEditStockItem.Anchor = AnchorStyles.None;
			btnConfirmEditStockItem.BackColor = Color.FromArgb(33, 150, 243);
			btnConfirmEditStockItem.FlatAppearance.BorderSize = 0;
			btnConfirmEditStockItem.FlatStyle = FlatStyle.Flat;
			btnConfirmEditStockItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnConfirmEditStockItem.ForeColor = Color.White;
			btnConfirmEditStockItem.Location = new Point(552, 513);
			btnConfirmEditStockItem.Name = "btnConfirmEditStockItem";
			btnConfirmEditStockItem.Size = new Size(220, 50);
			btnConfirmEditStockItem.TabIndex = 8;
			btnConfirmEditStockItem.Text = "Confirm Changes";
			btnConfirmEditStockItem.UseVisualStyleBackColor = false;
			// 
			// lblDescription
			// 
			lblDescription.Anchor = AnchorStyles.None;
			lblDescription.AutoSize = true;
			lblDescription.Font = new Font("Segoe UI", 14F);
			lblDescription.ForeColor = Color.Black;
			lblDescription.Location = new Point(552, 117);
			lblDescription.Name = "lblDescription";
			lblDescription.Size = new Size(112, 25);
			lblDescription.TabIndex = 29;
			lblDescription.Text = "Description:";
			// 
			// lblPrice
			// 
			lblPrice.Anchor = AnchorStyles.None;
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Segoe UI", 14F);
			lblPrice.ForeColor = Color.Black;
			lblPrice.Location = new Point(552, 244);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(58, 25);
			lblPrice.TabIndex = 28;
			lblPrice.Text = "Price:";
			// 
			// lblMinimumLevel
			// 
			lblMinimumLevel.Anchor = AnchorStyles.None;
			lblMinimumLevel.AutoSize = true;
			lblMinimumLevel.Font = new Font("Segoe UI", 14F);
			lblMinimumLevel.ForeColor = Color.Black;
			lblMinimumLevel.Location = new Point(236, 181);
			lblMinimumLevel.Name = "lblMinimumLevel";
			lblMinimumLevel.Size = new Size(145, 25);
			lblMinimumLevel.TabIndex = 27;
			lblMinimumLevel.Text = "Minimum Level:";
			// 
			// lblOrderQuantity
			// 
			lblOrderQuantity.Anchor = AnchorStyles.None;
			lblOrderQuantity.AutoSize = true;
			lblOrderQuantity.Font = new Font("Segoe UI", 14F);
			lblOrderQuantity.ForeColor = Color.Black;
			lblOrderQuantity.Location = new Point(236, 244);
			lblOrderQuantity.Name = "lblOrderQuantity";
			lblOrderQuantity.Size = new Size(142, 25);
			lblOrderQuantity.TabIndex = 26;
			lblOrderQuantity.Text = "Order Quantity:";
			// 
			// lblMaximumLevel
			// 
			lblMaximumLevel.Anchor = AnchorStyles.None;
			lblMaximumLevel.AutoSize = true;
			lblMaximumLevel.Font = new Font("Segoe UI", 14F);
			lblMaximumLevel.ForeColor = Color.Black;
			lblMaximumLevel.Location = new Point(552, 182);
			lblMaximumLevel.Name = "lblMaximumLevel";
			lblMaximumLevel.Size = new Size(148, 25);
			lblMaximumLevel.TabIndex = 25;
			lblMaximumLevel.Text = "Maximum Level:";
			// 
			// lblName
			// 
			lblName.Anchor = AnchorStyles.None;
			lblName.AutoSize = true;
			lblName.Font = new Font("Segoe UI", 14F);
			lblName.ForeColor = Color.Black;
			lblName.Location = new Point(236, 117);
			lblName.Name = "lblName";
			lblName.Size = new Size(66, 25);
			lblName.TabIndex = 24;
			lblName.Text = "Name:";
			// 
			// frmStaffManagement
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(1000, 680);
			Controls.Add(pnlEditStockItem);
			Controls.Add(pnlOrderInfo);
			Name = "frmStaffManagement";
			Text = "frmStaffManagement";
			pnlOrderInfo.ResumeLayout(false);
			pnlOrderInfo.PerformLayout();
			pnlEditStockItem.ResumeLayout(false);
			pnlEditStockItem.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlOrderInfo;
		private Button btnEditPosition;
		private Button btnEditStaffMember;
		private Label lblInstructions;
		private ListView lstViewOrders;
		private ColumnHeader cHeaderStaffForename;
		private ColumnHeader cHeaderStaffSurname;
		private ColumnHeader cHeaderPosition;
		private Panel pnlEditStockItem;
		private Button btnCancelStockEdit;
		private TextBox txtBoxStockCheckFrequency;
		private TextBox txtBoxDeliveryTime;
		private Label lblStockCheckFrequency;
		private Label lblDeliveryTimeDays;
		private TextBox txtBoxDescription;
		private TextBox txtBoxMaximumLevel;
		private TextBox txtBoxMinimumLevel;
		private TextBox txtBoxOrderQuantity;
		private TextBox txtBoxPrice;
		private Label lblErrorStockEdit;
		private TextBox txtBoxName;
		private Button btnConfirmEditStockItem;
		private Label lblDescription;
		private Label lblPrice;
		private Label lblMinimumLevel;
		private Label lblOrderQuantity;
		private Label lblMaximumLevel;
		private Label lblName;
		private ColumnHeader cHeaderActive;
	}
}