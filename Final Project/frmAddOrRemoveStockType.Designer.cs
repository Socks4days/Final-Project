namespace Final_Project
{
    partial class frmAddOrRemoveStockType
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
            pnlAddStock = new Panel();
            txtBoxAddStock = new TextBox();
            lblAddStock = new Label();
            btnBack = new Button();
            btnAddStock = new Button();
            pnlAddStock.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAddStock
            // 
            pnlAddStock.BackColor = Color.SteelBlue;
            pnlAddStock.Controls.Add(txtBoxAddStock);
            pnlAddStock.Controls.Add(lblAddStock);
            pnlAddStock.Controls.Add(btnBack);
            pnlAddStock.Controls.Add(btnAddStock);
            pnlAddStock.Dock = DockStyle.Top;
            pnlAddStock.Location = new Point(0, 0);
            pnlAddStock.Name = "pnlAddStock";
            pnlAddStock.Size = new Size(783, 560);
            pnlAddStock.TabIndex = 1;
            // 
            // txtBoxAddStock
            // 
            txtBoxAddStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAddStock.Location = new Point(283, 203);
            txtBoxAddStock.Name = "txtBoxAddStock";
            txtBoxAddStock.Size = new Size(216, 32);
            txtBoxAddStock.TabIndex = 3;
            // 
            // lblAddStock
            // 
            lblAddStock.AutoSize = true;
            lblAddStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddStock.ForeColor = SystemColors.Control;
            lblAddStock.Location = new Point(331, 128);
            lblAddStock.Name = "lblAddStock";
            lblAddStock.Size = new Size(121, 32);
            lblAddStock.TabIndex = 2;
            lblAddStock.Text = "Add Stock";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAddStock
            // 
            btnAddStock.Location = new Point(318, 276);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(147, 36);
            btnAddStock.TabIndex = 0;
            btnAddStock.Text = "Add Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            // 
            // frmAddOrRemoveStockType
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new Size(800, 513);
            Controls.Add(pnlAddStock);
            Name = "frmAddOrRemoveStockType";
            Text = "AddOrRemoveStockType";
            pnlAddStock.ResumeLayout(false);
            pnlAddStock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAddStock;
        private TextBox txtBoxAddStock;
        private Label lblAddStock;
        private Button btnBack;
        private Button btnAddStock;
    }
}