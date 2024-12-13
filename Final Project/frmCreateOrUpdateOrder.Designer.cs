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
            pnlAddItemToOrder = new Panel();
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
            lblFinalOrderTotal = new Label();
            lblStaffNameToDeliverTo = new Label();
            btnConfirmAndPlace = new Button();
            btnReturnToEditScreen = new Button();
            cBoxStaffMembers = new ComboBox();
            pnlOptions = new Panel();
            btnPlaceOrder = new Button();
            btnSaveAsDraft = new Button();
            btnRemoveFromOrder = new Button();
            btnAddAnItemToOrder = new Button();
            pnlOrderInfo = new Panel();
            lstViewOrderItems = new ListView();
            cHeaderStockItem = new ColumnHeader();
            cHeaderUnit = new ColumnHeader();
            cHeaderUnitPrice = new ColumnHeader();
            cHeaderNoOfUnits = new ColumnHeader();
            cHeaderTotalPrice = new ColumnHeader();
            pnlOrderNoToStat = new Panel();
            lblInstructions = new Label();
            lblOrderNumberOrder = new Label();
            lblOrderStatus = new Label();
            lblOrderTotal = new Label();
            pnlAddItemToOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuantity).BeginInit();
            pnlViewOrderItems.SuspendLayout();
            pnlOrderConfirmation.SuspendLayout();
            pnlOptions.SuspendLayout();
            pnlOrderInfo.SuspendLayout();
            pnlOrderNoToStat.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddItemToOrder
            // 
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
            pnlAddItemToOrder.Size = new Size(751, 560);
            pnlAddItemToOrder.TabIndex = 0;
            // 
            // lblWarning
            // 
            lblWarning.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWarning.ForeColor = SystemColors.Control;
            lblWarning.Location = new Point(122, 285);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(511, 35);
            lblWarning.TabIndex = 27;
            lblWarning.Text = "Warning goes here";
            lblWarning.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOrderNumberItem
            // 
            lblOrderNumberItem.AutoSize = true;
            lblOrderNumberItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderNumberItem.ForeColor = SystemColors.Control;
            lblOrderNumberItem.Location = new Point(12, 21);
            lblOrderNumberItem.Name = "lblOrderNumberItem";
            lblOrderNumberItem.Size = new Size(172, 41);
            lblOrderNumberItem.TabIndex = 26;
            lblOrderNumberItem.Text = "Order No ...";
            // 
            // lblCurrentStockLevel
            // 
            lblCurrentStockLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStockLevel.ForeColor = SystemColors.Control;
            lblCurrentStockLevel.Location = new Point(122, 250);
            lblCurrentStockLevel.Name = "lblCurrentStockLevel";
            lblCurrentStockLevel.Size = new Size(511, 35);
            lblCurrentStockLevel.TabIndex = 25;
            lblCurrentStockLevel.Text = "Current Stock Level Goes Here";
            lblCurrentStockLevel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nUDQuantity
            // 
            nUDQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUDQuantity.Location = new Point(412, 183);
            nUDQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDQuantity.Name = "nUDQuantity";
            nUDQuantity.Size = new Size(176, 39);
            nUDQuantity.TabIndex = 24;
            nUDQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Anchor = AnchorStyles.None;
            btnAddToOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToOrder.Location = new Point(521, 498);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(220, 50);
            btnAddToOrder.TabIndex = 23;
            btnAddToOrder.Text = "Add To Order";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.None;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(283, 498);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(220, 50);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.Control;
            lblQuantity.Location = new Point(412, 155);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(106, 32);
            lblQuantity.TabIndex = 21;
            lblQuantity.Text = "Quantity";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(285, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 41);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Add Item To Order";
            // 
            // cBoxStock
            // 
            cBoxStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxStock.FormattingEnabled = true;
            cBoxStock.Location = new Point(166, 183);
            cBoxStock.Name = "cBoxStock";
            cBoxStock.Size = new Size(176, 40);
            cBoxStock.TabIndex = 18;
            // 
            // lblStockItem
            // 
            lblStockItem.AutoSize = true;
            lblStockItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockItem.ForeColor = SystemColors.Control;
            lblStockItem.Location = new Point(166, 155);
            lblStockItem.Name = "lblStockItem";
            lblStockItem.Size = new Size(126, 32);
            lblStockItem.TabIndex = 20;
            lblStockItem.Text = "Stock Item";
            // 
            // pnlViewOrderItems
            // 
            pnlViewOrderItems.BackColor = Color.White;
            pnlViewOrderItems.Controls.Add(pnlOrderConfirmation);
            pnlViewOrderItems.Controls.Add(pnlOptions);
            pnlViewOrderItems.Controls.Add(pnlOrderInfo);
            pnlViewOrderItems.Dock = DockStyle.Top;
            pnlViewOrderItems.Location = new Point(0, 560);
            pnlViewOrderItems.Name = "pnlViewOrderItems";
            pnlViewOrderItems.Size = new Size(751, 826);
            pnlViewOrderItems.TabIndex = 26;
            // 
            // pnlOrderConfirmation
            // 
            pnlOrderConfirmation.Controls.Add(lblFinalOrderTotal);
            pnlOrderConfirmation.Controls.Add(lblStaffNameToDeliverTo);
            pnlOrderConfirmation.Controls.Add(btnConfirmAndPlace);
            pnlOrderConfirmation.Controls.Add(btnReturnToEditScreen);
            pnlOrderConfirmation.Controls.Add(cBoxStaffMembers);
            pnlOrderConfirmation.Dock = DockStyle.Top;
            pnlOrderConfirmation.Location = new Point(0, 560);
            pnlOrderConfirmation.Name = "pnlOrderConfirmation";
            pnlOrderConfirmation.Size = new Size(751, 268);
            pnlOrderConfirmation.TabIndex = 3;
            // 
            // lblFinalOrderTotal
            // 
            lblFinalOrderTotal.AutoSize = true;
            lblFinalOrderTotal.FlatStyle = FlatStyle.Flat;
            lblFinalOrderTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinalOrderTotal.ForeColor = SystemColors.ControlText;
            lblFinalOrderTotal.Location = new Point(434, 63);
            lblFinalOrderTotal.Name = "lblFinalOrderTotal";
            lblFinalOrderTotal.Size = new Size(138, 32);
            lblFinalOrderTotal.TabIndex = 23;
            lblFinalOrderTotal.Text = "Order Total:";
            // 
            // lblStaffNameToDeliverTo
            // 
            lblStaffNameToDeliverTo.AutoSize = true;
            lblStaffNameToDeliverTo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStaffNameToDeliverTo.ForeColor = SystemColors.ControlText;
            lblStaffNameToDeliverTo.Location = new Point(60, 16);
            lblStaffNameToDeliverTo.Name = "lblStaffNameToDeliverTo";
            lblStaffNameToDeliverTo.Size = new Size(333, 32);
            lblStaffNameToDeliverTo.TabIndex = 22;
            lblStaffNameToDeliverTo.Text = "Enter Staff name to deliver to:";
            // 
            // btnConfirmAndPlace
            // 
            btnConfirmAndPlace.BackColor = Color.LightSeaGreen;
            btnConfirmAndPlace.FlatAppearance.BorderSize = 0;
            btnConfirmAndPlace.FlatStyle = FlatStyle.Flat;
            btnConfirmAndPlace.Font = new Font("Segoe UI", 12F);
            btnConfirmAndPlace.ForeColor = SystemColors.Control;
            btnConfirmAndPlace.Location = new Point(434, 204);
            btnConfirmAndPlace.Name = "btnConfirmAndPlace";
            btnConfirmAndPlace.Size = new Size(220, 50);
            btnConfirmAndPlace.TabIndex = 21;
            btnConfirmAndPlace.Text = "Confirm and Place";
            btnConfirmAndPlace.UseVisualStyleBackColor = false;
            btnConfirmAndPlace.Click += btnConfirmAndPlace_Click;
            // 
            // btnReturnToEditScreen
            // 
            btnReturnToEditScreen.BackColor = Color.LightSeaGreen;
            btnReturnToEditScreen.FlatAppearance.BorderSize = 0;
            btnReturnToEditScreen.FlatStyle = FlatStyle.Flat;
            btnReturnToEditScreen.Font = new Font("Segoe UI", 12F);
            btnReturnToEditScreen.ForeColor = SystemColors.Control;
            btnReturnToEditScreen.Location = new Point(122, 204);
            btnReturnToEditScreen.Name = "btnReturnToEditScreen";
            btnReturnToEditScreen.Size = new Size(220, 50);
            btnReturnToEditScreen.TabIndex = 20;
            btnReturnToEditScreen.Text = "Cancel";
            btnReturnToEditScreen.UseVisualStyleBackColor = false;
            // 
            // cBoxStaffMembers
            // 
            cBoxStaffMembers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxStaffMembers.FormattingEnabled = true;
            cBoxStaffMembers.Location = new Point(146, 63);
            cBoxStaffMembers.Name = "cBoxStaffMembers";
            cBoxStaffMembers.Size = new Size(176, 40);
            cBoxStaffMembers.TabIndex = 19;
            // 
            // pnlOptions
            // 
            pnlOptions.Controls.Add(btnPlaceOrder);
            pnlOptions.Controls.Add(btnSaveAsDraft);
            pnlOptions.Controls.Add(btnRemoveFromOrder);
            pnlOptions.Controls.Add(btnAddAnItemToOrder);
            pnlOptions.Dock = DockStyle.Top;
            pnlOptions.Location = new Point(0, 413);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(751, 147);
            pnlOptions.TabIndex = 2;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.BackColor = Color.LightSeaGreen;
            btnPlaceOrder.FlatAppearance.BorderSize = 0;
            btnPlaceOrder.FlatStyle = FlatStyle.Flat;
            btnPlaceOrder.Font = new Font("Segoe UI", 12F);
            btnPlaceOrder.ForeColor = SystemColors.Control;
            btnPlaceOrder.Location = new Point(434, 85);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(220, 50);
            btnPlaceOrder.TabIndex = 12;
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.UseVisualStyleBackColor = false;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnSaveAsDraft
            // 
            btnSaveAsDraft.BackColor = Color.LightSeaGreen;
            btnSaveAsDraft.FlatAppearance.BorderSize = 0;
            btnSaveAsDraft.FlatStyle = FlatStyle.Flat;
            btnSaveAsDraft.Font = new Font("Segoe UI", 12F);
            btnSaveAsDraft.ForeColor = SystemColors.Control;
            btnSaveAsDraft.Location = new Point(122, 85);
            btnSaveAsDraft.Name = "btnSaveAsDraft";
            btnSaveAsDraft.Size = new Size(220, 50);
            btnSaveAsDraft.TabIndex = 11;
            btnSaveAsDraft.Text = "Save Order As Draft";
            btnSaveAsDraft.UseVisualStyleBackColor = false;
            btnSaveAsDraft.Click += btnSaveAsDraft_Click;
            // 
            // btnRemoveFromOrder
            // 
            btnRemoveFromOrder.BackColor = Color.LightSeaGreen;
            btnRemoveFromOrder.FlatAppearance.BorderSize = 0;
            btnRemoveFromOrder.FlatStyle = FlatStyle.Flat;
            btnRemoveFromOrder.Font = new Font("Segoe UI", 12F);
            btnRemoveFromOrder.ForeColor = SystemColors.Control;
            btnRemoveFromOrder.Location = new Point(434, 21);
            btnRemoveFromOrder.Name = "btnRemoveFromOrder";
            btnRemoveFromOrder.Size = new Size(220, 50);
            btnRemoveFromOrder.TabIndex = 10;
            btnRemoveFromOrder.Text = "Remove From Order";
            btnRemoveFromOrder.UseVisualStyleBackColor = false;
            btnRemoveFromOrder.Click += btnRemoveFromOrder_Click;
            // 
            // btnAddAnItemToOrder
            // 
            btnAddAnItemToOrder.BackColor = Color.LightSeaGreen;
            btnAddAnItemToOrder.FlatAppearance.BorderSize = 0;
            btnAddAnItemToOrder.FlatStyle = FlatStyle.Flat;
            btnAddAnItemToOrder.Font = new Font("Segoe UI", 12F);
            btnAddAnItemToOrder.ForeColor = SystemColors.Control;
            btnAddAnItemToOrder.Location = new Point(122, 21);
            btnAddAnItemToOrder.Name = "btnAddAnItemToOrder";
            btnAddAnItemToOrder.Size = new Size(220, 50);
            btnAddAnItemToOrder.TabIndex = 9;
            btnAddAnItemToOrder.Text = "Add Item To Order";
            btnAddAnItemToOrder.UseVisualStyleBackColor = false;
            btnAddAnItemToOrder.Click += btnAddToStock_Click;
            // 
            // pnlOrderInfo
            // 
            pnlOrderInfo.BackColor = Color.White;
            pnlOrderInfo.Controls.Add(lstViewOrderItems);
            pnlOrderInfo.Controls.Add(pnlOrderNoToStat);
            pnlOrderInfo.Dock = DockStyle.Top;
            pnlOrderInfo.Location = new Point(0, 0);
            pnlOrderInfo.Name = "pnlOrderInfo";
            pnlOrderInfo.Size = new Size(751, 413);
            pnlOrderInfo.TabIndex = 1;
            // 
            // lstViewOrderItems
            // 
            lstViewOrderItems.BackColor = Color.LightSeaGreen;
            lstViewOrderItems.Columns.AddRange(new ColumnHeader[] { cHeaderStockItem, cHeaderUnit, cHeaderUnitPrice, cHeaderNoOfUnits, cHeaderTotalPrice });
            lstViewOrderItems.Dock = DockStyle.Top;
            lstViewOrderItems.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewOrderItems.ForeColor = Color.White;
            lstViewOrderItems.FullRowSelect = true;
            lstViewOrderItems.GridLines = true;
            lstViewOrderItems.Location = new Point(0, 0);
            lstViewOrderItems.Name = "lstViewOrderItems";
            lstViewOrderItems.Size = new Size(751, 292);
            lstViewOrderItems.TabIndex = 0;
            lstViewOrderItems.UseCompatibleStateImageBehavior = false;
            lstViewOrderItems.View = View.Details;
            lstViewOrderItems.ItemSelectionChanged += lstViewOrderItems_ItemSelectionChanged;
            // 
            // cHeaderStockItem
            // 
            cHeaderStockItem.Text = "Stock";
            cHeaderStockItem.Width = 250;
            // 
            // cHeaderUnit
            // 
            cHeaderUnit.Text = "Unit Size";
            cHeaderUnit.Width = 100;
            // 
            // cHeaderUnitPrice
            // 
            cHeaderUnitPrice.Text = "Unit Price";
            cHeaderUnitPrice.Width = 150;
            // 
            // cHeaderNoOfUnits
            // 
            cHeaderNoOfUnits.Text = "No. Units";
            cHeaderNoOfUnits.Width = 100;
            // 
            // cHeaderTotalPrice
            // 
            cHeaderTotalPrice.Text = "Total Price";
            cHeaderTotalPrice.Width = 150;
            // 
            // pnlOrderNoToStat
            // 
            pnlOrderNoToStat.Controls.Add(lblInstructions);
            pnlOrderNoToStat.Controls.Add(lblOrderNumberOrder);
            pnlOrderNoToStat.Controls.Add(lblOrderStatus);
            pnlOrderNoToStat.Controls.Add(lblOrderTotal);
            pnlOrderNoToStat.Location = new Point(0, 292);
            pnlOrderNoToStat.Name = "pnlOrderNoToStat";
            pnlOrderNoToStat.Size = new Size(751, 121);
            pnlOrderNoToStat.TabIndex = 19;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.FlatStyle = FlatStyle.Flat;
            lblInstructions.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = SystemColors.ControlText;
            lblInstructions.Location = new Point(3, 3);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(651, 41);
            lblInstructions.TabIndex = 15;
            lblInstructions.Text = "Add or select an item to manage its information";
            // 
            // lblOrderNumberOrder
            // 
            lblOrderNumberOrder.AutoSize = true;
            lblOrderNumberOrder.FlatStyle = FlatStyle.Flat;
            lblOrderNumberOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderNumberOrder.ForeColor = SystemColors.ControlText;
            lblOrderNumberOrder.Location = new Point(16, 49);
            lblOrderNumberOrder.Name = "lblOrderNumberOrder";
            lblOrderNumberOrder.Size = new Size(192, 32);
            lblOrderNumberOrder.TabIndex = 18;
            lblOrderNumberOrder.Text = "Order Number ...";
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.FlatStyle = FlatStyle.Flat;
            lblOrderStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderStatus.ForeColor = SystemColors.ControlText;
            lblOrderStatus.Location = new Point(412, 86);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(151, 32);
            lblOrderStatus.TabIndex = 17;
            lblOrderStatus.Text = "Order Status:";
            // 
            // lblOrderTotal
            // 
            lblOrderTotal.AutoSize = true;
            lblOrderTotal.FlatStyle = FlatStyle.Flat;
            lblOrderTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderTotal.ForeColor = SystemColors.ControlText;
            lblOrderTotal.Location = new Point(412, 49);
            lblOrderTotal.Name = "lblOrderTotal";
            lblOrderTotal.Size = new Size(138, 32);
            lblOrderTotal.TabIndex = 16;
            lblOrderTotal.Text = "Order Total:";
            // 
            // frmCreateOrUpdateOrder
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(772, 559);
            Controls.Add(pnlViewOrderItems);
            Controls.Add(pnlAddItemToOrder);
            Name = "frmCreateOrUpdateOrder";
            Text = "Order";
            pnlAddItemToOrder.ResumeLayout(false);
            pnlAddItemToOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuantity).EndInit();
            pnlViewOrderItems.ResumeLayout(false);
            pnlOrderConfirmation.ResumeLayout(false);
            pnlOrderConfirmation.PerformLayout();
            pnlOptions.ResumeLayout(false);
            pnlOrderInfo.ResumeLayout(false);
            pnlOrderNoToStat.ResumeLayout(false);
            pnlOrderNoToStat.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cBoxQuantity;
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
        private ColumnHeader cHeaderUnit;
        private ColumnHeader cHeaderUnitPrice;
        private ColumnHeader cHeaderNoOfUnits;
        private ColumnHeader cHeaderTotalPrice;
        private Panel pnlOrderInfo;
        private Label lblInstructions;
        private Panel pnlOptions;
        private Button btnSaveAsDraft;
        private Button btnRemoveFromOrder;
        private Button btnAddAnItemToOrder;
        private Label lblOrderTotal;
        private Button btnPlaceOrder;
        private Label lblOrderStatus;
        private Label lblOrderNumberItem;
        private Label lblWarning;
        private Button btnCancel;
        private Label lblOrderNumberOrder;
        private Panel pnlOrderConfirmation;
        private Panel pnlOrderNoToStat;
        private Label lblStaffNameToDeliverTo;
        private Button btnConfirmAndPlace;
        private Button btnReturnToEditScreen;
        private ComboBox cBoxStaffMembers;
        private Label lblFinalOrderTotal;
    }
}