namespace Final_Project
{
    partial class frmViewOrders
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
            pnlViewAllOrders = new Panel();
            pnlOptions = new Panel();
            btnViewOrder = new Button();
            btnEditOrder = new Button();
            pnlOrderInfo = new Panel();
            lblInstructions = new Label();
            lstViewOrders = new ListView();
            cHeaderOrderNumber = new ColumnHeader();
            cHeaderOrderStatus = new ColumnHeader();
            cHeaderDateOrdered = new ColumnHeader();
            pnlViewAllOrders.SuspendLayout();
            pnlOptions.SuspendLayout();
            pnlOrderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlViewAllOrders
            // 
            pnlViewAllOrders.Controls.Add(pnlOptions);
            pnlViewAllOrders.Controls.Add(pnlOrderInfo);
            pnlViewAllOrders.Dock = DockStyle.Top;
            pnlViewAllOrders.Location = new Point(0, 0);
            pnlViewAllOrders.Margin = new Padding(3, 4, 3, 4);
            pnlViewAllOrders.Name = "pnlViewAllOrders";
            pnlViewAllOrders.Size = new Size(882, 747);
            pnlViewAllOrders.TabIndex = 0;
            // 
            // pnlOptions
            // 
            pnlOptions.BackColor = Color.White;
            pnlOptions.Controls.Add(btnViewOrder);
            pnlOptions.Controls.Add(btnEditOrder);
            pnlOptions.Dock = DockStyle.Top;
            pnlOptions.Location = new Point(0, 621);
            pnlOptions.Margin = new Padding(3, 4, 3, 4);
            pnlOptions.Name = "pnlOptions";
            pnlOptions.Size = new Size(882, 125);
            pnlOptions.TabIndex = 3;
            // 
            // btnViewOrder
            // 
            btnViewOrder.BackColor = Color.LightSeaGreen;
            btnViewOrder.FlatAppearance.BorderSize = 0;
            btnViewOrder.FlatStyle = FlatStyle.Flat;
            btnViewOrder.Font = new Font("Segoe UI", 12F);
            btnViewOrder.ForeColor = SystemColors.Control;
            btnViewOrder.Location = new Point(152, 29);
            btnViewOrder.Margin = new Padding(3, 4, 3, 4);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(251, 67);
            btnViewOrder.TabIndex = 10;
            btnViewOrder.Text = "View Order";
            btnViewOrder.UseVisualStyleBackColor = false;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.BackColor = Color.LightSeaGreen;
            btnEditOrder.FlatAppearance.BorderSize = 0;
            btnEditOrder.FlatStyle = FlatStyle.Flat;
            btnEditOrder.Font = new Font("Segoe UI", 12F);
            btnEditOrder.ForeColor = SystemColors.Control;
            btnEditOrder.Location = new Point(479, 29);
            btnEditOrder.Margin = new Padding(3, 4, 3, 4);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(251, 67);
            btnEditOrder.TabIndex = 9;
            btnEditOrder.Text = "Edit Order";
            btnEditOrder.UseVisualStyleBackColor = false;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // pnlOrderInfo
            // 
            pnlOrderInfo.BackColor = Color.White;
            pnlOrderInfo.Controls.Add(lblInstructions);
            pnlOrderInfo.Controls.Add(lstViewOrders);
            pnlOrderInfo.Dock = DockStyle.Top;
            pnlOrderInfo.Location = new Point(0, 0);
            pnlOrderInfo.Margin = new Padding(3, 4, 3, 4);
            pnlOrderInfo.Name = "pnlOrderInfo";
            pnlOrderInfo.Size = new Size(882, 621);
            pnlOrderInfo.TabIndex = 4;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Dock = DockStyle.Top;
            lblInstructions.FlatStyle = FlatStyle.Flat;
            lblInstructions.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.ForeColor = SystemColors.ControlText;
            lblInstructions.Location = new Point(0, 545);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(568, 41);
            lblInstructions.TabIndex = 15;
            lblInstructions.Text = "Select an order to manage its information";
            // 
            // lstViewOrders
            // 
            lstViewOrders.BackColor = Color.LightSeaGreen;
            lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderOrderNumber, cHeaderOrderStatus, cHeaderDateOrdered });
            lstViewOrders.Dock = DockStyle.Top;
            lstViewOrders.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewOrders.ForeColor = Color.White;
            lstViewOrders.FullRowSelect = true;
            lstViewOrders.GridLines = true;
            lstViewOrders.Location = new Point(0, 0);
            lstViewOrders.Margin = new Padding(3, 4, 3, 4);
            lstViewOrders.Name = "lstViewOrders";
            lstViewOrders.Size = new Size(882, 545);
            lstViewOrders.TabIndex = 0;
            lstViewOrders.UseCompatibleStateImageBehavior = false;
            lstViewOrders.View = View.Details;
            lstViewOrders.ItemSelectionChanged += lstViewOrders_ItemSelectionChanged;
            // 
            // cHeaderOrderNumber
            // 
            cHeaderOrderNumber.Text = "Order Number";
            cHeaderOrderNumber.Width = 250;
            // 
            // cHeaderOrderStatus
            // 
            cHeaderOrderStatus.Text = "Order Status";
            cHeaderOrderStatus.Width = 250;
            // 
            // cHeaderDateOrdered
            // 
            cHeaderDateOrdered.Text = "Date Ordered";
            cHeaderDateOrdered.Width = 250;
            // 
            // frmViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 745);
            Controls.Add(pnlViewAllOrders);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmViewOrders";
            Text = "frmViewOrders";
            pnlViewAllOrders.ResumeLayout(false);
            pnlOptions.ResumeLayout(false);
            pnlOrderInfo.ResumeLayout(false);
            pnlOrderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewAllOrders;
        private Panel pnlOptions;
        private Button btnPlaceOrder;
        private Button btnSaveAsDraft;
        private Button btnRemoveFromOrder;
        private Button btnEditOrder;
        private Panel pnlOrderInfo;
        private Label lblInstructions;
        private ListView lstViewOrders;
        private ColumnHeader cHeaderOrderNumber;
        private ColumnHeader cHeaderOrderStatus;
        private ColumnHeader cHeaderDateOrdered;
        private Button btnViewOrder;
    }
}