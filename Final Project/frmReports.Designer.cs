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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
			pnlOrdersReport = new Panel();
			printPreviewControl1 = new PrintPreviewControl();
			btnPreviewReport = new Button();
			btnOpenPDF = new Button();
			printDocument1 = new System.Drawing.Printing.PrintDocument();
			printPreviewDialog1 = new PrintPreviewDialog();
			btnPrintReport = new Button();
			pnlOrdersReport.SuspendLayout();
			SuspendLayout();
			// 
			// pnlOrdersReport
			// 
			pnlOrdersReport.BackColor = SystemColors.ScrollBar;
			pnlOrdersReport.Controls.Add(btnPrintReport);
			pnlOrdersReport.Controls.Add(printPreviewControl1);
			pnlOrdersReport.Controls.Add(btnPreviewReport);
			pnlOrdersReport.Controls.Add(btnOpenPDF);
			pnlOrdersReport.Dock = DockStyle.Top;
			pnlOrdersReport.Location = new Point(0, 0);
			pnlOrdersReport.Name = "pnlOrdersReport";
			pnlOrdersReport.Size = new Size(1000, 680);
			pnlOrdersReport.TabIndex = 0;
			// 
			// printPreviewControl1
			// 
			printPreviewControl1.Location = new Point(27, 220);
			printPreviewControl1.Name = "printPreviewControl1";
			printPreviewControl1.Size = new Size(909, 347);
			printPreviewControl1.TabIndex = 3;
			// 
			// btnPreviewReport
			// 
			btnPreviewReport.Location = new Point(393, 34);
			btnPreviewReport.Name = "btnPreviewReport";
			btnPreviewReport.Size = new Size(258, 100);
			btnPreviewReport.TabIndex = 2;
			btnPreviewReport.Text = "Preview";
			btnPreviewReport.UseVisualStyleBackColor = true;
			btnPreviewReport.Click += btnPreviewReport_Click;
			// 
			// btnOpenPDF
			// 
			btnOpenPDF.Location = new Point(27, 30);
			btnOpenPDF.Name = "btnOpenPDF";
			btnOpenPDF.Size = new Size(248, 109);
			btnOpenPDF.TabIndex = 0;
			btnOpenPDF.Text = "Open Report";
			btnOpenPDF.UseVisualStyleBackColor = true;
			btnOpenPDF.Click += btnOpenPDF_Click;
			// 
			// printDocument1
			// 
			printDocument1.PrintPage += printDocument1_PrintPage;
			// 
			// printPreviewDialog1
			// 
			printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
			printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
			printPreviewDialog1.ClientSize = new Size(400, 300);
			printPreviewDialog1.Enabled = true;
			printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
			printPreviewDialog1.Name = "printPreviewDialog1";
			printPreviewDialog1.Visible = false;
			// 
			// btnPrintReport
			// 
			btnPrintReport.Location = new Point(683, 34);
			btnPrintReport.Name = "btnPrintReport";
			btnPrintReport.Size = new Size(253, 100);
			btnPrintReport.TabIndex = 4;
			btnPrintReport.Text = "Print";
			btnPrintReport.UseVisualStyleBackColor = true;
			btnPrintReport.Click += btnPrintReport_Click;
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
			pnlOrdersReport.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel pnlOrdersReport;
		private Button btnOpenPDF;
		private Button btnPreviewReport;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private PrintPreviewDialog printPreviewDialog1;
		private PrintPreviewControl printPreviewControl1;
		private Button btnPrintReport;
	}
}