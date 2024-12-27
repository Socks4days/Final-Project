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
			btnViewOrRecordDelivery = new Button();
			lstViewOrders = new ListView();
			cHeaderOrderNumber = new ColumnHeader();
			cHeaderOrderDate = new ColumnHeader();
			cHeaderOrderStatus = new ColumnHeader();
			pnlDelivery = new Panel();
			btnRecordDeliveryForOrder = new Button();
			btnMarkOrderAsCompleted = new Button();
			lblOrderDate = new Label();
			lstViewOrderItemsDelivered = new ListView();
			cHeaderOrderItem = new ColumnHeader();
			cHeaderQuantityOrdered = new ColumnHeader();
			cHeaderDeliveryStatus = new ColumnHeader();
			cHeaderQuantityReceived = new ColumnHeader();
			cHeaderQuantityFaulty = new ColumnHeader();
			lblOrderNumber = new Label();
			pnlDeliveryDetails = new Panel();
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
			label1 = new Label();
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
			pnlOrders.Controls.Add(btnViewOrRecordDelivery);
			pnlOrders.Controls.Add(lstViewOrders);
			pnlOrders.Dock = DockStyle.Top;
			pnlOrders.Location = new Point(0, 0);
			pnlOrders.Margin = new Padding(3, 2, 3, 2);
			pnlOrders.Name = "pnlOrders";
			pnlOrders.Size = new Size(967, 560);
			pnlOrders.TabIndex = 2;
			// 
			// btnViewOrRecordDelivery
			// 
			btnViewOrRecordDelivery.Anchor = AnchorStyles.None;
			btnViewOrRecordDelivery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnViewOrRecordDelivery.Location = new Point(387, 493);
			btnViewOrRecordDelivery.Margin = new Padding(3, 2, 3, 2);
			btnViewOrRecordDelivery.Name = "btnViewOrRecordDelivery";
			btnViewOrRecordDelivery.Size = new Size(220, 50);
			btnViewOrRecordDelivery.TabIndex = 25;
			btnViewOrRecordDelivery.Text = "View or Record Delivery";
			btnViewOrRecordDelivery.UseVisualStyleBackColor = true;
			btnViewOrRecordDelivery.Click += btnRecordDelivery_Click;
			// 
			// lstViewOrders
			// 
			lstViewOrders.BackColor = Color.FromArgb(200, 200, 200);
			lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderOrderNumber, cHeaderOrderDate, cHeaderOrderStatus });
			lstViewOrders.Dock = DockStyle.Top;
			lstViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrders.ForeColor = SystemColors.Window;
			lstViewOrders.FullRowSelect = true;
			lstViewOrders.GridLines = true;
			lstViewOrders.Location = new Point(0, 0);
			lstViewOrders.Margin = new Padding(3, 2, 3, 2);
			lstViewOrders.Name = "lstViewOrders";
			lstViewOrders.Size = new Size(967, 467);
			lstViewOrders.TabIndex = 0;
			lstViewOrders.UseCompatibleStateImageBehavior = false;
			lstViewOrders.View = View.Details;
			lstViewOrders.ItemSelectionChanged += lstViewOrders_ItemSelectionChanged;
			// 
			// cHeaderOrderNumber
			// 
			cHeaderOrderNumber.Text = "Order Number";
			cHeaderOrderNumber.Width = 150;
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
			pnlDelivery.Controls.Add(btnRecordDeliveryForOrder);
			pnlDelivery.Controls.Add(btnMarkOrderAsCompleted);
			pnlDelivery.Controls.Add(lblOrderDate);
			pnlDelivery.Controls.Add(lstViewOrderItemsDelivered);
			pnlDelivery.Controls.Add(lblOrderNumber);
			pnlDelivery.Controls.Add(pnlDeliveryDetails);
			pnlDelivery.Dock = DockStyle.Top;
			pnlDelivery.Location = new Point(0, 560);
			pnlDelivery.Name = "pnlDelivery";
			pnlDelivery.Size = new Size(967, 560);
			pnlDelivery.TabIndex = 4;
			// 
			// btnRecordDeliveryForOrder
			// 
			btnRecordDeliveryForOrder.Anchor = AnchorStyles.None;
			btnRecordDeliveryForOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnRecordDeliveryForOrder.Location = new Point(215, 223);
			btnRecordDeliveryForOrder.Margin = new Padding(3, 2, 3, 2);
			btnRecordDeliveryForOrder.Name = "btnRecordDeliveryForOrder";
			btnRecordDeliveryForOrder.Size = new Size(220, 50);
			btnRecordDeliveryForOrder.TabIndex = 31;
			btnRecordDeliveryForOrder.Text = "Record Delivery For Order";
			btnRecordDeliveryForOrder.UseVisualStyleBackColor = true;
			btnRecordDeliveryForOrder.Click += btnRecordDeliveryForOrder_Click;
			// 
			// btnMarkOrderAsCompleted
			// 
			btnMarkOrderAsCompleted.Anchor = AnchorStyles.None;
			btnMarkOrderAsCompleted.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnMarkOrderAsCompleted.Location = new Point(546, 223);
			btnMarkOrderAsCompleted.Margin = new Padding(3, 2, 3, 2);
			btnMarkOrderAsCompleted.Name = "btnMarkOrderAsCompleted";
			btnMarkOrderAsCompleted.Size = new Size(220, 50);
			btnMarkOrderAsCompleted.TabIndex = 27;
			btnMarkOrderAsCompleted.Text = "Mark Order As Completed";
			btnMarkOrderAsCompleted.UseVisualStyleBackColor = true;
			// 
			// lblOrderDate
			// 
			lblOrderDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderDate.ForeColor = SystemColors.Control;
			lblOrderDate.Location = new Point(394, 19);
			lblOrderDate.Name = "lblOrderDate";
			lblOrderDate.Size = new Size(349, 32);
			lblOrderDate.TabIndex = 28;
			lblOrderDate.Text = "Order Date Goes Here";
			lblOrderDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lstViewOrderItemsDelivered
			// 
			lstViewOrderItemsDelivered.BackColor = Color.FromArgb(200, 200, 200);
			lstViewOrderItemsDelivered.Columns.AddRange(new ColumnHeader[] { cHeaderOrderItem, cHeaderQuantityOrdered, cHeaderDeliveryStatus, cHeaderQuantityReceived, cHeaderQuantityFaulty });
			lstViewOrderItemsDelivered.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrderItemsDelivered.ForeColor = SystemColors.Window;
			lstViewOrderItemsDelivered.FullRowSelect = true;
			lstViewOrderItemsDelivered.GridLines = true;
			lstViewOrderItemsDelivered.Location = new Point(12, 53);
			lstViewOrderItemsDelivered.Margin = new Padding(3, 2, 3, 2);
			lstViewOrderItemsDelivered.MultiSelect = false;
			lstViewOrderItemsDelivered.Name = "lstViewOrderItemsDelivered";
			lstViewOrderItemsDelivered.Size = new Size(731, 150);
			lstViewOrderItemsDelivered.TabIndex = 2;
			lstViewOrderItemsDelivered.UseCompatibleStateImageBehavior = false;
			lstViewOrderItemsDelivered.View = View.Details;
			lstViewOrderItemsDelivered.ItemSelectionChanged += lstViewDeliveryItems_ItemSelectionChanged;
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
			lblOrderNumber.AutoSize = true;
			lblOrderNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblOrderNumber.ForeColor = SystemColors.Control;
			lblOrderNumber.Location = new Point(12, 19);
			lblOrderNumber.Name = "lblOrderNumber";
			lblOrderNumber.Size = new Size(183, 25);
			lblOrderNumber.TabIndex = 0;
			lblOrderNumber.Text = "Order No Goes Here";
			// 
			// pnlDeliveryDetails
			// 
			pnlDeliveryDetails.Controls.Add(lblDeliveryDate);
			pnlDeliveryDetails.Controls.Add(btnMarkDeliveryAsCompleted);
			pnlDeliveryDetails.Controls.Add(btnAddItem);
			pnlDeliveryDetails.Controls.Add(lblDeliveryNumber);
			pnlDeliveryDetails.Controls.Add(lstViewDeliveryItems);
			pnlDeliveryDetails.Location = new Point(12, 278);
			pnlDeliveryDetails.Name = "pnlDeliveryDetails";
			pnlDeliveryDetails.Size = new Size(731, 276);
			pnlDeliveryDetails.TabIndex = 33;
			// 
			// lblDeliveryDate
			// 
			lblDeliveryDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveryDate.ForeColor = SystemColors.Control;
			lblDeliveryDate.Location = new Point(379, 10);
			lblDeliveryDate.Name = "lblDeliveryDate";
			lblDeliveryDate.Size = new Size(349, 32);
			lblDeliveryDate.TabIndex = 33;
			lblDeliveryDate.Text = "Delivery Date Goes Here";
			lblDeliveryDate.TextAlign = ContentAlignment.MiddleRight;
			// 
			// btnMarkDeliveryAsCompleted
			// 
			btnMarkDeliveryAsCompleted.Anchor = AnchorStyles.None;
			btnMarkDeliveryAsCompleted.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnMarkDeliveryAsCompleted.Location = new Point(433, 208);
			btnMarkDeliveryAsCompleted.Margin = new Padding(3, 2, 3, 2);
			btnMarkDeliveryAsCompleted.Name = "btnMarkDeliveryAsCompleted";
			btnMarkDeliveryAsCompleted.Size = new Size(220, 50);
			btnMarkDeliveryAsCompleted.TabIndex = 32;
			btnMarkDeliveryAsCompleted.Text = "Mark Delivery As Completed";
			btnMarkDeliveryAsCompleted.UseVisualStyleBackColor = true;
			btnMarkDeliveryAsCompleted.Click += btnMarkDeliveryAsCompleted_Click;
			// 
			// btnAddItem
			// 
			btnAddItem.Anchor = AnchorStyles.None;
			btnAddItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddItem.Location = new Point(102, 208);
			btnAddItem.Margin = new Padding(3, 2, 3, 2);
			btnAddItem.Name = "btnAddItem";
			btnAddItem.Size = new Size(220, 50);
			btnAddItem.TabIndex = 26;
			btnAddItem.Text = "Add Item For Delivery";
			btnAddItem.UseVisualStyleBackColor = true;
			btnAddItem.Click += btnAddItem_Click;
			// 
			// lblDeliveryNumber
			// 
			lblDeliveryNumber.AutoSize = true;
			lblDeliveryNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveryNumber.ForeColor = SystemColors.Control;
			lblDeliveryNumber.Location = new Point(5, 10);
			lblDeliveryNumber.Name = "lblDeliveryNumber";
			lblDeliveryNumber.Size = new Size(202, 25);
			lblDeliveryNumber.TabIndex = 30;
			lblDeliveryNumber.Text = "Delivery No Goes Here";
			// 
			// lstViewDeliveryItems
			// 
			lstViewDeliveryItems.BackColor = Color.FromArgb(200, 200, 200);
			lstViewDeliveryItems.Columns.AddRange(new ColumnHeader[] { cHeaderItem, cHeaderDeliveryQuantityReceived, cHeaderDeliveryQuantityFaulty });
			lstViewDeliveryItems.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewDeliveryItems.ForeColor = SystemColors.Window;
			lstViewDeliveryItems.FullRowSelect = true;
			lstViewDeliveryItems.GridLines = true;
			lstViewDeliveryItems.Location = new Point(5, 44);
			lstViewDeliveryItems.Margin = new Padding(3, 2, 3, 2);
			lstViewDeliveryItems.MultiSelect = false;
			lstViewDeliveryItems.Name = "lstViewDeliveryItems";
			lstViewDeliveryItems.Size = new Size(731, 150);
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
			cHeaderDeliveryQuantityReceived.Width = 120;
			// 
			// cHeaderDeliveryQuantityFaulty
			// 
			cHeaderDeliveryQuantityFaulty.Text = "Qty Faulty";
			cHeaderDeliveryQuantityFaulty.Width = 120;
			// 
			// pnlItemToAddToDelivery
			// 
			pnlItemToAddToDelivery.Controls.Add(btnAddItemToDelivery);
			pnlItemToAddToDelivery.Controls.Add(label1);
			pnlItemToAddToDelivery.Controls.Add(lblQuantityDelivered);
			pnlItemToAddToDelivery.Controls.Add(nUDQuantityDelivered);
			pnlItemToAddToDelivery.Controls.Add(nUDQuantityFaulty);
			pnlItemToAddToDelivery.Controls.Add(lblSelectedItem);
			pnlItemToAddToDelivery.Controls.Add(lblSelectedItemQuantity);
			pnlItemToAddToDelivery.Dock = DockStyle.Top;
			pnlItemToAddToDelivery.Location = new Point(0, 1120);
			pnlItemToAddToDelivery.Name = "pnlItemToAddToDelivery";
			pnlItemToAddToDelivery.Size = new Size(967, 560);
			pnlItemToAddToDelivery.TabIndex = 6;
			// 
			// btnAddItemToDelivery
			// 
			btnAddItemToDelivery.Anchor = AnchorStyles.None;
			btnAddItemToDelivery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnAddItemToDelivery.Location = new Point(373, 390);
			btnAddItemToDelivery.Margin = new Padding(3, 2, 3, 2);
			btnAddItemToDelivery.Name = "btnAddItemToDelivery";
			btnAddItemToDelivery.Size = new Size(220, 50);
			btnAddItemToDelivery.TabIndex = 29;
			btnAddItemToDelivery.Text = "Add Item To Delivery";
			btnAddItemToDelivery.UseVisualStyleBackColor = true;
			btnAddItemToDelivery.Click += btnAddItemToDelivery_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(436, 194);
			label1.Name = "label1";
			label1.Size = new Size(142, 25);
			label1.TabIndex = 28;
			label1.Text = "Quantity Faulty:";
			label1.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblQuantityDelivered
			// 
			lblQuantityDelivered.AutoSize = true;
			lblQuantityDelivered.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblQuantityDelivered.ForeColor = SystemColors.Control;
			lblQuantityDelivered.Location = new Point(137, 194);
			lblQuantityDelivered.Name = "lblQuantityDelivered";
			lblQuantityDelivered.Size = new Size(173, 25);
			lblQuantityDelivered.TabIndex = 27;
			lblQuantityDelivered.Text = "Quantity Delivered:";
			lblQuantityDelivered.TextAlign = ContentAlignment.TopCenter;
			// 
			// nUDQuantityDelivered
			// 
			nUDQuantityDelivered.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nUDQuantityDelivered.Location = new Point(158, 242);
			nUDQuantityDelivered.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nUDQuantityDelivered.Name = "nUDQuantityDelivered";
			nUDQuantityDelivered.Size = new Size(176, 32);
			nUDQuantityDelivered.TabIndex = 26;
			nUDQuantityDelivered.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// nUDQuantityFaulty
			// 
			nUDQuantityFaulty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nUDQuantityFaulty.Location = new Point(440, 242);
			nUDQuantityFaulty.Name = "nUDQuantityFaulty";
			nUDQuantityFaulty.Size = new Size(176, 32);
			nUDQuantityFaulty.TabIndex = 25;
			// 
			// lblSelectedItem
			// 
			lblSelectedItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSelectedItem.ForeColor = SystemColors.Control;
			lblSelectedItem.Location = new Point(112, 52);
			lblSelectedItem.Name = "lblSelectedItem";
			lblSelectedItem.Size = new Size(530, 32);
			lblSelectedItem.TabIndex = 2;
			lblSelectedItem.Text = "Item Name Goes Here";
			lblSelectedItem.TextAlign = ContentAlignment.TopCenter;
			// 
			// lblSelectedItemQuantity
			// 
			lblSelectedItemQuantity.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSelectedItemQuantity.ForeColor = SystemColors.Control;
			lblSelectedItemQuantity.Location = new Point(112, 104);
			lblSelectedItemQuantity.Name = "lblSelectedItemQuantity";
			lblSelectedItemQuantity.Size = new Size(530, 32);
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
        private Button btnViewOrRecordDelivery;
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
        private Label label1;
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
        private Label lblOrderDate;
        private Panel pnlDeliveryDetails;
        private Label lblDeliveryDate;
    }
}