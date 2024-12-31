namespace Final_Project
{
    partial class frmViewOrders
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
			btnViewOrder = new Button();
			btnEditOrder = new Button();
			lblInstructions = new Label();
			lstViewOrders = new ListView();
			cHeaderOrderNumber = new ColumnHeader();
			cHeaderOrderStatus = new ColumnHeader();
			cHeaderDateOrdered = new ColumnHeader();
			pnlOrderInfo.SuspendLayout();
			SuspendLayout();
			// 
			// pnlOrderInfo
			// 
			pnlOrderInfo.BackColor = SystemColors.ScrollBar;
			pnlOrderInfo.Controls.Add(btnViewOrder);
			pnlOrderInfo.Controls.Add(btnEditOrder);
			pnlOrderInfo.Controls.Add(lblInstructions);
			pnlOrderInfo.Controls.Add(lstViewOrders);
			pnlOrderInfo.Dock = DockStyle.Fill;
			pnlOrderInfo.Location = new Point(0, 0);
			pnlOrderInfo.Name = "pnlOrderInfo";
			pnlOrderInfo.Size = new Size(984, 680);
			pnlOrderInfo.TabIndex = 5;
			// 
			// btnViewOrder
			// 
			btnViewOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnViewOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnViewOrder.FlatAppearance.BorderSize = 0;
			btnViewOrder.FlatStyle = FlatStyle.Flat;
			btnViewOrder.Font = new Font("Segoe UI", 14F);
			btnViewOrder.ForeColor = SystemColors.Control;
			btnViewOrder.Location = new Point(239, 618);
			btnViewOrder.Name = "btnViewOrder";
			btnViewOrder.Size = new Size(220, 50);
			btnViewOrder.TabIndex = 17;
			btnViewOrder.Text = "View Order";
			btnViewOrder.UseVisualStyleBackColor = false;
			// 
			// btnEditOrder
			// 
			btnEditOrder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnEditOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnEditOrder.FlatAppearance.BorderSize = 0;
			btnEditOrder.FlatStyle = FlatStyle.Flat;
			btnEditOrder.Font = new Font("Segoe UI", 14F);
			btnEditOrder.ForeColor = SystemColors.Control;
			btnEditOrder.Location = new Point(525, 618);
			btnEditOrder.Name = "btnEditOrder";
			btnEditOrder.Size = new Size(220, 50);
			btnEditOrder.TabIndex = 16;
			btnEditOrder.Text = "Edit Order";
			btnEditOrder.UseVisualStyleBackColor = false;
			// 
			// lblInstructions
			// 
			lblInstructions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			lblInstructions.AutoSize = true;
			lblInstructions.FlatStyle = FlatStyle.Flat;
			lblInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructions.ForeColor = SystemColors.ControlText;
			lblInstructions.Location = new Point(311, 568);
			lblInstructions.Name = "lblInstructions";
			lblInstructions.Size = new Size(362, 25);
			lblInstructions.TabIndex = 15;
			lblInstructions.Text = "Select an order to manage its information";
			// 
			// lstViewOrders
			// 
			lstViewOrders.BackColor = Color.FromArgb(227, 115, 166);
			lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderOrderNumber, cHeaderOrderStatus, cHeaderDateOrdered });
			lstViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrders.ForeColor = Color.White;
			lstViewOrders.FullRowSelect = true;
			lstViewOrders.GridLines = true;
			lstViewOrders.Location = new Point(26, 23);
			lstViewOrders.Name = "lstViewOrders";
			lstViewOrders.Size = new Size(932, 518);
			lstViewOrders.TabIndex = 0;
			lstViewOrders.UseCompatibleStateImageBehavior = false;
			lstViewOrders.View = View.Details;
			lstViewOrders.ItemSelectionChanged += lstViewOrders_ItemSelectionChanged;
			// 
			// cHeaderOrderNumber
			// 
			cHeaderOrderNumber.Text = "Order Number";
			cHeaderOrderNumber.Width = 250;
			// 
			// cHeaderOrderStatus
			// 
			cHeaderOrderStatus.Text = "Order Status";
			cHeaderOrderStatus.Width = 250;
			// 
			// cHeaderDateOrdered
			// 
			cHeaderDateOrdered.Text = "Date Ordered";
			cHeaderDateOrdered.Width = 250;
			// 
			// frmViewOrders
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			ClientSize = new Size(984, 680);
			Controls.Add(pnlOrderInfo);
			Name = "frmViewOrders";
			Text = "frmViewOrders";
			Resize += frmViewOrders_Resize;
			pnlOrderInfo.ResumeLayout(false);
			pnlOrderInfo.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Button btnPlaceOrder;
        private Button btnSaveAsDraft;
        private Button btnRemoveFromOrder;
		private Panel pnlOrderInfo;
		private Label lblInstructions;
		private ListView lstViewOrders;
		private ColumnHeader cHeaderOrderNumber;
		private ColumnHeader cHeaderOrderStatus;
		private ColumnHeader cHeaderDateOrdered;
		private Button btnViewOrder;
		private Button btnEditOrder;
	}
}