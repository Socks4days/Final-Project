namespace Final_Project
{
	partial class frmCreateAudit
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
			pnlCreateAudit = new Panel();
			btnCancel = new Button();
			label1 = new Label();
			nUDNoInStockActual = new NumericUpDown();
			lblNoExpectedInStock = new Label();
			btnCreatAudit = new Button();
			pnlAuditInfo = new Panel();
			lblAuditNumber = new Label();
			lstViewDeliveryItems = new ListView();
			cHeaderStockItemAudited = new ColumnHeader();
			cHeaderQuantityExpected = new ColumnHeader();
			cHeaderActualQuantity = new ColumnHeader();
			btnAddItemToAudit = new Button();
			btnCompleteAudit = new Button();
			lblAuditError = new Label();
			lstViewAllStock = new ListView();
			cHeaderOrderItem = new ColumnHeader();
			cHeaderLastAudited = new ColumnHeader();
			cHeaderLastCheckedBy = new ColumnHeader();
			cHeaderItem = new ColumnHeader();
			pnlAuditHistory = new Panel();
			pnlCreateAudit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUDNoInStockActual).BeginInit();
			pnlAuditInfo.SuspendLayout();
			SuspendLayout();
			// 
			// pnlCreateAudit
			// 
			pnlCreateAudit.Controls.Add(btnCancel);
			pnlCreateAudit.Controls.Add(label1);
			pnlCreateAudit.Controls.Add(nUDNoInStockActual);
			pnlCreateAudit.Controls.Add(lblNoExpectedInStock);
			pnlCreateAudit.Controls.Add(btnCreatAudit);
			pnlCreateAudit.Dock = DockStyle.Top;
			pnlCreateAudit.Location = new Point(0, 0);
			pnlCreateAudit.Name = "pnlCreateAudit";
			pnlCreateAudit.Size = new Size(966, 680);
			pnlCreateAudit.TabIndex = 0;
			// 
			// btnCancel
			// 
			btnCancel.Anchor = AnchorStyles.Top;
			btnCancel.BackColor = Color.FromArgb(255, 138, 98);
			btnCancel.FlatAppearance.BorderSize = 0;
			btnCancel.FlatStyle = FlatStyle.Flat;
			btnCancel.Font = new Font("Segoe UI", 14F);
			btnCancel.ForeColor = Color.White;
			btnCancel.Location = new Point(236, 374);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(220, 50);
			btnCancel.TabIndex = 7;
			btnCancel.Text = "Cancel";
			btnCancel.UseVisualStyleBackColor = false;
			btnCancel.Click += btnCancel_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top;
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14F);
			label1.Location = new Point(373, 241);
			label1.Name = "label1";
			label1.Size = new Size(204, 25);
			label1.TabIndex = 5;
			label1.Text = "Enter Number In Stock:";
			// 
			// nUDNoInStockActual
			// 
			nUDNoInStockActual.Anchor = AnchorStyles.Top;
			nUDNoInStockActual.Font = new Font("Segoe UI", 14F);
			nUDNoInStockActual.Location = new Point(373, 269);
			nUDNoInStockActual.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
			nUDNoInStockActual.Name = "nUDNoInStockActual";
			nUDNoInStockActual.Size = new Size(220, 32);
			nUDNoInStockActual.TabIndex = 4;
			// 
			// lblNoExpectedInStock
			// 
			lblNoExpectedInStock.Anchor = AnchorStyles.Top;
			lblNoExpectedInStock.AutoSize = true;
			lblNoExpectedInStock.Font = new Font("Segoe UI", 14F);
			lblNoExpectedInStock.Location = new Point(365, 173);
			lblNoExpectedInStock.Name = "lblNoExpectedInStock";
			lblNoExpectedInStock.Size = new Size(236, 25);
			lblNoExpectedInStock.TabIndex = 2;
			lblNoExpectedInStock.Text = "Number Expected In Stock:";
			// 
			// btnCreatAudit
			// 
			btnCreatAudit.Anchor = AnchorStyles.Top;
			btnCreatAudit.BackColor = Color.FromArgb(255, 138, 98);
			btnCreatAudit.FlatAppearance.BorderSize = 0;
			btnCreatAudit.FlatStyle = FlatStyle.Flat;
			btnCreatAudit.Font = new Font("Segoe UI", 14F);
			btnCreatAudit.ForeColor = Color.White;
			btnCreatAudit.Location = new Point(511, 374);
			btnCreatAudit.Name = "btnCreatAudit";
			btnCreatAudit.Size = new Size(220, 50);
			btnCreatAudit.TabIndex = 1;
			btnCreatAudit.Text = "Create Audit";
			btnCreatAudit.UseVisualStyleBackColor = false;
			// 
			// pnlAuditInfo
			// 
			pnlAuditInfo.Controls.Add(lblAuditNumber);
			pnlAuditInfo.Controls.Add(lstViewDeliveryItems);
			pnlAuditInfo.Controls.Add(btnAddItemToAudit);
			pnlAuditInfo.Controls.Add(btnCompleteAudit);
			pnlAuditInfo.Controls.Add(lblAuditError);
			pnlAuditInfo.Controls.Add(lstViewAllStock);
			pnlAuditInfo.Dock = DockStyle.Top;
			pnlAuditInfo.Location = new Point(0, 680);
			pnlAuditInfo.Name = "pnlAuditInfo";
			pnlAuditInfo.Size = new Size(966, 680);
			pnlAuditInfo.TabIndex = 1;
			// 
			// lblAuditNumber
			// 
			lblAuditNumber.AutoSize = true;
			lblAuditNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAuditNumber.ForeColor = Color.Black;
			lblAuditNumber.Location = new Point(119, 33);
			lblAuditNumber.Name = "lblAuditNumber";
			lblAuditNumber.Size = new Size(179, 25);
			lblAuditNumber.TabIndex = 46;
			lblAuditNumber.Text = "Audit No Goes Here";
			// 
			// lstViewDeliveryItems
			// 
			lstViewDeliveryItems.BackColor = Color.FromArgb(255, 192, 167);
			lstViewDeliveryItems.Columns.AddRange(new ColumnHeader[] { cHeaderStockItemAudited, cHeaderQuantityExpected, cHeaderActualQuantity });
			lstViewDeliveryItems.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewDeliveryItems.ForeColor = Color.Black;
			lstViewDeliveryItems.FullRowSelect = true;
			lstViewDeliveryItems.GridLines = true;
			lstViewDeliveryItems.Location = new Point(116, 329);
			lstViewDeliveryItems.Margin = new Padding(3, 2, 3, 2);
			lstViewDeliveryItems.MultiSelect = false;
			lstViewDeliveryItems.Name = "lstViewDeliveryItems";
			lstViewDeliveryItems.Size = new Size(735, 173);
			lstViewDeliveryItems.TabIndex = 45;
			lstViewDeliveryItems.UseCompatibleStateImageBehavior = false;
			lstViewDeliveryItems.View = View.Details;
			// 
			// cHeaderStockItemAudited
			// 
			cHeaderStockItemAudited.Text = "Stock Item Audited";
			cHeaderStockItemAudited.Width = 330;
			// 
			// cHeaderQuantityExpected
			// 
			cHeaderQuantityExpected.Text = "Expected Quantity";
			cHeaderQuantityExpected.Width = 200;
			// 
			// cHeaderActualQuantity
			// 
			cHeaderActualQuantity.Text = "Actual Quantity";
			cHeaderActualQuantity.Width = 199;
			// 
			// btnAddItemToAudit
			// 
			btnAddItemToAudit.Anchor = AnchorStyles.None;
			btnAddItemToAudit.BackColor = Color.FromArgb(255, 138, 98);
			btnAddItemToAudit.FlatAppearance.BorderSize = 0;
			btnAddItemToAudit.FlatStyle = FlatStyle.Flat;
			btnAddItemToAudit.Font = new Font("Segoe UI", 12F);
			btnAddItemToAudit.ForeColor = Color.White;
			btnAddItemToAudit.Location = new Point(160, 261);
			btnAddItemToAudit.Margin = new Padding(3, 2, 3, 2);
			btnAddItemToAudit.Name = "btnAddItemToAudit";
			btnAddItemToAudit.Size = new Size(220, 50);
			btnAddItemToAudit.TabIndex = 44;
			btnAddItemToAudit.Text = "Add Item";
			btnAddItemToAudit.UseVisualStyleBackColor = false;
			btnAddItemToAudit.Click += btnAddItemToAudit_Click;
			// 
			// btnCompleteAudit
			// 
			btnCompleteAudit.Anchor = AnchorStyles.None;
			btnCompleteAudit.BackColor = Color.FromArgb(255, 138, 98);
			btnCompleteAudit.FlatAppearance.BorderSize = 0;
			btnCompleteAudit.FlatStyle = FlatStyle.Flat;
			btnCompleteAudit.Font = new Font("Segoe UI", 12F);
			btnCompleteAudit.ForeColor = Color.White;
			btnCompleteAudit.Location = new Point(588, 261);
			btnCompleteAudit.Margin = new Padding(3, 2, 3, 2);
			btnCompleteAudit.Name = "btnCompleteAudit";
			btnCompleteAudit.Size = new Size(220, 50);
			btnCompleteAudit.TabIndex = 42;
			btnCompleteAudit.Text = "Audit Completed";
			btnCompleteAudit.UseVisualStyleBackColor = false;
			btnCompleteAudit.Click += btnCompleteAudit_Click;
			// 
			// lblAuditError
			// 
			lblAuditError.Anchor = AnchorStyles.Top;
			lblAuditError.BackColor = Color.FromArgb(255, 209, 209);
			lblAuditError.BorderStyle = BorderStyle.FixedSingle;
			lblAuditError.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblAuditError.ForeColor = Color.FromArgb(250, 0, 0);
			lblAuditError.Location = new Point(231, 601);
			lblAuditError.Name = "lblAuditError";
			lblAuditError.Size = new Size(505, 61);
			lblAuditError.TabIndex = 41;
			lblAuditError.Text = "Error message goes here";
			lblAuditError.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lstViewAllStock
			// 
			lstViewAllStock.Anchor = AnchorStyles.Top;
			lstViewAllStock.BackColor = Color.FromArgb(255, 192, 167);
			lstViewAllStock.Columns.AddRange(new ColumnHeader[] { cHeaderOrderItem, cHeaderLastAudited, cHeaderLastCheckedBy });
			lstViewAllStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewAllStock.ForeColor = Color.Black;
			lstViewAllStock.FullRowSelect = true;
			lstViewAllStock.GridLines = true;
			lstViewAllStock.Location = new Point(116, 75);
			lstViewAllStock.Margin = new Padding(3, 2, 3, 2);
			lstViewAllStock.MultiSelect = false;
			lstViewAllStock.Name = "lstViewAllStock";
			lstViewAllStock.Size = new Size(735, 167);
			lstViewAllStock.TabIndex = 36;
			lstViewAllStock.UseCompatibleStateImageBehavior = false;
			lstViewAllStock.View = View.Details;
			// 
			// cHeaderOrderItem
			// 
			cHeaderOrderItem.Text = "Stock Item To Audit";
			cHeaderOrderItem.Width = 350;
			// 
			// cHeaderLastAudited
			// 
			cHeaderLastAudited.Text = "Last Checked";
			cHeaderLastAudited.Width = 160;
			// 
			// cHeaderLastCheckedBy
			// 
			cHeaderLastCheckedBy.Text = "Checked By";
			cHeaderLastCheckedBy.Width = 200;
			// 
			// cHeaderItem
			// 
			cHeaderItem.Text = "Stock Item Audited";
			cHeaderItem.Width = 330;
			// 
			// pnlAuditHistory
			// 
			pnlAuditHistory.Dock = DockStyle.Top;
			pnlAuditHistory.Location = new Point(0, 1360);
			pnlAuditHistory.Name = "pnlAuditHistory";
			pnlAuditHistory.Size = new Size(966, 680);
			pnlAuditHistory.TabIndex = 2;
			// 
			// frmCreateAudit
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			BackColor = SystemColors.ScrollBar;
			ClientSize = new Size(984, 681);
			Controls.Add(pnlAuditHistory);
			Controls.Add(pnlAuditInfo);
			Controls.Add(pnlCreateAudit);
			Name = "frmCreateAudit";
			Text = "frmCreateAudit";
			pnlCreateAudit.ResumeLayout(false);
			pnlCreateAudit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nUDNoInStockActual).EndInit();
			pnlAuditInfo.ResumeLayout(false);
			pnlAuditInfo.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlCreateAudit;
		private NumericUpDown numericUpDown1;
		private Label lblNoExpectedInStock;
		private Button btnCreatAudit;
		private NumericUpDown nUDNoInStockActual;
		private Label label1;
		private Button btnCancel;
		private Panel pnlAuditInfo;
		private Label lblAuditError;
		private Button btnCompleteAudit;
		private Label lblOrderDateAndStatus;
		private ListView lstViewAllStock;
		private ColumnHeader cHeaderOrderItem;
		private ColumnHeader cHeaderLastAudited;
		private Label lblOrderNumber;
		private Label lblInstructionsDeliveryItem;
		private Label lblDeliveryDate;
		private Button btnMarkDeliveryAsCompleted;
		private Button btnAddItem;
		private ColumnHeader cHeaderItem;
		private ColumnHeader cHeaderDeliveryQuantityReceived;
		private Button btnAddItemToAudit;
		private Label lblAuditNumber;
		private ListView lstViewDeliveryItems;
		private ColumnHeader cHeaderStockItemAudited;
		private ColumnHeader cHeaderQuantityExpected;
		private ColumnHeader cHeaderActualQuantity;
		private ColumnHeader cHeaderLastCheckedBy;
		private Panel pnlAuditHistory;
	}
}