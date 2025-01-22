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
			lblStockToAudit = new Label();
			btnCancel = new Button();
			lblEnterNumberInStock = new Label();
			nUDNoInStockActual = new NumericUpDown();
			lblNoExpectedInStock = new Label();
			btnAddToAudit = new Button();
			pnlAuditInfo = new Panel();
			lblAuditNumber = new Label();
			lstViewAuditItems = new ListView();
			cHeaderStockItemAudited = new ColumnHeader();
			cHeaderQuantityExpected = new ColumnHeader();
			cHeaderActualQuantity = new ColumnHeader();
			btnAddItemToAudit = new Button();
			btnCompleteAudit = new Button();
			lblAuditError = new Label();
			lstViewAllStock = new ListView();
			cHeaderStockItem = new ColumnHeader();
			cHeaderLastAudited = new ColumnHeader();
			cHeaderLastCheckedBy = new ColumnHeader();
			cHeaderNextCheck = new ColumnHeader();
			cHeaderItem = new ColumnHeader();
			pnlAuditHistory = new Panel();
			btnViewAuditDetails = new Button();
			lstViewAuditHistory = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			columnHeader5 = new ColumnHeader();
			pnlAuditHistoryDetails = new Panel();
			btnReturnToAuditHistory = new Button();
			lstViewAuditHistoryDetails = new ListView();
			columnHeader6 = new ColumnHeader();
			columnHeader7 = new ColumnHeader();
			columnHeader8 = new ColumnHeader();
			pnlCreateAudit.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nUDNoInStockActual).BeginInit();
			pnlAuditInfo.SuspendLayout();
			pnlAuditHistory.SuspendLayout();
			pnlAuditHistoryDetails.SuspendLayout();
			SuspendLayout();
			// 
			// pnlCreateAudit
			// 
			pnlCreateAudit.Controls.Add(lblStockToAudit);
			pnlCreateAudit.Controls.Add(btnCancel);
			pnlCreateAudit.Controls.Add(lblEnterNumberInStock);
			pnlCreateAudit.Controls.Add(nUDNoInStockActual);
			pnlCreateAudit.Controls.Add(lblNoExpectedInStock);
			pnlCreateAudit.Controls.Add(btnAddToAudit);
			pnlCreateAudit.Dock = DockStyle.Top;
			pnlCreateAudit.Location = new Point(0, 0);
			pnlCreateAudit.Name = "pnlCreateAudit";
			pnlCreateAudit.Size = new Size(966, 680);
			pnlCreateAudit.TabIndex = 0;
			// 
			// lblStockToAudit
			// 
			lblStockToAudit.Anchor = AnchorStyles.Top;
			lblStockToAudit.Font = new Font("Segoe UI", 14F);
			lblStockToAudit.Location = new Point(298, 123);
			lblStockToAudit.Name = "lblStockToAudit";
			lblStockToAudit.Size = new Size(370, 25);
			lblStockToAudit.TabIndex = 8;
			lblStockToAudit.Text = "Stock To Audit:";
			lblStockToAudit.TextAlign = ContentAlignment.MiddleCenter;
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
			// lblEnterNumberInStock
			// 
			lblEnterNumberInStock.Anchor = AnchorStyles.Top;
			lblEnterNumberInStock.AutoSize = true;
			lblEnterNumberInStock.Font = new Font("Segoe UI", 14F);
			lblEnterNumberInStock.Location = new Point(373, 241);
			lblEnterNumberInStock.Name = "lblEnterNumberInStock";
			lblEnterNumberInStock.Size = new Size(204, 25);
			lblEnterNumberInStock.TabIndex = 5;
			lblEnterNumberInStock.Text = "Enter Number In Stock:";
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
			lblNoExpectedInStock.Font = new Font("Segoe UI", 14F);
			lblNoExpectedInStock.Location = new Point(324, 173);
			lblNoExpectedInStock.Name = "lblNoExpectedInStock";
			lblNoExpectedInStock.Size = new Size(318, 25);
			lblNoExpectedInStock.TabIndex = 2;
			lblNoExpectedInStock.Text = "Number Expected In Stock:";
			lblNoExpectedInStock.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnAddToAudit
			// 
			btnAddToAudit.Anchor = AnchorStyles.Top;
			btnAddToAudit.BackColor = Color.FromArgb(255, 138, 98);
			btnAddToAudit.FlatAppearance.BorderSize = 0;
			btnAddToAudit.FlatStyle = FlatStyle.Flat;
			btnAddToAudit.Font = new Font("Segoe UI", 14F);
			btnAddToAudit.ForeColor = Color.White;
			btnAddToAudit.Location = new Point(511, 374);
			btnAddToAudit.Name = "btnAddToAudit";
			btnAddToAudit.Size = new Size(220, 50);
			btnAddToAudit.TabIndex = 1;
			btnAddToAudit.Text = "Add To Audit";
			btnAddToAudit.UseVisualStyleBackColor = false;
			btnAddToAudit.Click += btnCreateAudit_Click;
			// 
			// pnlAuditInfo
			// 
			pnlAuditInfo.Controls.Add(lblAuditNumber);
			pnlAuditInfo.Controls.Add(lstViewAuditItems);
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
			lblAuditNumber.Anchor = AnchorStyles.None;
			lblAuditNumber.AutoSize = true;
			lblAuditNumber.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAuditNumber.ForeColor = Color.Black;
			lblAuditNumber.Location = new Point(119, 33);
			lblAuditNumber.Name = "lblAuditNumber";
			lblAuditNumber.Size = new Size(179, 25);
			lblAuditNumber.TabIndex = 46;
			lblAuditNumber.Text = "Audit No Goes Here";
			// 
			// lstViewAuditItems
			// 
			lstViewAuditItems.Anchor = AnchorStyles.None;
			lstViewAuditItems.BackColor = Color.FromArgb(255, 192, 167);
			lstViewAuditItems.Columns.AddRange(new ColumnHeader[] { cHeaderStockItemAudited, cHeaderQuantityExpected, cHeaderActualQuantity });
			lstViewAuditItems.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewAuditItems.ForeColor = Color.Black;
			lstViewAuditItems.FullRowSelect = true;
			lstViewAuditItems.GridLines = true;
			lstViewAuditItems.Location = new Point(50, 330);
			lstViewAuditItems.Margin = new Padding(3, 2, 3, 2);
			lstViewAuditItems.MultiSelect = false;
			lstViewAuditItems.Name = "lstViewAuditItems";
			lstViewAuditItems.Size = new Size(866, 173);
			lstViewAuditItems.TabIndex = 45;
			lstViewAuditItems.UseCompatibleStateImageBehavior = false;
			lstViewAuditItems.View = View.Details;
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
			lblAuditError.Anchor = AnchorStyles.None;
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
			lstViewAllStock.Anchor = AnchorStyles.None;
			lstViewAllStock.BackColor = Color.FromArgb(255, 192, 167);
			lstViewAllStock.Columns.AddRange(new ColumnHeader[] { cHeaderStockItem, cHeaderLastAudited, cHeaderLastCheckedBy, cHeaderNextCheck });
			lstViewAllStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewAllStock.ForeColor = Color.Black;
			lstViewAllStock.FullRowSelect = true;
			lstViewAllStock.GridLines = true;
			lstViewAllStock.Location = new Point(50, 77);
			lstViewAllStock.Margin = new Padding(3, 2, 3, 2);
			lstViewAllStock.MultiSelect = false;
			lstViewAllStock.Name = "lstViewAllStock";
			lstViewAllStock.Size = new Size(866, 167);
			lstViewAllStock.TabIndex = 36;
			lstViewAllStock.UseCompatibleStateImageBehavior = false;
			lstViewAllStock.View = View.Details;
			lstViewAllStock.ItemSelectionChanged += lstViewAllStock_ItemSelectionChanged;
			// 
			// cHeaderStockItem
			// 
			cHeaderStockItem.Text = "Stock Item To Audit";
			cHeaderStockItem.Width = 350;
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
			// cHeaderNextCheck
			// 
			cHeaderNextCheck.Text = "Next Check";
			cHeaderNextCheck.Width = 150;
			// 
			// cHeaderItem
			// 
			cHeaderItem.Text = "Stock Item Audited";
			cHeaderItem.Width = 330;
			// 
			// pnlAuditHistory
			// 
			pnlAuditHistory.Controls.Add(btnViewAuditDetails);
			pnlAuditHistory.Controls.Add(lstViewAuditHistory);
			pnlAuditHistory.Dock = DockStyle.Top;
			pnlAuditHistory.Location = new Point(0, 1360);
			pnlAuditHistory.Name = "pnlAuditHistory";
			pnlAuditHistory.Size = new Size(966, 680);
			pnlAuditHistory.TabIndex = 2;
			// 
			// btnViewAuditDetails
			// 
			btnViewAuditDetails.Anchor = AnchorStyles.Bottom;
			btnViewAuditDetails.BackColor = Color.FromArgb(255, 138, 98);
			btnViewAuditDetails.FlatAppearance.BorderSize = 0;
			btnViewAuditDetails.FlatStyle = FlatStyle.Flat;
			btnViewAuditDetails.Font = new Font("Segoe UI", 12F);
			btnViewAuditDetails.ForeColor = Color.White;
			btnViewAuditDetails.Location = new Point(373, 615);
			btnViewAuditDetails.Margin = new Padding(3, 2, 3, 2);
			btnViewAuditDetails.Name = "btnViewAuditDetails";
			btnViewAuditDetails.Size = new Size(220, 50);
			btnViewAuditDetails.TabIndex = 47;
			btnViewAuditDetails.Text = "View Audit Details";
			btnViewAuditDetails.UseVisualStyleBackColor = false;
			btnViewAuditDetails.Click += btnViewAuditDetails_Click;
			// 
			// lstViewAuditHistory
			// 
			lstViewAuditHistory.Anchor = AnchorStyles.Top;
			lstViewAuditHistory.BackColor = Color.FromArgb(255, 192, 167);
			lstViewAuditHistory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
			lstViewAuditHistory.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewAuditHistory.ForeColor = Color.Black;
			lstViewAuditHistory.FullRowSelect = true;
			lstViewAuditHistory.GridLines = true;
			lstViewAuditHistory.Location = new Point(93, 25);
			lstViewAuditHistory.Margin = new Padding(3, 2, 3, 2);
			lstViewAuditHistory.MaximumSize = new Size(790, 553);
			lstViewAuditHistory.MultiSelect = false;
			lstViewAuditHistory.Name = "lstViewAuditHistory";
			lstViewAuditHistory.Size = new Size(790, 553);
			lstViewAuditHistory.TabIndex = 46;
			lstViewAuditHistory.UseCompatibleStateImageBehavior = false;
			lstViewAuditHistory.View = View.Details;
			lstViewAuditHistory.ItemSelectionChanged += lstViewAuditHistory_ItemSelectionChanged;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Audit Number";
			columnHeader1.Width = 140;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Date Checked";
			columnHeader2.Width = 200;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Checked By";
			columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Correct";
			columnHeader4.Width = 120;
			// 
			// columnHeader5
			// 
			columnHeader5.Text = "Incorrect";
			columnHeader5.Width = 120;
			// 
			// pnlAuditHistoryDetails
			// 
			pnlAuditHistoryDetails.Controls.Add(btnReturnToAuditHistory);
			pnlAuditHistoryDetails.Controls.Add(lstViewAuditHistoryDetails);
			pnlAuditHistoryDetails.Dock = DockStyle.Top;
			pnlAuditHistoryDetails.Location = new Point(0, 2040);
			pnlAuditHistoryDetails.Name = "pnlAuditHistoryDetails";
			pnlAuditHistoryDetails.Size = new Size(966, 680);
			pnlAuditHistoryDetails.TabIndex = 3;
			// 
			// btnReturnToAuditHistory
			// 
			btnReturnToAuditHistory.Anchor = AnchorStyles.Bottom;
			btnReturnToAuditHistory.BackColor = Color.FromArgb(255, 138, 98);
			btnReturnToAuditHistory.FlatAppearance.BorderSize = 0;
			btnReturnToAuditHistory.FlatStyle = FlatStyle.Flat;
			btnReturnToAuditHistory.Font = new Font("Segoe UI", 12F);
			btnReturnToAuditHistory.ForeColor = Color.White;
			btnReturnToAuditHistory.Location = new Point(373, 619);
			btnReturnToAuditHistory.Margin = new Padding(3, 2, 3, 2);
			btnReturnToAuditHistory.Name = "btnReturnToAuditHistory";
			btnReturnToAuditHistory.Size = new Size(220, 50);
			btnReturnToAuditHistory.TabIndex = 48;
			btnReturnToAuditHistory.Text = "Return To Audits";
			btnReturnToAuditHistory.UseVisualStyleBackColor = false;
			btnReturnToAuditHistory.Click += btnBackToAuditHistory_Click;
			// 
			// lstViewAuditHistoryDetails
			// 
			lstViewAuditHistoryDetails.Anchor = AnchorStyles.Top;
			lstViewAuditHistoryDetails.BackColor = Color.FromArgb(255, 192, 167);
			lstViewAuditHistoryDetails.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8 });
			lstViewAuditHistoryDetails.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewAuditHistoryDetails.ForeColor = Color.Black;
			lstViewAuditHistoryDetails.FullRowSelect = true;
			lstViewAuditHistoryDetails.GridLines = true;
			lstViewAuditHistoryDetails.Location = new Point(88, 22);
			lstViewAuditHistoryDetails.Margin = new Padding(3, 2, 3, 2);
			lstViewAuditHistoryDetails.MultiSelect = false;
			lstViewAuditHistoryDetails.Name = "lstViewAuditHistoryDetails";
			lstViewAuditHistoryDetails.Size = new Size(790, 580);
			lstViewAuditHistoryDetails.TabIndex = 46;
			lstViewAuditHistoryDetails.UseCompatibleStateImageBehavior = false;
			lstViewAuditHistoryDetails.View = View.Details;
			// 
			// columnHeader6
			// 
			columnHeader6.Text = "Stock Item Checked";
			columnHeader6.Width = 300;
			// 
			// columnHeader7
			// 
			columnHeader7.Text = "Expected Quantity";
			columnHeader7.Width = 200;
			// 
			// columnHeader8
			// 
			columnHeader8.Text = "Actual Quantity";
			columnHeader8.Width = 200;
			// 
			// frmCreateAudit
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			BackColor = SystemColors.ScrollBar;
			ClientSize = new Size(984, 681);
			Controls.Add(pnlAuditHistoryDetails);
			Controls.Add(pnlAuditHistory);
			Controls.Add(pnlAuditInfo);
			Controls.Add(pnlCreateAudit);
			Name = "frmCreateAudit";
			Text = "frmCreateAudit";
			Resize += frmCreateAudit_Resize;
			pnlCreateAudit.ResumeLayout(false);
			pnlCreateAudit.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nUDNoInStockActual).EndInit();
			pnlAuditInfo.ResumeLayout(false);
			pnlAuditInfo.PerformLayout();
			pnlAuditHistory.ResumeLayout(false);
			pnlAuditHistoryDetails.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlCreateAudit;
		private NumericUpDown numericUpDown1;
		private Label lblNoExpectedInStock;
		private Button btnAddToAudit;
		private NumericUpDown nUDNoInStockActual;
		private Label lblEnterNumberInStock;
		private Button btnCancel;
		private Panel pnlAuditInfo;
		private Label lblAuditError;
		private Button btnCompleteAudit;
		private Label lblOrderDateAndStatus;
		private ListView lstViewAllStock;
		private ColumnHeader cHeaderStockItem;
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
		private ListView lstViewAuditItems;
		private ColumnHeader cHeaderStockItemAudited;
		private ColumnHeader cHeaderQuantityExpected;
		private ColumnHeader cHeaderActualQuantity;
		private ColumnHeader cHeaderLastCheckedBy;
		private Panel pnlAuditHistory;
		private Label lblStockToAudit;
		private ListView lstViewAuditHistory;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader cHeaderNextCheck;
		private Panel pnlAuditHistoryDetails;
		private ListView lstViewAuditHistoryDetails;
		private ColumnHeader columnHeader6;
		private ColumnHeader columnHeader7;
		private ColumnHeader columnHeader8;
		private Button btnViewAuditDetails;
		private Button btnReturnToAuditHistory;
	}
}