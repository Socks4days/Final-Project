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
            btnViewStock = new Button();
            btnStock = new Button();
            pnlAvatar = new Panel();
            pnlTitleBar = new Panel();
            pnlFormContainer = new Panel();
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
            pnlStock.Controls.Add(btnViewStock);
            pnlStock.Dock = DockStyle.Top;
            pnlStock.Location = new Point(0, 175);
            pnlStock.Name = "pnlStock";
            pnlStock.Size = new Size(220, 125);
            pnlStock.TabIndex = 3;
            // 
            // btnViewStock
            // 
            btnViewStock.BackColor = Color.LightSeaGreen;
            btnViewStock.Dock = DockStyle.Top;
            btnViewStock.FlatAppearance.BorderSize = 0;
            btnViewStock.FlatStyle = FlatStyle.Flat;
            btnViewStock.Font = new Font("Segoe UI", 14.5F);
            btnViewStock.Location = new Point(0, 0);
            btnViewStock.Name = "btnViewStock";
            btnViewStock.Size = new Size(220, 50);
            btnViewStock.TabIndex = 4;
            btnViewStock.Text = "Stock";
            btnViewStock.UseVisualStyleBackColor = false;
            btnViewStock.Click += btnViewStock_Click;
            // 
            // btnStock
            // 
            btnStock.Dock = DockStyle.Top;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Segoe UI", 14.5F);
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
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.Teal;
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(220, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(750, 60);
            pnlTitleBar.TabIndex = 1;
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.BackColor = Color.LightSeaGreen;
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(220, 60);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(750, 500);
            pnlFormContainer.TabIndex = 2;
            // 
            // frmMainScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(970, 560);
            Controls.Add(pnlFormContainer);
            Controls.Add(pnlTitleBar);
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
        private Panel pnlTitleBar;
        private Panel pnlFormContainer;
        private Panel pnlAvatar;
        private Button btnStock;
        private Panel pnlStock;
        private Button btnViewStock;
    }
}