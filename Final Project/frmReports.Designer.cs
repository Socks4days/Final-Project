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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
			pnlOrdersReport = new Panel();
			btnPrintReport = new Button();
			printPreviewReport = new PrintPreviewControl();
			btnRefreshReport = new Button();
			printReportDocument = new System.Drawing.Printing.PrintDocument();
			printPreviewReportDialog = new PrintPreviewDialog();
			toolTipReports = new ToolTip(components);
			pnlOrdersReport.SuspendLayout();
			SuspendLayout();
			// 
			// pnlOrdersReport
			// 
			pnlOrdersReport.BackColor = SystemColors.ScrollBar;
			pnlOrdersReport.Controls.Add(btnPrintReport);
			pnlOrdersReport.Controls.Add(printPreviewReport);
			pnlOrdersReport.Controls.Add(btnRefreshReport);
			pnlOrdersReport.Dock = DockStyle.Fill;
			pnlOrdersReport.Location = new Point(0, 0);
			pnlOrdersReport.Name = "pnlOrdersReport";
			pnlOrdersReport.Size = new Size(1000, 680);
			pnlOrdersReport.TabIndex = 0;
			// 
			// btnPrintReport
			// 
			btnPrintReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnPrintReport.Location = new Point(748, 30);
			btnPrintReport.Name = "btnPrintReport";
			btnPrintReport.Size = new Size(220, 50);
			btnPrintReport.TabIndex = 4;
			btnPrintReport.Text = "Print";
			toolTipReports.SetToolTip(btnPrintReport, "Open print preview for current report");
			btnPrintReport.UseVisualStyleBackColor = true;
			btnPrintReport.Click += btnPrintReport_Click;
			// 
			// printPreviewReport
			// 
			printPreviewReport.Location = new Point(27, 119);
			printPreviewReport.Name = "printPreviewReport";
			printPreviewReport.Size = new Size(940, 490);
			printPreviewReport.TabIndex = 3;
			// 
			// btnRefreshReport
			// 
			btnRefreshReport.Location = new Point(27, 30);
			btnRefreshReport.Name = "btnRefreshReport";
			btnRefreshReport.Size = new Size(220, 50);
			btnRefreshReport.TabIndex = 2;
			btnRefreshReport.Text = "Refresh";
			toolTipReports.SetToolTip(btnRefreshReport, "Refresh current report below");
			btnRefreshReport.UseVisualStyleBackColor = true;
			btnRefreshReport.Click += btnPreviewReport_Click;
			// 
			// printReportDocument
			// 
			printReportDocument.PrintPage += printReportDocument_PrintPage;
			// 
			// printPreviewReportDialog
			// 
			printPreviewReportDialog.AutoScrollMargin = new Size(0, 0);
			printPreviewReportDialog.AutoScrollMinSize = new Size(0, 0);
			printPreviewReportDialog.ClientSize = new Size(400, 300);
			printPreviewReportDialog.Enabled = true;
			printPreviewReportDialog.Icon = (Icon)resources.GetObject("printPreviewReportDialog.Icon");
			printPreviewReportDialog.Name = "printPreviewDialog1";
			printPreviewReportDialog.Visible = false;
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
			Resize += frmReports_Resize;
			pnlOrdersReport.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlOrdersReport;
		private Button btnRefreshReport;
		private System.Drawing.Printing.PrintDocument printReportDocument;
		private PrintPreviewDialog printPreviewReportDialog;
		private PrintPreviewControl printPreviewReport;
		private Button btnPrintReport;
		private ToolTip toolTipReports;
	}
}