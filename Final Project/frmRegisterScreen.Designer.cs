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
			lblPassword = new Label();
			lblUsername = new Label();
			lblSurname = new Label();
			lblForename = new Label();
			SuspendLayout();
			// 
			// btnClear
			// 
			btnClear.Anchor = AnchorStyles.None;
			btnClear.Font = new Font("Segoe UI", 14.5F);
			btnClear.Location = new Point(351, 526);
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
			btnRegister.Location = new Point(630, 526);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(220, 50);
			btnRegister.TabIndex = 4;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// txtBoxUsername
			// 
			txtBoxUsername.Anchor = AnchorStyles.None;
			txtBoxUsername.Font = new Font("Segoe UI", 14F);
			txtBoxUsername.Location = new Point(331, 245);
			txtBoxUsername.MaxLength = 15;
			txtBoxUsername.Name = "txtBoxUsername";
			txtBoxUsername.Size = new Size(240, 32);
			txtBoxUsername.TabIndex = 0;
			// 
			// txtBoxSurname
			// 
			txtBoxSurname.Anchor = AnchorStyles.None;
			txtBoxSurname.Font = new Font("Segoe UI", 14F);
			txtBoxSurname.Location = new Point(630, 321);
			txtBoxSurname.MaxLength = 15;
			txtBoxSurname.Name = "txtBoxSurname";
			txtBoxSurname.Size = new Size(240, 32);
			txtBoxSurname.TabIndex = 3;
			// 
			// txtBoxForename
			// 
			txtBoxForename.Anchor = AnchorStyles.None;
			txtBoxForename.Font = new Font("Segoe UI", 14F);
			txtBoxForename.Location = new Point(331, 321);
			txtBoxForename.MaxLength = 15;
			txtBoxForename.Name = "txtBoxForename";
			txtBoxForename.Size = new Size(240, 32);
			txtBoxForename.TabIndex = 2;
			// 
			// txtBoxPassword
			// 
			txtBoxPassword.Anchor = AnchorStyles.None;
			txtBoxPassword.Font = new Font("Segoe UI", 14F);
			txtBoxPassword.Location = new Point(630, 247);
			txtBoxPassword.MaxLength = 15;
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.Size = new Size(240, 32);
			txtBoxPassword.TabIndex = 1;
			// 
			// lblTitle
			// 
			lblTitle.Anchor = AnchorStyles.None;
			lblTitle.AutoSize = true;
			lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTitle.ForeColor = Color.Black;
			lblTitle.Location = new Point(533, 137);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(135, 45);
			lblTitle.TabIndex = 6;
			lblTitle.Text = "Register";
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.BackColor = Color.FromArgb(255, 219, 219);
			lblError.BorderStyle = BorderStyle.FixedSingle;
			lblError.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			lblError.ForeColor = Color.FromArgb(250, 0, 0);
			lblError.Location = new Point(195, 397);
			lblError.Name = "lblError";
			lblError.Size = new Size(812, 96);
			lblError.TabIndex = 7;
			lblError.Text = "Register";
			lblError.TextAlign = ContentAlignment.MiddleCenter;
			lblError.Visible = false;
			// 
			// lblErrorUsername
			// 
			lblErrorUsername.Anchor = AnchorStyles.None;
			lblErrorUsername.AutoSize = true;
			lblErrorUsername.Font = new Font("Segoe UI", 15F);
			lblErrorUsername.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorUsername.Location = new Point(310, 243);
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
			lblErrorSurname.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorSurname.Location = new Point(609, 321);
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
			lblErrorPassword.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorPassword.Location = new Point(611, 247);
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
			lblErrorForename.ForeColor = Color.FromArgb(250, 0, 0);
			lblErrorForename.Location = new Point(309, 319);
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
			btnBack.TabIndex = 6;
			btnBack.Text = "←";
			btnBack.TextAlign = ContentAlignment.TopCenter;
			btnBack.UseVisualStyleBackColor = true;
			btnBack.Click += btnBack_Click;
			// 
			// lblPassword
			// 
			lblPassword.Anchor = AnchorStyles.None;
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Segoe UI", 14F);
			lblPassword.ForeColor = Color.Black;
			lblPassword.Location = new Point(630, 217);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(95, 25);
			lblPassword.TabIndex = 13;
			lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			lblUsername.Anchor = AnchorStyles.None;
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Segoe UI", 14F);
			lblUsername.ForeColor = Color.Black;
			lblUsername.Location = new Point(331, 217);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(101, 25);
			lblUsername.TabIndex = 14;
			lblUsername.Text = "Username:";
			// 
			// lblSurname
			// 
			lblSurname.Anchor = AnchorStyles.None;
			lblSurname.AutoSize = true;
			lblSurname.Font = new Font("Segoe UI", 14F);
			lblSurname.ForeColor = Color.Black;
			lblSurname.Location = new Point(630, 293);
			lblSurname.Name = "lblSurname";
			lblSurname.Size = new Size(91, 25);
			lblSurname.TabIndex = 15;
			lblSurname.Text = "Surname:";
			// 
			// lblForename
			// 
			lblForename.Anchor = AnchorStyles.None;
			lblForename.AutoSize = true;
			lblForename.Font = new Font("Segoe UI", 14F);
			lblForename.ForeColor = Color.Black;
			lblForename.Location = new Point(331, 293);
			lblForename.Name = "lblForename";
			lblForename.Size = new Size(100, 25);
			lblForename.TabIndex = 16;
			lblForename.Text = "Forename:";
			// 
			// frmRegisterScreen
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			BackColor = Color.FromArgb(149, 204, 249);
			ClientSize = new Size(1200, 750);
			Controls.Add(lblForename);
			Controls.Add(lblSurname);
			Controls.Add(lblUsername);
			Controls.Add(lblPassword);
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
		private Label lblPassword;
		private Label lblUsername;
		private Label lblSurname;
		private Label lblForename;
	}
}