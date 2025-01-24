namespace Final_Project
{
	partial class frmStaffManagement
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
			pnlStaffInfo = new Panel();
			btnEditPosition = new Button();
			btnEditStaffMember = new Button();
			lblInstructions = new Label();
			lstViewOrders = new ListView();
			cHeaderStaffForename = new ColumnHeader();
			cHeaderStaffSurname = new ColumnHeader();
			cHeaderPosition = new ColumnHeader();
			cHeaderActive = new ColumnHeader();
			pnlEditStaffMember = new Panel();
			btnCancelStaffEdit = new Button();
			txtBoxSurname = new TextBox();
			txtBoxPassword = new TextBox();
			txtBoxUsername = new TextBox();
			lblErrorStaffEdit = new Label();
			txtBoxForename = new TextBox();
			btnConfirmEditStaff = new Button();
			lblSurname = new Label();
			lblUsername = new Label();
			lblPassword = new Label();
			lblForename = new Label();
			panel1 = new Panel();
			cBoxStaffPositions = new ComboBox();
			button1 = new Button();
			button2 = new Button();
			lblStaffToEditPosition = new Label();
			pnlStaffListView = new Panel();
			pnlOptionButtons = new Panel();
			pnlStaffInfo.SuspendLayout();
			pnlEditStaffMember.SuspendLayout();
			panel1.SuspendLayout();
			pnlStaffListView.SuspendLayout();
			pnlOptionButtons.SuspendLayout();
			SuspendLayout();
			// 
			// pnlStaffInfo
			// 
			pnlStaffInfo.BackColor = SystemColors.ScrollBar;
			pnlStaffInfo.Controls.Add(pnlStaffListView);
			pnlStaffInfo.Controls.Add(pnlOptionButtons);
			pnlStaffInfo.Dock = DockStyle.Top;
			pnlStaffInfo.Location = new Point(0, 0);
			pnlStaffInfo.Name = "pnlStaffInfo";
			pnlStaffInfo.Size = new Size(982, 680);
			pnlStaffInfo.TabIndex = 6;
			// 
			// btnEditPosition
			// 
			btnEditPosition.Anchor = AnchorStyles.Bottom;
			btnEditPosition.BackColor = Color.FromArgb(150, 12, 150);
			btnEditPosition.FlatAppearance.BorderSize = 0;
			btnEditPosition.FlatStyle = FlatStyle.Flat;
			btnEditPosition.Font = new Font("Segoe UI", 14F);
			btnEditPosition.ForeColor = SystemColors.Control;
			btnEditPosition.Location = new Point(566, 18);
			btnEditPosition.Name = "btnEditPosition";
			btnEditPosition.Size = new Size(220, 50);
			btnEditPosition.TabIndex = 17;
			btnEditPosition.Text = "Edit Staff Position";
			btnEditPosition.UseVisualStyleBackColor = false;
			// 
			// btnEditStaffMember
			// 
			btnEditStaffMember.Anchor = AnchorStyles.Bottom;
			btnEditStaffMember.BackColor = Color.FromArgb(150, 12, 150);
			btnEditStaffMember.FlatAppearance.BorderSize = 0;
			btnEditStaffMember.FlatStyle = FlatStyle.Flat;
			btnEditStaffMember.Font = new Font("Segoe UI", 14F);
			btnEditStaffMember.ForeColor = SystemColors.Control;
			btnEditStaffMember.Location = new Point(223, 18);
			btnEditStaffMember.Name = "btnEditStaffMember";
			btnEditStaffMember.Size = new Size(220, 50);
			btnEditStaffMember.TabIndex = 16;
			btnEditStaffMember.Text = "Edit Staff Member";
			btnEditStaffMember.UseVisualStyleBackColor = false;
			// 
			// lblInstructions
			// 
			lblInstructions.Anchor = AnchorStyles.Bottom;
			lblInstructions.AutoSize = true;
			lblInstructions.FlatStyle = FlatStyle.Flat;
			lblInstructions.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblInstructions.ForeColor = SystemColors.ControlText;
			lblInstructions.Location = new Point(273, 560);
			lblInstructions.Name = "lblInstructions";
			lblInstructions.Size = new Size(436, 25);
			lblInstructions.TabIndex = 15;
			lblInstructions.Text = "Select a staff member to manage their information";
			// 
			// lstViewOrders
			// 
			lstViewOrders.Anchor = AnchorStyles.Top;
			lstViewOrders.BackColor = Color.FromArgb(200, 12, 200);
			lstViewOrders.Columns.AddRange(new ColumnHeader[] { cHeaderStaffForename, cHeaderStaffSurname, cHeaderPosition, cHeaderActive });
			lstViewOrders.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lstViewOrders.ForeColor = Color.Black;
			lstViewOrders.FullRowSelect = true;
			lstViewOrders.GridLines = true;
			lstViewOrders.Location = new Point(12, 28);
			lstViewOrders.Name = "lstViewOrders";
			lstViewOrders.Size = new Size(942, 518);
			lstViewOrders.TabIndex = 0;
			lstViewOrders.UseCompatibleStateImageBehavior = false;
			lstViewOrders.View = View.Details;
			lstViewOrders.ItemSelectionChanged += lstViewOrders_ItemSelectionChanged;
			// 
			// cHeaderStaffForename
			// 
			cHeaderStaffForename.Text = "Forename";
			cHeaderStaffForename.Width = 250;
			// 
			// cHeaderStaffSurname
			// 
			cHeaderStaffSurname.Text = "Surname";
			cHeaderStaffSurname.Width = 250;
			// 
			// cHeaderPosition
			// 
			cHeaderPosition.Text = "Position";
			cHeaderPosition.Width = 250;
			// 
			// cHeaderActive
			// 
			cHeaderActive.Text = "Active";
			cHeaderActive.Width = 150;
			// 
			// pnlEditStaffMember
			// 
			pnlEditStaffMember.BackColor = Color.FromArgb(200, 200, 200);
			pnlEditStaffMember.Controls.Add(btnCancelStaffEdit);
			pnlEditStaffMember.Controls.Add(txtBoxSurname);
			pnlEditStaffMember.Controls.Add(txtBoxPassword);
			pnlEditStaffMember.Controls.Add(txtBoxUsername);
			pnlEditStaffMember.Controls.Add(lblErrorStaffEdit);
			pnlEditStaffMember.Controls.Add(txtBoxForename);
			pnlEditStaffMember.Controls.Add(btnConfirmEditStaff);
			pnlEditStaffMember.Controls.Add(lblSurname);
			pnlEditStaffMember.Controls.Add(lblUsername);
			pnlEditStaffMember.Controls.Add(lblPassword);
			pnlEditStaffMember.Controls.Add(lblForename);
			pnlEditStaffMember.Dock = DockStyle.Top;
			pnlEditStaffMember.Location = new Point(0, 680);
			pnlEditStaffMember.Name = "pnlEditStaffMember";
			pnlEditStaffMember.Size = new Size(982, 680);
			pnlEditStaffMember.TabIndex = 7;
			// 
			// btnCancelStaffEdit
			// 
			btnCancelStaffEdit.Anchor = AnchorStyles.None;
			btnCancelStaffEdit.BackColor = Color.FromArgb(150, 12, 150);
			btnCancelStaffEdit.FlatAppearance.BorderSize = 0;
			btnCancelStaffEdit.FlatStyle = FlatStyle.Flat;
			btnCancelStaffEdit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnCancelStaffEdit.ForeColor = Color.White;
			btnCancelStaffEdit.Location = new Point(236, 441);
			btnCancelStaffEdit.Name = "btnCancelStaffEdit";
			btnCancelStaffEdit.Size = new Size(220, 50);
			btnCancelStaffEdit.TabIndex = 9;
			btnCancelStaffEdit.Text = "Cancel";
			btnCancelStaffEdit.UseVisualStyleBackColor = false;
			// 
			// txtBoxSurname
			// 
			txtBoxSurname.Anchor = AnchorStyles.None;
			txtBoxSurname.BorderStyle = BorderStyle.None;
			txtBoxSurname.Font = new Font("Segoe UI", 14F);
			txtBoxSurname.Location = new Point(552, 220);
			txtBoxSurname.Name = "txtBoxSurname";
			txtBoxSurname.Size = new Size(220, 25);
			txtBoxSurname.TabIndex = 1;
			// 
			// txtBoxPassword
			// 
			txtBoxPassword.Anchor = AnchorStyles.None;
			txtBoxPassword.BorderStyle = BorderStyle.None;
			txtBoxPassword.Font = new Font("Segoe UI", 14F);
			txtBoxPassword.Location = new Point(552, 284);
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.Size = new Size(220, 25);
			txtBoxPassword.TabIndex = 3;
			// 
			// txtBoxUsername
			// 
			txtBoxUsername.Anchor = AnchorStyles.None;
			txtBoxUsername.BorderStyle = BorderStyle.None;
			txtBoxUsername.Font = new Font("Segoe UI", 14F);
			txtBoxUsername.Location = new Point(236, 284);
			txtBoxUsername.Name = "txtBoxUsername";
			txtBoxUsername.Size = new Size(220, 25);
			txtBoxUsername.TabIndex = 2;
			// 
			// lblErrorStaffEdit
			// 
			lblErrorStaffEdit.Anchor = AnchorStyles.None;
			lblErrorStaffEdit.BackColor = Color.FromArgb(255, 209, 209);
			lblErrorStaffEdit.BorderStyle = BorderStyle.FixedSingle;
			lblErrorStaffEdit.FlatStyle = FlatStyle.Flat;
			lblErrorStaffEdit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblErrorStaffEdit.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorStaffEdit.Location = new Point(128, 331);
			lblErrorStaffEdit.Name = "lblErrorStaffEdit";
			lblErrorStaffEdit.Size = new Size(726, 83);
			lblErrorStaffEdit.TabIndex = 17;
			lblErrorStaffEdit.Text = "Error message goes here";
			lblErrorStaffEdit.TextAlign = ContentAlignment.MiddleCenter;
			lblErrorStaffEdit.Visible = false;
			// 
			// txtBoxForename
			// 
			txtBoxForename.Anchor = AnchorStyles.None;
			txtBoxForename.BorderStyle = BorderStyle.None;
			txtBoxForename.Font = new Font("Segoe UI", 14F);
			txtBoxForename.Location = new Point(236, 220);
			txtBoxForename.Name = "txtBoxForename";
			txtBoxForename.Size = new Size(220, 25);
			txtBoxForename.TabIndex = 0;
			// 
			// btnConfirmEditStaff
			// 
			btnConfirmEditStaff.Anchor = AnchorStyles.None;
			btnConfirmEditStaff.BackColor = Color.FromArgb(150, 12, 150);
			btnConfirmEditStaff.FlatAppearance.BorderSize = 0;
			btnConfirmEditStaff.FlatStyle = FlatStyle.Flat;
			btnConfirmEditStaff.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnConfirmEditStaff.ForeColor = Color.White;
			btnConfirmEditStaff.Location = new Point(552, 441);
			btnConfirmEditStaff.Name = "btnConfirmEditStaff";
			btnConfirmEditStaff.Size = new Size(220, 50);
			btnConfirmEditStaff.TabIndex = 8;
			btnConfirmEditStaff.Text = "Confirm Changes";
			btnConfirmEditStaff.UseVisualStyleBackColor = false;
			// 
			// lblSurname
			// 
			lblSurname.Anchor = AnchorStyles.None;
			lblSurname.AutoSize = true;
			lblSurname.Font = new Font("Segoe UI", 14F);
			lblSurname.ForeColor = Color.Black;
			lblSurname.Location = new Point(552, 192);
			lblSurname.Name = "lblSurname";
			lblSurname.Size = new Size(91, 25);
			lblSurname.TabIndex = 29;
			lblSurname.Text = "Surname:";
			// 
			// lblUsername
			// 
			lblUsername.Anchor = AnchorStyles.None;
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Segoe UI", 14F);
			lblUsername.ForeColor = Color.Black;
			lblUsername.Location = new Point(236, 256);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(101, 25);
			lblUsername.TabIndex = 27;
			lblUsername.Text = "Username:";
			// 
			// lblPassword
			// 
			lblPassword.Anchor = AnchorStyles.None;
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Segoe UI", 14F);
			lblPassword.ForeColor = Color.Black;
			lblPassword.Location = new Point(552, 257);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(95, 25);
			lblPassword.TabIndex = 25;
			lblPassword.Text = "Password:";
			// 
			// lblForename
			// 
			lblForename.Anchor = AnchorStyles.None;
			lblForename.AutoSize = true;
			lblForename.Font = new Font("Segoe UI", 14F);
			lblForename.ForeColor = Color.Black;
			lblForename.Location = new Point(236, 192);
			lblForename.Name = "lblForename";
			lblForename.Size = new Size(100, 25);
			lblForename.TabIndex = 24;
			lblForename.Text = "Forename:";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(200, 200, 200);
			panel1.Controls.Add(cBoxStaffPositions);
			panel1.Controls.Add(button1);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(lblStaffToEditPosition);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 1360);
			panel1.Name = "panel1";
			panel1.Size = new Size(982, 680);
			panel1.TabIndex = 8;
			// 
			// cBoxStaffPositions
			// 
			cBoxStaffPositions.Font = new Font("Segoe UI", 14F);
			cBoxStaffPositions.FormattingEnabled = true;
			cBoxStaffPositions.Location = new Point(381, 266);
			cBoxStaffPositions.Name = "cBoxStaffPositions";
			cBoxStaffPositions.Size = new Size(220, 33);
			cBoxStaffPositions.TabIndex = 25;
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.None;
			button1.BackColor = Color.FromArgb(150, 12, 150);
			button1.FlatAppearance.BorderSize = 0;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(223, 337);
			button1.Name = "button1";
			button1.Size = new Size(220, 50);
			button1.TabIndex = 9;
			button1.Text = "Cancel";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.None;
			button2.BackColor = Color.FromArgb(150, 12, 150);
			button2.FlatAppearance.BorderSize = 0;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.White;
			button2.Location = new Point(539, 337);
			button2.Name = "button2";
			button2.Size = new Size(220, 50);
			button2.TabIndex = 8;
			button2.Text = "Confirm Changes";
			button2.UseVisualStyleBackColor = false;
			// 
			// lblStaffToEditPosition
			// 
			lblStaffToEditPosition.Anchor = AnchorStyles.None;
			lblStaffToEditPosition.Font = new Font("Segoe UI", 14F);
			lblStaffToEditPosition.ForeColor = Color.Black;
			lblStaffToEditPosition.Location = new Point(224, 217);
			lblStaffToEditPosition.Name = "lblStaffToEditPosition";
			lblStaffToEditPosition.Size = new Size(535, 25);
			lblStaffToEditPosition.TabIndex = 24;
			lblStaffToEditPosition.Text = "Editing position for:";
			lblStaffToEditPosition.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pnlStaffListView
			// 
			pnlStaffListView.Controls.Add(lstViewOrders);
			pnlStaffListView.Controls.Add(lblInstructions);
			pnlStaffListView.Dock = DockStyle.Top;
			pnlStaffListView.Location = new Point(0, 0);
			pnlStaffListView.Name = "pnlStaffListView";
			pnlStaffListView.Size = new Size(982, 598);
			pnlStaffListView.TabIndex = 18;
			// 
			// pnlOptionButtons
			// 
			pnlOptionButtons.Controls.Add(btnEditPosition);
			pnlOptionButtons.Controls.Add(btnEditStaffMember);
			pnlOptionButtons.Dock = DockStyle.Bottom;
			pnlOptionButtons.Location = new Point(0, 598);
			pnlOptionButtons.Name = "pnlOptionButtons";
			pnlOptionButtons.Size = new Size(982, 82);
			pnlOptionButtons.TabIndex = 19;
			// 
			// frmStaffManagement
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoScroll = true;
			AutoSize = true;
			ClientSize = new Size(1000, 680);
			Controls.Add(panel1);
			Controls.Add(pnlEditStaffMember);
			Controls.Add(pnlStaffInfo);
			Name = "frmStaffManagement";
			Text = "frmStaffManagement";
			pnlStaffInfo.ResumeLayout(false);
			pnlEditStaffMember.ResumeLayout(false);
			pnlEditStaffMember.PerformLayout();
			panel1.ResumeLayout(false);
			pnlStaffListView.ResumeLayout(false);
			pnlStaffListView.PerformLayout();
			pnlOptionButtons.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlStaffInfo;
		private Button btnEditPosition;
		private Button btnEditStaffMember;
		private Label lblInstructions;
		private ListView lstViewOrders;
		private ColumnHeader cHeaderStaffForename;
		private ColumnHeader cHeaderStaffSurname;
		private ColumnHeader cHeaderPosition;
		private Panel pnlEditStaffMember;
		private Button btnCancelStaffEdit;
		private TextBox txtBoxSurname;
		private TextBox txtBoxPassword;
		private TextBox txtBoxUsername;
		private Label lblErrorStaffEdit;
		private TextBox txtBoxForename;
		private TextBox txtBoxStockCheckFrequency;
		private TextBox txtBoxDeliveryTime;
		private Label lblStockCheckFrequency;
		private Label lblDeliveryTimeDays;
		private TextBox txtBoxDescription;
		private TextBox txtBoxMaximumLevel;
		private TextBox txtBoxMinimumLevel;
		private TextBox txtBoxOrderQuantity;
		private TextBox txtBoxPrice;
		private Label lblErrorStockEdit;
		private TextBox txtBoxName;
		private Button btnConfirmEditStaff;
		private Label lblSurname;
		private Label lblUsername;
		private Label lblPassword;
		private Label lblDescription;
		private Label lblPrice;
		private Label lblMinimumLevel;
		private Label lblOrderQuantity;
		private Label lblMaximumLevel;
		private Label lblForename;
		private ColumnHeader cHeaderActive;
		private Panel panel1;
		private ComboBox cBoxStaffPositions;
		private Button button1;
		private Button button2;
		private Label lblStaffToEditPosition;
		private Panel pnlStaffListView;
		private Panel pnlOptionButtons;
	}
}