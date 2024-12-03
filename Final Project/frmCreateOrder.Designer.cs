namespace Final_Project
{
    partial class frmCreateOrder
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
            panel1 = new Panel();
            lblCurrentStockLevel = new Label();
            nUPQuantity = new NumericUpDown();
            btnAddToBasket = new Button();
            btnGoToBasket = new Button();
            lblQuantity = new Label();
            lblStockItem = new Label();
            lblTitle = new Label();
            cBoxStock = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUPQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCurrentStockLevel);
            panel1.Controls.Add(nUPQuantity);
            panel1.Controls.Add(btnAddToBasket);
            panel1.Controls.Add(btnGoToBasket);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblStockItem);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(cBoxStock);
            panel1.Location = new Point(-3, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 560);
            panel1.TabIndex = 0;
            // 
            // lblCurrentStockLevel
            // 
            lblCurrentStockLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStockLevel.ForeColor = SystemColors.Control;
            lblCurrentStockLevel.Location = new Point(122, 250);
            lblCurrentStockLevel.Name = "lblCurrentStockLevel";
            lblCurrentStockLevel.Size = new Size(511, 78);
            lblCurrentStockLevel.TabIndex = 25;
            lblCurrentStockLevel.Text = "Current Stock Level Goes Here";
            lblCurrentStockLevel.TextAlign = ContentAlignment.TopCenter;
            // 
            // nUPQuantity
            // 
            nUPQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nUPQuantity.Location = new Point(412, 183);
            nUPQuantity.Name = "nUPQuantity";
            nUPQuantity.Size = new Size(176, 33);
            nUPQuantity.TabIndex = 24;
            // 
            // btnAddToBasket
            // 
            btnAddToBasket.Anchor = AnchorStyles.None;
            btnAddToBasket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToBasket.Location = new Point(519, 500);
            btnAddToBasket.Name = "btnAddToBasket";
            btnAddToBasket.Size = new Size(220, 50);
            btnAddToBasket.TabIndex = 23;
            btnAddToBasket.Text = "Add To Basket";
            btnAddToBasket.UseVisualStyleBackColor = true;
            btnAddToBasket.Click += btnAddToBasket_Click;
            // 
            // btnGoToBasket
            // 
            btnGoToBasket.Anchor = AnchorStyles.None;
            btnGoToBasket.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGoToBasket.Location = new Point(639, 15);
            btnGoToBasket.Name = "btnGoToBasket";
            btnGoToBasket.Size = new Size(100, 50);
            btnGoToBasket.TabIndex = 22;
            btnGoToBasket.Text = "Go To Basket";
            btnGoToBasket.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.Control;
            lblQuantity.Location = new Point(412, 155);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 25);
            lblQuantity.TabIndex = 21;
            lblQuantity.Text = "Quantity";
            // 
            // lblStockItem
            // 
            lblStockItem.AutoSize = true;
            lblStockItem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockItem.ForeColor = SystemColors.Control;
            lblStockItem.Location = new Point(166, 155);
            lblStockItem.Name = "lblStockItem";
            lblStockItem.Size = new Size(98, 25);
            lblStockItem.TabIndex = 20;
            lblStockItem.Text = "Stock Item";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(285, 46);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(184, 32);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Create an Order";
            // 
            // cBoxStock
            // 
            cBoxStock.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxStock.FormattingEnabled = true;
            cBoxStock.Location = new Point(166, 183);
            cBoxStock.Name = "cBoxStock";
            cBoxStock.Size = new Size(176, 33);
            cBoxStock.TabIndex = 18;
            // 
            // frmCreateOrder
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(748, 559);
            Controls.Add(panel1);
            Name = "frmCreateOrder";
            Text = "frmCreateOrder";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUPQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cBoxQuantity;
        private Panel panel1;
        private Label lblCurrentStockLevel;
        private NumericUpDown nUPQuantity;
        private Button btnAddToBasket;
        private Button btnGoToBasket;
        private Label lblQuantity;
        private Label lblStockItem;
        private Label lblTitle;
        private ComboBox cBoxStock;
    }
}