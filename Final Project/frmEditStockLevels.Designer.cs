namespace Final_Project
{
    partial class frmEditStockLevels
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
			pnlEditStockLevels = new Panel();
			lblAmountTo = new Label();
			lblCurrentStockLevel = new Label();
			lblStockLevelToEdit = new Label();
			btnCancel = new Button();
			lblError = new Label();
			txtBoxAmountOfStockToChange = new TextBox();
			btnRemoveStock = new Button();
			btnAddStock = new Button();
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
			pnlStockList = new Panel();
			lstViewStock = new ListView();
			cHeaderStockName = new ColumnHeader();
			cHeaderStockQuantity = new ColumnHeader();
			cHeaderLastCheckedDate = new ColumnHeader();
			cHeaderCheckedBy = new ColumnHeader();
			pnlOptionButtons = new Panel();
			lblInstructions = new Label();
			btnEditStock = new Button();
			btnRemoveFromStock = new Button();
			btnAddToStock = new Button();
			pnlEditStockLevels.SuspendLayout();
			pnlEditStockItem.SuspendLayout();
			pnlStockList.SuspendLayout();
			pnlOptionButtons.SuspendLayout();
			SuspendLayout();
			// 
			// pnlEditStockLevels
			// 
			pnlEditStockLevels.BackColor = Color.FromArgb(200, 200, 200);
			pnlEditStockLevels.Controls.Add(lblAmountTo);
			pnlEditStockLevels.Controls.Add(lblCurrentStockLevel);
			pnlEditStockLevels.Controls.Add(lblStockLevelToEdit);
			pnlEditStockLevels.Controls.Add(btnCancel);
			pnlEditStockLevels.Controls.Add(lblError);
			pnlEditStockLevels.Controls.Add(txtBoxAmountOfStockToChange);
			pnlEditStockLevels.Controls.Add(btnRemoveStock);
			pnlEditStockLevels.Controls.Add(btnAddStock);
			pnlEditStockLevels.Dock = DockStyle.Top;
			pnlEditStockLevels.Location = new Point(0, 0);
			pnlEditStockLevels.Name = "pnlEditStockLevels";
			pnlEditStockLevels.Size = new Size(966, 680);
			pnlEditStockLevels.TabIndex = 1;
			// 
			// lblAmountTo
			// 
			lblAmountTo.Anchor = AnchorStyles.None;
			lblAmountTo.AutoSize = true;
			lblAmountTo.Font = new Font("Segoe UI", 14F);
			lblAmountTo.ForeColor = Color.Black;
			lblAmountTo.Location = new Point(373, 242);
			lblAmountTo.Name = "lblAmountTo";
			lblAmountTo.Size = new Size(132, 25);
			lblAmountTo.TabIndex = 25;
			lblAmountTo.Text = "Enter Amount:";
			// 
			// lblCurrentStockLevel
			// 
			lblCurrentStockLevel.Anchor = AnchorStyles.None;
			lblCurrentStockLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCurrentStockLevel.ForeColor = Color.Black;
			lblCurrentStockLevel.Location = new Point(145, 160);
			lblCurrentStockLevel.Name = "lblCurrentStockLevel";
			lblCurrentStockLevel.Size = new Size(676, 40);
			lblCurrentStockLevel.TabIndex = 18;
			lblCurrentStockLevel.Text = "Stock level goes here";
			lblCurrentStockLevel.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblStockLevelToEdit
			// 
			lblStockLevelToEdit.Anchor = AnchorStyles.None;
			lblStockLevelToEdit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblStockLevelToEdit.ForeColor = Color.Black;
			lblStockLevelToEdit.Location = new Point(145, 122);
			lblStockLevelToEdit.Name = "lblStockLevelToEdit";
			lblStockLevelToEdit.Size = new Size(676, 40);
			lblStockLevelToEdit.TabIndex = 17;
			lblStockLevelToEdit.Text = "Stock name goes here";
			lblStockLevelToEdit.TextAlign = ContentAlignment.TopCenter;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.None;
			btnCancel.BackColor = Color.FromArgb(33, 150, 243);
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCancel.ForeColor = Color.White;
			btnCancel.Location = new Point(227, 415);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(220, 50);
			btnCancel.TabIndex = 16;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnBack_Click;
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.BackColor = Color.FromArgb(255, 219, 219);
			lblError.BorderStyle = BorderStyle.FixedSingle;
			lblError.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblError.ForeColor = Color.FromArgb(250, 0, 0);
			lblError.Location = new Point(151, 316);
			lblError.Name = "lblError";
			lblError.Size = new Size(664, 78);
			lblError.TabIndex = 15;
			lblError.Text = "Error message goes here";
			lblError.TextAlign = ContentAlignment.MiddleCenter;
			lblError.Visible = false;
			// 
			// txtBoxAmountOfStockToChange
			// 
			txtBoxAmountOfStockToChange.Anchor = AnchorStyles.None;
			txtBoxAmountOfStockToChange.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			txtBoxAmountOfStockToChange.Location = new Point(373, 270);
			txtBoxAmountOfStockToChange.Name = "txtBoxAmountOfStockToChange";
			txtBoxAmountOfStockToChange.Size = new Size(220, 32);
			txtBoxAmountOfStockToChange.TabIndex = 14;
			// 
			// btnRemoveStock
			// 
			btnRemoveStock.Anchor = AnchorStyles.None;
			btnRemoveStock.BackColor = Color.FromArgb(33, 150, 243);
			btnRemoveStock.FlatAppearance.BorderSize = 0;
			btnRemoveStock.FlatStyle = FlatStyle.Flat;
			btnRemoveStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRemoveStock.ForeColor = Color.White;
			btnRemoveStock.Location = new Point(520, 415);
			btnRemoveStock.Name = "btnRemoveStock";
			btnRemoveStock.Size = new Size(220, 50);
			btnRemoveStock.TabIndex = 13;
			btnRemoveStock.Text = "Remove From Stock";
			btnRemoveStock.UseVisualStyleBackColor = false;
			btnRemoveStock.Click += btnRemoveStock_Click;
			// 
			// btnAddStock
			// 
			btnAddStock.Anchor = AnchorStyles.None;
			btnAddStock.BackColor = Color.FromArgb(33, 150, 243);
			btnAddStock.FlatAppearance.BorderSize = 0;
			btnAddStock.FlatStyle = FlatStyle.Flat;
			btnAddStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddStock.ForeColor = Color.White;
			btnAddStock.Location = new Point(520, 415);
			btnAddStock.Name = "btnAddStock";
			btnAddStock.Size = new Size(220, 50);
			btnAddStock.TabIndex = 11;
			btnAddStock.Text = "Add To Stock";
			btnAddStock.UseVisualStyleBackColor = false;
			btnAddStock.Click += btnAddStock_Click;
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
			pnlEditStockItem.Size = new Size(966, 680);
			pnlEditStockItem.TabIndex = 2;
			// 
			// btnCancelStockEdit
			// 
			btnCancelStockEdit.Anchor = AnchorStyles.None;
			btnCancelStockEdit.BackColor = Color.FromArgb(33, 150, 243);
			btnCancelStockEdit.FlatAppearance.BorderSize = 0;
			btnCancelStockEdit.FlatStyle = FlatStyle.Flat;
			btnCancelStockEdit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCancelStockEdit.ForeColor = Color.White;
			btnCancelStockEdit.Location = new Point(242, 521);
			btnCancelStockEdit.Name = "btnCancelStockEdit";
			btnCancelStockEdit.Size = new Size(220, 50);
			btnCancelStockEdit.TabIndex = 9;
			btnCancelStockEdit.Text = "Cancel";
			btnCancelStockEdit.UseVisualStyleBackColor = false;
			btnCancelStockEdit.Click += btnCancelStockEdit_Click;
			// 
			// txtBoxStockCheckFrequency
			// 
			txtBoxStockCheckFrequency.Anchor = AnchorStyles.None;
			txtBoxStockCheckFrequency.BorderStyle = BorderStyle.None;
			txtBoxStockCheckFrequency.Font = new Font("Segoe UI", 14F);
			txtBoxStockCheckFrequency.Location = new Point(558, 345);
			txtBoxStockCheckFrequency.Name = "txtBoxStockCheckFrequency";
			txtBoxStockCheckFrequency.Size = new Size(220, 25);
			txtBoxStockCheckFrequency.TabIndex = 7;
			// 
			// txtBoxDeliveryTime
			// 
			txtBoxDeliveryTime.Anchor = AnchorStyles.None;
			txtBoxDeliveryTime.BorderStyle = BorderStyle.None;
			txtBoxDeliveryTime.Font = new Font("Segoe UI", 14F);
			txtBoxDeliveryTime.Location = new Point(242, 345);
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
			lblStockCheckFrequency.Location = new Point(558, 317);
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
			lblDeliveryTimeDays.Location = new Point(242, 317);
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
			txtBoxDescription.Location = new Point(558, 153);
			txtBoxDescription.Name = "txtBoxDescription";
			txtBoxDescription.Size = new Size(220, 25);
			txtBoxDescription.TabIndex = 1;
			// 
			// txtBoxMaximumLevel
			// 
			txtBoxMaximumLevel.Anchor = AnchorStyles.None;
			txtBoxMaximumLevel.BorderStyle = BorderStyle.None;
			txtBoxMaximumLevel.Font = new Font("Segoe UI", 14F);
			txtBoxMaximumLevel.Location = new Point(558, 217);
			txtBoxMaximumLevel.Name = "txtBoxMaximumLevel";
			txtBoxMaximumLevel.Size = new Size(220, 25);
			txtBoxMaximumLevel.TabIndex = 3;
			// 
			// txtBoxMinimumLevel
			// 
			txtBoxMinimumLevel.Anchor = AnchorStyles.None;
			txtBoxMinimumLevel.BorderStyle = BorderStyle.None;
			txtBoxMinimumLevel.Font = new Font("Segoe UI", 14F);
			txtBoxMinimumLevel.Location = new Point(242, 217);
			txtBoxMinimumLevel.Name = "txtBoxMinimumLevel";
			txtBoxMinimumLevel.Size = new Size(220, 25);
			txtBoxMinimumLevel.TabIndex = 2;
			// 
			// txtBoxOrderQuantity
			// 
			txtBoxOrderQuantity.Anchor = AnchorStyles.None;
			txtBoxOrderQuantity.BorderStyle = BorderStyle.None;
			txtBoxOrderQuantity.Font = new Font("Segoe UI", 14F);
			txtBoxOrderQuantity.Location = new Point(242, 281);
			txtBoxOrderQuantity.Name = "txtBoxOrderQuantity";
			txtBoxOrderQuantity.Size = new Size(220, 25);
			txtBoxOrderQuantity.TabIndex = 4;
			// 
			// txtBoxPrice
			// 
			txtBoxPrice.Anchor = AnchorStyles.None;
			txtBoxPrice.BorderStyle = BorderStyle.None;
			txtBoxPrice.Font = new Font("Segoe UI", 14F);
			txtBoxPrice.Location = new Point(558, 281);
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
			lblErrorStockEdit.Location = new Point(134, 404);
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
			txtBoxName.Location = new Point(242, 153);
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
			btnConfirmEditStockItem.Location = new Point(558, 521);
			btnConfirmEditStockItem.Name = "btnConfirmEditStockItem";
			btnConfirmEditStockItem.Size = new Size(220, 50);
			btnConfirmEditStockItem.TabIndex = 8;
			btnConfirmEditStockItem.Text = "Confirm Changes";
			btnConfirmEditStockItem.UseVisualStyleBackColor = false;
			btnConfirmEditStockItem.Click += btnEditStockItem_Click;
			// 
			// lblDescription
			// 
			lblDescription.Anchor = AnchorStyles.None;
			lblDescription.AutoSize = true;
			lblDescription.Font = new Font("Segoe UI", 14F);
			lblDescription.ForeColor = Color.Black;
			lblDescription.Location = new Point(558, 125);
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
			lblPrice.Location = new Point(558, 252);
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
			lblMinimumLevel.Location = new Point(242, 189);
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
			lblOrderQuantity.Location = new Point(242, 252);
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
			lblMaximumLevel.Location = new Point(558, 190);
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
			lblName.Location = new Point(242, 125);
			lblName.Name = "lblName";
			lblName.Size = new Size(66, 25);
			lblName.TabIndex = 24;
			lblName.Text = "Name:";
			// 
			// pnlStockList
			// 
			pnlStockList.BackColor = SystemColors.ScrollBar;
			pnlStockList.Controls.Add(lstViewStock);
			pnlStockList.Dock = DockStyle.Top;
			pnlStockList.Location = new Point(0, 1360);
			pnlStockList.Name = "pnlStockList";
			pnlStockList.Size = new Size(966, 580);
			pnlStockList.TabIndex = 12;
			pnlStockList.Click += pnlStockList_Click;
			// 
			// lstViewStock
			// 
			lstViewStock.BackColor = Color.FromArgb(149, 204, 249);
			lstViewStock.BackgroundImageTiled = true;
			lstViewStock.Columns.AddRange(new ColumnHeader[] { cHeaderStockName, cHeaderStockQuantity, cHeaderLastCheckedDate, cHeaderCheckedBy });
			lstViewStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewStock.ForeColor = Color.Black;
			lstViewStock.FullRowSelect = true;
			lstViewStock.GridLines = true;
			lstViewStock.Location = new Point(36, 27);
			lstViewStock.Margin = new Padding(3, 2, 3, 2);
			lstViewStock.Name = "lstViewStock";
			lstViewStock.Size = new Size(892, 522);
			lstViewStock.TabIndex = 13;
			lstViewStock.UseCompatibleStateImageBehavior = false;
			lstViewStock.View = View.Details;
			lstViewStock.ItemSelectionChanged += lstViewStock_ItemSelectionChanged;
			// 
			// cHeaderStockName
			// 
			cHeaderStockName.Text = "Stock";
			cHeaderStockName.Width = 250;
			// 
			// cHeaderStockQuantity
			// 
			cHeaderStockQuantity.Text = "Quantity";
			cHeaderStockQuantity.Width = 120;
			// 
			// cHeaderLastCheckedDate
			// 
			cHeaderLastCheckedDate.Text = "Last Checked";
			cHeaderLastCheckedDate.Width = 160;
			// 
			// cHeaderCheckedBy
			// 
			cHeaderCheckedBy.Text = "Checked By";
			cHeaderCheckedBy.Width = 215;
			// 
			// pnlOptionButtons
			// 
			pnlOptionButtons.BackColor = SystemColors.ScrollBar;
			pnlOptionButtons.Controls.Add(lblInstructions);
			pnlOptionButtons.Controls.Add(btnEditStock);
			pnlOptionButtons.Controls.Add(btnRemoveFromStock);
			pnlOptionButtons.Controls.Add(btnAddToStock);
			pnlOptionButtons.Dock = DockStyle.Bottom;
			pnlOptionButtons.Location = new Point(0, 1940);
			pnlOptionButtons.Name = "pnlOptionButtons";
			pnlOptionButtons.Size = new Size(966, 100);
			pnlOptionButtons.TabIndex = 13;
			pnlOptionButtons.Click += pnlOptionButtons_Click;
			// 
			// lblInstructions
			// 
			lblInstructions.AutoSize = true;
			lblInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructions.Location = new Point(37, 6);
			lblInstructions.Name = "lblInstructions";
			lblInstructions.Size = new Size(434, 25);
			lblInstructions.TabIndex = 14;
			lblInstructions.Text = "Select an item to manage its level and information";
			// 
			// btnEditStock
			// 
			btnEditStock.BackColor = Color.FromArgb(33, 150, 243);
			btnEditStock.FlatAppearance.BorderSize = 0;
			btnEditStock.FlatStyle = FlatStyle.Flat;
			btnEditStock.Font = new Font("Segoe UI", 14F);
			btnEditStock.ForeColor = SystemColors.Control;
			btnEditStock.Location = new Point(120, 39);
			btnEditStock.Name = "btnEditStock";
			btnEditStock.Size = new Size(220, 50);
			btnEditStock.TabIndex = 8;
			btnEditStock.Text = "Edit Stock Item";
			btnEditStock.UseVisualStyleBackColor = false;
			btnEditStock.Click += btnEditStock_Click;
			// 
			// btnRemoveFromStock
			// 
			btnRemoveFromStock.BackColor = Color.FromArgb(33, 150, 243);
			btnRemoveFromStock.FlatAppearance.BorderSize = 0;
			btnRemoveFromStock.FlatStyle = FlatStyle.Flat;
			btnRemoveFromStock.Font = new Font("Segoe UI", 14F);
			btnRemoveFromStock.ForeColor = SystemColors.Control;
			btnRemoveFromStock.Location = new Point(626, 39);
			btnRemoveFromStock.Name = "btnRemoveFromStock";
			btnRemoveFromStock.Size = new Size(220, 50);
			btnRemoveFromStock.TabIndex = 7;
			btnRemoveFromStock.Text = "Remove From Stock";
			btnRemoveFromStock.UseVisualStyleBackColor = false;
			btnRemoveFromStock.Click += btnRemoveFromStock_Click;
			// 
			// btnAddToStock
			// 
			btnAddToStock.BackColor = Color.FromArgb(33, 150, 243);
			btnAddToStock.FlatAppearance.BorderSize = 0;
			btnAddToStock.FlatStyle = FlatStyle.Flat;
			btnAddToStock.Font = new Font("Segoe UI", 14F);
			btnAddToStock.ForeColor = SystemColors.Control;
			btnAddToStock.Location = new Point(373, 39);
			btnAddToStock.Name = "btnAddToStock";
			btnAddToStock.Size = new Size(220, 50);
			btnAddToStock.TabIndex = 5;
			btnAddToStock.Text = "Add To Stock";
			btnAddToStock.UseVisualStyleBackColor = false;
			btnAddToStock.Click += btnAddToStock_Click;
			// 
			// frmEditStockLevels
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			BackColor = Color.White;
			ClientSize = new Size(984, 681);
			Controls.Add(pnlOptionButtons);
			Controls.Add(pnlStockList);
			Controls.Add(pnlEditStockItem);
			Controls.Add(pnlEditStockLevels);
			Margin = new Padding(3, 2, 3, 2);
			MaximizeBox = false;
			Name = "frmEditStockLevels";
			Text = "ViewStock";
			Resize += frmEditStockLevels_Resize;
			pnlEditStockLevels.ResumeLayout(false);
			pnlEditStockLevels.PerformLayout();
			pnlEditStockItem.ResumeLayout(false);
			pnlEditStockItem.PerformLayout();
			pnlStockList.ResumeLayout(false);
			pnlOptionButtons.ResumeLayout(false);
			pnlOptionButtons.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel pnlEditStockLevels;
        private Label lblStockLevelToEdit;
        private Button btnCancel;
        private Label lblError;
        private TextBox txtBoxAmountOfStockToChange;
        private Button btnRemoveStock;
        private Button btnAddStock;
        private Label lblCurrentStockLevel;
        private Panel pnlEditStockItem;
        private Label lblErrorStockEdit;
        private TextBox txtBoxName;
        private Button btnConfirmEditStockItem;
        private Label lblMaximumLevel;
        private Label lblName;
        private TextBox txtBoxDescription;
        private TextBox txtBoxMaximumLevel;
        private TextBox txtBoxMinimumLevel;
        private TextBox txtBoxOrderQuantity;
        private TextBox txtBoxPrice;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblMinimumLevel;
        private Label lblOrderQuantity;
        private TextBox txtBoxStockCheckFrequency;
        private TextBox txtBoxDeliveryTime;
        private Label lblStockCheckFrequency;
        private Label lblDeliveryTimeDays;
        private Button btnCancelStockEdit;
		private Panel pnlStockList;
		private ListView lstViewStock;
		private ColumnHeader cHeaderStockName;
		private ColumnHeader cHeaderStockQuantity;
		private ColumnHeader cHeaderLastCheckedDate;
		private ColumnHeader cHeaderCheckedBy;
		private Panel pnlOptionButtons;
		private Label lblInstructions;
		private Button btnEditStock;
		private Button btnRemoveFromStock;
		private Button btnAddToStock;
		private Label lblAmountTo;
	}
}