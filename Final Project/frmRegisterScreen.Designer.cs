namespace Final_Project
{
    partial class frmRegisterScreen
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
			btnClear = new Button();
			btnRegister = new Button();
			txtBoxUsername = new TextBox();
			txtBoxSurname = new TextBox();
			txtBoxForename = new TextBox();
			txtBoxPassword = new TextBox();
			lblTitle = new Label();
			lblError = new Label();
			lblErrorUsername = new Label();
			lblErrorSurname = new Label();
			lblErrorPassword = new Label();
			lblErrorForename = new Label();
			btnBack = new Button();
			SuspendLayout();
			// 
			// btnClear
			// 
			btnClear.Anchor = AnchorStyles.None;
			btnClear.Font = new Font("Segoe UI", 14.5F);
			btnClear.Location = new Point(344, 495);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(220, 50);
			btnClear.TabIndex = 5;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnRegister
			// 
			btnRegister.Anchor = AnchorStyles.None;
			btnRegister.Font = new Font("Segoe UI", 14.5F);
			btnRegister.Location = new Point(636, 495);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(220, 50);
			btnRegister.TabIndex = 0;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// txtBoxUsername
			// 
			txtBoxUsername.Anchor = AnchorStyles.None;
			txtBoxUsername.Font = new Font("Segoe UI", 14F);
			txtBoxUsername.Location = new Point(331, 270);
			txtBoxUsername.Name = "txtBoxUsername";
			txtBoxUsername.PlaceholderText = "Username:";
			txtBoxUsername.Size = new Size(240, 32);
			txtBoxUsername.TabIndex = 1;
			// 
			// txtBoxSurname
			// 
			txtBoxSurname.Anchor = AnchorStyles.None;
			txtBoxSurname.Font = new Font("Segoe UI", 14F);
			txtBoxSurname.Location = new Point(630, 336);
			txtBoxSurname.Name = "txtBoxSurname";
			txtBoxSurname.PlaceholderText = "Surname:";
			txtBoxSurname.Size = new Size(240, 32);
			txtBoxSurname.TabIndex = 4;
			// 
			// txtBoxForename
			// 
			txtBoxForename.Anchor = AnchorStyles.None;
			txtBoxForename.Font = new Font("Segoe UI", 14F);
			txtBoxForename.Location = new Point(331, 336);
			txtBoxForename.Name = "txtBoxForename";
			txtBoxForename.PlaceholderText = "Forename:";
			txtBoxForename.Size = new Size(240, 32);
			txtBoxForename.TabIndex = 3;
			// 
			// txtBoxPassword
			// 
			txtBoxPassword.Anchor = AnchorStyles.None;
			txtBoxPassword.Font = new Font("Segoe UI", 14F);
			txtBoxPassword.Location = new Point(630, 272);
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.PlaceholderText = "Password:";
			txtBoxPassword.Size = new Size(240, 32);
			txtBoxPassword.TabIndex = 2;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.None;
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = SystemColors.Control;
			lblTitle.Location = new Point(533, 119);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(135, 45);
			lblTitle.TabIndex = 6;
			lblTitle.Text = "Register";
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.Font = new Font("Segoe UI", 16F);
			lblError.ForeColor = Color.Gold;
			lblError.Location = new Point(194, 389);
			lblError.Name = "lblError";
			lblError.Size = new Size(812, 96);
			lblError.TabIndex = 7;
			lblError.Text = "Register";
			lblError.TextAlign = ContentAlignment.TopCenter;
			lblError.Visible = false;
			// 
			// lblErrorUsername
			// 
			lblErrorUsername.Anchor = AnchorStyles.None;
			lblErrorUsername.AutoSize = true;
			lblErrorUsername.Font = new Font("Segoe UI", 15F);
			lblErrorUsername.ForeColor = Color.Gold;
			lblErrorUsername.Location = new Point(310, 268);
			lblErrorUsername.Name = "lblErrorUsername";
			lblErrorUsername.Size = new Size(20, 28);
			lblErrorUsername.TabIndex = 8;
			lblErrorUsername.Text = "*";
			// 
			// lblErrorSurname
			// 
			lblErrorSurname.Anchor = AnchorStyles.None;
			lblErrorSurname.AutoSize = true;
			lblErrorSurname.Font = new Font("Segoe UI", 15F);
			lblErrorSurname.ForeColor = Color.Gold;
			lblErrorSurname.Location = new Point(609, 336);
			lblErrorSurname.Name = "lblErrorSurname";
			lblErrorSurname.Size = new Size(20, 28);
			lblErrorSurname.TabIndex = 9;
			lblErrorSurname.Text = "*";
			// 
			// lblErrorPassword
			// 
			lblErrorPassword.Anchor = AnchorStyles.None;
			lblErrorPassword.AutoSize = true;
			lblErrorPassword.Font = new Font("Segoe UI", 15F);
			lblErrorPassword.ForeColor = Color.Gold;
			lblErrorPassword.Location = new Point(611, 272);
			lblErrorPassword.Name = "lblErrorPassword";
			lblErrorPassword.Size = new Size(20, 28);
			lblErrorPassword.TabIndex = 10;
			lblErrorPassword.Text = "*";
			// 
			// lblErrorForename
			// 
			lblErrorForename.Anchor = AnchorStyles.None;
			lblErrorForename.AutoSize = true;
			lblErrorForename.Font = new Font("Segoe UI", 15F);
			lblErrorForename.ForeColor = Color.Gold;
			lblErrorForename.Location = new Point(309, 334);
			lblErrorForename.Name = "lblErrorForename";
			lblErrorForename.Size = new Size(20, 28);
			lblErrorForename.TabIndex = 11;
			lblErrorForename.Text = "*";
			// 
			// btnBack
			// 
			btnBack.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnBack.Location = new Point(12, 12);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(90, 50);
			btnBack.TabIndex = 12;
			btnBack.Text = "←";
			btnBack.TextAlign = ContentAlignment.TopCenter;
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// frmRegisterScreen
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			BackColor = Color.FromArgb(200, 200, 200);
			ClientSize = new Size(1200, 750);
			Controls.Add(btnBack);
			Controls.Add(lblError);
			Controls.Add(lblTitle);
			Controls.Add(txtBoxPassword);
			Controls.Add(txtBoxForename);
			Controls.Add(txtBoxSurname);
			Controls.Add(txtBoxUsername);
			Controls.Add(btnRegister);
			Controls.Add(btnClear);
			Controls.Add(lblErrorUsername);
			Controls.Add(lblErrorForename);
			Controls.Add(lblErrorPassword);
			Controls.Add(lblErrorSurname);
			Name = "frmRegisterScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "frmRegister";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClear;
        private Button btnRegister;
        private TextBox txtBoxUsername;
        private TextBox txtBoxSurname;
        private TextBox txtBoxForename;
        private TextBox txtBoxPassword;
        private Label lblTitle;
        private Label lblError;
        private Label lblErrorUsername;
        private Label lblErrorSurname;
        private Label lblErrorPassword;
        private Label lblErrorForename;
        private Button btnBack;
    }
}