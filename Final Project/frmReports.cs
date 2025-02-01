using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Final_Project
{
	public partial class frmReports : Form
	{

		public frmReports()
		{
			InitializeComponent();
		}

		private void btnOpenPDF_Click(object sender, EventArgs e)
		{
			string program = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
			//string filename = @"C:\html.html";
			string filename = @"C:\Users\andre\Downloads\EXEMPLAR_9.pdf";
			System.Diagnostics.Process.Start(program, filename);
		}

		private string documentContents = "";
		private string stringToPrint = "";
		private void btnPreviewReport_Click(object sender, EventArgs e)
		{
			string docName = "html.html";
			string docPath = @"C:\";
			string fullPath = System.IO.Path.Combine(docPath, docName);
			printDocument1.DocumentName = docName;
			stringToPrint = System.IO.File.ReadAllText(fullPath);
			stringToPrint = "This is my report\nWith some more lines";
			//printPreviewDialog1.Document = printDocument1;
			//printPreviewDialog1.ShowDialog();
			printPreviewControl1.Document = printDocument1;
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			int charactersOnPage = 0;
			int linesPerPage = 0;

			// Sets the value of charactersOnPage to the number of characters
			// of stringToPrint that will fit within the bounds of the page.
			e.Graphics.MeasureString(stringToPrint, this.Font,
				e.MarginBounds.Size, StringFormat.GenericTypographic,
				out charactersOnPage, out linesPerPage);

			// Draws the string within the bounds of the page.
			e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black,
			e.MarginBounds, StringFormat.GenericTypographic);

			// Remove the portion of the string that has been printed.
			stringToPrint = stringToPrint.Substring(charactersOnPage);

			// Check to see if more pages are to be printed.
			e.HasMorePages = (stringToPrint.Length > 0);

			// If there are no more pages, reset the string to be printed.
			if (!e.HasMorePages)
				stringToPrint = documentContents;
		}

		private void btnPrintReport_Click(object sender, EventArgs e)
		{
			string docName = "html.html";
			string docPath = @"C:\";
			string fullPath = System.IO.Path.Combine(docPath, docName);
			printDocument1.DocumentName = docName;
			stringToPrint = System.IO.File.ReadAllText(fullPath);
			stringToPrint = "This is my report\nWith some more lines";
			printPreviewDialog1.Document = printDocument1;
			printPreviewDialog1.ShowDialog();
		}
	}
}
