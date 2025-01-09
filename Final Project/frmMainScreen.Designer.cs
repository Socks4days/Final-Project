namespace Final_Project
{
    partial class frmMainScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
			pnlSideBar = new Panel();
			pnlAudits = new Panel();
			btnAuditHistory = new Button();
			btnCreateAudit = new Button();
			btnAudits = new Button();
			pnlDelivery = new Panel();
			btnViewDeliveries = new Button();
			btnDelivery = new Button();
			pnlOrder = new Panel();
			btnViewOrders = new Button();
			btnOrderStock = new Button();
			btnOrder = new Button();
			pnlStock = new Panel();
			btnRetireStock = new Button();
			btnAddNewStock = new Button();
			btnManageStockLevels = new Button();
			btnStock = new Button();
			pnlLogo = new Panel();
			pctBoxSmallLogo = new PictureBox();
			pnlTitleBar = new Panel();
			lblTitle = new Label();
			pnlFormContainer = new Panel();
			pctBoxLogo = new PictureBox();
			pnlSideBar.SuspendLayout();
			pnlAudits.SuspendLayout();
			pnlDelivery.SuspendLayout();
			pnlOrder.SuspendLayout();
			pnlStock.SuspendLayout();
			pnlLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pctBoxSmallLogo).BeginInit();
			pnlTitleBar.SuspendLayout();
			pnlFormContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pctBoxLogo).BeginInit();
			SuspendLayout();
			// 
			// pnlSideBar
			// 
			pnlSideBar.AutoScroll = true;
			pnlSideBar.BackColor = Color.FromArgb(51, 51, 79);
			pnlSideBar.Controls.Add(pnlAudits);
			pnlSideBar.Controls.Add(btnAudits);
			pnlSideBar.Controls.Add(pnlDelivery);
			pnlSideBar.Controls.Add(btnDelivery);
			pnlSideBar.Controls.Add(pnlOrder);
			pnlSideBar.Controls.Add(btnOrder);
			pnlSideBar.Controls.Add(pnlStock);
			pnlSideBar.Controls.Add(btnStock);
			pnlSideBar.Controls.Add(pnlLogo);
			pnlSideBar.Dock = DockStyle.Left;
			pnlSideBar.Location = new Point(0, 0);
			pnlSideBar.Margin = new Padding(2);
			pnlSideBar.Name = "pnlSideBar";
			pnlSideBar.Size = new Size(200, 750);
			pnlSideBar.TabIndex = 0;
			// 
			// pnlAudits
			// 
			pnlAudits.Controls.Add(btnAuditHistory);
			pnlAudits.Controls.Add(btnCreateAudit);
			pnlAudits.Dock = DockStyle.Top;
			pnlAudits.Location = new Point(0, 770);
			pnlAudits.Name = "pnlAudits";
			pnlAudits.Size = new Size(182, 140);
			pnlAudits.TabIndex = 13;
			// 
			// btnAuditHistory
			// 
			btnAuditHistory.BackColor = Color.Transparent;
			btnAuditHistory.Dock = DockStyle.Top;
			btnAuditHistory.FlatAppearance.BorderSize = 0;
			btnAuditHistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnAuditHistory.FlatStyle = FlatStyle.Flat;
			btnAuditHistory.Font = new Font("Segoe UI", 14F);
			btnAuditHistory.ForeColor = SystemColors.Control;
			btnAuditHistory.Location = new Point(0, 70);
			btnAuditHistory.Margin = new Padding(2);
			btnAuditHistory.Name = "btnAuditHistory";
			btnAuditHistory.Padding = new Padding(20, 0, 0, 0);
			btnAuditHistory.Size = new Size(182, 70);
			btnAuditHistory.TabIndex = 14;
			btnAuditHistory.Text = "Audit History";
			btnAuditHistory.TextAlign = ContentAlignment.MiddleLeft;
			btnAuditHistory.UseVisualStyleBackColor = false;
			btnAuditHistory.Click += btnAuditHistory_Click;
			// 
			// btnCreateAudit
			// 
			btnCreateAudit.BackColor = Color.Transparent;
			btnCreateAudit.Dock = DockStyle.Top;
			btnCreateAudit.FlatAppearance.BorderSize = 0;
			btnCreateAudit.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnCreateAudit.FlatStyle = FlatStyle.Flat;
			btnCreateAudit.Font = new Font("Segoe UI", 14F);
			btnCreateAudit.ForeColor = SystemColors.Control;
			btnCreateAudit.Location = new Point(0, 0);
			btnCreateAudit.Margin = new Padding(2);
			btnCreateAudit.Name = "btnCreateAudit";
			btnCreateAudit.Padding = new Padding(20, 0, 0, 0);
			btnCreateAudit.Size = new Size(182, 70);
			btnCreateAudit.TabIndex = 13;
			btnCreateAudit.Text = "Create Audit";
			btnCreateAudit.TextAlign = ContentAlignment.MiddleLeft;
			btnCreateAudit.UseVisualStyleBackColor = false;
			btnCreateAudit.Click += btnCreateAudit_Click;
			// 
			// btnAudits
			// 
			btnAudits.BackColor = Color.Transparent;
			btnAudits.Dock = DockStyle.Top;
			btnAudits.FlatAppearance.BorderSize = 0;
			btnAudits.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnAudits.FlatStyle = FlatStyle.Flat;
			btnAudits.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			btnAudits.ForeColor = SystemColors.Control;
			btnAudits.Location = new Point(0, 700);
			btnAudits.Margin = new Padding(2);
			btnAudits.Name = "btnAudits";
			btnAudits.Size = new Size(182, 70);
			btnAudits.TabIndex = 12;
			btnAudits.Text = "Audits";
			btnAudits.TextAlign = ContentAlignment.MiddleLeft;
			btnAudits.UseVisualStyleBackColor = false;
			btnAudits.Click += btnAudits_Click;
			// 
			// pnlDelivery
			// 
			pnlDelivery.Controls.Add(btnViewDeliveries);
			pnlDelivery.Dock = DockStyle.Top;
			pnlDelivery.Font = new Font("Segoe UI", 14F);
			pnlDelivery.Location = new Point(0, 630);
			pnlDelivery.Margin = new Padding(2);
			pnlDelivery.Name = "pnlDelivery";
			pnlDelivery.Size = new Size(182, 70);
			pnlDelivery.TabIndex = 11;
			// 
			// btnViewDeliveries
			// 
			btnViewDeliveries.BackColor = Color.Transparent;
			btnViewDeliveries.Dock = DockStyle.Top;
			btnViewDeliveries.FlatAppearance.BorderSize = 0;
			btnViewDeliveries.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnViewDeliveries.FlatStyle = FlatStyle.Flat;
			btnViewDeliveries.Font = new Font("Segoe UI", 14F);
			btnViewDeliveries.ForeColor = SystemColors.Control;
			btnViewDeliveries.Location = new Point(0, 0);
			btnViewDeliveries.Margin = new Padding(2);
			btnViewDeliveries.Name = "btnViewDeliveries";
			btnViewDeliveries.Padding = new Padding(20, 0, 0, 0);
			btnViewDeliveries.Size = new Size(182, 70);
			btnViewDeliveries.TabIndex = 6;
			btnViewDeliveries.Text = "View Deliveries";
			btnViewDeliveries.TextAlign = ContentAlignment.MiddleLeft;
			btnViewDeliveries.UseVisualStyleBackColor = false;
			btnViewDeliveries.Click += btnViewDeliveries_Click;
			// 
			// btnDelivery
			// 
			btnDelivery.BackColor = Color.Transparent;
			btnDelivery.Dock = DockStyle.Top;
			btnDelivery.FlatAppearance.BorderSize = 0;
			btnDelivery.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnDelivery.FlatStyle = FlatStyle.Flat;
			btnDelivery.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			btnDelivery.ForeColor = SystemColors.Control;
			btnDelivery.Location = new Point(0, 560);
			btnDelivery.Margin = new Padding(2);
			btnDelivery.Name = "btnDelivery";
			btnDelivery.Size = new Size(182, 70);
			btnDelivery.TabIndex = 10;
			btnDelivery.Text = "Deliveries";
			btnDelivery.TextAlign = ContentAlignment.MiddleLeft;
			btnDelivery.UseVisualStyleBackColor = false;
			btnDelivery.Click += btnDelivery_Click;
			// 
			// pnlOrder
			// 
			pnlOrder.Controls.Add(btnViewOrders);
			pnlOrder.Controls.Add(btnOrderStock);
			pnlOrder.Dock = DockStyle.Top;
			pnlOrder.Location = new Point(0, 420);
			pnlOrder.Margin = new Padding(2);
			pnlOrder.Name = "pnlOrder";
			pnlOrder.Size = new Size(182, 140);
			pnlOrder.TabIndex = 9;
			// 
			// btnViewOrders
			// 
			btnViewOrders.BackColor = Color.Transparent;
			btnViewOrders.Dock = DockStyle.Top;
			btnViewOrders.FlatAppearance.BorderSize = 0;
			btnViewOrders.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnViewOrders.FlatStyle = FlatStyle.Flat;
			btnViewOrders.Font = new Font("Segoe UI", 14F);
			btnViewOrders.ForeColor = SystemColors.Control;
			btnViewOrders.Location = new Point(0, 70);
			btnViewOrders.Margin = new Padding(2);
			btnViewOrders.Name = "btnViewOrders";
			btnViewOrders.Padding = new Padding(20, 0, 0, 0);
			btnViewOrders.Size = new Size(182, 70);
			btnViewOrders.TabIndex = 5;
			btnViewOrders.Text = "View Orders";
			btnViewOrders.TextAlign = ContentAlignment.MiddleLeft;
			btnViewOrders.UseVisualStyleBackColor = false;
			btnViewOrders.Click += btnViewOrders_Click;
			// 
			// btnOrderStock
			// 
			btnOrderStock.BackColor = Color.Transparent;
			btnOrderStock.Dock = DockStyle.Top;
			btnOrderStock.FlatAppearance.BorderSize = 0;
			btnOrderStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnOrderStock.FlatStyle = FlatStyle.Flat;
			btnOrderStock.Font = new Font("Segoe UI", 14F);
			btnOrderStock.ForeColor = SystemColors.Control;
			btnOrderStock.Location = new Point(0, 0);
			btnOrderStock.Margin = new Padding(2);
			btnOrderStock.Name = "btnOrderStock";
			btnOrderStock.Padding = new Padding(20, 0, 0, 0);
			btnOrderStock.Size = new Size(182, 70);
			btnOrderStock.TabIndex = 4;
			btnOrderStock.Text = "Order Stock";
			btnOrderStock.TextAlign = ContentAlignment.MiddleLeft;
			btnOrderStock.UseVisualStyleBackColor = false;
			btnOrderStock.Click += btnOrderStock_Click;
			// 
			// btnOrder
			// 
			btnOrder.BackColor = Color.Transparent;
			btnOrder.Dock = DockStyle.Top;
			btnOrder.FlatAppearance.BorderSize = 0;
			btnOrder.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnOrder.FlatStyle = FlatStyle.Flat;
			btnOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			btnOrder.ForeColor = SystemColors.Control;
			btnOrder.Location = new Point(0, 350);
			btnOrder.Margin = new Padding(2);
			btnOrder.Name = "btnOrder";
			btnOrder.Size = new Size(182, 70);
			btnOrder.TabIndex = 4;
			btnOrder.Text = "Orders";
			btnOrder.TextAlign = ContentAlignment.MiddleLeft;
			btnOrder.UseVisualStyleBackColor = false;
			btnOrder.Click += btnOrder_Click;
			// 
			// pnlStock
			// 
			pnlStock.Controls.Add(btnRetireStock);
			pnlStock.Controls.Add(btnAddNewStock);
			pnlStock.Controls.Add(btnManageStockLevels);
			pnlStock.Dock = DockStyle.Top;
			pnlStock.Location = new Point(0, 140);
			pnlStock.Margin = new Padding(2);
			pnlStock.Name = "pnlStock";
			pnlStock.Size = new Size(182, 210);
			pnlStock.TabIndex = 3;
			// 
			// btnRetireStock
			// 
			btnRetireStock.BackColor = Color.Transparent;
			btnRetireStock.Dock = DockStyle.Top;
			btnRetireStock.FlatAppearance.BorderSize = 0;
			btnRetireStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnRetireStock.FlatStyle = FlatStyle.Flat;
			btnRetireStock.Font = new Font("Segoe UI", 14F);
			btnRetireStock.ForeColor = SystemColors.Control;
			btnRetireStock.Location = new Point(0, 140);
			btnRetireStock.Margin = new Padding(2);
			btnRetireStock.Name = "btnRetireStock";
			btnRetireStock.Padding = new Padding(20, 0, 0, 0);
			btnRetireStock.Size = new Size(182, 70);
			btnRetireStock.TabIndex = 9;
			btnRetireStock.Text = "Retire Stock";
			btnRetireStock.TextAlign = ContentAlignment.MiddleLeft;
			btnRetireStock.UseVisualStyleBackColor = false;
			btnRetireStock.Click += btnRetireStock_Click;
			// 
			// btnAddNewStock
			// 
			btnAddNewStock.BackColor = Color.Transparent;
			btnAddNewStock.Dock = DockStyle.Top;
			btnAddNewStock.FlatAppearance.BorderSize = 0;
			btnAddNewStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnAddNewStock.FlatStyle = FlatStyle.Flat;
			btnAddNewStock.Font = new Font("Segoe UI", 14F);
			btnAddNewStock.ForeColor = SystemColors.Control;
			btnAddNewStock.Location = new Point(0, 70);
			btnAddNewStock.Margin = new Padding(2);
			btnAddNewStock.Name = "btnAddNewStock";
			btnAddNewStock.Padding = new Padding(20, 0, 0, 0);
			btnAddNewStock.Size = new Size(182, 70);
			btnAddNewStock.TabIndex = 6;
			btnAddNewStock.Text = "Add New Stock";
			btnAddNewStock.TextAlign = ContentAlignment.MiddleLeft;
			btnAddNewStock.UseVisualStyleBackColor = false;
			btnAddNewStock.Click += btnAddNewStock_Click;
			// 
			// btnManageStockLevels
			// 
			btnManageStockLevels.BackColor = Color.Transparent;
			btnManageStockLevels.Dock = DockStyle.Top;
			btnManageStockLevels.FlatAppearance.BorderSize = 0;
			btnManageStockLevels.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnManageStockLevels.FlatStyle = FlatStyle.Flat;
			btnManageStockLevels.Font = new Font("Segoe UI", 14F);
			btnManageStockLevels.ForeColor = SystemColors.Control;
			btnManageStockLevels.Location = new Point(0, 0);
			btnManageStockLevels.Margin = new Padding(2);
			btnManageStockLevels.Name = "btnManageStockLevels";
			btnManageStockLevels.Padding = new Padding(20, 0, 0, 0);
			btnManageStockLevels.Size = new Size(182, 70);
			btnManageStockLevels.TabIndex = 4;
			btnManageStockLevels.Text = "Manage Stock";
			btnManageStockLevels.TextAlign = ContentAlignment.MiddleLeft;
			btnManageStockLevels.UseVisualStyleBackColor = false;
			btnManageStockLevels.Click += btnManageStockLevels_Click;
			// 
			// btnStock
			// 
			btnStock.BackColor = Color.Transparent;
			btnStock.Dock = DockStyle.Top;
			btnStock.FlatAppearance.BorderSize = 0;
			btnStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnStock.FlatStyle = FlatStyle.Flat;
			btnStock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			btnStock.ForeColor = SystemColors.Control;
			btnStock.Location = new Point(0, 70);
			btnStock.Margin = new Padding(2);
			btnStock.Name = "btnStock";
			btnStock.Size = new Size(182, 70);
			btnStock.TabIndex = 1;
			btnStock.Text = "Stock";
			btnStock.TextAlign = ContentAlignment.MiddleLeft;
			btnStock.UseVisualStyleBackColor = false;
			btnStock.Click += btnStock_Click;
			// 
			// pnlLogo
			// 
			pnlLogo.Controls.Add(pctBoxSmallLogo);
			pnlLogo.Dock = DockStyle.Top;
			pnlLogo.Location = new Point(0, 0);
			pnlLogo.Margin = new Padding(2);
			pnlLogo.Name = "pnlLogo";
			pnlLogo.Size = new Size(182, 70);
			pnlLogo.TabIndex = 0;
			// 
			// pctBoxSmallLogo
			// 
			pctBoxSmallLogo.Dock = DockStyle.Fill;
			pctBoxSmallLogo.Location = new Point(0, 0);
			pctBoxSmallLogo.Margin = new Padding(2);
			pctBoxSmallLogo.Name = "pctBoxSmallLogo";
			pctBoxSmallLogo.Size = new Size(182, 70);
			pctBoxSmallLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pctBoxSmallLogo.TabIndex = 2;
			pctBoxSmallLogo.TabStop = false;
			// 
			// pnlTitleBar
			// 
			pnlTitleBar.BackColor = Color.FromArgb(51, 51, 79);
			pnlTitleBar.Controls.Add(lblTitle);
			pnlTitleBar.Dock = DockStyle.Top;
			pnlTitleBar.Location = new Point(200, 0);
			pnlTitleBar.Name = "pnlTitleBar";
			pnlTitleBar.Size = new Size(1000, 70);
			pnlTitleBar.TabIndex = 5;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.None;
			lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = SystemColors.Control;
			lblTitle.Location = new Point(129, 10);
			lblTitle.Margin = new Padding(2, 0, 2, 0);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(738, 51);
			lblTitle.TabIndex = 0;
			lblTitle.Text = "Movers Maintenance Garage Stock Control System";
			lblTitle.TextAlign = ContentAlignment.TopCenter;
			// 
			// pnlFormContainer
			// 
			pnlFormContainer.AutoSize = true;
			pnlFormContainer.BackColor = SystemColors.ScrollBar;
			pnlFormContainer.Controls.Add(pctBoxLogo);
			pnlFormContainer.Dock = DockStyle.Fill;
			pnlFormContainer.Location = new Point(200, 70);
			pnlFormContainer.Margin = new Padding(2);
			pnlFormContainer.Name = "pnlFormContainer";
			pnlFormContainer.Size = new Size(1000, 680);
			pnlFormContainer.TabIndex = 6;
			// 
			// pctBoxLogo
			// 
			pctBoxLogo.Anchor = AnchorStyles.None;
			pctBoxLogo.Location = new Point(266, 70);
			pctBoxLogo.Margin = new Padding(2);
			pctBoxLogo.Name = "pctBoxLogo";
			pctBoxLogo.Size = new Size(441, 186);
			pctBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pctBoxLogo.TabIndex = 1;
			pctBoxLogo.TabStop = false;
			// 
			// frmMainScreen
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			ClientSize = new Size(1200, 750);
			Controls.Add(pnlFormContainer);
			Controls.Add(pnlTitleBar);
			Controls.Add(pnlSideBar);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(2);
			MinimumSize = new Size(1218, 791);
			Name = "frmMainScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Stock Control";
			pnlSideBar.ResumeLayout(false);
			pnlAudits.ResumeLayout(false);
			pnlDelivery.ResumeLayout(false);
			pnlOrder.ResumeLayout(false);
			pnlStock.ResumeLayout(false);
			pnlLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pctBoxSmallLogo).EndInit();
			pnlTitleBar.ResumeLayout(false);
			pnlFormContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pctBoxLogo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel pnlSideBar;
        private Panel pnlLogo;
        private Button btnStock;
        private Panel pnlStock;
        private Button btnManageStockLevels;
        private Button btnAddNewStock;
        private Button btnOrder;
        private Panel pnlOrder;
        public Button btnViewOrders;
        private Button btnOrderStock;
        private Button btnRetireStock;
        private Button btnDelivery;
        private Panel pnlDelivery;
        private Button btnViewDeliveries;
		private Panel pnlTitleBar;
		private Label lblTitle;
		private Panel pnlFormContainer;
		private PictureBox pctBoxLogo;
		private PictureBox pctBoxSmallLogo;
		private Button button2;
		private Button btnAudits;
		private Panel pnlAudits;
		private Button btnCreateAudit;
		private Button btnAuditHistory;
	}
}