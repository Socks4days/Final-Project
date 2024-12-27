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
			SuspendLayout();
			// 
			// btnClear
			// 
			btnClear.Anchor = AnchorStyles.None;
			btnClear.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnClear.Location = new Point(355, 437);
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
			lblLogin.ForeColor = SystemColors.Control;
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
			txtBoxUsername.Location = new Point(408, 212);
			txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
			txtBoxUsername.Name = "txtBoxUsername";
			txtBoxUsername.PlaceholderText = "Username:";
			txtBoxUsername.Size = new Size(372, 32);
			txtBoxUsername.TabIndex = 1;
			// 
			// cBoxPassword
			// 
			cBoxPassword.Anchor = AnchorStyles.None;
			cBoxPassword.AutoSize = true;
			cBoxPassword.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
			cBoxPassword.ForeColor = SystemColors.Control;
			cBoxPassword.Location = new Point(612, 328);
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
			btnSubmit.Location = new Point(625, 437);
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
			txtBoxPassword.Location = new Point(408, 281);
			txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
			txtBoxPassword.Name = "txtBoxPassword";
			txtBoxPassword.PasswordChar = '*';
			txtBoxPassword.PlaceholderText = "Password:";
			txtBoxPassword.Size = new Size(372, 32);
			txtBoxPassword.TabIndex = 2;
			// 
			// lblError
			// 
			lblError.Anchor = AnchorStyles.None;
			lblError.Font = new Font("Segoe UI", 16F);
			lblError.ForeColor = Color.Gold;
			lblError.Location = new Point(355, 367);
			lblError.Name = "lblError";
			lblError.Size = new Size(490, 56);
			lblError.TabIndex = 6;
			lblError.Text = "Login";
			lblError.TextAlign = ContentAlignment.TopCenter;
			lblError.Visible = false;
			// 
			// btnRegister
			// 
			btnRegister.Anchor = AnchorStyles.None;
			btnRegister.BackColor = Color.Transparent;
			btnRegister.FlatAppearance.BorderSize = 0;
			btnRegister.FlatStyle = FlatStyle.Flat;
			btnRegister.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline);
			btnRegister.ForeColor = SystemColors.Control;
			btnRegister.Location = new Point(464, 528);
			btnRegister.Margin = new Padding(3, 4, 3, 4);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(260, 50);
			btnRegister.TabIndex = 7;
			btnRegister.Text = "Register a new account";
			btnRegister.UseVisualStyleBackColor = false;
			btnRegister.Click += btnRegister_Click;
			// 
			// frmLoginScreen
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			BackColor = Color.FromArgb(200, 200, 200);
			ClientSize = new Size(1200, 750);
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
    }
}