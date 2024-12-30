namespace Final_Project
{
    partial class frmLoginScreen
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
			lblLogin = new Label();
			txtBoxUsername = new TextBox();
			cBoxPassword = new CheckBox();
			btnSubmit = new Button();
			txtBoxPassword = new TextBox();
			lblError = new Label();
			btnRegister = new Button();
			lblPassword = new Label();
			lblUsername = new Label();
			SuspendLayout();
			// 
			// btnClear
			// 
			btnClear.Anchor = AnchorStyles.None;
			btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnClear.Location = new Point(355, 485);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(220, 50);
			btnClear.TabIndex = 0;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// lblLogin
			// 
			lblLogin.Anchor = AnchorStyles.None;
			lblLogin.AutoSize = true;
			lblLogin.Font = new Font("Segoe UI", 24F);
			lblLogin.ForeColor = Color.Black;
			lblLogin.Location = new Point(545, 128);
			lblLogin.Name = "lblLogin";
			lblLogin.Size = new Size(99, 45);
			lblLogin.TabIndex = 1;
			lblLogin.Text = "Login";
			// 
			// txtBoxUsername
			// 
			txtBoxUsername.Anchor = AnchorStyles.None;
			txtBoxUsername.Font = new Font("Segoe UI", 14F);
			txtBoxUsername.Location = new Point(408, 239);
			txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
			txtBoxUsername.MaxLength = 50;
			txtBoxUsername.Name = "txtBoxUsername";
			txtBoxUsername.Size = new Size(372, 32);
			txtBoxUsername.TabIndex = 1;
			// 
			// cBoxPassword
			// 
			cBoxPassword.Anchor = AnchorStyles.None;
			cBoxPassword.AutoSize = true;
			cBoxPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cBoxPassword.ForeColor = Color.Black;
			cBoxPassword.Location = new Point(612, 363);
			cBoxPassword.Margin = new Padding(3, 4, 3, 4);
			cBoxPassword.Name = "cBoxPassword";
			cBoxPassword.Size = new Size(161, 29);
			cBoxPassword.TabIndex = 3;
			cBoxPassword.Text = "Show Password";
			cBoxPassword.UseVisualStyleBackColor = true;
			cBoxPassword.CheckedChanged += cBoxPassword_CheckedChanged;
			// 
			// btnSubmit
			// 
			btnSubmit.Anchor = AnchorStyles.None;
			btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSubmit.Location = new Point(625, 485);
			btnSubmit.Margin = new Padding(3, 4, 3, 4);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(220, 50);
			btnSubmit.TabIndex = 3;
			btnSubmit.Text = "Submit";
			btnSubmit.UseVisualStyleBackColor = true;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// txtBoxPassword
			// 
			txtBoxPassword.Anchor = AnchorStyles.None;
			txtBoxPassword.Font = new Font("Segoe UI", 14F);
			txtBoxPassword.Location = new Point(408, 322);
			txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
			txtBoxPassword.MaxLength = 50;
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.PasswordChar = '*';
			txtBoxPassword.Size = new Size(372, 32);
			txtBoxPassword.TabIndex = 2;
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.BackColor = Color.FromArgb(255, 209, 209);
			lblError.BorderStyle = BorderStyle.FixedSingle;
			lblError.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			lblError.ForeColor = Color.FromArgb(250, 0, 0);
			lblError.Location = new Point(355, 415);
			lblError.Name = "lblError";
			lblError.Size = new Size(490, 56);
			lblError.TabIndex = 6;
			lblError.Text = "Login";
			lblError.TextAlign = ContentAlignment.MiddleCenter;
			lblError.Visible = false;
			// 
			// btnRegister
			// 
			btnRegister.Anchor = AnchorStyles.None;
			btnRegister.BackColor = Color.Transparent;
			btnRegister.FlatAppearance.BorderSize = 0;
			btnRegister.FlatStyle = FlatStyle.Flat;
			btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
			btnRegister.ForeColor = Color.Black;
			btnRegister.Location = new Point(464, 576);
			btnRegister.Margin = new Padding(3, 4, 3, 4);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(260, 50);
			btnRegister.TabIndex = 7;
			btnRegister.Text = "Register a new account";
			btnRegister.UseVisualStyleBackColor = false;
			btnRegister.Click += btnRegister_Click;
			// 
			// lblPassword
			// 
			lblPassword.Anchor = AnchorStyles.None;
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Segoe UI", 14F);
			lblPassword.ForeColor = Color.Black;
			lblPassword.Location = new Point(408, 293);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(95, 25);
			lblPassword.TabIndex = 8;
			lblPassword.Text = "Password:";
			// 
			// lblUsername
			// 
			lblUsername.Anchor = AnchorStyles.None;
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Segoe UI", 14F);
			lblUsername.ForeColor = Color.Black;
			lblUsername.Location = new Point(408, 210);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(101, 25);
			lblUsername.TabIndex = 9;
			lblUsername.Text = "Username:";
			// 
			// frmLoginScreen
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			BackColor = Color.FromArgb(149, 204, 249);
			ClientSize = new Size(1200, 750);
			Controls.Add(lblUsername);
			Controls.Add(lblPassword);
			Controls.Add(btnRegister);
			Controls.Add(lblError);
			Controls.Add(txtBoxPassword);
			Controls.Add(btnSubmit);
			Controls.Add(cBoxPassword);
			Controls.Add(txtBoxUsername);
			Controls.Add(lblLogin);
			Controls.Add(btnClear);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmLoginScreen";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClear;
        private Label lblLogin;
        private TextBox txtBoxUsername;
        private CheckBox cBoxPassword;
        private Button btnSubmit;
        private TextBox txtBoxPassword;
        private Label lblError;
        private Button btnRegister;
		private Label lblPassword;
		private Label lblUsername;
	}
}