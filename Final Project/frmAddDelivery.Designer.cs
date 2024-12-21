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
            btnRecordDelivery = new Button();
            lstViewOrders = new ListView();
            cHeaderOrderNumber = new ColumnHeader();
            cHeaderOrderDate = new ColumnHeader();
            pnlDelivery = new Panel();
            lblDate = new Label();
            button2 = new Button();
            btnAddItem = new Button();
            lstViewDeliveryItems = new ListView();
            cHeaderOrderItem = new ColumnHeader();
            cHeaderQuantityOrdered = new ColumnHeader();
            cHeaderDelivered = new ColumnHeader();
            cHeaderQuantityReceived = new ColumnHeader();
            cHeaderQuantityFaulty = new ColumnHeader();
            lblOrderNumber = new Label();
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
            pnlItemToAddToDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDQuantityDelivered).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDQuantityFaulty).BeginInit();
            SuspendLayout();
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(btnRecordDelivery);
            pnlOrders.Controls.Add(lstViewOrders);
            pnlOrders.Dock = DockStyle.Top;
            pnlOrders.Location = new Point(0, 0);
            pnlOrders.Margin = new Padding(3, 2, 3, 2);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(755, 560);
            pnlOrders.TabIndex = 2;
            // 
            // btnRecordDelivery
            // 
            btnRecordDelivery.Anchor = AnchorStyles.None;
            btnRecordDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRecordDelivery.Location = new Point(281, 493);
            btnRecordDelivery.Margin = new Padding(3, 2, 3, 2);
            btnRecordDelivery.Name = "btnRecordDelivery";
            btnRecordDelivery.Size = new Size(220, 50);
            btnRecordDelivery.TabIndex = 25;
            btnRecordDelivery.Text = "Record Delivery";
            btnRecordDelivery.UseVisualStyleBackColor = true;
            btnRecordDelivery.Click += btnRecordDelivery_Click;
            // 
            // lstViewOrders
            // 
            lstViewOrders.BackColor = Color.LightSeaGreen;
            lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderOrderNumber, cHeaderOrderDate });
            lstViewOrders.Dock = DockStyle.Top;
            lstViewOrders.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewOrders.ForeColor = SystemColors.Window;
            lstViewOrders.FullRowSelect = true;
            lstViewOrders.GridLines = true;
            lstViewOrders.Location = new Point(0, 0);
            lstViewOrders.Margin = new Padding(3, 2, 3, 2);
            lstViewOrders.Name = "lstViewOrders";
            lstViewOrders.Size = new Size(755, 467);
            lstViewOrders.TabIndex = 0;
            lstViewOrders.UseCompatibleStateImageBehavior = false;
            lstViewOrders.View = View.Details;
            lstViewOrders.ItemSelectionChanged += lstViewOrders_ItemSelectionChanged;
            // 
            // cHeaderOrderNumber
            // 
            cHeaderOrderNumber.Text = "Order Number";
            cHeaderOrderNumber.Width = 300;
            // 
            // cHeaderOrderDate
            // 
            cHeaderOrderDate.Text = "Order Date";
            cHeaderOrderDate.Width = 300;
            // 
            // pnlDelivery
            // 
            pnlDelivery.Controls.Add(lblDate);
            pnlDelivery.Controls.Add(button2);
            pnlDelivery.Controls.Add(btnAddItem);
            pnlDelivery.Controls.Add(lstViewDeliveryItems);
            pnlDelivery.Controls.Add(lblOrderNumber);
            pnlDelivery.Dock = DockStyle.Top;
            pnlDelivery.Location = new Point(0, 560);
            pnlDelivery.Name = "pnlDelivery";
            pnlDelivery.Size = new Size(755, 560);
            pnlDelivery.TabIndex = 4;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.ForeColor = SystemColors.Control;
            lblDate.Location = new Point(394, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(349, 32);
            lblDate.TabIndex = 28;
            lblDate.Text = "Date Goes Here";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(426, 486);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 27;
            button2.Text = "Something Else";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.None;
            btnAddItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(109, 486);
            btnAddItem.Margin = new Padding(3, 2, 3, 2);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(220, 50);
            btnAddItem.TabIndex = 26;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // lstViewDeliveryItems
            // 
            lstViewDeliveryItems.BackColor = Color.LightSeaGreen;
            lstViewDeliveryItems.Columns.AddRange(new ColumnHeader[] { cHeaderOrderItem, cHeaderQuantityOrdered, cHeaderDelivered, cHeaderQuantityReceived, cHeaderQuantityFaulty });
            lstViewDeliveryItems.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewDeliveryItems.ForeColor = SystemColors.Window;
            lstViewDeliveryItems.FullRowSelect = true;
            lstViewDeliveryItems.GridLines = true;
            lstViewDeliveryItems.Location = new Point(12, 69);
            lstViewDeliveryItems.Margin = new Padding(3, 2, 3, 2);
            lstViewDeliveryItems.MultiSelect = false;
            lstViewDeliveryItems.Name = "lstViewDeliveryItems";
            lstViewDeliveryItems.Size = new Size(731, 399);
            lstViewDeliveryItems.TabIndex = 2;
            lstViewDeliveryItems.UseCompatibleStateImageBehavior = false;
            lstViewDeliveryItems.View = View.Details;
            lstViewDeliveryItems.ItemSelectionChanged += lstViewDeliveryItems_ItemSelectionChanged;
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
            // cHeaderDelivered
            // 
            cHeaderDelivered.Text = "Delivered";
            cHeaderDelivered.Width = 120;
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
            lblOrderNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrderNumber.ForeColor = SystemColors.Control;
            lblOrderNumber.Location = new Point(12, 19);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(232, 32);
            lblOrderNumber.TabIndex = 0;
            lblOrderNumber.Text = "Order No Goes Here";
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
            pnlItemToAddToDelivery.Size = new Size(755, 560);
            pnlItemToAddToDelivery.TabIndex = 6;
            // 
            // btnAddItemToDelivery
            // 
            btnAddItemToDelivery.Anchor = AnchorStyles.None;
            btnAddItemToDelivery.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItemToDelivery.Location = new Point(267, 390);
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
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(436, 194);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 28;
            label1.Text = "Quantity Faulty:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblQuantityDelivered
            // 
            lblQuantityDelivered.AutoSize = true;
            lblQuantityDelivered.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantityDelivered.ForeColor = SystemColors.Control;
            lblQuantityDelivered.Location = new Point(137, 194);
            lblQuantityDelivered.Name = "lblQuantityDelivered";
            lblQuantityDelivered.Size = new Size(220, 32);
            lblQuantityDelivered.TabIndex = 27;
            lblQuantityDelivered.Text = "Quantity Delivered:";
            lblQuantityDelivered.TextAlign = ContentAlignment.TopCenter;
            // 
            // nUDQuantityDelivered
            // 
            nUDQuantityDelivered.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUDQuantityDelivered.Location = new Point(158, 242);
            nUDQuantityDelivered.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nUDQuantityDelivered.Name = "nUDQuantityDelivered";
            nUDQuantityDelivered.Size = new Size(176, 33);
            nUDQuantityDelivered.TabIndex = 26;
            nUDQuantityDelivered.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUDQuantityFaulty
            // 
            nUDQuantityFaulty.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUDQuantityFaulty.Location = new Point(440, 242);
            nUDQuantityFaulty.Name = "nUDQuantityFaulty";
            nUDQuantityFaulty.Size = new Size(176, 33);
            nUDQuantityFaulty.TabIndex = 25;
            // 
            // lblSelectedItem
            // 
            lblSelectedItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            lblSelectedItemQuantity.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(772, 559);
            Controls.Add(pnlItemToAddToDelivery);
            Controls.Add(pnlDelivery);
            Controls.Add(pnlOrders);
            Name = "frmAddDelivery";
            Text = "frmAddDelivery";
            pnlOrders.ResumeLayout(false);
            pnlDelivery.ResumeLayout(false);
            pnlDelivery.PerformLayout();
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
        private Button button2;
        private Button btnAddItem;
        private ListView lstViewDeliveryItems;
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
        private Label lblDate;
        private ColumnHeader cHeaderDelivered;
        private ColumnHeader cHeaderQuantityReceived;
        private ColumnHeader cHeaderQuantityFaulty;
    }
}