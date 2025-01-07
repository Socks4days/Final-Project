using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Models;

namespace Final_Project
{
	public partial class frmCreateAudit : Form
	{	
		public frmCreateAudit(Audit audit)
		{
			InitializeComponent();
			this.audit = audit;
			UpdateStockItems();
			ShowAuditInfo();			
		}

		Audit audit;

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ShowAuditInfo();
		}

		private void btnCompleteAudit_Click(object sender, EventArgs e)
		{

		}

		private void UpdateStockItems()
		{
			List<StockLevelsView> sortedStockList = StockDal.GetStockLevelsView("AuditDate");

			// Add each stock in the sorted list to the stock list
			foreach (StockLevelsView stockLevel in sortedStockList)
			{
				// Create an array with stock details
				string[] row = { stockLevel.stockName, stockLevel.auditDate.ToString(), stockLevel.auditedByStaffFullName };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the stock list view
				lstViewAllStock.Items.Add(item);
			}
		}

		private void ShowAuditInfo()
		{
			pnlAuditInfo.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditHistory.Visible = false;
			lblAuditError.Visible = false;
			lblAuditNumber.Text = $"Audit Number: {audit.auditId}";
		}

		private void ShowCreateAudit()
		{
			pnlCreateAudit.Visible = true;
			pnlAuditInfo.Visible = false;
			pnlAuditHistory.Visible = false;
		}

		private void ShowAuditHistory()
		{
			pnlAuditHistory.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditInfo.Visible = false;
		}

		private void btnAddItemToAudit_Click(object sender, EventArgs e)
		{
			ShowCreateAudit();
		}
	}
}
