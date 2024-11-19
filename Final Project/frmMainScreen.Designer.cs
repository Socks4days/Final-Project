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
            pnlSideBar = new Panel();
            pnlStock = new Panel();
            btnAddNewStock = new Button();
            btnEditStockLevels = new Button();
            btnViewStock = new Button();
            btnStock = new Button();
            pnlAvatar = new Panel();
            pnlFormContainer = new Panel();
            btnRemoveStock = new Button();
            pnlSideBar.SuspendLayout();
            pnlStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoScroll = true;
            pnlSideBar.BackColor = Color.Teal;
            pnlSideBar.Controls.Add(pnlStock);
            pnlSideBar.Controls.Add(btnStock);
            pnlSideBar.Controls.Add(pnlAvatar);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(220, 560);
            pnlSideBar.TabIndex = 0;
            // 
            // pnlStock
            // 
            pnlStock.Controls.Add(btnRemoveStock);
            pnlStock.Controls.Add(btnAddNewStock);
            pnlStock.Controls.Add(btnEditStockLevels);
            pnlStock.Controls.Add(btnViewStock);
            pnlStock.Dock = DockStyle.Top;
            pnlStock.Location = new Point(0, 175);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(220, 217);
            pnlStock.TabIndex = 3;
            // 
            // btnAddNewStock
            // 
            btnAddNewStock.BackColor = Color.LightSeaGreen;
            btnAddNewStock.Dock = DockStyle.Top;
            btnAddNewStock.FlatAppearance.BorderSize = 0;
            btnAddNewStock.FlatStyle = FlatStyle.Flat;
            btnAddNewStock.Font = new Font("Segoe UI", 12F);
            btnAddNewStock.ForeColor = SystemColors.Control;
            btnAddNewStock.Location = new Point(0, 100);
            btnAddNewStock.Name = "btnAddNewStock";
            btnAddNewStock.Size = new Size(220, 50);
            btnAddNewStock.TabIndex = 6;
            btnAddNewStock.Text = "Add New Stock";
            btnAddNewStock.UseVisualStyleBackColor = false;
            btnAddNewStock.Click += btnAddNewStock_Click;
            // 
            // btnEditStockLevels
            // 
            btnEditStockLevels.BackColor = Color.LightSeaGreen;
            btnEditStockLevels.Dock = DockStyle.Top;
            btnEditStockLevels.FlatAppearance.BorderSize = 0;
            btnEditStockLevels.FlatStyle = FlatStyle.Flat;
            btnEditStockLevels.Font = new Font("Segoe UI", 12F);
            btnEditStockLevels.ForeColor = SystemColors.Control;
            btnEditStockLevels.Location = new Point(0, 50);
            btnEditStockLevels.Name = "btnEditStockLevels";
            btnEditStockLevels.Size = new Size(220, 50);
            btnEditStockLevels.TabIndex = 5;
            btnEditStockLevels.Text = "Edit Stock Levels";
            btnEditStockLevels.UseVisualStyleBackColor = false;
            btnEditStockLevels.Click += btnEditStockLevels_Click;
            // 
            // btnViewStock
            // 
            btnViewStock.BackColor = Color.LightSeaGreen;
            btnViewStock.Dock = DockStyle.Top;
            btnViewStock.FlatAppearance.BorderSize = 0;
            btnViewStock.FlatStyle = FlatStyle.Flat;
            btnViewStock.Font = new Font("Segoe UI", 12F);
            btnViewStock.ForeColor = SystemColors.Control;
            btnViewStock.Location = new Point(0, 0);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Size = new Size(220, 50);
            btnViewStock.TabIndex = 4;
            btnViewStock.Text = "View Stock Levels";
            btnViewStock.UseVisualStyleBackColor = false;
            btnViewStock.Click += btnViewStock_Click;
            // 
            // btnStock
            // 
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
            btnStock.UseVisualStyleBackColor = true;
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
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(220, 0);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(750, 560);
            pnlFormContainer.TabIndex = 2;
            // 
            // btnRemoveStock
            // 
            btnRemoveStock.BackColor = Color.LightSeaGreen;
            btnRemoveStock.Dock = DockStyle.Top;
            btnRemoveStock.FlatAppearance.BorderSize = 0;
            btnRemoveStock.FlatStyle = FlatStyle.Flat;
            btnRemoveStock.Font = new Font("Segoe UI", 12F);
            btnRemoveStock.ForeColor = SystemColors.Control;
            btnRemoveStock.Location = new Point(0, 150);
            btnRemoveStock.Name = "btnRemoveStock";
            btnRemoveStock.Size = new Size(220, 50);
            btnRemoveStock.TabIndex = 7;
            btnRemoveStock.Text = "Remove Stock";
            btnRemoveStock.UseVisualStyleBackColor = false;
            btnRemoveStock.Click += btnRemoveStock_Click;
            // 
            // frmMainScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(970, 560);
            Controls.Add(pnlFormContainer);
            Controls.Add(pnlSideBar);
            Name = "frmMainScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stock Control";
            pnlSideBar.ResumeLayout(false);
            pnlStock.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlFormContainer;
        private Panel pnlAvatar;
        private Button btnStock;
        private Panel pnlStock;
        private Button btnViewStock;
        private Button btnEditStockLevels;
        private Button btnAddNewStock;
        private Button btnRemoveStock;
    }
}