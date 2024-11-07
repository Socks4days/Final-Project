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
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnClear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(103, 358);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(220, 50);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblLogin
            // 
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.Control;
            lblLogin.Location = new Point(325, 47);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(92, 41);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Login";
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxUsername.Font = new Font("Segoe UI", 14.25F);
            txtBoxUsername.Location = new Point(213, 123);
            txtBoxUsername.Margin = new Padding(3, 4, 3, 4);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.PlaceholderText = "Username:";
            txtBoxUsername.Size = new Size(309, 39);
            txtBoxUsername.TabIndex = 0;
            // 
            // cBoxPassword
            // 
            cBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cBoxPassword.AutoSize = true;
            cBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBoxPassword.ForeColor = SystemColors.Control;
            cBoxPassword.Location = new Point(365, 244);
            cBoxPassword.Margin = new Padding(3, 4, 3, 4);
            cBoxPassword.Name = "cBoxPassword";
            cBoxPassword.Size = new Size(168, 32);
            cBoxPassword.TabIndex = 3;
            cBoxPassword.Text = "Show Password";
            cBoxPassword.UseVisualStyleBackColor = true;
            cBoxPassword.CheckedChanged += cBoxPassword_CheckedChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSubmit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(409, 358);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(220, 50);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBoxPassword.Font = new Font("Segoe UI", 14.25F);
            txtBoxPassword.Location = new Point(213, 192);
            txtBoxPassword.Margin = new Padding(3, 4, 3, 4);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.PlaceholderText = "Password:";
            txtBoxPassword.Size = new Size(309, 39);
            txtBoxPassword.TabIndex = 1;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 16F);
            lblError.ForeColor = Color.Coral;
            lblError.Location = new Point(103, 282);
            lblError.Name = "lblError";
            lblError.Size = new Size(84, 37);
            lblError.TabIndex = 6;
            lblError.Text = "Login";
            lblError.Visible = false;
            // 
            // frmLoginScreen
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(732, 453);
            Controls.Add(lblError);
            Controls.Add(txtBoxPassword);
            Controls.Add(btnSubmit);
            Controls.Add(cBoxPassword);
            Controls.Add(txtBoxUsername);
            Controls.Add(lblLogin);
            Controls.Add(btnClear);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLoginScreen";
            Text = "Login";
            FormClosed += frmLoginScreen_FormClosed;
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
    }
}