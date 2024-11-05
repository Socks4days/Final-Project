namespace Final_Project
{
    partial class frmRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14.5F);
            btnClear.Location = new Point(110, 361);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(220, 50);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 14.5F);
            btnRegister.Location = new Point(402, 361);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 50);
            btnRegister.TabIndex = 1;
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
            txtBoxUsername.TabIndex = 2;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Font = new Font("Segoe UI", 12F);
            txtBoxSurname.Location = new Point(391, 198);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.PlaceholderText = "Surname:";
            txtBoxSurname.Size = new Size(200, 34);
            txtBoxSurname.TabIndex = 3;
            // 
            // txtBoxForename
            // 
            txtBoxForename.Font = new Font("Segoe UI", 12F);
            txtBoxForename.Location = new Point(391, 134);
            txtBoxForename.Name = "txtBoxForename";
            txtBoxForename.PlaceholderText = "Forename:";
            txtBoxForename.Size = new Size(200, 34);
            txtBoxForename.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Font = new Font("Segoe UI", 12F);
            txtBoxPassword.Location = new Point(141, 198);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PlaceholderText = "Password:";
            txtBoxPassword.Size = new Size(200, 34);
            txtBoxPassword.TabIndex = 5;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(122, 134);
            label1.Name = "label1";
            label1.Size = new Size(25, 35);
            label1.TabIndex = 8;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(371, 198);
            label2.Name = "label2";
            label2.Size = new Size(25, 35);
            label2.TabIndex = 9;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(123, 198);
            label3.Name = "label3";
            label3.Size = new Size(25, 35);
            label3.TabIndex = 10;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(371, 134);
            label4.Name = "label4";
            label4.Size = new Size(25, 35);
            label4.TabIndex = 11;
            label4.Text = "*";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(90, 50);
            button1.TabIndex = 12;
            button1.Text = "←";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(732, 453);
            Controls.Add(button1);
            Controls.Add(lblError);
            Controls.Add(lblTitle);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxForename);
            Controls.Add(txtBoxSurname);
            Controls.Add(txtBoxUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}