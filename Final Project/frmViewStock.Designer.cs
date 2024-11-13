namespace Final_Project
{
    partial class frmViewStock
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
            lstViewStock = new ListView();
            cHeaderStockName = new ColumnHeader();
            cHeaderStockQuantity = new ColumnHeader();
            SuspendLayout();
            // 
            // lstViewStock
            // 
            lstViewStock.BackColor = Color.SteelBlue;
            lstViewStock.BackgroundImageTiled = true;
            lstViewStock.Columns.AddRange(new ColumnHeader[] { cHeaderStockName, cHeaderStockQuantity });
            lstViewStock.Dock = DockStyle.Fill;
            lstViewStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewStock.ForeColor = Color.White;
            lstViewStock.GridLines = true;
            lstViewStock.Location = new Point(0, 0);
            lstViewStock.Name = "lstViewStock";
            lstViewStock.Size = new Size(732, 453);
            lstViewStock.TabIndex = 0;
            lstViewStock.UseCompatibleStateImageBehavior = false;
            lstViewStock.View = View.Details;
            // 
            // cHeaderStockName
            // 
            cHeaderStockName.Text = "Stock";
            cHeaderStockName.Width = 370;
            // 
            // cHeaderStockQuantity
            // 
            cHeaderStockQuantity.Text = "Quantity";
            cHeaderStockQuantity.Width = 370;
            // 
            // frmViewStock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(732, 453);
            Controls.Add(lstViewStock);
            Name = "frmViewStock";
            Text = "ViewStock";
            ResumeLayout(false);
        }

        #endregion

        private ListView lstViewStock;
        private ColumnHeader cHeaderStockName;
        private ColumnHeader cHeaderStockQuantity;
    }
}