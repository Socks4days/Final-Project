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
			pnlDelivery = new Panel();
			btnViewDeliveries = new Button();
			btnDelivery = new Button();
			pnlOrder = new Panel();
			btnViewOrders = new Button();
			btnOrderStock = new Button();
			btnOrder = new Button();
			pnlStock = new Panel();
			btnRemoveStock = new Button();
			btnAddNewStock = new Button();
			btnManageStockLevels = new Button();
			btnStock = new Button();
			pnlLogo = new Panel();
			label1 = new Label();
			pnlTitleBar = new Panel();
			lblTitle = new Label();
			pnlFormContainer = new Panel();
			pctBoxLogo = new PictureBox();
			pnlSideBar.SuspendLayout();
			pnlDelivery.SuspendLayout();
			pnlOrder.SuspendLayout();
			pnlStock.SuspendLayout();
			pnlLogo.SuspendLayout();
			pnlTitleBar.SuspendLayout();
			pnlFormContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pctBoxLogo).BeginInit();
			SuspendLayout();
			// 
			// pnlSideBar
			// 
			pnlSideBar.AutoScroll = true;
			pnlSideBar.BackColor = Color.FromArgb(51, 51, 79);
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
			// pnlDelivery
			// 
			pnlDelivery.Controls.Add(btnViewDeliveries);
			pnlDelivery.Dock = DockStyle.Top;
			pnlDelivery.Font = new Font("Segoe UI", 14F);
			pnlDelivery.Location = new Point(0, 630);
			pnlDelivery.Margin = new Padding(2);
			pnlDelivery.Name = "pnlDelivery";
			pnlDelivery.Size = new Size(200, 70);
			pnlDelivery.TabIndex = 11;
			// 
			// btnViewDeliveries
			// 
			btnViewDeliveries.BackColor = Color.Transparent;
			btnViewDeliveries.Dock = DockStyle.Top;
			btnViewDeliveries.FlatAppearance.BorderSize = 0;
			btnViewDeliveries.FlatStyle = FlatStyle.Flat;
			btnViewDeliveries.Font = new Font("Segoe UI", 14F);
			btnViewDeliveries.ForeColor = SystemColors.Control;
			btnViewDeliveries.Location = new Point(0, 0);
			btnViewDeliveries.Margin = new Padding(2);
			btnViewDeliveries.Name = "btnViewDeliveries";
			btnViewDeliveries.Size = new Size(200, 70);
			btnViewDeliveries.TabIndex = 6;
			btnViewDeliveries.Text = "View Deliveries";
			btnViewDeliveries.UseVisualStyleBackColor = false;
			btnViewDeliveries.Click += btnViewDeliveries_Click;
			// 
			// btnDelivery
			// 
			btnDelivery.BackColor = Color.Transparent;
			btnDelivery.Dock = DockStyle.Top;
			btnDelivery.FlatAppearance.BorderSize = 0;
			btnDelivery.FlatStyle = FlatStyle.Flat;
			btnDelivery.Font = new Font("Segoe UI", 14F);
			btnDelivery.ForeColor = SystemColors.Control;
			btnDelivery.Location = new Point(0, 560);
			btnDelivery.Margin = new Padding(2);
			btnDelivery.Name = "btnDelivery";
			btnDelivery.Size = new Size(200, 70);
			btnDelivery.TabIndex = 10;
			btnDelivery.Text = "Deliveries";
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
			pnlOrder.Size = new Size(200, 140);
			pnlOrder.TabIndex = 9;
			// 
			// btnViewOrders
			// 
			btnViewOrders.BackColor = Color.Transparent;
			btnViewOrders.Dock = DockStyle.Top;
			btnViewOrders.FlatAppearance.BorderSize = 0;
			btnViewOrders.FlatStyle = FlatStyle.Flat;
			btnViewOrders.Font = new Font("Segoe UI", 14F);
			btnViewOrders.ForeColor = SystemColors.Control;
			btnViewOrders.Location = new Point(0, 70);
			btnViewOrders.Margin = new Padding(2);
			btnViewOrders.Name = "btnViewOrders";
			btnViewOrders.Size = new Size(200, 70);
			btnViewOrders.TabIndex = 5;
			btnViewOrders.Text = "View Orders";
			btnViewOrders.UseVisualStyleBackColor = false;
			btnViewOrders.Click += btnViewOrders_Click;
			// 
			// btnOrderStock
			// 
			btnOrderStock.BackColor = Color.Transparent;
			btnOrderStock.Dock = DockStyle.Top;
			btnOrderStock.FlatAppearance.BorderSize = 0;
			btnOrderStock.FlatStyle = FlatStyle.Flat;
			btnOrderStock.Font = new Font("Segoe UI", 14F);
			btnOrderStock.ForeColor = SystemColors.Control;
			btnOrderStock.Location = new Point(0, 0);
			btnOrderStock.Margin = new Padding(2);
			btnOrderStock.Name = "btnOrderStock";
			btnOrderStock.Size = new Size(200, 70);
			btnOrderStock.TabIndex = 4;
			btnOrderStock.Text = "Order Stock";
			btnOrderStock.UseVisualStyleBackColor = false;
			btnOrderStock.Click += btnOrderStock_Click;
			// 
			// btnOrder
			// 
			btnOrder.BackColor = Color.Transparent;
			btnOrder.Dock = DockStyle.Top;
			btnOrder.FlatAppearance.BorderSize = 0;
			btnOrder.FlatStyle = FlatStyle.Flat;
			btnOrder.Font = new Font("Segoe UI", 14F);
			btnOrder.ForeColor = SystemColors.Control;
			btnOrder.Location = new Point(0, 350);
			btnOrder.Margin = new Padding(2);
			btnOrder.Name = "btnOrder";
			btnOrder.Size = new Size(200, 70);
			btnOrder.TabIndex = 4;
			btnOrder.Text = "Orders";
			btnOrder.UseVisualStyleBackColor = false;
			btnOrder.Click += btnOrder_Click;
			// 
			// pnlStock
			// 
			pnlStock.Controls.Add(btnRemoveStock);
			pnlStock.Controls.Add(btnAddNewStock);
			pnlStock.Controls.Add(btnManageStockLevels);
			pnlStock.Dock = DockStyle.Top;
			pnlStock.Location = new Point(0, 140);
			pnlStock.Margin = new Padding(2);
			pnlStock.Name = "pnlStock";
			pnlStock.Size = new Size(200, 210);
			pnlStock.TabIndex = 3;
			// 
			// btnRemoveStock
			// 
			btnRemoveStock.BackColor = Color.Transparent;
			btnRemoveStock.Dock = DockStyle.Top;
			btnRemoveStock.FlatAppearance.BorderSize = 0;
			btnRemoveStock.FlatStyle = FlatStyle.Flat;
			btnRemoveStock.Font = new Font("Segoe UI", 14F);
			btnRemoveStock.ForeColor = SystemColors.Control;
			btnRemoveStock.Location = new Point(0, 140);
			btnRemoveStock.Margin = new Padding(2);
			btnRemoveStock.Name = "btnRemoveStock";
			btnRemoveStock.Size = new Size(200, 70);
			btnRemoveStock.TabIndex = 9;
			btnRemoveStock.Text = "Remove Stock";
			btnRemoveStock.UseVisualStyleBackColor = false;
			btnRemoveStock.Click += btnRemoveStock_Click;
			// 
			// btnAddNewStock
			// 
			btnAddNewStock.BackColor = Color.Transparent;
			btnAddNewStock.Dock = DockStyle.Top;
			btnAddNewStock.FlatAppearance.BorderSize = 0;
			btnAddNewStock.FlatStyle = FlatStyle.Flat;
			btnAddNewStock.Font = new Font("Segoe UI", 14F);
			btnAddNewStock.ForeColor = SystemColors.Control;
			btnAddNewStock.Location = new Point(0, 70);
			btnAddNewStock.Margin = new Padding(2);
			btnAddNewStock.Name = "btnAddNewStock";
			btnAddNewStock.Size = new Size(200, 70);
			btnAddNewStock.TabIndex = 6;
			btnAddNewStock.Text = "Add New Stock";
			btnAddNewStock.UseVisualStyleBackColor = false;
			btnAddNewStock.Click += btnAddNewStock_Click;
			// 
			// btnManageStockLevels
			// 
			btnManageStockLevels.BackColor = Color.Transparent;
			btnManageStockLevels.Dock = DockStyle.Top;
			btnManageStockLevels.FlatAppearance.BorderSize = 0;
			btnManageStockLevels.FlatStyle = FlatStyle.Flat;
			btnManageStockLevels.Font = new Font("Segoe UI", 14F);
			btnManageStockLevels.ForeColor = SystemColors.Control;
			btnManageStockLevels.Location = new Point(0, 0);
			btnManageStockLevels.Margin = new Padding(2);
			btnManageStockLevels.Name = "btnManageStockLevels";
			btnManageStockLevels.Size = new Size(200, 70);
			btnManageStockLevels.TabIndex = 4;
			btnManageStockLevels.Text = "Manage Stock Levels";
			btnManageStockLevels.UseVisualStyleBackColor = false;
			btnManageStockLevels.Click += btnViewStock_Click;
			// 
			// btnStock
			// 
			btnStock.BackColor = Color.Transparent;
			btnStock.Dock = DockStyle.Top;
			btnStock.FlatAppearance.BorderSize = 0;
			btnStock.FlatStyle = FlatStyle.Flat;
			btnStock.Font = new Font("Segoe UI", 14F);
			btnStock.ForeColor = SystemColors.Control;
			btnStock.Location = new Point(0, 70);
			btnStock.Margin = new Padding(2);
			btnStock.Name = "btnStock";
			btnStock.Size = new Size(200, 70);
			btnStock.TabIndex = 1;
			btnStock.Text = "Stock";
			btnStock.UseVisualStyleBackColor = false;
			btnStock.Click += btnStock_Click;
			// 
			// pnlLogo
			// 
			pnlLogo.Controls.Add(label1);
			pnlLogo.Dock = DockStyle.Top;
			pnlLogo.Location = new Point(0, 0);
			pnlLogo.Margin = new Padding(2);
			pnlLogo.Name = "pnlLogo";
			pnlLogo.Size = new Size(200, 70);
			pnlLogo.TabIndex = 0;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.None;
			label1.Font = new Font("Segoe UI", 14F);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(8, 10);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(184, 51);
			label1.TabIndex = 1;
			label1.Text = "Movers ";
			label1.TextAlign = ContentAlignment.MiddleCenter;
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
			pctBoxLogo.Location = new Point(351, 184);
			pctBoxLogo.Margin = new Padding(2);
			pctBoxLogo.Name = "pctBoxLogo";
			pctBoxLogo.Size = new Size(311, 306);
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
			Name = "frmMainScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Stock Control";
			pnlSideBar.ResumeLayout(false);
			pnlDelivery.ResumeLayout(false);
			pnlOrder.ResumeLayout(false);
			pnlStock.ResumeLayout(false);
			pnlLogo.ResumeLayout(false);
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
        private Button btnViewOrders;
        private Button btnOrderStock;
        private Button btnRemoveStock;
        private Button btnDelivery;
        private Panel pnlDelivery;
        private Button btnViewDeliveries;
		private Label label1;
		private Panel pnlTitleBar;
		private Label lblTitle;
		private Panel pnlFormContainer;
		private PictureBox pctBoxLogo;
	}
}