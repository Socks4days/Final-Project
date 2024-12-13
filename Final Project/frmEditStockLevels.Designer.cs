namespace Final_Project
{
    partial class frmEditStockLevels
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
            pnlViewStock = new Panel();
            pnlLstViewAndInstructions = new Panel();
            lblInstructions = new Label();
            lstViewStock = new ListView();
            cHeaderStockName = new ColumnHeader();
            cHeaderStockQuantity = new ColumnHeader();
            cHeaderLastCheckedDate = new ColumnHeader();
            cHeaderCheckedBy = new ColumnHeader();
            pnlOptionButtons = new Panel();
            btnEditStock = new Button();
            btnRemoveFromStock = new Button();
            btnAddToStock = new Button();
            pnlEditStockLevels = new Panel();
            lblCurrentStockLevel = new Label();
            lblStockLevelToEdit = new Label();
            btnCancel = new Button();
            lblError = new Label();
            txtBoxAmountOfStockToChange = new TextBox();
            label1 = new Label();
            btnRemoveStock = new Button();
            btnAddStock = new Button();
            pnlEditStockItem = new Panel();
            btnReturnStockEdit = new Button();
            txtBoxStockCheckFrequency = new TextBox();
            txtBoxDeliveryTime = new TextBox();
            lblStockCheckFrequency = new Label();
            lblDeliveryTimeDays = new Label();
            txtBoxDescription = new TextBox();
            txtBoxMaximumLevel = new TextBox();
            txtBoxMinimumLevel = new TextBox();
            txtBoxOrderQuantity = new TextBox();
            txtBoxPrice = new TextBox();
            lblErrorStockEdit = new Label();
            label2 = new Label();
            txtBoxName = new TextBox();
            btnEditStockItem = new Button();
            lblDescription = new Label();
            lblPrice = new Label();
            lblMinimumLevel = new Label();
            lblOrderQuantity = new Label();
            lblMaximumLevel = new Label();
            lblName = new Label();
            pnlViewStock.SuspendLayout();
            pnlLstViewAndInstructions.SuspendLayout();
            pnlOptionButtons.SuspendLayout();
            pnlEditStockLevels.SuspendLayout();
            pnlEditStockItem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlViewStock
            // 
            pnlViewStock.Controls.Add(pnlLstViewAndInstructions);
            pnlViewStock.Controls.Add(pnlOptionButtons);
            pnlViewStock.Dock = DockStyle.Top;
            pnlViewStock.Location = new Point(0, 0);
            pnlViewStock.Name = "pnlViewStock";
            pnlViewStock.Size = new Size(746, 558);
            pnlViewStock.TabIndex = 0;
            // 
            // pnlLstViewAndInstructions
            // 
            pnlLstViewAndInstructions.Controls.Add(lblInstructions);
            pnlLstViewAndInstructions.Controls.Add(lstViewStock);
            pnlLstViewAndInstructions.Dock = DockStyle.Top;
            pnlLstViewAndInstructions.Location = new Point(0, 0);
            pnlLstViewAndInstructions.Name = "pnlLstViewAndInstructions";
            pnlLstViewAndInstructions.Size = new Size(746, 468);
            pnlLstViewAndInstructions.TabIndex = 11;
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Dock = DockStyle.Bottom;
            lblInstructions.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(0, 427);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(681, 41);
            lblInstructions.TabIndex = 14;
            lblInstructions.Text = "Select an item to manage its level and information";
            // 
            // lstViewStock
            // 
            lstViewStock.BackColor = Color.LightSeaGreen;
            lstViewStock.BackgroundImageTiled = true;
            lstViewStock.Columns.AddRange(new ColumnHeader[] { cHeaderStockName, cHeaderStockQuantity, cHeaderLastCheckedDate, cHeaderCheckedBy });
            lstViewStock.Dock = DockStyle.Top;
            lstViewStock.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstViewStock.ForeColor = Color.White;
            lstViewStock.FullRowSelect = true;
            lstViewStock.GridLines = true;
            lstViewStock.Location = new Point(0, 0);
            lstViewStock.Margin = new Padding(3, 2, 3, 2);
            lstViewStock.Name = "lstViewStock";
            lstViewStock.Size = new Size(746, 434);
            lstViewStock.TabIndex = 13;
            lstViewStock.UseCompatibleStateImageBehavior = false;
            lstViewStock.View = View.Details;
            lstViewStock.ItemSelectionChanged += lstViewStock_ItemSelectionChanged;
            // 
            // cHeaderStockName
            // 
            cHeaderStockName.Text = "Stock";
            cHeaderStockName.Width = 250;
            // 
            // cHeaderStockQuantity
            // 
            cHeaderStockQuantity.Text = "Quantity";
            cHeaderStockQuantity.Width = 120;
            // 
            // cHeaderLastCheckedDate
            // 
            cHeaderLastCheckedDate.Text = "Last Checked";
            cHeaderLastCheckedDate.Width = 160;
            // 
            // cHeaderCheckedBy
            // 
            cHeaderCheckedBy.Text = "Checked By";
            cHeaderCheckedBy.Width = 215;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.BackColor = Color.White;
            pnlOptionButtons.Controls.Add(btnEditStock);
            pnlOptionButtons.Controls.Add(btnRemoveFromStock);
            pnlOptionButtons.Controls.Add(btnAddToStock);
            pnlOptionButtons.Dock = DockStyle.Bottom;
            pnlOptionButtons.Location = new Point(0, 462);
            pnlOptionButtons.Name = "pnlOptionButtons";
            pnlOptionButtons.Size = new Size(746, 96);
            pnlOptionButtons.TabIndex = 10;
            pnlOptionButtons.Click += pnlOptionButtons_Click;
            // 
            // btnEditStock
            // 
            btnEditStock.BackColor = Color.LightSeaGreen;
            btnEditStock.FlatAppearance.BorderSize = 0;
            btnEditStock.FlatStyle = FlatStyle.Flat;
            btnEditStock.Font = new Font("Segoe UI", 12F);
            btnEditStock.ForeColor = SystemColors.Control;
            btnEditStock.Location = new Point(12, 21);
            btnEditStock.Name = "btnEditStock";
            btnEditStock.Size = new Size(220, 50);
            btnEditStock.TabIndex = 8;
            btnEditStock.Text = "Edit Stock Item";
            btnEditStock.UseVisualStyleBackColor = false;
            btnEditStock.Click += btnEditStock_Click;
            // 
            // btnRemoveFromStock
            // 
            btnRemoveFromStock.BackColor = Color.LightSeaGreen;
            btnRemoveFromStock.FlatAppearance.BorderSize = 0;
            btnRemoveFromStock.FlatStyle = FlatStyle.Flat;
            btnRemoveFromStock.Font = new Font("Segoe UI", 12F);
            btnRemoveFromStock.ForeColor = SystemColors.Control;
            btnRemoveFromStock.Location = new Point(518, 21);
            btnRemoveFromStock.Name = "btnRemoveFromStock";
            btnRemoveFromStock.Size = new Size(220, 50);
            btnRemoveFromStock.TabIndex = 7;
            btnRemoveFromStock.Text = "Remove From Stock";
            btnRemoveFromStock.UseVisualStyleBackColor = false;
            btnRemoveFromStock.Click += btnRemoveFromStock_Click;
            // 
            // btnAddToStock
            // 
            btnAddToStock.BackColor = Color.LightSeaGreen;
            btnAddToStock.FlatAppearance.BorderSize = 0;
            btnAddToStock.FlatStyle = FlatStyle.Flat;
            btnAddToStock.Font = new Font("Segoe UI", 12F);
            btnAddToStock.ForeColor = SystemColors.Control;
            btnAddToStock.Location = new Point(265, 21);
            btnAddToStock.Name = "btnAddToStock";
            btnAddToStock.Size = new Size(220, 50);
            btnAddToStock.TabIndex = 5;
            btnAddToStock.Text = "Add To Stock";
            btnAddToStock.UseVisualStyleBackColor = false;
            btnAddToStock.Click += btnAddToStock_Click;
            // 
            // pnlEditStockLevels
            // 
            pnlEditStockLevels.BackColor = Color.LightSeaGreen;
            pnlEditStockLevels.Controls.Add(lblCurrentStockLevel);
            pnlEditStockLevels.Controls.Add(lblStockLevelToEdit);
            pnlEditStockLevels.Controls.Add(btnCancel);
            pnlEditStockLevels.Controls.Add(lblError);
            pnlEditStockLevels.Controls.Add(txtBoxAmountOfStockToChange);
            pnlEditStockLevels.Controls.Add(label1);
            pnlEditStockLevels.Controls.Add(btnRemoveStock);
            pnlEditStockLevels.Controls.Add(btnAddStock);
            pnlEditStockLevels.Dock = DockStyle.Top;
            pnlEditStockLevels.Location = new Point(0, 558);
            pnlEditStockLevels.Name = "pnlEditStockLevels";
            pnlEditStockLevels.Size = new Size(746, 560);
            pnlEditStockLevels.TabIndex = 1;
            // 
            // lblCurrentStockLevel
            // 
            lblCurrentStockLevel.Anchor = AnchorStyles.None;
            lblCurrentStockLevel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentStockLevel.ForeColor = SystemColors.Control;
            lblCurrentStockLevel.Location = new Point(35, 160);
            lblCurrentStockLevel.Name = "lblCurrentStockLevel";
            lblCurrentStockLevel.Size = new Size(676, 40);
            lblCurrentStockLevel.TabIndex = 18;
            lblCurrentStockLevel.Text = "Stock level goes here";
            lblCurrentStockLevel.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblStockLevelToEdit
            // 
            lblStockLevelToEdit.Anchor = AnchorStyles.None;
            lblStockLevelToEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockLevelToEdit.ForeColor = SystemColors.Control;
            lblStockLevelToEdit.Location = new Point(35, 120);
            lblStockLevelToEdit.Name = "lblStockLevelToEdit";
            lblStockLevelToEdit.Size = new Size(676, 40);
            lblStockLevelToEdit.TabIndex = 17;
            lblStockLevelToEdit.Text = "Stock name goes here";
            lblStockLevelToEdit.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(92, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(220, 50);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnBack_Click;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.Font = new Font("Segoe UI", 16F);
            lblError.ForeColor = Color.Coral;
            lblError.Location = new Point(41, 247);
            lblError.Name = "lblError";
            lblError.Size = new Size(664, 119);
            lblError.TabIndex = 15;
            lblError.Text = "Error message goes here";
            lblError.TextAlign = ContentAlignment.TopCenter;
            lblError.Visible = false;
            // 
            // txtBoxAmountOfStockToChange
            // 
            txtBoxAmountOfStockToChange.Anchor = AnchorStyles.None;
            txtBoxAmountOfStockToChange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAmountOfStockToChange.Location = new Point(263, 201);
            txtBoxAmountOfStockToChange.Name = "txtBoxAmountOfStockToChange";
            txtBoxAmountOfStockToChange.PlaceholderText = "Enter Amount:";
            txtBoxAmountOfStockToChange.Size = new Size(220, 38);
            txtBoxAmountOfStockToChange.TabIndex = 14;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(257, 78);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 12;
            label1.Text = "Change Stock Levels";
            // 
            // btnRemoveStock
            // 
            btnRemoveStock.Anchor = AnchorStyles.None;
            btnRemoveStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemoveStock.Location = new Point(438, 436);
            btnRemoveStock.Name = "btnRemoveStock";
            btnRemoveStock.Size = new Size(220, 50);
            btnRemoveStock.TabIndex = 13;
            btnRemoveStock.Text = "Remove From Stock";
            btnRemoveStock.UseVisualStyleBackColor = true;
            btnRemoveStock.Click += btnRemoveStock_Click;
            // 
            // btnAddStock
            // 
            btnAddStock.Anchor = AnchorStyles.None;
            btnAddStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddStock.Location = new Point(438, 436);
            btnAddStock.Name = "btnAddStock";
            btnAddStock.Size = new Size(220, 50);
            btnAddStock.TabIndex = 11;
            btnAddStock.Text = "Add To Stock";
            btnAddStock.UseVisualStyleBackColor = true;
            btnAddStock.Click += btnAddStock_Click;
            // 
            // pnlEditStockItem
            // 
            pnlEditStockItem.BackColor = Color.LightSeaGreen;
            pnlEditStockItem.Controls.Add(btnReturnStockEdit);
            pnlEditStockItem.Controls.Add(txtBoxStockCheckFrequency);
            pnlEditStockItem.Controls.Add(txtBoxDeliveryTime);
            pnlEditStockItem.Controls.Add(lblStockCheckFrequency);
            pnlEditStockItem.Controls.Add(lblDeliveryTimeDays);
            pnlEditStockItem.Controls.Add(txtBoxDescription);
            pnlEditStockItem.Controls.Add(txtBoxMaximumLevel);
            pnlEditStockItem.Controls.Add(txtBoxMinimumLevel);
            pnlEditStockItem.Controls.Add(txtBoxOrderQuantity);
            pnlEditStockItem.Controls.Add(txtBoxPrice);
            pnlEditStockItem.Controls.Add(lblErrorStockEdit);
            pnlEditStockItem.Controls.Add(label2);
            pnlEditStockItem.Controls.Add(txtBoxName);
            pnlEditStockItem.Controls.Add(btnEditStockItem);
            pnlEditStockItem.Controls.Add(lblDescription);
            pnlEditStockItem.Controls.Add(lblPrice);
            pnlEditStockItem.Controls.Add(lblMinimumLevel);
            pnlEditStockItem.Controls.Add(lblOrderQuantity);
            pnlEditStockItem.Controls.Add(lblMaximumLevel);
            pnlEditStockItem.Controls.Add(lblName);
            pnlEditStockItem.Dock = DockStyle.Top;
            pnlEditStockItem.Location = new Point(0, 1118);
            pnlEditStockItem.Name = "pnlEditStockItem";
            pnlEditStockItem.Size = new Size(746, 560);
            pnlEditStockItem.TabIndex = 2;
            // 
            // btnReturnStockEdit
            // 
            btnReturnStockEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReturnStockEdit.Location = new Point(122, 498);
            btnReturnStockEdit.Name = "btnReturnStockEdit";
            btnReturnStockEdit.Size = new Size(220, 50);
            btnReturnStockEdit.TabIndex = 34;
            btnReturnStockEdit.Text = "Return";
            btnReturnStockEdit.UseVisualStyleBackColor = true;
            btnReturnStockEdit.Click += btnCancelStockEdit_Click;
            // 
            // txtBoxStockCheckFrequency
            // 
            txtBoxStockCheckFrequency.Anchor = AnchorStyles.None;
            txtBoxStockCheckFrequency.Font = new Font("Segoe UI", 12F);
            txtBoxStockCheckFrequency.Location = new Point(509, 282);
            txtBoxStockCheckFrequency.Name = "txtBoxStockCheckFrequency";
            txtBoxStockCheckFrequency.Size = new Size(220, 34);
            txtBoxStockCheckFrequency.TabIndex = 31;
            // 
            // txtBoxDeliveryTime
            // 
            txtBoxDeliveryTime.Anchor = AnchorStyles.None;
            txtBoxDeliveryTime.Font = new Font("Segoe UI", 12F);
            txtBoxDeliveryTime.Location = new Point(133, 279);
            txtBoxDeliveryTime.Name = "txtBoxDeliveryTime";
            txtBoxDeliveryTime.Size = new Size(220, 34);
            txtBoxDeliveryTime.TabIndex = 30;
            // 
            // lblStockCheckFrequency
            // 
            lblStockCheckFrequency.Anchor = AnchorStyles.None;
            lblStockCheckFrequency.AutoSize = true;
            lblStockCheckFrequency.Font = new Font("Segoe UI", 12F);
            lblStockCheckFrequency.ForeColor = SystemColors.Control;
            lblStockCheckFrequency.Location = new Point(379, 285);
            lblStockCheckFrequency.Name = "lblStockCheckFrequency";
            lblStockCheckFrequency.Size = new Size(163, 28);
            lblStockCheckFrequency.TabIndex = 33;
            lblStockCheckFrequency.Text = "Check Frequency:";
            // 
            // lblDeliveryTimeDays
            // 
            lblDeliveryTimeDays.Anchor = AnchorStyles.None;
            lblDeliveryTimeDays.AutoSize = true;
            lblDeliveryTimeDays.Font = new Font("Segoe UI", 12F);
            lblDeliveryTimeDays.ForeColor = SystemColors.Control;
            lblDeliveryTimeDays.Location = new Point(19, 282);
            lblDeliveryTimeDays.Name = "lblDeliveryTimeDays";
            lblDeliveryTimeDays.Size = new Size(134, 28);
            lblDeliveryTimeDays.TabIndex = 32;
            lblDeliveryTimeDays.Text = "Delivery Time:";
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Anchor = AnchorStyles.None;
            txtBoxDescription.Font = new Font("Segoe UI", 12F);
            txtBoxDescription.Location = new Point(133, 174);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(220, 34);
            txtBoxDescription.TabIndex = 23;
            // 
            // txtBoxMaximumLevel
            // 
            txtBoxMaximumLevel.Anchor = AnchorStyles.None;
            txtBoxMaximumLevel.Font = new Font("Segoe UI", 12F);
            txtBoxMaximumLevel.Location = new Point(509, 122);
            txtBoxMaximumLevel.Name = "txtBoxMaximumLevel";
            txtBoxMaximumLevel.Size = new Size(220, 34);
            txtBoxMaximumLevel.TabIndex = 22;
            // 
            // txtBoxMinimumLevel
            // 
            txtBoxMinimumLevel.Anchor = AnchorStyles.None;
            txtBoxMinimumLevel.Font = new Font("Segoe UI", 12F);
            txtBoxMinimumLevel.Location = new Point(509, 177);
            txtBoxMinimumLevel.Name = "txtBoxMinimumLevel";
            txtBoxMinimumLevel.Size = new Size(220, 34);
            txtBoxMinimumLevel.TabIndex = 21;
            // 
            // txtBoxOrderQuantity
            // 
            txtBoxOrderQuantity.Anchor = AnchorStyles.None;
            txtBoxOrderQuantity.Font = new Font("Segoe UI", 12F);
            txtBoxOrderQuantity.Location = new Point(509, 233);
            txtBoxOrderQuantity.Name = "txtBoxOrderQuantity";
            txtBoxOrderQuantity.Size = new Size(220, 34);
            txtBoxOrderQuantity.TabIndex = 20;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Anchor = AnchorStyles.None;
            txtBoxPrice.Font = new Font("Segoe UI", 12F);
            txtBoxPrice.Location = new Point(133, 230);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(220, 34);
            txtBoxPrice.TabIndex = 19;
            // 
            // lblErrorStockEdit
            // 
            lblErrorStockEdit.Anchor = AnchorStyles.None;
            lblErrorStockEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorStockEdit.ForeColor = Color.Coral;
            lblErrorStockEdit.Location = new Point(10, 339);
            lblErrorStockEdit.Name = "lblErrorStockEdit";
            lblErrorStockEdit.Size = new Size(726, 83);
            lblErrorStockEdit.TabIndex = 17;
            lblErrorStockEdit.Text = "Error message goes here";
            lblErrorStockEdit.TextAlign = ContentAlignment.TopCenter;
            lblErrorStockEdit.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(287, 21);
            label2.Name = "label2";
            label2.Size = new Size(216, 41);
            label2.TabIndex = 16;
            label2.Text = "Edit Stock Item";
            // 
            // txtBoxName
            // 
            txtBoxName.Anchor = AnchorStyles.None;
            txtBoxName.Font = new Font("Segoe UI", 12F);
            txtBoxName.Location = new Point(133, 119);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(220, 34);
            txtBoxName.TabIndex = 15;
            // 
            // btnEditStockItem
            // 
            btnEditStockItem.Anchor = AnchorStyles.None;
            btnEditStockItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditStockItem.Location = new Point(407, 498);
            btnEditStockItem.Name = "btnEditStockItem";
            btnEditStockItem.Size = new Size(220, 50);
            btnEditStockItem.TabIndex = 14;
            btnEditStockItem.Text = "Confirm Changes";
            btnEditStockItem.UseVisualStyleBackColor = true;
            btnEditStockItem.Click += btnEditStockItem_Click;
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F);
            lblDescription.ForeColor = SystemColors.Control;
            lblDescription.Location = new Point(39, 177);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(116, 28);
            lblDescription.TabIndex = 29;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.None;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.ForeColor = SystemColors.Control;
            lblPrice.Location = new Point(82, 233);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 28);
            lblPrice.TabIndex = 28;
            lblPrice.Text = "Price:";
            // 
            // lblMinimumLevel
            // 
            lblMinimumLevel.Anchor = AnchorStyles.None;
            lblMinimumLevel.AutoSize = true;
            lblMinimumLevel.Font = new Font("Segoe UI", 12F);
            lblMinimumLevel.ForeColor = SystemColors.Control;
            lblMinimumLevel.Location = new Point(389, 180);
            lblMinimumLevel.Name = "lblMinimumLevel";
            lblMinimumLevel.Size = new Size(149, 28);
            lblMinimumLevel.TabIndex = 27;
            lblMinimumLevel.Text = "Minimum Level:";
            // 
            // lblOrderQuantity
            // 
            lblOrderQuantity.Anchor = AnchorStyles.None;
            lblOrderQuantity.AutoSize = true;
            lblOrderQuantity.Font = new Font("Segoe UI", 12F);
            lblOrderQuantity.ForeColor = SystemColors.Control;
            lblOrderQuantity.Location = new Point(392, 236);
            lblOrderQuantity.Name = "lblOrderQuantity";
            lblOrderQuantity.Size = new Size(148, 28);
            lblOrderQuantity.TabIndex = 26;
            lblOrderQuantity.Text = "Order Quantity:";
            // 
            // lblMaximumLevel
            // 
            lblMaximumLevel.Anchor = AnchorStyles.None;
            lblMaximumLevel.AutoSize = true;
            lblMaximumLevel.Font = new Font("Segoe UI", 12F);
            lblMaximumLevel.ForeColor = SystemColors.Control;
            lblMaximumLevel.Location = new Point(387, 122);
            lblMaximumLevel.Name = "lblMaximumLevel";
            lblMaximumLevel.Size = new Size(152, 28);
            lblMaximumLevel.TabIndex = 25;
            lblMaximumLevel.Text = "Maximum Level:";
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.ForeColor = SystemColors.Control;
            lblName.Location = new Point(74, 122);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 24;
            lblName.Text = "Name:";
            // 
            // frmEditStockLevels
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(767, 559);
            Controls.Add(pnlEditStockItem);
            Controls.Add(pnlEditStockLevels);
            Controls.Add(pnlViewStock);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmEditStockLevels";
            Text = "ViewStock";
            pnlViewStock.ResumeLayout(false);
            pnlLstViewAndInstructions.ResumeLayout(false);
            pnlLstViewAndInstructions.PerformLayout();
            pnlOptionButtons.ResumeLayout(false);
            pnlEditStockLevels.ResumeLayout(false);
            pnlEditStockLevels.PerformLayout();
            pnlEditStockItem.ResumeLayout(false);
            pnlEditStockItem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewStock;
        private Panel pnlOptionButtons;
        private Button btnRemoveFromStock;
        private Button btnAddToStock;
        private Panel pnlEditStockLevels;
        private Label lblStockLevelToEdit;
        private Button btnCancel;
        private Label lblError;
        private TextBox txtBoxAmountOfStockToChange;
        private Button btnRemoveStock;
        private Label label1;
        private Button btnAddStock;
        private Label lblCurrentStockLevel;
        private Button btnEditStock;
        private Panel pnlEditStockItem;
        private Label lblErrorStockEdit;
        private Label label2;
        private TextBox txtBoxName;
        private Button btnEditStockItem;
        private Label lblMaximumLevel;
        private Label lblName;
        private TextBox txtBoxDescription;
        private TextBox txtBoxMaximumLevel;
        private TextBox txtBoxMinimumLevel;
        private TextBox txtBoxOrderQuantity;
        private TextBox txtBoxPrice;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblMinimumLevel;
        private Label lblOrderQuantity;
        private Panel pnlLstViewAndInstructions;
        private Label lblInstructions;
        private ListView lstViewStock;
        private ColumnHeader cHeaderStockName;
        private ColumnHeader cHeaderStockQuantity;
        private ColumnHeader cHeaderLastCheckedDate;
        private ColumnHeader cHeaderCheckedBy;
        private TextBox txtBoxStockCheckFrequency;
        private TextBox txtBoxDeliveryTime;
        private Label lblStockCheckFrequency;
        private Label lblDeliveryTimeDays;
        private Button btnReturnStockEdit;
    }
}