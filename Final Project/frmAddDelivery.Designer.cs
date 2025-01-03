namespace Final_Project
{
    partial class frmAddDelivery
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
			pnlOrders = new Panel();
			lblOrderError = new Label();
			btnRecordDelivery = new Button();
			lstViewOrders = new ListView();
			cHeaderOrderNumber = new ColumnHeader();
			cHeaderOrderDate = new ColumnHeader();
			cHeaderOrderStatus = new ColumnHeader();
			pnlDelivery = new Panel();
			lblDeliveryItemError = new Label();
			btnRecordDeliveryForOrder = new Button();
			btnMarkOrderAsCompleted = new Button();
			lblOrderDateAndStatus = new Label();
			lstViewOrderItemsDelivered = new ListView();
			cHeaderOrderItem = new ColumnHeader();
			cHeaderQuantityOrdered = new ColumnHeader();
			cHeaderDeliveryStatus = new ColumnHeader();
			cHeaderQuantityReceived = new ColumnHeader();
			cHeaderQuantityFaulty = new ColumnHeader();
			lblOrderNumber = new Label();
			pnlDeliveryDetails = new Panel();
			lblInstructionsDeliveryItem = new Label();
			lblDeliveryDate = new Label();
			btnMarkDeliveryAsCompleted = new Button();
			btnAddItem = new Button();
			lblDeliveryNumber = new Label();
			lstViewDeliveryItems = new ListView();
			cHeaderItem = new ColumnHeader();
			cHeaderDeliveryQuantityReceived = new ColumnHeader();
			cHeaderDeliveryQuantityFaulty = new ColumnHeader();
			pnlItemToAddToDelivery = new Panel();
			btnAddItemToDelivery = new Button();
			lblQuantityFaulty = new Label();
			lblQuantityDelivered = new Label();
			nUDQuantityDelivered = new NumericUpDown();
			nUDQuantityFaulty = new NumericUpDown();
			lblSelectedItem = new Label();
			lblSelectedItemQuantity = new Label();
			pnlOrders.SuspendLayout();
			pnlDelivery.SuspendLayout();
			pnlDeliveryDetails.SuspendLayout();
			pnlItemToAddToDelivery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUDQuantityDelivered).BeginInit();
			((System.ComponentModel.ISupportInitialize)nUDQuantityFaulty).BeginInit();
			SuspendLayout();
			// 
			// pnlOrders
			// 
			pnlOrders.Controls.Add(lblOrderError);
			pnlOrders.Controls.Add(btnRecordDelivery);
			pnlOrders.Controls.Add(lstViewOrders);
			pnlOrders.Dock = DockStyle.Top;
			pnlOrders.Location = new Point(0, 0);
			pnlOrders.Margin = new Padding(3, 2, 3, 2);
			pnlOrders.Name = "pnlOrders";
			pnlOrders.Size = new Size(966, 680);
			pnlOrders.TabIndex = 2;
			pnlOrders.Resize += pnlOrders_Resize;
			// 
			// lblOrderError
			// 
			lblOrderError.Anchor = AnchorStyles.Bottom;
			lblOrderError.BackColor = Color.FromArgb(255, 209, 209);
			lblOrderError.BorderStyle = BorderStyle.FixedSingle;
			lblOrderError.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblOrderError.ForeColor = Color.FromArgb(250, 0, 0);
			lblOrderError.Location = new Point(231, 518);
			lblOrderError.Name = "lblOrderError";
			lblOrderError.Size = new Size(505, 61);
			lblOrderError.TabIndex = 26;
			lblOrderError.Text = "Error message goes here";
			lblOrderError.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnRecordDelivery
			// 
			btnRecordDelivery.Anchor = AnchorStyles.Bottom;
			btnRecordDelivery.BackColor = Color.FromArgb(0, 151, 136);
			btnRecordDelivery.FlatAppearance.BorderSize = 0;
			btnRecordDelivery.FlatStyle = FlatStyle.Flat;
			btnRecordDelivery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRecordDelivery.ForeColor = Color.White;
			btnRecordDelivery.Location = new Point(373, 602);
			btnRecordDelivery.Margin = new Padding(3, 2, 3, 2);
			btnRecordDelivery.Name = "btnRecordDelivery";
			btnRecordDelivery.Size = new Size(220, 50);
			btnRecordDelivery.TabIndex = 25;
			btnRecordDelivery.Text = "Record Delivery";
			btnRecordDelivery.UseVisualStyleBackColor = false;
			btnRecordDelivery.Click += btnRecordDelivery_Click;
			// 
			// lstViewOrders
			// 
			lstViewOrders.Anchor = AnchorStyles.Top;
			lstViewOrders.BackColor = Color.FromArgb(0, 214, 194);
			lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderOrderNumber, cHeaderOrderDate, cHeaderOrderStatus });
			lstViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrders.ForeColor = Color.Black;
			lstViewOrders.FullRowSelect = true;
			lstViewOrders.GridLines = true;
			lstViewOrders.Location = new Point(44, 32);
			lstViewOrders.Margin = new Padding(3, 2, 3, 2);
			lstViewOrders.Name = "lstViewOrders";
			lstViewOrders.Size = new Size(875, 468);
			lstViewOrders.TabIndex = 0;
			lstViewOrders.UseCompatibleStateImageBehavior = false;
			lstViewOrders.View = View.Details;
			lstViewOrders.ItemSelectionChanged += lstViewOrders_ItemSelectionChanged;
			// 
			// cHeaderOrderNumber
			// 
			cHeaderOrderNumber.Text = "Order Number";
			cHeaderOrderNumber.Width = 200;
			// 
			// cHeaderOrderDate
			// 
			cHeaderOrderDate.Text = "Order Date";
			cHeaderOrderDate.Width = 250;
			// 
			// cHeaderOrderStatus
			// 
			cHeaderOrderStatus.Text = "Status";
			cHeaderOrderStatus.Width = 250;
			// 
			// pnlDelivery
			// 
			pnlDelivery.Controls.Add(lblDeliveryItemError);
			pnlDelivery.Controls.Add(btnRecordDeliveryForOrder);
			pnlDelivery.Controls.Add(btnMarkOrderAsCompleted);
			pnlDelivery.Controls.Add(lblOrderDateAndStatus);
			pnlDelivery.Controls.Add(lstViewOrderItemsDelivered);
			pnlDelivery.Controls.Add(lblOrderNumber);
			pnlDelivery.Controls.Add(pnlDeliveryDetails);
			pnlDelivery.Dock = DockStyle.Top;
			pnlDelivery.Location = new Point(0, 680);
			pnlDelivery.Name = "pnlDelivery";
			pnlDelivery.Size = new Size(966, 680);
			pnlDelivery.TabIndex = 4;
			// 
			// lblDeliveryItemError
			// 
			lblDeliveryItemError.Anchor = AnchorStyles.None;
			lblDeliveryItemError.BackColor = Color.FromArgb(255, 209, 209);
			lblDeliveryItemError.BorderStyle = BorderStyle.FixedSingle;
			lblDeliveryItemError.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblDeliveryItemError.ForeColor = Color.FromArgb(250, 0, 0);
			lblDeliveryItemError.Location = new Point(231, 598);
			lblDeliveryItemError.Name = "lblDeliveryItemError";
			lblDeliveryItemError.Size = new Size(505, 61);
			lblDeliveryItemError.TabIndex = 34;
			lblDeliveryItemError.Text = "Error message goes here";
			lblDeliveryItemError.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnRecordDeliveryForOrder
			// 
			btnRecordDeliveryForOrder.Anchor = AnchorStyles.None;
			btnRecordDeliveryForOrder.BackColor = Color.FromArgb(0, 151, 136);
			btnRecordDeliveryForOrder.FlatAppearance.BorderSize = 0;
			btnRecordDeliveryForOrder.FlatStyle = FlatStyle.Flat;
			btnRecordDeliveryForOrder.Font = new Font("Segoe UI", 12F);
			btnRecordDeliveryForOrder.ForeColor = Color.White;
			btnRecordDeliveryForOrder.Location = new Point(211, 211);
			btnRecordDeliveryForOrder.Margin = new Padding(3, 2, 3, 2);
			btnRecordDeliveryForOrder.Name = "btnRecordDeliveryForOrder";
			btnRecordDeliveryForOrder.Size = new Size(220, 50);
			btnRecordDeliveryForOrder.TabIndex = 31;
			btnRecordDeliveryForOrder.Text = "Record Delivery";
			btnRecordDeliveryForOrder.UseVisualStyleBackColor = false;
			btnRecordDeliveryForOrder.Click += btnRecordDeliveryForOrder_Click;
			// 
			// btnMarkOrderAsCompleted
			// 
			btnMarkOrderAsCompleted.Anchor = AnchorStyles.None;
			btnMarkOrderAsCompleted.BackColor = Color.FromArgb(0, 151, 136);
			btnMarkOrderAsCompleted.FlatAppearance.BorderSize = 0;
			btnMarkOrderAsCompleted.FlatStyle = FlatStyle.Flat;
			btnMarkOrderAsCompleted.Font = new Font("Segoe UI", 12F);
			btnMarkOrderAsCompleted.ForeColor = Color.White;
			btnMarkOrderAsCompleted.Location = new Point(542, 211);
			btnMarkOrderAsCompleted.Margin = new Padding(3, 2, 3, 2);
			btnMarkOrderAsCompleted.Name = "btnMarkOrderAsCompleted";
			btnMarkOrderAsCompleted.Size = new Size(220, 50);
			btnMarkOrderAsCompleted.TabIndex = 27;
			btnMarkOrderAsCompleted.Text = "Order Completed";
			btnMarkOrderAsCompleted.UseVisualStyleBackColor = false;
			btnMarkOrderAsCompleted.Click += btnMarkOrderAsCompleted_Click;
			// 
			// lblOrderDateAndStatus
			// 
			lblOrderDateAndStatus.Anchor = AnchorStyles.None;
			lblOrderDateAndStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderDateAndStatus.ForeColor = Color.Black;
			lblOrderDateAndStatus.Location = new Point(334, 16);
			lblOrderDateAndStatus.Name = "lblOrderDateAndStatus";
			lblOrderDateAndStatus.Size = new Size(515, 32);
			lblOrderDateAndStatus.TabIndex = 28;
			lblOrderDateAndStatus.Text = "Order Date And Status Goes Here";
			lblOrderDateAndStatus.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lstViewOrderItemsDelivered
			// 
			lstViewOrderItemsDelivered.Anchor = AnchorStyles.None;
			lstViewOrderItemsDelivered.BackColor = Color.FromArgb(0, 214, 194);
			lstViewOrderItemsDelivered.Columns.AddRange(new ColumnHeader[] { cHeaderOrderItem, cHeaderQuantityOrdered, cHeaderDeliveryStatus, cHeaderQuantityReceived, cHeaderQuantityFaulty });
			lstViewOrderItemsDelivered.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrderItemsDelivered.ForeColor = Color.Black;
			lstViewOrderItemsDelivered.FullRowSelect = true;
			lstViewOrderItemsDelivered.GridLines = true;
			lstViewOrderItemsDelivered.Location = new Point(118, 50);
			lstViewOrderItemsDelivered.Margin = new Padding(3, 2, 3, 2);
			lstViewOrderItemsDelivered.MultiSelect = false;
			lstViewOrderItemsDelivered.Name = "lstViewOrderItemsDelivered";
			lstViewOrderItemsDelivered.Size = new Size(731, 150);
			lstViewOrderItemsDelivered.TabIndex = 2;
			lstViewOrderItemsDelivered.UseCompatibleStateImageBehavior = false;
			lstViewOrderItemsDelivered.View = View.Details;
			lstViewOrderItemsDelivered.ItemSelectionChanged += lstViewOrderItemsDelivered_ItemSelectionChanged;
			// 
			// cHeaderOrderItem
			// 
			cHeaderOrderItem.Text = "Item";
			cHeaderOrderItem.Width = 230;
			// 
			// cHeaderQuantityOrdered
			// 
			cHeaderQuantityOrdered.Text = "Qty Ordered";
			cHeaderQuantityOrdered.Width = 120;
			// 
			// cHeaderDeliveryStatus
			// 
			cHeaderDeliveryStatus.Text = "Status";
			cHeaderDeliveryStatus.Width = 120;
			// 
			// cHeaderQuantityReceived
			// 
			cHeaderQuantityReceived.Text = "Qty Received";
			cHeaderQuantityReceived.Width = 120;
			// 
			// cHeaderQuantityFaulty
			// 
			cHeaderQuantityFaulty.Text = "Qty Faulty";
			cHeaderQuantityFaulty.Width = 120;
			// 
			// lblOrderNumber
			// 
			lblOrderNumber.Anchor = AnchorStyles.None;
			lblOrderNumber.AutoSize = true;
			lblOrderNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderNumber.ForeColor = Color.Black;
			lblOrderNumber.Location = new Point(118, 20);
			lblOrderNumber.Name = "lblOrderNumber";
			lblOrderNumber.Size = new Size(183, 25);
			lblOrderNumber.TabIndex = 0;
			lblOrderNumber.Text = "Order No Goes Here";
			// 
			// pnlDeliveryDetails
			// 
			pnlDeliveryDetails.Anchor = AnchorStyles.None;
			pnlDeliveryDetails.Controls.Add(lblInstructionsDeliveryItem);
			pnlDeliveryDetails.Controls.Add(lblDeliveryDate);
			pnlDeliveryDetails.Controls.Add(btnMarkDeliveryAsCompleted);
			pnlDeliveryDetails.Controls.Add(btnAddItem);
			pnlDeliveryDetails.Controls.Add(lblDeliveryNumber);
			pnlDeliveryDetails.Controls.Add(lstViewDeliveryItems);
			pnlDeliveryDetails.Location = new Point(118, 274);
			pnlDeliveryDetails.Name = "pnlDeliveryDetails";
			pnlDeliveryDetails.Size = new Size(731, 316);
			pnlDeliveryDetails.TabIndex = 33;
			// 
			// lblInstructionsDeliveryItem
			// 
			lblInstructionsDeliveryItem.Anchor = AnchorStyles.None;
			lblInstructionsDeliveryItem.AutoSize = true;
			lblInstructionsDeliveryItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructionsDeliveryItem.ForeColor = Color.Black;
			lblInstructionsDeliveryItem.Location = new Point(88, 9);
			lblInstructionsDeliveryItem.Name = "lblInstructionsDeliveryItem";
			lblInstructionsDeliveryItem.Size = new Size(554, 25);
			lblInstructionsDeliveryItem.TabIndex = 35;
			lblInstructionsDeliveryItem.Text = "Select an item from the order above to add to the delivery below";
			// 
			// lblDeliveryDate
			// 
			lblDeliveryDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveryDate.ForeColor = Color.Black;
			lblDeliveryDate.Location = new Point(377, 101);
			lblDeliveryDate.Name = "lblDeliveryDate";
			lblDeliveryDate.Size = new Size(349, 32);
			lblDeliveryDate.TabIndex = 33;
			lblDeliveryDate.Text = "Delivery Date Goes Here";
			lblDeliveryDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnMarkDeliveryAsCompleted
			// 
			btnMarkDeliveryAsCompleted.Anchor = AnchorStyles.None;
			btnMarkDeliveryAsCompleted.BackColor = Color.FromArgb(0, 151, 136);
			btnMarkDeliveryAsCompleted.FlatAppearance.BorderSize = 0;
			btnMarkDeliveryAsCompleted.FlatStyle = FlatStyle.Flat;
			btnMarkDeliveryAsCompleted.Font = new Font("Segoe UI", 12F);
			btnMarkDeliveryAsCompleted.ForeColor = Color.White;
			btnMarkDeliveryAsCompleted.Location = new Point(424, 48);
			btnMarkDeliveryAsCompleted.Margin = new Padding(3, 2, 3, 2);
			btnMarkDeliveryAsCompleted.Name = "btnMarkDeliveryAsCompleted";
			btnMarkDeliveryAsCompleted.Size = new Size(220, 50);
			btnMarkDeliveryAsCompleted.TabIndex = 32;
			btnMarkDeliveryAsCompleted.Text = "Delivery Completed";
			btnMarkDeliveryAsCompleted.UseVisualStyleBackColor = false;
			btnMarkDeliveryAsCompleted.Click += btnMarkDeliveryAsCompleted_Click;
			// 
			// btnAddItem
			// 
			btnAddItem.Anchor = AnchorStyles.None;
			btnAddItem.BackColor = Color.FromArgb(0, 151, 136);
			btnAddItem.FlatAppearance.BorderSize = 0;
			btnAddItem.FlatStyle = FlatStyle.Flat;
			btnAddItem.Font = new Font("Segoe UI", 12F);
			btnAddItem.ForeColor = Color.White;
			btnAddItem.Location = new Point(93, 48);
			btnAddItem.Margin = new Padding(3, 2, 3, 2);
			btnAddItem.Name = "btnAddItem";
			btnAddItem.Size = new Size(220, 50);
			btnAddItem.TabIndex = 26;
			btnAddItem.Text = "Add Item";
			btnAddItem.UseVisualStyleBackColor = false;
			btnAddItem.Click += btnAddItem_Click;
			// 
			// lblDeliveryNumber
			// 
			lblDeliveryNumber.AutoSize = true;
			lblDeliveryNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveryNumber.ForeColor = Color.Black;
			lblDeliveryNumber.Location = new Point(3, 101);
			lblDeliveryNumber.Name = "lblDeliveryNumber";
			lblDeliveryNumber.Size = new Size(202, 25);
			lblDeliveryNumber.TabIndex = 30;
			lblDeliveryNumber.Text = "Delivery No Goes Here";
			// 
			// lstViewDeliveryItems
			// 
			lstViewDeliveryItems.BackColor = Color.FromArgb(0, 214, 194);
			lstViewDeliveryItems.Columns.AddRange(new ColumnHeader[] { cHeaderItem, cHeaderDeliveryQuantityReceived, cHeaderDeliveryQuantityFaulty });
			lstViewDeliveryItems.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewDeliveryItems.ForeColor = Color.Black;
			lstViewDeliveryItems.FullRowSelect = true;
			lstViewDeliveryItems.GridLines = true;
			lstViewDeliveryItems.Location = new Point(3, 135);
			lstViewDeliveryItems.Margin = new Padding(3, 2, 3, 2);
			lstViewDeliveryItems.MultiSelect = false;
			lstViewDeliveryItems.Name = "lstViewDeliveryItems";
			lstViewDeliveryItems.Size = new Size(731, 177);
			lstViewDeliveryItems.TabIndex = 29;
			lstViewDeliveryItems.UseCompatibleStateImageBehavior = false;
			lstViewDeliveryItems.View = View.Details;
			// 
			// cHeaderItem
			// 
			cHeaderItem.Text = "Item";
			cHeaderItem.Width = 230;
			// 
			// cHeaderDeliveryQuantityReceived
			// 
			cHeaderDeliveryQuantityReceived.Text = "Qty Received";
			cHeaderDeliveryQuantityReceived.Width = 200;
			// 
			// cHeaderDeliveryQuantityFaulty
			// 
			cHeaderDeliveryQuantityFaulty.Text = "Qty Faulty";
			cHeaderDeliveryQuantityFaulty.Width = 200;
			// 
			// pnlItemToAddToDelivery
			// 
			pnlItemToAddToDelivery.Controls.Add(btnAddItemToDelivery);
			pnlItemToAddToDelivery.Controls.Add(lblQuantityFaulty);
			pnlItemToAddToDelivery.Controls.Add(lblQuantityDelivered);
			pnlItemToAddToDelivery.Controls.Add(nUDQuantityDelivered);
			pnlItemToAddToDelivery.Controls.Add(nUDQuantityFaulty);
			pnlItemToAddToDelivery.Controls.Add(lblSelectedItem);
			pnlItemToAddToDelivery.Controls.Add(lblSelectedItemQuantity);
			pnlItemToAddToDelivery.Dock = DockStyle.Top;
			pnlItemToAddToDelivery.Location = new Point(0, 1360);
			pnlItemToAddToDelivery.Name = "pnlItemToAddToDelivery";
			pnlItemToAddToDelivery.Size = new Size(966, 680);
			pnlItemToAddToDelivery.TabIndex = 6;
			// 
			// btnAddItemToDelivery
			// 
			btnAddItemToDelivery.Anchor = AnchorStyles.None;
			btnAddItemToDelivery.BackColor = Color.FromArgb(0, 151, 136);
			btnAddItemToDelivery.FlatAppearance.BorderSize = 0;
			btnAddItemToDelivery.FlatStyle = FlatStyle.Flat;
			btnAddItemToDelivery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddItemToDelivery.ForeColor = Color.White;
			btnAddItemToDelivery.Location = new Point(373, 389);
			btnAddItemToDelivery.Margin = new Padding(3, 2, 3, 2);
			btnAddItemToDelivery.Name = "btnAddItemToDelivery";
			btnAddItemToDelivery.Size = new Size(220, 50);
			btnAddItemToDelivery.TabIndex = 29;
			btnAddItemToDelivery.Text = "Add Item To Delivery";
			btnAddItemToDelivery.UseVisualStyleBackColor = false;
			btnAddItemToDelivery.Click += btnAddItemToDelivery_Click;
			// 
			// lblQuantityFaulty
			// 
			lblQuantityFaulty.Anchor = AnchorStyles.None;
			lblQuantityFaulty.AutoSize = true;
			lblQuantityFaulty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblQuantityFaulty.ForeColor = Color.Black;
			lblQuantityFaulty.Location = new Point(542, 265);
			lblQuantityFaulty.Name = "lblQuantityFaulty";
			lblQuantityFaulty.Size = new Size(142, 25);
			lblQuantityFaulty.TabIndex = 28;
			lblQuantityFaulty.Text = "Quantity Faulty:";
			lblQuantityFaulty.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblQuantityDelivered
			// 
			lblQuantityDelivered.Anchor = AnchorStyles.None;
			lblQuantityDelivered.AutoSize = true;
			lblQuantityDelivered.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblQuantityDelivered.ForeColor = Color.Black;
			lblQuantityDelivered.Location = new Point(258, 265);
			lblQuantityDelivered.Name = "lblQuantityDelivered";
			lblQuantityDelivered.Size = new Size(173, 25);
			lblQuantityDelivered.TabIndex = 27;
			lblQuantityDelivered.Text = "Quantity Delivered:";
			lblQuantityDelivered.TextAlign = ContentAlignment.TopCenter;
			// 
			// nUDQuantityDelivered
			// 
			nUDQuantityDelivered.Anchor = AnchorStyles.None;
			nUDQuantityDelivered.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nUDQuantityDelivered.Location = new Point(264, 293);
			nUDQuantityDelivered.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nUDQuantityDelivered.Name = "nUDQuantityDelivered";
			nUDQuantityDelivered.Size = new Size(176, 32);
			nUDQuantityDelivered.TabIndex = 26;
			nUDQuantityDelivered.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// nUDQuantityFaulty
			// 
			nUDQuantityFaulty.Anchor = AnchorStyles.None;
			nUDQuantityFaulty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nUDQuantityFaulty.Location = new Point(546, 293);
			nUDQuantityFaulty.Name = "nUDQuantityFaulty";
			nUDQuantityFaulty.Size = new Size(176, 32);
			nUDQuantityFaulty.TabIndex = 25;
			// 
			// lblSelectedItem
			// 
			lblSelectedItem.Anchor = AnchorStyles.None;
			lblSelectedItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSelectedItem.ForeColor = Color.Black;
			lblSelectedItem.Location = new Point(218, 88);
			lblSelectedItem.Name = "lblSelectedItem";
			lblSelectedItem.Size = new Size(530, 32);
			lblSelectedItem.TabIndex = 2;
			lblSelectedItem.Text = "Item Name Goes Here";
			lblSelectedItem.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblSelectedItemQuantity
			// 
			lblSelectedItemQuantity.Anchor = AnchorStyles.None;
			lblSelectedItemQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSelectedItemQuantity.ForeColor = Color.Black;
			lblSelectedItemQuantity.Location = new Point(218, 140);
			lblSelectedItemQuantity.Name = "lblSelectedItemQuantity";
			lblSelectedItemQuantity.Size = new Size(530, 108);
			lblSelectedItemQuantity.TabIndex = 1;
			lblSelectedItemQuantity.Text = "Item Quantity Goes Here";
			lblSelectedItemQuantity.TextAlign = ContentAlignment.TopCenter;
			// 
			// frmAddDelivery
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			BackColor = Color.FromArgb(200, 200, 200);
			ClientSize = new Size(984, 711);
			Controls.Add(pnlItemToAddToDelivery);
			Controls.Add(pnlDelivery);
			Controls.Add(pnlOrders);
			Name = "frmAddDelivery";
			Text = "frmAddDelivery";
			Resize += frmAddDelivery_Resize;
			pnlOrders.ResumeLayout(false);
			pnlDelivery.ResumeLayout(false);
			pnlDelivery.PerformLayout();
			pnlDeliveryDetails.ResumeLayout(false);
			pnlDeliveryDetails.PerformLayout();
			pnlItemToAddToDelivery.ResumeLayout(false);
			pnlItemToAddToDelivery.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nUDQuantityDelivered).EndInit();
			((System.ComponentModel.ISupportInitialize)nUDQuantityFaulty).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlOrders;
        private ListView lstViewOrders;
        private ColumnHeader cHeaderOrderNumber;
        private ColumnHeader cHeaderOrderDate;
        private Button btnRecordDelivery;
        private Panel pnlDelivery;
        private Button btnMarkOrderAsCompleted;
        private Button btnAddItem;
        private ListView lstViewOrderItemsDelivered;
        private ColumnHeader cHeaderOrderItem;
        private ColumnHeader cHeaderQuantityOrdered;
        private Label lblOrderNumber;
        private Panel pnlItemToAddToDelivery;
        private Label lblSelectedItem;
        private Label lblSelectedItemQuantity;
        private Label lblQuantityFaulty;
        private Label lblQuantityDelivered;
        private NumericUpDown nUDQuantityDelivered;
        private NumericUpDown nUDQuantityFaulty;
        private Button btnAddItemToDelivery;
        private ColumnHeader cHeaderDeliveryStatus;
        private ColumnHeader cHeaderQuantityReceived;
        private ColumnHeader cHeaderQuantityFaulty;
        private ListView lstViewDeliveryItems;
        private ColumnHeader cHeaderItem;
        private ColumnHeader cHeaderDeliveryQuantityReceived;
        private ColumnHeader cHeaderDeliveryQuantityFaulty;
        private Label lblDeliveryNumber;
        private Button btnMarkDeliveryAsCompleted;
        private Button btnRecordDeliveryForOrder;
        private ColumnHeader cHeaderOrderStatus;
        private Label lblOrderDateAndStatus;
        private Panel pnlDeliveryDetails;
        private Label lblDeliveryDate;
		private Label lblOrderError;
		private Label lblDeliveryItemError;
		private Label lblInstructionsDeliveryItem;
	}
}