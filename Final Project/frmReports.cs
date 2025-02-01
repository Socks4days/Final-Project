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
using Microsoft.Reporting;
using Microsoft.Reporting.WinForms;


namespace Final_Project
{
	public partial class frmReports : Form
	{

		// Set report colours/styles to use
		private Pen blackPen = new Pen(Color.Black);
		private Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold);
		private Font labelFont = new Font("Segoe UI", 12, FontStyle.Bold);
		private Font valueFont = new Font("Segoe UI", 12);
		private Brush textBrush = new SolidBrush(Color.Black);
		private StringFormat centreTopText = new StringFormat();
		private StringFormat centreMiddleText = new StringFormat();
		private StringFormat centreBottomText = new StringFormat();
		private StringFormat leftMiddleText = new StringFormat();

		// Fields for report details
		private string reportName = "Report Name";
		private string reportHeaderLine = "Report Header Line";
		private string reportFooterLine = "Report Footer Line";
		private List<string[]> reportLines = new List<string[]>();

		public frmReports()
		{
			InitializeComponent();

			// Initialise report colours/styles
			centreTopText.Alignment = StringAlignment.Center;
			centreTopText.LineAlignment = StringAlignment.Near;
			centreMiddleText.Alignment = StringAlignment.Center;
			centreMiddleText.LineAlignment = StringAlignment.Center;
			centreBottomText.Alignment = StringAlignment.Center;
			centreBottomText.LineAlignment = StringAlignment.Far;
			leftMiddleText.Alignment = StringAlignment.Near;
			leftMiddleText.LineAlignment = StringAlignment.Center;

		}

		private string documentContents = "";
		private void btnPreviewReport_Click(object sender, EventArgs e)
		{
			printPreviewReport.Document = printReportDocument;
		}

		private void getOrderReportDetails (int orderNumber)
		{
			// Set report details
			reportName = "Order";
			Order order = OrderDal.GetOrderByOrderNumber(orderNumber);
			List<OrderItem> orderItems = OrderDal.GetAllOrderItems(orderNumber);
			Staff staff = StaffDal.GetStaffByStaffId(order.orderPlacedByStaffId);

			// Set Header/Footer
			reportHeaderLine = $"Order Number: {order.orderNumber}   Placed On: {order.orderDate}\nPlaced By: {staff.forename} {staff.surname}   Status: {order.orderStatus}";

			// Set table details as an array
			reportLines = new List<string[]>();

			// Add a row for the column headings
			reportLines.Add(["Item", "Quantity", "Unit Price", "Total Price"]);

			// Add a row for each item
			decimal orderTotal = 0;
			for (int oi = 0; oi < orderItems.Count; oi++)
			{
				reportLines.Add(
					[orderItems[oi].stockName,
					orderItems[oi].orderItemQuantity.ToString(),
					orderItems[oi].unitPrice.ToString(),
					"£" + (orderItems[oi].orderItemQuantity * orderItems[oi].unitPrice).ToString()
					]
				);
				orderTotal += (orderItems[oi].orderItemQuantity * orderItems[oi].unitPrice);
			}

			// Set report footer to order total
			reportFooterLine = $"Order Total: £{orderTotal}";
		}

		private void printReportDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

			// Get order report details
			getOrderReportDetails(263);

			// Print report details

			// Get page margins/size
			int leftMargin = e.MarginBounds.X;
			int rightMargin = e.MarginBounds.X + e.MarginBounds.Width;
			int topMargin = e.MarginBounds.Y;
			int bottomMargin = e.MarginBounds.Y + e.MarginBounds.Height;
			int pageWidth = e.MarginBounds.Width;
			int pageHeight = e.MarginBounds.Height;

			// Define area for title, header line, table
			Rectangle titleArea = new Rectangle(leftMargin, topMargin, pageWidth, 40);
			Rectangle headerLineArea = new Rectangle(leftMargin, topMargin + 40, pageWidth, 60);
			Rectangle footerArea = new Rectangle(leftMargin, topMargin + pageHeight - 60, pageWidth, 60);

			int tableX = leftMargin;
			int tableY = topMargin + titleArea.Height + headerLineArea.Height;
			int tableWidth = pageWidth;
			int tableHeight = pageHeight - titleArea.Height - headerLineArea.Height - footerArea.Height;

			// Set number of tableColumns and tableRows
			int tableColumns = reportLines[0].Length;
			int tableRows = 20;
			int columnWidth = tableWidth / tableColumns;
			int rowHeight = tableHeight / tableRows;

			// Draw rectangle at margins of page (used for testing)
			// e.Graphics.DrawRectangle(blackPen, e.MarginBounds);

			// Show title centred at top
			e.Graphics.DrawString(reportName, titleFont, textBrush, titleArea, centreTopText);

			// Show header line below title
			e.Graphics.DrawString(reportHeaderLine, labelFont, textBrush, headerLineArea, centreTopText);

			// Draw grid using tableRows and tableColumns
			Font cellFont = labelFont; // Show first row as header
			for (int r = 0; r < reportLines.Count; r++)
			{
				for (int c = 0; c < reportLines[r].Length; c++)
				{
					Rectangle tableCell = new Rectangle(tableX + c * columnWidth, tableY + r * rowHeight, columnWidth, rowHeight);
					e.Graphics.DrawRectangle(blackPen, tableCell);
					e.Graphics.DrawString(reportLines[r][c], cellFont, textBrush, tableCell, leftMiddleText);
				}
				cellFont = valueFont; // Show remaining rows as values
			}

			e.Graphics.DrawString(reportFooterLine, labelFont, textBrush, footerArea, centreBottomText);
		}

		private void btnPrintReport_Click(object sender, EventArgs e)
		{
			printReportDocument.DocumentName = reportName;
			printPreviewReportDialog.Document = printReportDocument;
			printPreviewReportDialog.ShowDialog();
		}
	}
}
