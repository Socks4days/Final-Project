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
            lblSurname = new Label();
            lblErrorPassword = new Label();
            lblForename = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.5F);
            btnClear.Location = new Point(110, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(220, 50);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14.5F);
            btnRegister.Location = new Point(402, 361);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 50);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtBoxUsername
            // 
            txtBoxUsername.Font = new Font("Segoe UI", 12F);
            txtBoxUsername.Location = new Point(141, 134);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.PlaceholderText = "Username:";
            txtBoxUsername.Size = new Size(200, 34);
            txtBoxUsername.TabIndex = 1;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Segoe UI", 12F);
            txtBoxSurname.Location = new Point(391, 198);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.PlaceholderText = "Surname:";
            txtBoxSurname.Size = new Size(200, 34);
            txtBoxSurname.TabIndex = 4;
            // 
            // txtBoxForename
            // 
            txtBoxForename.Font = new Font("Segoe UI", 12F);
            txtBoxForename.Location = new Point(141, 200);
            txtBoxForename.Name = "txtBoxForename";
            txtBoxForename.PlaceholderText = "Forename:";
            txtBoxForename.Size = new Size(200, 34);
            txtBoxForename.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 12F);
            txtBoxPassword.Location = new Point(391, 134);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PlaceholderText = "Password:";
            txtBoxPassword.Size = new Size(200, 34);
            txtBoxPassword.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(304, 41);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 41);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Register";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 16F);
            lblError.ForeColor = Color.Coral;
            lblError.Location = new Point(110, 262);
            lblError.Name = "lblError";
            lblError.Size = new Size(112, 37);
            lblError.TabIndex = 7;
            lblError.Text = "Register";
            lblError.Visible = false;
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.Font = new Font("Segoe UI", 15F);
            lblErrorUsername.ForeColor = Color.Coral;
            lblErrorUsername.Location = new Point(122, 134);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(25, 35);
            lblErrorUsername.TabIndex = 8;
            lblErrorUsername.Text = "*";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 15F);
            lblSurname.ForeColor = Color.Coral;
            lblSurname.Location = new Point(371, 198);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(25, 35);
            lblSurname.TabIndex = 9;
            lblSurname.Text = "*";
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 15F);
            lblErrorPassword.ForeColor = Color.Coral;
            lblErrorPassword.Location = new Point(373, 134);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(25, 35);
            lblErrorPassword.TabIndex = 10;
            lblErrorPassword.Text = "*";
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Font = new Font("Segoe UI", 15F);
            lblForename.ForeColor = Color.Coral;
            lblForename.Location = new Point(121, 200);
            lblForename.Name = "lblForename";
            lblForename.Size = new Size(25, 35);
            lblForename.TabIndex = 11;
            lblForename.Text = "*";
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
            // frmRegister
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(732, 453);
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
            Controls.Add(lblForename);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblSurname);
            Name = "frmRegister";
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
        private Label lblSurname;
        private Label lblErrorPassword;
        private Label lblForename;
        private Button btnBack;
    }
}