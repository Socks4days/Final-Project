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
            btnClear.Location = new Point(244, 398);
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
            btnRegister.Location = new Point(536, 398);
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
            txtBoxUsername.Font = new Font("Segoe UI", 12F);
            txtBoxUsername.Location = new Point(226, 173);
            txtBoxUsername.Name = "txtBoxUsername";
            txtBoxUsername.PlaceholderText = "Username:";
            txtBoxUsername.Size = new Size(240, 34);
            txtBoxUsername.TabIndex = 1;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Anchor = AnchorStyles.None;
            txtBoxSurname.Font = new Font("Segoe UI", 12F);
            txtBoxSurname.Location = new Point(525, 239);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.PlaceholderText = "Surname:";
            txtBoxSurname.Size = new Size(240, 34);
            txtBoxSurname.TabIndex = 4;
            // 
            // txtBoxForename
            // 
            txtBoxForename.Anchor = AnchorStyles.None;
            txtBoxForename.Font = new Font("Segoe UI", 12F);
            txtBoxForename.Location = new Point(226, 239);
            txtBoxForename.Name = "txtBoxForename";
            txtBoxForename.PlaceholderText = "Forename:";
            txtBoxForename.Size = new Size(240, 34);
            txtBoxForename.TabIndex = 3;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Anchor = AnchorStyles.None;
            txtBoxPassword.Font = new Font("Segoe UI", 12F);
            txtBoxPassword.Location = new Point(525, 175);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PlaceholderText = "Password:";
            txtBoxPassword.Size = new Size(240, 34);
            txtBoxPassword.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Control;
            lblTitle.Location = new Point(436, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(125, 41);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Register";
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.None;
            lblError.Font = new Font("Segoe UI", 16F);
            lblError.ForeColor = Color.Coral;
            lblError.Location = new Point(79, 292);
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
            lblErrorUsername.ForeColor = Color.Coral;
            lblErrorUsername.Location = new Point(206, 171);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(25, 35);
            lblErrorUsername.TabIndex = 8;
            lblErrorUsername.Text = "*";
            // 
            // lblErrorSurname
            // 
            lblErrorSurname.Anchor = AnchorStyles.None;
            lblErrorSurname.AutoSize = true;
            lblErrorSurname.Font = new Font("Segoe UI", 15F);
            lblErrorSurname.ForeColor = Color.Coral;
            lblErrorSurname.Location = new Point(505, 239);
            lblErrorSurname.Name = "lblErrorSurname";
            lblErrorSurname.Size = new Size(25, 35);
            lblErrorSurname.TabIndex = 9;
            lblErrorSurname.Text = "*";
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.Anchor = AnchorStyles.None;
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.Font = new Font("Segoe UI", 15F);
            lblErrorPassword.ForeColor = Color.Coral;
            lblErrorPassword.Location = new Point(507, 175);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(25, 35);
            lblErrorPassword.TabIndex = 10;
            lblErrorPassword.Text = "*";
            // 
            // lblErrorForename
            // 
            lblErrorForename.Anchor = AnchorStyles.None;
            lblErrorForename.AutoSize = true;
            lblErrorForename.Font = new Font("Segoe UI", 15F);
            lblErrorForename.ForeColor = Color.Coral;
            lblErrorForename.Location = new Point(205, 237);
            lblErrorForename.Name = "lblErrorForename";
            lblErrorForename.Size = new Size(25, 35);
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
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(970, 557);
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