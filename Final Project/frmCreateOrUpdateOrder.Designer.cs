namespace Final_Project
{
    partial class frmCreateOrUpdateOrder
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
			components = new System.ComponentModel.Container();
			pnlAddItemToOrder = new Panel();
			lblDeliveryTime = new Label();
			lblWarning = new Label();
			lblOrderNumberItem = new Label();
			lblCurrentStockLevel = new Label();
			nUDQuantity = new NumericUpDown();
			btnAddToOrder = new Button();
			btnCancel = new Button();
			lblQuantity = new Label();
			lblTitle = new Label();
			cBoxStock = new ComboBox();
			lblStockItem = new Label();
			pnlViewOrderItems = new Panel();
			pnlOrderConfirmation = new Panel();
			lblConfirmation = new Label();
			lblFinalOrderTotal = new Label();
			lblDeliveringTo = new Label();
			btnConfirmAndPlace = new Button();
			btnReturnToEditScreen = new Button();
			btnCancelOrder = new Button();
			btnReturn = new Button();
			pnlOrderNoToStat = new Panel();
			btnPlaceOrder = new Button();
			lblInstructions = new Label();
			btnRemoveFromOrder = new Button();
			btnAddAnItemToOrder = new Button();
			lblOrderNumberOrder = new Label();
			btnSaveAsDraft = new Button();
			lblOrderStatus = new Label();
			lblOrderTotal = new Label();
			pnlOrderInfo = new Panel();
			lstViewOrderItems = new ListView();
			cHeaderStockItem = new ColumnHeader();
			toolTipCreateOrUpdateOrder = new ToolTip(components);
			cHeaderQuantity = new ColumnHeader();
			cHeaderRecommendedQty = new ColumnHeader();
			cHeaderPricePerUnit = new ColumnHeader();
			cHeaderTotalPricePerItem = new ColumnHeader();
			pnlAddItemToOrder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUDQuantity).BeginInit();
			pnlViewOrderItems.SuspendLayout();
			pnlOrderConfirmation.SuspendLayout();
			pnlOrderNoToStat.SuspendLayout();
			pnlOrderInfo.SuspendLayout();
			SuspendLayout();
			// 
			// pnlAddItemToOrder
			// 
			pnlAddItemToOrder.Controls.Add(lblDeliveryTime);
			pnlAddItemToOrder.Controls.Add(lblWarning);
			pnlAddItemToOrder.Controls.Add(lblOrderNumberItem);
			pnlAddItemToOrder.Controls.Add(lblCurrentStockLevel);
			pnlAddItemToOrder.Controls.Add(nUDQuantity);
			pnlAddItemToOrder.Controls.Add(btnAddToOrder);
			pnlAddItemToOrder.Controls.Add(btnCancel);
			pnlAddItemToOrder.Controls.Add(lblQuantity);
			pnlAddItemToOrder.Controls.Add(lblTitle);
			pnlAddItemToOrder.Controls.Add(cBoxStock);
			pnlAddItemToOrder.Controls.Add(lblStockItem);
			pnlAddItemToOrder.Dock = DockStyle.Top;
			pnlAddItemToOrder.Location = new Point(0, 0);
			pnlAddItemToOrder.Name = "pnlAddItemToOrder";
			pnlAddItemToOrder.Size = new Size(1000, 680);
			pnlAddItemToOrder.TabIndex = 0;
			// 
			// lblDeliveryTime
			// 
			lblDeliveryTime.Anchor = AnchorStyles.None;
			lblDeliveryTime.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveryTime.ForeColor = Color.Black;
			lblDeliveryTime.Location = new Point(245, 313);
			lblDeliveryTime.Name = "lblDeliveryTime";
			lblDeliveryTime.Size = new Size(511, 35);
			lblDeliveryTime.TabIndex = 28;
			lblDeliveryTime.Text = "Item Delivery Time Goes Here:";
			lblDeliveryTime.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblWarning
			// 
			lblWarning.Anchor = AnchorStyles.None;
			lblWarning.BackColor = Color.FromArgb(255, 219, 219);
			lblWarning.BorderStyle = BorderStyle.FixedSingle;
			lblWarning.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblWarning.ForeColor = Color.FromArgb(250, 0, 0);
			lblWarning.Location = new Point(245, 349);
			lblWarning.Name = "lblWarning";
			lblWarning.Size = new Size(511, 56);
			lblWarning.TabIndex = 27;
			lblWarning.Text = "Warning goes here";
			lblWarning.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblOrderNumberItem
			// 
			lblOrderNumberItem.Anchor = AnchorStyles.None;
			lblOrderNumberItem.AutoSize = true;
			lblOrderNumberItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderNumberItem.ForeColor = Color.Black;
			lblOrderNumberItem.Location = new Point(289, 115);
			lblOrderNumberItem.Name = "lblOrderNumberItem";
			lblOrderNumberItem.Size = new Size(108, 25);
			lblOrderNumberItem.TabIndex = 26;
			lblOrderNumberItem.Text = "Order No ...";
			// 
			// lblCurrentStockLevel
			// 
			lblCurrentStockLevel.Anchor = AnchorStyles.None;
			lblCurrentStockLevel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblCurrentStockLevel.ForeColor = Color.Black;
			lblCurrentStockLevel.Location = new Point(245, 281);
			lblCurrentStockLevel.Name = "lblCurrentStockLevel";
			lblCurrentStockLevel.Size = new Size(511, 35);
			lblCurrentStockLevel.TabIndex = 25;
			lblCurrentStockLevel.Text = "Current Stock Level Goes Here";
			lblCurrentStockLevel.TextAlign = ContentAlignment.TopCenter;
			// 
			// nUDQuantity
			// 
			nUDQuantity.Anchor = AnchorStyles.None;
			nUDQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nUDQuantity.Location = new Point(536, 230);
			nUDQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nUDQuantity.Name = "nUDQuantity";
			nUDQuantity.Size = new Size(176, 32);
			nUDQuantity.TabIndex = 1;
			toolTipCreateOrUpdateOrder.SetToolTip(nUDQuantity, "Quantity to add to order");
			nUDQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// btnAddToOrder
			// 
			btnAddToOrder.Anchor = AnchorStyles.None;
			btnAddToOrder.BackColor = Color.FromArgb(161, 67, 135);
			btnAddToOrder.FlatAppearance.BorderSize = 0;
			btnAddToOrder.FlatStyle = FlatStyle.Flat;
			btnAddToOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddToOrder.ForeColor = Color.White;
			btnAddToOrder.Location = new Point(536, 437);
			btnAddToOrder.Name = "btnAddToOrder";
			btnAddToOrder.Size = new Size(220, 50);
			btnAddToOrder.TabIndex = 2;
			btnAddToOrder.Text = "Add To Order";
			toolTipCreateOrUpdateOrder.SetToolTip(btnAddToOrder, "Add item to order");
			btnAddToOrder.UseVisualStyleBackColor = false;
			btnAddToOrder.Click += btnAddToOrder_Click;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.None;
			btnCancel.BackColor = Color.FromArgb(161, 67, 135);
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCancel.ForeColor = Color.White;
			btnCancel.Location = new Point(245, 437);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(220, 50);
			btnCancel.TabIndex = 3;
			btnCancel.Text = "Cancel";
			toolTipCreateOrUpdateOrder.SetToolTip(btnCancel, "Go back to order");
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// lblQuantity
			// 
			lblQuantity.Anchor = AnchorStyles.None;
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblQuantity.ForeColor = Color.Black;
			lblQuantity.Location = new Point(535, 202);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(84, 25);
			lblQuantity.TabIndex = 21;
			lblQuantity.Text = "Quantity";
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.None;
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.Black;
			lblTitle.Location = new Point(535, 115);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(166, 25);
			lblTitle.TabIndex = 19;
			lblTitle.Text = "Add Item To Order";
			// 
			// cBoxStock
			// 
			cBoxStock.Anchor = AnchorStyles.None;
			cBoxStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cBoxStock.FormattingEnabled = true;
			cBoxStock.Location = new Point(289, 230);
			cBoxStock.Name = "cBoxStock";
			cBoxStock.Size = new Size(176, 33);
			cBoxStock.TabIndex = 0;
			toolTipCreateOrUpdateOrder.SetToolTip(cBoxStock, "Select item to add");
			cBoxStock.SelectedIndexChanged += cBoxStock_SelectedIndexChanged;
			// 
			// lblStockItem
			// 
			lblStockItem.Anchor = AnchorStyles.None;
			lblStockItem.AutoSize = true;
			lblStockItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblStockItem.ForeColor = Color.Black;
			lblStockItem.Location = new Point(289, 202);
			lblStockItem.Name = "lblStockItem";
			lblStockItem.Size = new Size(98, 25);
			lblStockItem.TabIndex = 20;
			lblStockItem.Text = "Stock Item";
			// 
			// pnlViewOrderItems
			// 
			pnlViewOrderItems.BackColor = Color.White;
			pnlViewOrderItems.Controls.Add(pnlOrderConfirmation);
			pnlViewOrderItems.Controls.Add(pnlOrderNoToStat);
			pnlViewOrderItems.Controls.Add(pnlOrderInfo);
			pnlViewOrderItems.Dock = DockStyle.Top;
			pnlViewOrderItems.Location = new Point(0, 680);
			pnlViewOrderItems.Name = "pnlViewOrderItems";
			pnlViewOrderItems.Size = new Size(1000, 888);
			pnlViewOrderItems.TabIndex = 26;
			// 
			// pnlOrderConfirmation
			// 
			pnlOrderConfirmation.BackColor = SystemColors.ScrollBar;
			pnlOrderConfirmation.Controls.Add(lblConfirmation);
			pnlOrderConfirmation.Controls.Add(lblFinalOrderTotal);
			pnlOrderConfirmation.Controls.Add(lblDeliveringTo);
			pnlOrderConfirmation.Controls.Add(btnConfirmAndPlace);
			pnlOrderConfirmation.Controls.Add(btnReturnToEditScreen);
			pnlOrderConfirmation.Controls.Add(btnCancelOrder);
			pnlOrderConfirmation.Controls.Add(btnReturn);
			pnlOrderConfirmation.Dock = DockStyle.Top;
			pnlOrderConfirmation.Location = new Point(0, 680);
			pnlOrderConfirmation.Name = "pnlOrderConfirmation";
			pnlOrderConfirmation.Size = new Size(1000, 206);
			pnlOrderConfirmation.TabIndex = 30;
			// 
			// lblConfirmation
			// 
			lblConfirmation.Anchor = AnchorStyles.Top;
			lblConfirmation.FlatStyle = FlatStyle.Flat;
			lblConfirmation.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblConfirmation.ForeColor = SystemColors.ControlText;
			lblConfirmation.Location = new Point(264, 11);
			lblConfirmation.Name = "lblConfirmation";
			lblConfirmation.Size = new Size(473, 25);
			lblConfirmation.TabIndex = 24;
			lblConfirmation.Text = "Please confirm all information before confirming order";
			lblConfirmation.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblFinalOrderTotal
			// 
			lblFinalOrderTotal.Anchor = AnchorStyles.Top;
			lblFinalOrderTotal.FlatStyle = FlatStyle.Flat;
			lblFinalOrderTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblFinalOrderTotal.ForeColor = SystemColors.ControlText;
			lblFinalOrderTotal.Location = new Point(289, 84);
			lblFinalOrderTotal.Name = "lblFinalOrderTotal";
			lblFinalOrderTotal.Size = new Size(422, 32);
			lblFinalOrderTotal.TabIndex = 23;
			lblFinalOrderTotal.Text = "Order Total:";
			lblFinalOrderTotal.TextAlign = ContentAlignment.TopCenter;
			toolTipCreateOrUpdateOrder.SetToolTip(lblFinalOrderTotal, "Total price of order");
			// 
			// lblDeliveringTo
			// 
			lblDeliveringTo.Anchor = AnchorStyles.Top;
			lblDeliveringTo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveringTo.ForeColor = SystemColors.ControlText;
			lblDeliveringTo.Location = new Point(289, 52);
			lblDeliveringTo.Name = "lblDeliveringTo";
			lblDeliveringTo.Size = new Size(422, 32);
			lblDeliveringTo.TabIndex = 22;
			lblDeliveringTo.Text = "Order For:";
			lblDeliveringTo.TextAlign = ContentAlignment.TopCenter;
			toolTipCreateOrUpdateOrder.SetToolTip(lblDeliveringTo, "Where order will be delivered");
			// 
			// btnConfirmAndPlace
			// 
			btnConfirmAndPlace.Anchor = AnchorStyles.Top;
			btnConfirmAndPlace.BackColor = Color.FromArgb(161, 32, 89);
			btnConfirmAndPlace.FlatAppearance.BorderSize = 0;
			btnConfirmAndPlace.FlatStyle = FlatStyle.Flat;
			btnConfirmAndPlace.Font = new Font("Segoe UI", 12F);
			btnConfirmAndPlace.ForeColor = SystemColors.Control;
			btnConfirmAndPlace.Location = new Point(514, 140);
			btnConfirmAndPlace.Name = "btnConfirmAndPlace";
			btnConfirmAndPlace.Size = new Size(220, 50);
			btnConfirmAndPlace.TabIndex = 0;
			btnConfirmAndPlace.Text = "Confirm and Place";
			toolTipCreateOrUpdateOrder.SetToolTip(btnConfirmAndPlace, "Confirm and place order\r\nYou will no longer be able to edit items\r\n");
			btnConfirmAndPlace.UseVisualStyleBackColor = false;
			btnConfirmAndPlace.Click += btnConfirmAndPlace_Click;
			// 
			// btnReturnToEditScreen
			// 
			btnReturnToEditScreen.Anchor = AnchorStyles.Top;
			btnReturnToEditScreen.BackColor = Color.FromArgb(161, 32, 89);
			btnReturnToEditScreen.FlatAppearance.BorderSize = 0;
			btnReturnToEditScreen.FlatStyle = FlatStyle.Flat;
			btnReturnToEditScreen.Font = new Font("Segoe UI", 12F);
			btnReturnToEditScreen.ForeColor = SystemColors.Control;
			btnReturnToEditScreen.Location = new Point(269, 140);
			btnReturnToEditScreen.Name = "btnReturnToEditScreen";
			btnReturnToEditScreen.Size = new Size(220, 50);
			btnReturnToEditScreen.TabIndex = 1;
			btnReturnToEditScreen.Text = "Cancel";
			toolTipCreateOrUpdateOrder.SetToolTip(btnReturnToEditScreen, "Go back to edit order");
			btnReturnToEditScreen.UseVisualStyleBackColor = false;
			btnReturnToEditScreen.Click += btnReturnToEditScreen_Click;
			// 
			// btnCancelOrder
			// 
			btnCancelOrder.Anchor = AnchorStyles.Top;
			btnCancelOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnCancelOrder.FlatAppearance.BorderSize = 0;
			btnCancelOrder.FlatStyle = FlatStyle.Flat;
			btnCancelOrder.Font = new Font("Segoe UI", 12F);
			btnCancelOrder.ForeColor = SystemColors.Control;
			btnCancelOrder.Location = new Point(514, 140);
			btnCancelOrder.Name = "btnCancelOrder";
			btnCancelOrder.Size = new Size(220, 50);
			btnCancelOrder.TabIndex = 25;
			btnCancelOrder.Text = "Cancel Order";
			btnCancelOrder.UseVisualStyleBackColor = false;
			btnCancelOrder.Click += btnCancelOrder_Click;
			// 
			// btnReturn
			// 
			btnReturn.Anchor = AnchorStyles.Top;
			btnReturn.BackColor = Color.FromArgb(161, 32, 89);
			btnReturn.FlatAppearance.BorderSize = 0;
			btnReturn.FlatStyle = FlatStyle.Flat;
			btnReturn.Font = new Font("Segoe UI", 12F);
			btnReturn.ForeColor = SystemColors.Control;
			btnReturn.Location = new Point(269, 140);
			btnReturn.Name = "btnReturn";
			btnReturn.Size = new Size(220, 50);
			btnReturn.TabIndex = 26;
			btnReturn.Text = "Return";
			btnReturn.UseVisualStyleBackColor = false;
			btnReturn.Click += btnReturn_Click;
			// 
			// pnlOrderNoToStat
			// 
			pnlOrderNoToStat.BackColor = SystemColors.ScrollBar;
			pnlOrderNoToStat.Controls.Add(btnPlaceOrder);
			pnlOrderNoToStat.Controls.Add(lblInstructions);
			pnlOrderNoToStat.Controls.Add(btnRemoveFromOrder);
			pnlOrderNoToStat.Controls.Add(btnAddAnItemToOrder);
			pnlOrderNoToStat.Controls.Add(lblOrderNumberOrder);
			pnlOrderNoToStat.Controls.Add(btnSaveAsDraft);
			pnlOrderNoToStat.Controls.Add(lblOrderStatus);
			pnlOrderNoToStat.Controls.Add(lblOrderTotal);
			pnlOrderNoToStat.Dock = DockStyle.Top;
			pnlOrderNoToStat.Location = new Point(0, 474);
			pnlOrderNoToStat.Name = "pnlOrderNoToStat";
			pnlOrderNoToStat.Size = new Size(1000, 206);
			pnlOrderNoToStat.TabIndex = 28;
			// 
			// btnPlaceOrder
			// 
			btnPlaceOrder.Anchor = AnchorStyles.Top;
			btnPlaceOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnPlaceOrder.FlatAppearance.BorderSize = 0;
			btnPlaceOrder.FlatStyle = FlatStyle.Flat;
			btnPlaceOrder.Font = new Font("Segoe UI", 12F);
			btnPlaceOrder.ForeColor = SystemColors.Control;
			btnPlaceOrder.Location = new Point(754, 140);
			btnPlaceOrder.Name = "btnPlaceOrder";
			btnPlaceOrder.Size = new Size(220, 50);
			btnPlaceOrder.TabIndex = 3;
			btnPlaceOrder.Text = "Place Order";
			toolTipCreateOrUpdateOrder.SetToolTip(btnPlaceOrder, "Place Order");
			btnPlaceOrder.UseVisualStyleBackColor = false;
			btnPlaceOrder.Click += btnPlaceOrder_Click;
			// 
			// lblInstructions
			// 
			lblInstructions.Anchor = AnchorStyles.Top;
			lblInstructions.AutoSize = true;
			lblInstructions.FlatStyle = FlatStyle.Flat;
			lblInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructions.ForeColor = SystemColors.ControlText;
			lblInstructions.Location = new Point(277, 8);
			lblInstructions.Name = "lblInstructions";
			lblInstructions.Size = new Size(413, 25);
			lblInstructions.TabIndex = 15;
			lblInstructions.Text = "Add or select an item to manage its information";
			// 
			// btnRemoveFromOrder
			// 
			btnRemoveFromOrder.Anchor = AnchorStyles.Top;
			btnRemoveFromOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnRemoveFromOrder.FlatAppearance.BorderSize = 0;
			btnRemoveFromOrder.FlatStyle = FlatStyle.Flat;
			btnRemoveFromOrder.Font = new Font("Segoe UI", 12F);
			btnRemoveFromOrder.ForeColor = SystemColors.Control;
			btnRemoveFromOrder.Location = new Point(269, 140);
			btnRemoveFromOrder.Name = "btnRemoveFromOrder";
			btnRemoveFromOrder.Size = new Size(220, 50);
			btnRemoveFromOrder.TabIndex = 1;
			btnRemoveFromOrder.Text = "Remove From Order";
			toolTipCreateOrUpdateOrder.SetToolTip(btnRemoveFromOrder, "Remove selected item from order");
			btnRemoveFromOrder.UseVisualStyleBackColor = false;
			btnRemoveFromOrder.Click += btnRemoveFromOrder_Click;
			// 
			// btnAddAnItemToOrder
			// 
			btnAddAnItemToOrder.Anchor = AnchorStyles.Top;
			btnAddAnItemToOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnAddAnItemToOrder.FlatAppearance.BorderSize = 0;
			btnAddAnItemToOrder.FlatStyle = FlatStyle.Flat;
			btnAddAnItemToOrder.Font = new Font("Segoe UI", 12F);
			btnAddAnItemToOrder.ForeColor = SystemColors.Control;
			btnAddAnItemToOrder.Location = new Point(26, 140);
			btnAddAnItemToOrder.Name = "btnAddAnItemToOrder";
			btnAddAnItemToOrder.Size = new Size(220, 50);
			btnAddAnItemToOrder.TabIndex = 0;
			btnAddAnItemToOrder.Text = "Add Item To Order";
			toolTipCreateOrUpdateOrder.SetToolTip(btnAddAnItemToOrder, "Add an item to order");
			btnAddAnItemToOrder.UseVisualStyleBackColor = false;
			btnAddAnItemToOrder.Click += btnAddAnItemToOrder_Click;
			// 
			// lblOrderNumberOrder
			// 
			lblOrderNumberOrder.Anchor = AnchorStyles.Top;
			lblOrderNumberOrder.AutoSize = true;
			lblOrderNumberOrder.FlatStyle = FlatStyle.Flat;
			lblOrderNumberOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderNumberOrder.ForeColor = SystemColors.ControlText;
			lblOrderNumberOrder.Location = new Point(247, 54);
			lblOrderNumberOrder.Name = "lblOrderNumberOrder";
			lblOrderNumberOrder.Size = new Size(152, 25);
			lblOrderNumberOrder.TabIndex = 18;
			lblOrderNumberOrder.Text = "Order Number ...";
			toolTipCreateOrUpdateOrder.SetToolTip(lblOrderNumberOrder, "Current order number");
			// 
			// btnSaveAsDraft
			// 
			btnSaveAsDraft.Anchor = AnchorStyles.Top;
			btnSaveAsDraft.BackColor = Color.FromArgb(161, 32, 89);
			btnSaveAsDraft.FlatAppearance.BorderSize = 0;
			btnSaveAsDraft.FlatStyle = FlatStyle.Flat;
			btnSaveAsDraft.Font = new Font("Segoe UI", 12F);
			btnSaveAsDraft.ForeColor = SystemColors.Control;
			btnSaveAsDraft.Location = new Point(514, 140);
			btnSaveAsDraft.Name = "btnSaveAsDraft";
			btnSaveAsDraft.Size = new Size(220, 50);
			btnSaveAsDraft.TabIndex = 2;
			btnSaveAsDraft.Text = "Save Order As Draft";
			toolTipCreateOrUpdateOrder.SetToolTip(btnSaveAsDraft, "Save order as draft");
			btnSaveAsDraft.UseVisualStyleBackColor = false;
			btnSaveAsDraft.Click += btnSaveAsDraft_Click;
			// 
			// lblOrderStatus
			// 
			lblOrderStatus.Anchor = AnchorStyles.Top;
			lblOrderStatus.AutoSize = true;
			lblOrderStatus.FlatStyle = FlatStyle.Flat;
			lblOrderStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderStatus.ForeColor = SystemColors.ControlText;
			lblOrderStatus.Location = new Point(573, 91);
			lblOrderStatus.Name = "lblOrderStatus";
			lblOrderStatus.Size = new Size(120, 25);
			lblOrderStatus.TabIndex = 17;
			lblOrderStatus.Text = "Order Status:";
			toolTipCreateOrUpdateOrder.SetToolTip(lblOrderStatus, "Current status of order");
			// 
			// lblOrderTotal
			// 
			lblOrderTotal.Anchor = AnchorStyles.Top;
			lblOrderTotal.AutoSize = true;
			lblOrderTotal.FlatStyle = FlatStyle.Flat;
			lblOrderTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderTotal.ForeColor = SystemColors.ControlText;
			lblOrderTotal.Location = new Point(573, 54);
			lblOrderTotal.Name = "lblOrderTotal";
			lblOrderTotal.Size = new Size(110, 25);
			lblOrderTotal.TabIndex = 16;
			lblOrderTotal.Text = "Order Total:";
			toolTipCreateOrUpdateOrder.SetToolTip(lblOrderTotal, "Total price of order");
			// 
			// pnlOrderInfo
			// 
			pnlOrderInfo.BackColor = SystemColors.ScrollBar;
			pnlOrderInfo.Controls.Add(lstViewOrderItems);
			pnlOrderInfo.Dock = DockStyle.Top;
			pnlOrderInfo.Location = new Point(0, 0);
			pnlOrderInfo.Name = "pnlOrderInfo";
			pnlOrderInfo.Size = new Size(1000, 474);
			pnlOrderInfo.TabIndex = 1;
			pnlOrderInfo.Resize += pnlOrderInfo_Resize;
			// 
			// lstViewOrderItems
			// 
			lstViewOrderItems.Anchor = AnchorStyles.Top;
			lstViewOrderItems.BackColor = Color.FromArgb(227, 115, 166);
			lstViewOrderItems.Columns.AddRange(new ColumnHeader[] { cHeaderStockItem, cHeaderQuantity, cHeaderRecommendedQty, cHeaderPricePerUnit, cHeaderTotalPricePerItem });
			lstViewOrderItems.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrderItems.ForeColor = Color.Black;
			lstViewOrderItems.FullRowSelect = true;
			lstViewOrderItems.GridLines = true;
			lstViewOrderItems.Location = new Point(52, 25);
			lstViewOrderItems.Name = "lstViewOrderItems";
			lstViewOrderItems.Size = new Size(897, 424);
			lstViewOrderItems.TabIndex = 0;
			toolTipCreateOrUpdateOrder.SetToolTip(lstViewOrderItems, "Stock on current order");
			lstViewOrderItems.UseCompatibleStateImageBehavior = false;
			lstViewOrderItems.View = View.Details;
			lstViewOrderItems.ItemSelectionChanged += lstViewOrderItems_ItemSelectionChanged;
			// 
			// cHeaderStockItem
			// 
			cHeaderStockItem.Text = "Stock";
			cHeaderStockItem.Width = 250;
			// 
			// cHeaderQuantity
			// 
			cHeaderQuantity.Text = "Quantity";
			cHeaderQuantity.Width = 150;
			// 
			// cHeaderRecommendedQty
			// 
			cHeaderRecommendedQty.Text = "Recommended Qty";
			cHeaderRecommendedQty.Width = 150;
			// 
			// cHeaderPricePerUnit
			// 
			cHeaderPricePerUnit.Text = "Unit Price";
			cHeaderPricePerUnit.Width = 150;
			// 
			// cHeaderTotalPricePerItem
			// 
			cHeaderTotalPricePerItem.Text = "Total Price";
			cHeaderTotalPricePerItem.Width = 170;
			// 
			// frmCreateOrUpdateOrder
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			BackColor = Color.FromArgb(200, 200, 200);
			ClientSize = new Size(1018, 680);
			Controls.Add(pnlViewOrderItems);
			Controls.Add(pnlAddItemToOrder);
			Name = "frmCreateOrUpdateOrder";
			Text = "Order";
			pnlAddItemToOrder.ResumeLayout(false);
			pnlAddItemToOrder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nUDQuantity).EndInit();
			pnlViewOrderItems.ResumeLayout(false);
			pnlOrderConfirmation.ResumeLayout(false);
			pnlOrderNoToStat.ResumeLayout(false);
			pnlOrderNoToStat.PerformLayout();
			pnlOrderInfo.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Panel pnlAddItemToOrder;
        private Label lblCurrentStockLevel;
        private NumericUpDown nUDQuantity;
        private Button btnAddToOrder;
        private Label lblQuantity;
        private Label lblStockItem;
        private Label lblTitle;
        private ComboBox cBoxStock;
        private Panel pnlViewOrderItems;
        private ListView lstViewOrderItems;
        private ColumnHeader cHeaderStockItem;
        private Panel pnlOrderInfo;
        private Button btnSaveAsDraft;
        private Button btnRemoveFromOrder;
        private Button btnAddAnItemToOrder;
        private Button btnPlaceOrder;
        private Label lblOrderNumberItem;
        private Label lblWarning;
        private Button btnCancel;
        private Button btnConfirmAndPlace;
        private Button btnReturnToEditScreen;
		private Panel pnlOrderNoToStat;
		private Label lblInstructions;
		private Label lblOrderNumberOrder;
		private Label lblOrderStatus;
		private Label lblOrderTotal;
		private Panel pnlOrderConfirmation;
		private Label lblConfirmation;
		private Label lblFinalOrderTotal;
		private Label lblDeliveringTo;
		private Label lblDeliveryTime;
		private Button btnCancelOrder;
		private Button btnReturn;
		private ToolTip toolTipCreateOrUpdateOrder;
		private ColumnHeader cHeaderQuantity;
		private ColumnHeader cHeaderRecommendedQty;
		private ColumnHeader cHeaderPricePerUnit;
		private ColumnHeader cHeaderTotalPricePerItem;
	}
}