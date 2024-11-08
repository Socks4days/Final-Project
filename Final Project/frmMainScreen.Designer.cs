namespace Final_Project
{
    partial class frmMainScreen
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
            pnlSideBar = new Panel();
            button1 = new Button();
            pnlAvatar = new Panel();
            pnlTitleBar = new Panel();
            pnlFormContainer = new Panel();
            pnlSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSideBar
            // 
            pnlSideBar.AutoScroll = true;
            pnlSideBar.BackColor = Color.Teal;
            pnlSideBar.Controls.Add(button1);
            pnlSideBar.Controls.Add(pnlAvatar);
            pnlSideBar.Dock = DockStyle.Left;
            pnlSideBar.Location = new Point(0, 0);
            pnlSideBar.Name = "pnlSideBar";
            pnlSideBar.Size = new Size(220, 560);
            pnlSideBar.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.Font = new Font("Segoe UI", 14.5F);
            button1.Location = new Point(0, 125);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 1;
            button1.Text = "Stock";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlAvatar
            // 
            pnlAvatar.Dock = DockStyle.Top;
            pnlAvatar.Location = new Point(0, 0);
            pnlAvatar.Name = "pnlAvatar";
            pnlAvatar.Size = new Size(220, 125);
            pnlAvatar.TabIndex = 0;
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.Teal;
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(220, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(750, 60);
            pnlTitleBar.TabIndex = 1;
            // 
            // pnlFormContainer
            // 
            pnlFormContainer.BackColor = Color.LightSeaGreen;
            pnlFormContainer.Dock = DockStyle.Fill;
            pnlFormContainer.Location = new Point(220, 60);
            pnlFormContainer.Name = "pnlFormContainer";
            pnlFormContainer.Size = new Size(750, 500);
            pnlFormContainer.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(970, 560);
            Controls.Add(pnlFormContainer);
            Controls.Add(pnlTitleBar);
            Controls.Add(pnlSideBar);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            pnlSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSideBar;
        private Panel pnlTitleBar;
        private Panel pnlFormContainer;
        private Panel pnlAvatar;
        private Button button1;
    }
}