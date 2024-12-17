namespace Final_Project
{
    partial class frmAddDelivery
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
            pnlViewDeliveries = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnAddToOrder = new Button();
            lstViewDeliveries = new ListView();
            cHeaderDeliveryNumber = new ColumnHeader();
            cHeaderDeliveryDate = new ColumnHeader();
            cHeaderOrderNumber = new ColumnHeader();
            pnlViewDeliveries.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlViewDeliveries
            // 
            pnlViewDeliveries.Controls.Add(panel1);
            pnlViewDeliveries.Dock = DockStyle.Top;
            pnlViewDeliveries.Location = new Point(0, 0);
            pnlViewDeliveries.Margin = new Padding(3, 4, 3, 4);
            pnlViewDeliveries.Name = "pnlViewDeliveries";
            pnlViewDeliveries.Size = new Size(882, 747);
            pnlViewDeliveries.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAddToOrder);
            panel1.Controls.Add(lstViewDeliveries);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 599);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(316, 525);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 26;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(572, 525);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Anchor = AnchorStyles.None;
            btnAddToOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddToOrder.Location = new Point(51, 525);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(220, 50);
            btnAddToOrder.TabIndex = 24;
            btnAddToOrder.Text = "Check Delivery";
            btnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // lstViewDeliveries
            // 
            lstViewDeliveries.BackColor = Color.LightSeaGreen;
            lstViewDeliveries.Columns.AddRange(new ColumnHeader[] { cHeaderDeliveryNumber, cHeaderDeliveryDate, cHeaderOrderNumber });
            lstViewDeliveries.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewDeliveries.GridLines = true;
            lstViewDeliveries.Location = new Point(51, 37);
            lstViewDeliveries.Name = "lstViewDeliveries";
            lstViewDeliveries.Size = new Size(714, 460);
            lstViewDeliveries.TabIndex = 0;
            lstViewDeliveries.UseCompatibleStateImageBehavior = false;
            lstViewDeliveries.View = View.Details;
            lstViewDeliveries.ItemSelectionChanged += lstViewDeliveries_ItemSelectionChanged;
            // 
            // cHeaderDeliveryNumber
            // 
            cHeaderDeliveryNumber.Text = "Delivery Number";
            cHeaderDeliveryNumber.Width = 150;
            // 
            // cHeaderDeliveryDate
            // 
            cHeaderDeliveryDate.Text = "Delivery Date";
            cHeaderDeliveryDate.Width = 150;
            // 
            // cHeaderOrderNumber
            // 
            cHeaderOrderNumber.Text = "Order Number";
            cHeaderOrderNumber.Width = 150;
            // 
            // frmAddDelivery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(882, 745);
            Controls.Add(pnlViewDeliveries);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAddDelivery";
            Text = "frmAddDelivery";
            pnlViewDeliveries.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewDeliveries;
        private ListView lstViewDeliveries;
        private ColumnHeader cHeaderDeliveryNumber;
        private Panel panel1;
        private ColumnHeader cHeaderDeliveryDate;
        private ColumnHeader cHeaderOrderNumber;
        private Button button2;
        private Button button1;
        private Button btnAddToOrder;
    }
}