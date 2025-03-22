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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
			pnlSideBar = new Panel();
			pnlStaff = new Panel();
			btnMyDetails = new Button();
			btnManageStaff = new Button();
			btnStaff = new Button();
			btnLogout = new Button();
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
			btnRetireStockItem = new Button();
			btnNewStockItem = new Button();
			btnManageStockLevels = new Button();
			btnStock = new Button();
			pnlLogo = new Panel();
			pctBoxSmallLogo = new PictureBox();
			pnlTitleBar = new Panel();
			lblTitle = new Label();
			pnlFormContainer = new Panel();
			lblDeliveries = new Label();
			lblNumberDeliveryDiscrepancies = new Label();
			btnDeliveryDiscrepancies = new Button();
			lblAudits = new Label();
			lblNumberOverdueAudits = new Label();
			btnOverdueAudits = new Button();
			lblLowStock = new Label();
			lblNumberLowStockItems = new Label();
			btnLowStock = new Button();
			pctBoxLogo = new PictureBox();
			toolTipMainMenu = new ToolTip(components);
			pnlSideBar.SuspendLayout();
			pnlStaff.SuspendLayout();
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
			pnlSideBar.Controls.Add(pnlStaff);
			pnlSideBar.Controls.Add(btnStaff);
			pnlSideBar.Controls.Add(btnLogout);
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
			// pnlStaff
			// 
			pnlStaff.Controls.Add(btnMyDetails);
			pnlStaff.Controls.Add(btnManageStaff);
			pnlStaff.Dock = DockStyle.Top;
			pnlStaff.Location = new Point(0, 980);
			pnlStaff.Name = "pnlStaff";
			pnlStaff.Size = new Size(182, 140);
			pnlStaff.TabIndex = 17;
			// 
			// btnMyDetails
			// 
			btnMyDetails.BackColor = Color.Transparent;
			btnMyDetails.Dock = DockStyle.Top;
			btnMyDetails.FlatAppearance.BorderSize = 0;
			btnMyDetails.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnMyDetails.FlatStyle = FlatStyle.Flat;
			btnMyDetails.Font = new Font("Segoe UI", 14F);
			btnMyDetails.ForeColor = Color.White;
			btnMyDetails.Location = new Point(0, 70);
			btnMyDetails.Margin = new Padding(2);
			btnMyDetails.Name = "btnMyDetails";
			btnMyDetails.Padding = new Padding(20, 0, 0, 0);
			btnMyDetails.Size = new Size(182, 70);
			btnMyDetails.TabIndex = 19;
			btnMyDetails.Text = "My Details";
			btnMyDetails.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnMyDetails, "Manage Company Staff");
			btnMyDetails.UseVisualStyleBackColor = false;
			btnMyDetails.Click += btnMyDetails_Click;
			// 
			// btnManageStaff
			// 
			btnManageStaff.BackColor = Color.Transparent;
			btnManageStaff.Dock = DockStyle.Top;
			btnManageStaff.FlatAppearance.BorderSize = 0;
			btnManageStaff.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnManageStaff.FlatStyle = FlatStyle.Flat;
			btnManageStaff.Font = new Font("Segoe UI", 14F);
			btnManageStaff.ForeColor = Color.White;
			btnManageStaff.Location = new Point(0, 0);
			btnManageStaff.Margin = new Padding(2);
			btnManageStaff.Name = "btnManageStaff";
			btnManageStaff.Padding = new Padding(20, 0, 0, 0);
			btnManageStaff.Size = new Size(182, 70);
			btnManageStaff.TabIndex = 15;
			btnManageStaff.Text = "Manage Staff";
			btnManageStaff.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnManageStaff, "Manage Company Staff");
			btnManageStaff.UseVisualStyleBackColor = false;
			btnManageStaff.Click += btnManageStaff_Click;
			// 
			// btnStaff
			// 
			btnStaff.BackColor = Color.Transparent;
			btnStaff.Dock = DockStyle.Top;
			btnStaff.FlatAppearance.BorderSize = 0;
			btnStaff.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnStaff.FlatStyle = FlatStyle.Flat;
			btnStaff.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			btnStaff.ForeColor = Color.White;
			btnStaff.Location = new Point(0, 910);
			btnStaff.Margin = new Padding(2);
			btnStaff.Name = "btnStaff";
			btnStaff.Size = new Size(182, 70);
			btnStaff.TabIndex = 16;
			btnStaff.Text = "Staff";
			btnStaff.TextAlign = ContentAlignment.MiddleLeft;
			btnStaff.UseVisualStyleBackColor = false;
			btnStaff.Click += btnStaff_Click;
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.Transparent;
			btnLogout.Dock = DockStyle.Bottom;
			btnLogout.FlatAppearance.BorderSize = 0;
			btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(250, 0, 0);
			btnLogout.FlatStyle = FlatStyle.Flat;
			btnLogout.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			btnLogout.ForeColor = Color.White;
			btnLogout.Location = new Point(0, 1120);
			btnLogout.Margin = new Padding(2);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(182, 70);
			btnLogout.TabIndex = 15;
			btnLogout.Text = "Logout";
			btnLogout.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnLogout, "Logout of system");
			btnLogout.UseVisualStyleBackColor = false;
			btnLogout.Click += btnLogout_Click;
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
			btnAuditHistory.ForeColor = Color.White;
			btnAuditHistory.Location = new Point(0, 70);
			btnAuditHistory.Margin = new Padding(2);
			btnAuditHistory.Name = "btnAuditHistory";
			btnAuditHistory.Padding = new Padding(20, 0, 0, 0);
			btnAuditHistory.Size = new Size(182, 70);
			btnAuditHistory.TabIndex = 14;
			btnAuditHistory.Text = "Audit History";
			btnAuditHistory.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnAuditHistory, "View All Previous Audits");
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
			btnCreateAudit.ForeColor = Color.White;
			btnCreateAudit.Location = new Point(0, 0);
			btnCreateAudit.Margin = new Padding(2);
			btnCreateAudit.Name = "btnCreateAudit";
			btnCreateAudit.Padding = new Padding(20, 0, 0, 0);
			btnCreateAudit.Size = new Size(182, 70);
			btnCreateAudit.TabIndex = 13;
			btnCreateAudit.Text = "Create Audit";
			btnCreateAudit.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnCreateAudit, "Create Audit");
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
			btnAudits.ForeColor = Color.White;
			btnAudits.Location = new Point(0, 700);
			btnAudits.Margin = new Padding(2);
			btnAudits.Name = "btnAudits";
			btnAudits.Size = new Size(182, 70);
			btnAudits.TabIndex = 3;
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
			btnViewDeliveries.ForeColor = Color.White;
			btnViewDeliveries.Location = new Point(0, 0);
			btnViewDeliveries.Margin = new Padding(2);
			btnViewDeliveries.Name = "btnViewDeliveries";
			btnViewDeliveries.Padding = new Padding(20, 0, 0, 0);
			btnViewDeliveries.Size = new Size(182, 70);
			btnViewDeliveries.TabIndex = 0;
			btnViewDeliveries.Text = "View Deliveries";
			btnViewDeliveries.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnViewDeliveries, "View Deliveries");
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
			btnDelivery.ForeColor = Color.White;
			btnDelivery.Location = new Point(0, 560);
			btnDelivery.Margin = new Padding(2);
			btnDelivery.Name = "btnDelivery";
			btnDelivery.Size = new Size(182, 70);
			btnDelivery.TabIndex = 2;
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
			btnViewOrders.ForeColor = Color.White;
			btnViewOrders.Location = new Point(0, 70);
			btnViewOrders.Margin = new Padding(2);
			btnViewOrders.Name = "btnViewOrders";
			btnViewOrders.Padding = new Padding(20, 0, 0, 0);
			btnViewOrders.Size = new Size(182, 70);
			btnViewOrders.TabIndex = 1;
			btnViewOrders.Text = "View Orders";
			btnViewOrders.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnViewOrders, "View All Orders");
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
			btnOrderStock.ForeColor = Color.White;
			btnOrderStock.Location = new Point(0, 0);
			btnOrderStock.Margin = new Padding(2);
			btnOrderStock.Name = "btnOrderStock";
			btnOrderStock.Padding = new Padding(20, 0, 0, 0);
			btnOrderStock.Size = new Size(182, 70);
			btnOrderStock.TabIndex = 0;
			btnOrderStock.Text = "Order Stock";
			btnOrderStock.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnOrderStock, "Order Stock");
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
			btnOrder.ForeColor = Color.White;
			btnOrder.Location = new Point(0, 350);
			btnOrder.Margin = new Padding(2);
			btnOrder.Name = "btnOrder";
			btnOrder.Size = new Size(182, 70);
			btnOrder.TabIndex = 1;
			btnOrder.Text = "Orders";
			btnOrder.TextAlign = ContentAlignment.MiddleLeft;
			btnOrder.UseVisualStyleBackColor = false;
			btnOrder.Click += btnOrder_Click;
			// 
			// pnlStock
			// 
			pnlStock.Controls.Add(btnRetireStockItem);
			pnlStock.Controls.Add(btnNewStockItem);
			pnlStock.Controls.Add(btnManageStockLevels);
			pnlStock.Dock = DockStyle.Top;
			pnlStock.Location = new Point(0, 140);
			pnlStock.Margin = new Padding(2);
			pnlStock.Name = "pnlStock";
			pnlStock.Size = new Size(182, 210);
			pnlStock.TabIndex = 3;
			// 
			// btnRetireStockItem
			// 
			btnRetireStockItem.BackColor = Color.Transparent;
			btnRetireStockItem.Dock = DockStyle.Top;
			btnRetireStockItem.FlatAppearance.BorderSize = 0;
			btnRetireStockItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnRetireStockItem.FlatStyle = FlatStyle.Flat;
			btnRetireStockItem.Font = new Font("Segoe UI", 14F);
			btnRetireStockItem.ForeColor = Color.White;
			btnRetireStockItem.Location = new Point(0, 140);
			btnRetireStockItem.Margin = new Padding(2);
			btnRetireStockItem.Name = "btnRetireStockItem";
			btnRetireStockItem.Padding = new Padding(20, 0, 0, 0);
			btnRetireStockItem.Size = new Size(182, 70);
			btnRetireStockItem.TabIndex = 2;
			btnRetireStockItem.Text = "Retire Stock Item";
			btnRetireStockItem.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnRetireStockItem, "Retire Stock Item");
			btnRetireStockItem.UseVisualStyleBackColor = false;
			btnRetireStockItem.Click += btnRetireStockItem_Click;
			// 
			// btnNewStockItem
			// 
			btnNewStockItem.BackColor = Color.Transparent;
			btnNewStockItem.Dock = DockStyle.Top;
			btnNewStockItem.FlatAppearance.BorderSize = 0;
			btnNewStockItem.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnNewStockItem.FlatStyle = FlatStyle.Flat;
			btnNewStockItem.Font = new Font("Segoe UI", 14F);
			btnNewStockItem.ForeColor = Color.White;
			btnNewStockItem.Location = new Point(0, 70);
			btnNewStockItem.Margin = new Padding(2);
			btnNewStockItem.Name = "btnNewStockItem";
			btnNewStockItem.Padding = new Padding(20, 0, 0, 0);
			btnNewStockItem.Size = new Size(182, 70);
			btnNewStockItem.TabIndex = 1;
			btnNewStockItem.Text = "New Stock Item";
			btnNewStockItem.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnNewStockItem, "Add New Stock Item");
			btnNewStockItem.UseVisualStyleBackColor = false;
			btnNewStockItem.Click += btnNewStockItem_Click;
			// 
			// btnManageStockLevels
			// 
			btnManageStockLevels.BackColor = Color.Transparent;
			btnManageStockLevels.Dock = DockStyle.Top;
			btnManageStockLevels.FlatAppearance.BorderSize = 0;
			btnManageStockLevels.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 74, 114);
			btnManageStockLevels.FlatStyle = FlatStyle.Flat;
			btnManageStockLevels.Font = new Font("Segoe UI", 14F);
			btnManageStockLevels.ForeColor = Color.White;
			btnManageStockLevels.Location = new Point(0, 0);
			btnManageStockLevels.Margin = new Padding(2);
			btnManageStockLevels.Name = "btnManageStockLevels";
			btnManageStockLevels.Padding = new Padding(20, 0, 0, 0);
			btnManageStockLevels.Size = new Size(182, 70);
			btnManageStockLevels.TabIndex = 0;
			btnManageStockLevels.Text = "Manage Stock";
			btnManageStockLevels.TextAlign = ContentAlignment.MiddleLeft;
			toolTipMainMenu.SetToolTip(btnManageStockLevels, "Manage all stock levels and items");
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
			btnStock.ForeColor = Color.White;
			btnStock.Location = new Point(0, 70);
			btnStock.Margin = new Padding(2);
			btnStock.Name = "btnStock";
			btnStock.Size = new Size(182, 70);
			btnStock.TabIndex = 0;
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
			pctBoxSmallLogo.Image = Resources.Movers_Logo_White;
			pctBoxSmallLogo.Location = new Point(0, 0);
			pctBoxSmallLogo.Margin = new Padding(2);
			pctBoxSmallLogo.Name = "pctBoxSmallLogo";
			pctBoxSmallLogo.Size = new Size(182, 70);
			pctBoxSmallLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pctBoxSmallLogo.TabIndex = 2;
			pctBoxSmallLogo.TabStop = false;
			toolTipMainMenu.SetToolTip(pctBoxSmallLogo, "Main Menu");
			pctBoxSmallLogo.Click += pctBoxSmallLogo_Click;
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
			lblTitle.ForeColor = Color.White;
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
			pnlFormContainer.Controls.Add(lblDeliveries);
			pnlFormContainer.Controls.Add(lblNumberDeliveryDiscrepancies);
			pnlFormContainer.Controls.Add(btnDeliveryDiscrepancies);
			pnlFormContainer.Controls.Add(lblAudits);
			pnlFormContainer.Controls.Add(lblNumberOverdueAudits);
			pnlFormContainer.Controls.Add(btnOverdueAudits);
			pnlFormContainer.Controls.Add(lblLowStock);
			pnlFormContainer.Controls.Add(lblNumberLowStockItems);
			pnlFormContainer.Controls.Add(btnLowStock);
			pnlFormContainer.Controls.Add(pctBoxLogo);
			pnlFormContainer.Dock = DockStyle.Fill;
			pnlFormContainer.Location = new Point(200, 70);
			pnlFormContainer.Margin = new Padding(2);
			pnlFormContainer.Name = "pnlFormContainer";
			pnlFormContainer.Size = new Size(1000, 680);
			pnlFormContainer.TabIndex = 6;
			// 
			// lblDeliveries
			// 
			lblDeliveries.Anchor = AnchorStyles.None;
			lblDeliveries.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblDeliveries.ForeColor = Color.Black;
			lblDeliveries.Location = new Point(167, 280);
			lblDeliveries.Name = "lblDeliveries";
			lblDeliveries.Size = new Size(132, 29);
			lblDeliveries.TabIndex = 11;
			lblDeliveries.Text = "Deliveries";
			lblDeliveries.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNumberDeliveryDiscrepancies
			// 
			lblNumberDeliveryDiscrepancies.Anchor = AnchorStyles.None;
			lblNumberDeliveryDiscrepancies.BackColor = Color.Red;
			lblNumberDeliveryDiscrepancies.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNumberDeliveryDiscrepancies.ForeColor = Color.White;
			lblNumberDeliveryDiscrepancies.Location = new Point(184, 309);
			lblNumberDeliveryDiscrepancies.Name = "lblNumberDeliveryDiscrepancies";
			lblNumberDeliveryDiscrepancies.Size = new Size(100, 100);
			lblNumberDeliveryDiscrepancies.TabIndex = 10;
			lblNumberDeliveryDiscrepancies.Text = "99";
			lblNumberDeliveryDiscrepancies.TextAlign = ContentAlignment.MiddleCenter;
			toolTipMainMenu.SetToolTip(lblNumberDeliveryDiscrepancies, "Number of unchecked deliveries");
			// 
			// btnDeliveryDiscrepancies
			// 
			btnDeliveryDiscrepancies.Anchor = AnchorStyles.None;
			btnDeliveryDiscrepancies.BackColor = Color.FromArgb(33, 150, 243);
			btnDeliveryDiscrepancies.FlatAppearance.BorderSize = 0;
			btnDeliveryDiscrepancies.FlatStyle = FlatStyle.Flat;
			btnDeliveryDiscrepancies.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnDeliveryDiscrepancies.ForeColor = Color.White;
			btnDeliveryDiscrepancies.Location = new Point(124, 430);
			btnDeliveryDiscrepancies.Name = "btnDeliveryDiscrepancies";
			btnDeliveryDiscrepancies.Size = new Size(220, 50);
			btnDeliveryDiscrepancies.TabIndex = 9;
			btnDeliveryDiscrepancies.Text = "Delivery Discrepancies";
			toolTipMainMenu.SetToolTip(btnDeliveryDiscrepancies, "Delivery Discrepancy Report");
			btnDeliveryDiscrepancies.UseVisualStyleBackColor = false;
			btnDeliveryDiscrepancies.Click += btnDeliveryDiscrepancies_Click;
			// 
			// lblAudits
			// 
			lblAudits.Anchor = AnchorStyles.None;
			lblAudits.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAudits.ForeColor = Color.Black;
			lblAudits.Location = new Point(679, 280);
			lblAudits.Name = "lblAudits";
			lblAudits.Size = new Size(132, 29);
			lblAudits.TabIndex = 8;
			lblAudits.Text = "Audits";
			lblAudits.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNumberOverdueAudits
			// 
			lblNumberOverdueAudits.Anchor = AnchorStyles.None;
			lblNumberOverdueAudits.BackColor = Color.Red;
			lblNumberOverdueAudits.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNumberOverdueAudits.ForeColor = Color.White;
			lblNumberOverdueAudits.Location = new Point(696, 309);
			lblNumberOverdueAudits.Name = "lblNumberOverdueAudits";
			lblNumberOverdueAudits.Size = new Size(100, 100);
			lblNumberOverdueAudits.TabIndex = 7;
			lblNumberOverdueAudits.Text = "99";
			lblNumberOverdueAudits.TextAlign = ContentAlignment.MiddleCenter;
			toolTipMainMenu.SetToolTip(lblNumberOverdueAudits, "Number of overdue audits");
			// 
			// btnOverdueAudits
			// 
			btnOverdueAudits.Anchor = AnchorStyles.None;
			btnOverdueAudits.BackColor = Color.FromArgb(33, 150, 243);
			btnOverdueAudits.FlatAppearance.BorderSize = 0;
			btnOverdueAudits.FlatStyle = FlatStyle.Flat;
			btnOverdueAudits.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnOverdueAudits.ForeColor = Color.White;
			btnOverdueAudits.Location = new Point(636, 430);
			btnOverdueAudits.Name = "btnOverdueAudits";
			btnOverdueAudits.Size = new Size(220, 50);
			btnOverdueAudits.TabIndex = 6;
			btnOverdueAudits.Text = "Overdue Audits";
			toolTipMainMenu.SetToolTip(btnOverdueAudits, "Overdue Audits Report");
			btnOverdueAudits.UseVisualStyleBackColor = false;
			btnOverdueAudits.Click += btnOverdueAudits_Click;
			// 
			// lblLowStock
			// 
			lblLowStock.Anchor = AnchorStyles.None;
			lblLowStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblLowStock.ForeColor = Color.Black;
			lblLowStock.Location = new Point(424, 280);
			lblLowStock.Name = "lblLowStock";
			lblLowStock.Size = new Size(132, 29);
			lblLowStock.TabIndex = 5;
			lblLowStock.Text = "Stock Levels";
			lblLowStock.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// lblNumberLowStockItems
			// 
			lblNumberLowStockItems.Anchor = AnchorStyles.None;
			lblNumberLowStockItems.BackColor = Color.Red;
			lblNumberLowStockItems.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblNumberLowStockItems.ForeColor = Color.White;
			lblNumberLowStockItems.Location = new Point(441, 309);
			lblNumberLowStockItems.Name = "lblNumberLowStockItems";
			lblNumberLowStockItems.Size = new Size(100, 100);
			lblNumberLowStockItems.TabIndex = 4;
			lblNumberLowStockItems.Text = "99";
			lblNumberLowStockItems.TextAlign = ContentAlignment.MiddleCenter;
			toolTipMainMenu.SetToolTip(lblNumberLowStockItems, "Number of low stock levels");
			// 
			// btnLowStock
			// 
			btnLowStock.Anchor = AnchorStyles.None;
			btnLowStock.BackColor = Color.FromArgb(33, 150, 243);
			btnLowStock.FlatAppearance.BorderSize = 0;
			btnLowStock.FlatStyle = FlatStyle.Flat;
			btnLowStock.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnLowStock.ForeColor = Color.White;
			btnLowStock.Location = new Point(381, 430);
			btnLowStock.Name = "btnLowStock";
			btnLowStock.Size = new Size(220, 50);
			btnLowStock.TabIndex = 3;
			btnLowStock.Text = "Low Stock";
			toolTipMainMenu.SetToolTip(btnLowStock, "Low Stock Report");
			btnLowStock.UseVisualStyleBackColor = false;
			btnLowStock.Click += btnLowStockReport_Click;
			// 
			// pctBoxLogo
			// 
			pctBoxLogo.Anchor = AnchorStyles.None;
			pctBoxLogo.Image = Resources.Movers_Logo_Black;
			pctBoxLogo.Location = new Point(266, 70);
			pctBoxLogo.Margin = new Padding(2);
			pctBoxLogo.Name = "pctBoxLogo";
			pctBoxLogo.Size = new Size(441, 186);
			pctBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
			pctBoxLogo.TabIndex = 1;
			pctBoxLogo.TabStop = false;
			// 
			// toolTipMainMenu
			// 
			toolTipMainMenu.UseAnimation = false;
			toolTipMainMenu.UseFading = false;
			// 
			// frmMainScreen
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			BackColor = Color.White;
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
			pnlStaff.ResumeLayout(false);
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
        private Button btnNewStockItem;
        private Button btnOrder;
        private Panel pnlOrder;
        public Button btnViewOrders;
        private Button btnOrderStock;
        private Button btnRetireStockItem;
        private Button btnDelivery;
        private Panel pnlDelivery;
        public Button btnViewDeliveries;
		private Panel pnlTitleBar;
		public Label lblTitle;
		private Panel pnlFormContainer;
		private PictureBox pctBoxLogo;
		private PictureBox pctBoxSmallLogo;
		private Button btnAudits;
		private Panel pnlAudits;
		private Button btnCreateAudit;
		private Button btnAuditHistory;
		private Button btnLogout;
		private Panel pnlStaff;
		private Button btnStaff;
		private Button btnManageStaff;
		private Button btnLowStock;
		private Label lblNumberLowStockItems;
		private Label lblLowStock;
		private Label lblDeliveries;
		private Label lblNumberDeliveryDiscrepancies;
		private Button btnDeliveryDiscrepancies;
		private Label lblAudits;
		private Label lblNumberOverdueAudits;
		private Button btnOverdueAudits;
		private ToolTip toolTipMainMenu;
		private Button btnMyDetails;
	}
}