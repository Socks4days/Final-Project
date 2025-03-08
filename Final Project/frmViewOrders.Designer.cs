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
			components = new System.ComponentModel.Container();
			pnlOrderInfo = new Panel();
			btnOrderReport = new Button();
			btnCancelOrder = new Button();
			btnViewOrder = new Button();
			btnEditOrder = new Button();
			lblInstructions = new Label();
			lstViewOrders = new ListView();
			cHeaderOrderNumber = new ColumnHeader();
			cHeaderOrderStatus = new ColumnHeader();
			cHeaderDateOrdered = new ColumnHeader();
			cHeaderStaffName = new ColumnHeader();
			toolTipViewOrders = new ToolTip(components);
			pnlOrderInfo.SuspendLayout();
			SuspendLayout();
			// 
			// pnlOrderInfo
			// 
			pnlOrderInfo.BackColor = SystemColors.ScrollBar;
			pnlOrderInfo.Controls.Add(btnOrderReport);
			pnlOrderInfo.Controls.Add(btnCancelOrder);
			pnlOrderInfo.Controls.Add(btnViewOrder);
			pnlOrderInfo.Controls.Add(btnEditOrder);
			pnlOrderInfo.Controls.Add(lblInstructions);
			pnlOrderInfo.Controls.Add(lstViewOrders);
			pnlOrderInfo.Dock = DockStyle.Fill;
			pnlOrderInfo.Location = new Point(0, 0);
			pnlOrderInfo.Name = "pnlOrderInfo";
			pnlOrderInfo.Size = new Size(1000, 680);
			pnlOrderInfo.TabIndex = 5;
			// 
			// btnOrderReport
			// 
			btnOrderReport.Anchor = AnchorStyles.Bottom;
			btnOrderReport.BackColor = Color.FromArgb(161, 32, 89);
			btnOrderReport.FlatAppearance.BorderSize = 0;
			btnOrderReport.FlatStyle = FlatStyle.Flat;
			btnOrderReport.Font = new Font("Segoe UI", 14F);
			btnOrderReport.ForeColor = Color.White;
			btnOrderReport.Location = new Point(748, 618);
			btnOrderReport.Name = "btnOrderReport";
			btnOrderReport.Size = new Size(220, 50);
			btnOrderReport.TabIndex = 16;
			btnOrderReport.Text = "Order Report";
			toolTipViewOrders.SetToolTip(btnOrderReport, "View order report");
			btnOrderReport.UseVisualStyleBackColor = false;
			btnOrderReport.Click += btnOrderReport_Click;
			// 
			// btnCancelOrder
			// 
			btnCancelOrder.Anchor = AnchorStyles.Bottom;
			btnCancelOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnCancelOrder.FlatAppearance.BorderSize = 0;
			btnCancelOrder.FlatStyle = FlatStyle.Flat;
			btnCancelOrder.Font = new Font("Segoe UI", 14F);
			btnCancelOrder.ForeColor = Color.White;
			btnCancelOrder.Location = new Point(507, 618);
			btnCancelOrder.Name = "btnCancelOrder";
			btnCancelOrder.Size = new Size(220, 50);
			btnCancelOrder.TabIndex = 2;
			btnCancelOrder.Text = "Cancel Order";
			toolTipViewOrders.SetToolTip(btnCancelOrder, "Cancel order");
			btnCancelOrder.UseVisualStyleBackColor = false;
			btnCancelOrder.Click += btnCancelOrder_Click;
			// 
			// btnViewOrder
			// 
			btnViewOrder.Anchor = AnchorStyles.Bottom;
			btnViewOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnViewOrder.FlatAppearance.BorderSize = 0;
			btnViewOrder.FlatStyle = FlatStyle.Flat;
			btnViewOrder.Font = new Font("Segoe UI", 14F);
			btnViewOrder.ForeColor = Color.White;
			btnViewOrder.Location = new Point(26, 618);
			btnViewOrder.Name = "btnViewOrder";
			btnViewOrder.Size = new Size(220, 50);
			btnViewOrder.TabIndex = 0;
			btnViewOrder.Text = "View Order";
			toolTipViewOrders.SetToolTip(btnViewOrder, "View items in order");
			btnViewOrder.UseVisualStyleBackColor = false;
			btnViewOrder.Click += btnViewOrder_Click;
			// 
			// btnEditOrder
			// 
			btnEditOrder.Anchor = AnchorStyles.Bottom;
			btnEditOrder.BackColor = Color.FromArgb(161, 32, 89);
			btnEditOrder.FlatAppearance.BorderSize = 0;
			btnEditOrder.FlatStyle = FlatStyle.Flat;
			btnEditOrder.Font = new Font("Segoe UI", 14F);
			btnEditOrder.ForeColor = Color.White;
			btnEditOrder.Location = new Point(266, 618);
			btnEditOrder.Name = "btnEditOrder";
			btnEditOrder.Size = new Size(220, 50);
			btnEditOrder.TabIndex = 1;
			btnEditOrder.Text = "Edit Order";
			toolTipViewOrders.SetToolTip(btnEditOrder, "Edit items in drafted order");
			btnEditOrder.UseVisualStyleBackColor = false;
			btnEditOrder.Click += btnEditOrder_Click;
			// 
			// lblInstructions
			// 
			lblInstructions.Anchor = AnchorStyles.Bottom;
			lblInstructions.AutoSize = true;
			lblInstructions.FlatStyle = FlatStyle.Flat;
			lblInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructions.ForeColor = Color.Black;
			lblInstructions.Location = new Point(311, 568);
			lblInstructions.Name = "lblInstructions";
			lblInstructions.Size = new Size(362, 25);
			lblInstructions.TabIndex = 15;
			lblInstructions.Text = "Select an order to manage its information";
			// 
			// lstViewOrders
			// 
			lstViewOrders.Anchor = AnchorStyles.Top;
			lstViewOrders.BackColor = Color.FromArgb(227, 115, 166);
			lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderOrderNumber, cHeaderOrderStatus, cHeaderDateOrdered, cHeaderStaffName });
			lstViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrders.ForeColor = Color.Black;
			lstViewOrders.FullRowSelect = true;
			lstViewOrders.GridLines = true;
			lstViewOrders.Location = new Point(26, 23);
			lstViewOrders.Name = "lstViewOrders";
			lstViewOrders.Size = new Size(942, 518);
			lstViewOrders.TabIndex = 0;
			toolTipViewOrders.SetToolTip(lstViewOrders, "Select order to view options");
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
			// cHeaderStaffName
			// 
			cHeaderStaffName.Text = "Placed By";
			cHeaderStaffName.Width = 200;
			// 
			// frmViewOrders
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			ClientSize = new Size(1000, 680);
			Controls.Add(pnlOrderInfo);
			Name = "frmViewOrders";
			Text = "frmViewOrders";
			Resize += frmViewOrders_Resize;
			pnlOrderInfo.ResumeLayout(false);
			pnlOrderInfo.PerformLayout();
			ResumeLayout(false);
		}

		#endregion
		private Panel pnlOrderInfo;
		private Label lblInstructions;
		private ListView lstViewOrders;
		private ColumnHeader cHeaderOrderNumber;
		private ColumnHeader cHeaderOrderStatus;
		private ColumnHeader cHeaderDateOrdered;
		private Button btnViewOrder;
		private Button btnEditOrder;
		private ColumnHeader cHeaderStaffName;
		private Button btnCancelOrder;
		private Button btnOrderReport;
		private ToolTip toolTipViewOrders;
	}
}