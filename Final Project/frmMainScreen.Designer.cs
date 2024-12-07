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
            pnlOrder = new Panel();
            btnViewOrders = new Button();
            btnOrderStock = new Button();
            btnOrder = new Button();
            pnlStock = new Panel();
            btnRemoveStock = new Button();
            btnAddNewStock = new Button();
            btnManageStockLevels = new Button();
            btnStock = new Button();
            pnlAvatar = new Panel();
            pnlFormContainer = new Panel();
            pctBoxLogo = new PictureBox();
            lblTitle = new Label();
            pnlSideBar.SuspendLayout();
            pnlOrder.SuspendLayout();
            pnlStock.SuspendLayout();
            pnlFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoScroll = true;
            pnlSideBar.BackColor = Color.Teal;
            pnlSideBar.Controls.Add(pnlOrder);
            pnlSideBar.Controls.Add(btnOrder);
            pnlSideBar.Controls.Add(pnlStock);
            pnlSideBar.Controls.Add(btnStock);
            pnlSideBar.Controls.Add(pnlAvatar);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(220, 560);
            pnlSideBar.TabIndex = 0;
            // 
            // pnlOrder
            // 
            pnlOrder.Controls.Add(btnViewOrders);
            pnlOrder.Controls.Add(btnOrderStock);
            pnlOrder.Dock = DockStyle.Top;
            pnlOrder.Location = new Point(0, 375);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(220, 100);
            pnlOrder.TabIndex = 9;
            // 
            // btnViewOrders
            // 
            btnViewOrders.BackColor = Color.LightSeaGreen;
            btnViewOrders.Dock = DockStyle.Top;
            btnViewOrders.FlatAppearance.BorderSize = 0;
            btnViewOrders.FlatStyle = FlatStyle.Flat;
            btnViewOrders.Font = new Font("Segoe UI", 12F);
            btnViewOrders.ForeColor = SystemColors.Control;
            btnViewOrders.Location = new Point(0, 50);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(220, 50);
            btnViewOrders.TabIndex = 5;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.UseVisualStyleBackColor = false;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // btnOrderStock
            // 
            btnOrderStock.BackColor = Color.LightSeaGreen;
            btnOrderStock.Dock = DockStyle.Top;
            btnOrderStock.FlatAppearance.BorderSize = 0;
            btnOrderStock.FlatStyle = FlatStyle.Flat;
            btnOrderStock.Font = new Font("Segoe UI", 12F);
            btnOrderStock.ForeColor = SystemColors.Control;
            btnOrderStock.Location = new Point(0, 0);
            btnOrderStock.Name = "btnOrderStock";
            btnOrderStock.Size = new Size(220, 50);
            btnOrderStock.TabIndex = 4;
            btnOrderStock.Text = "Order Stock";
            btnOrderStock.UseVisualStyleBackColor = false;
            btnOrderStock.Click += btnOrderStock_Click;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 12F);
            btnOrder.ForeColor = SystemColors.Control;
            btnOrder.Location = new Point(0, 325);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(220, 50);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(btnRemoveStock);
            pnlStock.Controls.Add(btnAddNewStock);
            pnlStock.Controls.Add(btnManageStockLevels);
            pnlStock.Dock = DockStyle.Top;
            pnlStock.Location = new Point(0, 175);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(220, 150);
            pnlStock.TabIndex = 3;
            // 
            // btnRemoveStock
            // 
            btnRemoveStock.BackColor = Color.LightSeaGreen;
            btnRemoveStock.Dock = DockStyle.Top;
            btnRemoveStock.FlatAppearance.BorderSize = 0;
            btnRemoveStock.FlatStyle = FlatStyle.Flat;
            btnRemoveStock.Font = new Font("Segoe UI", 12F);
            btnRemoveStock.ForeColor = SystemColors.Control;
            btnRemoveStock.Location = new Point(0, 100);
            btnRemoveStock.Name = "btnRemoveStock";
            btnRemoveStock.Size = new Size(220, 50);
            btnRemoveStock.TabIndex = 9;
            btnRemoveStock.Text = "Remove Stock";
            btnRemoveStock.UseVisualStyleBackColor = false;
            btnRemoveStock.Click += btnRemoveStock_Click;
            // 
            // btnAddNewStock
            // 
            btnAddNewStock.BackColor = Color.LightSeaGreen;
            btnAddNewStock.Dock = DockStyle.Top;
            btnAddNewStock.FlatAppearance.BorderSize = 0;
            btnAddNewStock.FlatStyle = FlatStyle.Flat;
            btnAddNewStock.Font = new Font("Segoe UI", 12F);
            btnAddNewStock.ForeColor = SystemColors.Control;
            btnAddNewStock.Location = new Point(0, 50);
            btnAddNewStock.Name = "btnAddNewStock";
            btnAddNewStock.Size = new Size(220, 50);
            btnAddNewStock.TabIndex = 6;
            btnAddNewStock.Text = "Add New Stock";
            btnAddNewStock.UseVisualStyleBackColor = false;
            btnAddNewStock.Click += btnAddNewStock_Click;
            // 
            // btnManageStockLevels
            // 
            btnManageStockLevels.BackColor = Color.LightSeaGreen;
            btnManageStockLevels.Dock = DockStyle.Top;
            btnManageStockLevels.FlatAppearance.BorderSize = 0;
            btnManageStockLevels.FlatStyle = FlatStyle.Flat;
            btnManageStockLevels.Font = new Font("Segoe UI", 12F);
            btnManageStockLevels.ForeColor = SystemColors.Control;
            btnManageStockLevels.Location = new Point(0, 0);
            btnManageStockLevels.Name = "btnManageStockLevels";
            btnManageStockLevels.Size = new Size(220, 50);
            btnManageStockLevels.TabIndex = 4;
            btnManageStockLevels.Text = "Manage Stock Levels";
            btnManageStockLevels.UseVisualStyleBackColor = false;
            btnManageStockLevels.Click += btnViewStock_Click;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.Teal;
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 12F);
            btnStock.ForeColor = SystemColors.Control;
            btnStock.Location = new Point(0, 125);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(220, 50);
            btnStock.TabIndex = 1;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += btnStock_Click;
            // 
            // pnlAvatar
            // 
            pnlAvatar.Dock = DockStyle.Top;
            pnlAvatar.Location = new Point(0, 0);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(220, 125);
            pnlAvatar.TabIndex = 0;
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.BackColor = Color.LightSeaGreen;
            pnlFormContainer.Controls.Add(pctBoxLogo);
            pnlFormContainer.Controls.Add(lblTitle);
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(220, 0);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(750, 560);
            pnlFormContainer.TabIndex = 2;
            // 
            // pctBoxLogo
            // 
            pctBoxLogo.Location = new Point(265, 194);
            pctBoxLogo.Name = "pctBoxLogo";
            pctBoxLogo.Size = new Size(250, 250);
            pctBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctBoxLogo.TabIndex = 1;
            pctBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(181, 85);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(436, 90);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Movers Maintenance Garage \r\n      Stock Control System";
            // 
            // frmMainScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(970, 560);
            Controls.Add(pnlFormContainer);
            Controls.Add(pnlSideBar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Control";
            pnlSideBar.ResumeLayout(false);
            pnlOrder.ResumeLayout(false);
            pnlStock.ResumeLayout(false);
            pnlFormContainer.ResumeLayout(false);
            pnlFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlFormContainer;
        private Panel pnlAvatar;
        private Button btnStock;
        private Panel pnlStock;
        private Button btnManageStockLevels;
        private Button btnAddNewStock;
        private Button btnOrder;
        private Panel pnlOrder;
        private Button btnViewOrders;
        private Button btnOrderStock;
        private Button btnRemoveStock;
        private Label lblTitle;
        private PictureBox pctBoxLogo;
    }
}