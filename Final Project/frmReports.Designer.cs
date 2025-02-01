namespace Final_Project
{
	partial class frmReports
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
			pnlOrdersReport = new Panel();
			SuspendLayout();
			// 
			// pnlOrdersReport
			// 
			pnlOrdersReport.BackColor = SystemColors.ScrollBar;
			pnlOrdersReport.Dock = DockStyle.Top;
			pnlOrdersReport.Location = new Point(0, 0);
			pnlOrdersReport.Name = "pnlOrdersReport";
			pnlOrdersReport.Size = new Size(1000, 680);
			pnlOrdersReport.TabIndex = 0;
			// 
			// frmReports
			// 
			AutoScaleDimensions = new SizeF(96F, 96F);
			AutoScaleMode = AutoScaleMode.Dpi;
			AutoSize = true;
			ClientSize = new Size(1000, 680);
			Controls.Add(pnlOrdersReport);
			Font = new Font("Segoe UI", 14F);
			Name = "frmReports";
			Text = "Reports";
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlOrdersReport;
	}
}