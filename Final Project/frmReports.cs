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
using Final_Project.Models;
using System.Linq.Expressions;


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

		private int orderNumberToCreateReportFor = 0;
		private string reportToShow = "";

		public frmReports(string reportType, int orderNumber)
		{
			InitializeComponent();
			orderNumberToCreateReportFor = orderNumber;
			reportToShow = reportType;

			// Initialise report colours/styles
			centreTopText.Alignment = StringAlignment.Center;
			centreTopText.LineAlignment = StringAlignment.Near;
			centreMiddleText.Alignment = StringAlignment.Center;
			centreMiddleText.LineAlignment = StringAlignment.Center;
			centreBottomText.Alignment = StringAlignment.Center;
			centreBottomText.LineAlignment = StringAlignment.Far;
			leftMiddleText.Alignment = StringAlignment.Near;
			leftMiddleText.LineAlignment = StringAlignment.Center;

			// Show report
			printPreviewReport.Document = printReportDocument;
		}

		private void btnPreviewReport_Click(object sender, EventArgs e)
		{
			printPreviewReport.Document = printReportDocument;
		}

		private void GetOrderReportDetails(int orderNumber)
		{
			// Set report details
			reportName = "Order";
			Order order = OrderDal.GetOrderByOrderNumber(orderNumber);
			List<OrderItem> orderItems = OrderDal.GetAllOrderItems(orderNumber);
			Staff staff = StaffDal.GetStaffByStaffId(order.orderPlacedByStaffId);

			// Set report header
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

		private void GetLowStockReportDetails()
		{
			// Set report details
			reportName = "Low Stock";
			Staff loggedInStaff = frmLoginScreen.loggedInStaff;
			// Get stock levels for all stock items, including number on order
			List<Stock> stockItems = StockDal.GetAllActiveStock(true);
			List<Stock> lowLevelStockItems = new List<Stock>();

			foreach (Stock stock in stockItems)
			{
				if (stock.stockLevel < stock.minimumLevel)
				{
					lowLevelStockItems.Add(stock);
				}
			}

			// Set report header
			reportHeaderLine = $"Created On: {DateTime.Now}   Created By: {loggedInStaff.forename} {loggedInStaff.surname}";

			// Set table details as an array
			reportLines = new List<string[]>();

			// Add a row for the column headings
			reportLines.Add(["Item", "Current Level", "Minimum Level", "Number Ordered"]);

			// Add a row for each item
			decimal lowLevelItemCount = 0;
			for (int ls = 0; ls < lowLevelStockItems.Count; ls++)
			{
				string stockName = lowLevelStockItems[ls].stockName;
				int stockLevel = lowLevelStockItems[ls].stockLevel;
				int minimumLevel = lowLevelStockItems[ls].minimumLevel;
				int numberOnOrder = (int)lowLevelStockItems[ls].numberOnOrder!;

				// Check if the number ordered won't bring stock level up to minimum
				if (stockLevel + numberOnOrder < minimumLevel)
				{
					// If so, add an asterisk to the name and increase the low level item count
					stockName += "*";
					lowLevelItemCount++;
				}
				reportLines.Add(
					[stockName,
					stockLevel.ToString()!,
					minimumLevel.ToString()!,
					numberOnOrder.ToString()!
					]
				);
			}

			// Set report footer to low item total
			reportFooterLine = $"Number of items needing reordering (marked with *): {lowLevelItemCount}";
		}

		private void GetStockDiscrepancyDetails()
		{
			// Set report details
			reportName = "Delivery Discrepancies";
			Staff loggedInStaff = frmLoginScreen.loggedInStaff;
			List<OrderItemsDeliveredView> discrepancies = OrderDal.GetOrderItemDiscrepancies();

			// Set report header/footer
			reportHeaderLine = $"Created On: {DateTime.Now}   Created By: {loggedInStaff.forename} {loggedInStaff.surname}";
			reportFooterLine = "";

			// Set table details as an array
			reportLines = new List<string[]>();

			// Add a row for the column headings
			reportLines.Add(["Order Number", "Item", "Ordered", "Missing", "Faulty"]);

			// Add a row for each item
			for (int oi = 0; oi < discrepancies.Count; oi++)
			{
				int quantityMissing = 0;
					quantityMissing = (int)(discrepancies[oi].orderItemQuantity - discrepancies[oi].quantityDelivered)!;

				reportLines.Add(
					[discrepancies[oi].orderNumber.ToString(),
					discrepancies[oi].stockName,
					discrepancies[oi].orderItemQuantity.ToString(),
					quantityMissing.ToString(),
					discrepancies[oi].quantityFaulty.ToString()!
					]
				);
			}
		}

		private void printReportDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			if (reportToShow == "Order")
			{
				// Get order report details
				GetOrderReportDetails(orderNumberToCreateReportFor);
			}
			else if (reportToShow == "Low Stock")
			{
				// Get low stock report details
				GetLowStockReportDetails();
			}
			else if (reportToShow == "Delivery Discrepancies")
			{
				// Get stock discrepancy report details
				GetStockDiscrepancyDetails();
			}

			// Print report details

			// Get page margins/size
			int leftMargin = e.MarginBounds.X;
			int rightMargin = e.MarginBounds.X + e.MarginBounds.Width;
			int topMargin = e.MarginBounds.Y;
			int bottomMargin = e.MarginBounds.Y + e.MarginBounds.Height;
			int pageWidth = e.MarginBounds.Width;
			int pageHeight = e.MarginBounds.Height;

			// Define area for title, header line, table
			Rectangle departmentNameArea = new Rectangle(leftMargin, topMargin - 30, pageWidth, 30);
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

			// Add logo in top left of page
			Bitmap logoImage = new Bitmap(Resources.Movers_Logo_Black);
			int logoWidth = logoImage.Width;
			int logoHeight = logoImage.Height;
			int scaledLogoWidth = 100;
			int scaledLogoHeight = (int) (logoHeight * scaledLogoWidth / logoWidth);
			e.Graphics!.DrawImage(logoImage, leftMargin - (scaledLogoWidth/2), departmentNameArea.Top, scaledLogoWidth, scaledLogoHeight);

			// Add department name
			e.Graphics!.DrawString("Movers Maintenance Dept", labelFont, textBrush, departmentNameArea, centreTopText);

			// Show title centred at top
			e.Graphics!.DrawString(reportName, titleFont, textBrush, titleArea, centreTopText);

			// Show header line below title
			e.Graphics!.DrawString(reportHeaderLine, labelFont, textBrush, headerLineArea, centreTopText);

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

		private void frmReports_Resize(object sender, EventArgs e)
		{
			printPreviewReport.Height = pnlOrdersReport.Height - 190;
			printPreviewReport.Width = pnlOrdersReport.Width - 60;
		}
	}
}