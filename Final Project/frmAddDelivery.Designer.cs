namespace Final_Project
{
    partial class frmAddDelivery
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
            pnlViewDeliveries = new Panel();
            SuspendLayout();
            // 
            // pnlViewDeliveries
            // 
            pnlViewDeliveries.Dock = DockStyle.Top;
            pnlViewDeliveries.Location = new Point(0, 0);
            pnlViewDeliveries.Name = "pnlViewDeliveries";
            pnlViewDeliveries.Size = new Size(772, 560);
            pnlViewDeliveries.TabIndex = 0;
            // 
            // frmAddDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(772, 559);
            Controls.Add(pnlViewDeliveries);
            Name = "frmAddDelivery";
            Text = "frmAddDelivery";
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlViewDeliveries;
    }
}