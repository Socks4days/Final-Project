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
		public frmCreateAudit(Audit audit, string viewToShow)
		{
			InitializeComponent();
			this.audit = audit;
			UpdateStockItems();

			if(viewToShow == "Create Audit")
			ShowAuditInfo();
			else if(viewToShow == "Audit History")
			ShowAuditHistory();
		}

		Audit audit;
		Stock stockToAudit = new Stock();
		List<AuditItem> auditItems = new List<AuditItem>();
		List<Audit> audits = new List<Audit>();

		private void btnCancel_Click(object sender, EventArgs e)
		{
			lstViewAllStock.SelectedItems.Clear();
			ShowAuditInfo();
		}

		private void btnCompleteAudit_Click(object sender, EventArgs e)
		{
			ShowAuditHistory();
		}

		private void UpdateStockItems()
		{
			foreach (ListViewItem item in lstViewAllStock.Items)
			{
				lstViewAllStock.Items.Remove(item);
			}

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

		private void UpdateAuditItems()
		{
			foreach (ListViewItem item in lstViewAuditItems.Items)
			{
				lstViewAuditItems.Items.Remove(item);
			}

			// create a list of orders and fill with all orders
			auditItems = AuditDal.GetAllAuditItems(audit.auditId);

			// Add each order in the sorted list to the order list
			foreach (AuditItem auditItem in auditItems)
			{
				Stock stock = new Stock();
				stock = StockDal.GetStockByStockId(auditItem.stockId);
				// Create an array with order details
				string[] row = { stock.stockName, auditItem.predictedAmount.ToString(), auditItem.actualAmount.ToString() };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the order list view
				lstViewAuditItems.Items.Add(item);
			}
		}

		private void UpdateAuditHistoryItems()
		{
			foreach (ListViewItem item in lstViewAuditHistory.Items)
			{
				lstViewAuditHistory.Items.Remove(item);
			}

			audits = 
		}

		private void ShowAuditInfo()
		{
			pnlAuditInfo.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditHistory.Visible = false;
			lblAuditError.Visible = false;
			lblAuditNumber.Text = $"Audit Number: {audit.auditId}";
			btnAddItemToAudit.Enabled = false;
			lstViewAllStock.SelectedItems.Clear();
			//UpdateStockItems();
			UpdateAuditItems();
		}

		private void ShowCreateAudit()
		{
			pnlCreateAudit.Visible = true;
			pnlAuditInfo.Visible = false;
			pnlAuditHistory.Visible = false;
			lblNoExpectedInStock.Text = $"Number expected in stock: {stockToAudit.stockLevel}";
			lblStockToAudit.Text = $"You are auditing: {stockToAudit.stockName}";
			nUDNoInStockActual.Value = 0;
		}

		private void ShowAuditHistory()
		{
			pnlAuditHistory.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditInfo.Visible = false;
			UpdateAuditHistoryItems();
		}

		private void btnAddItemToAudit_Click(object sender, EventArgs e)
		{
			ShowCreateAudit();
		}

		private void lstViewAllStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
			{
				btnAddItemToAudit.Enabled = true;
				string stockName = e.Item.SubItems[0].Text;
				stockToAudit = StockDal.GetStockByStockName(stockName);
			}
		}

		private void btnCreateAudit_Click(object sender, EventArgs e)
		{
			int actualAmount = (int)nUDNoInStockActual.Value;
			int predictedAmount = stockToAudit.stockLevel;
			AuditItem item = new AuditItem();
			item.auditId = audit.auditId;
			item.stockId = stockToAudit.stockId;
			item.predictedAmount = predictedAmount;
			item.actualAmount = actualAmount;
			AuditDal.AddAuditItem(item);

			Stock stock = StockDal.GetStockByStockId(stockToAudit.stockId);
			stock.stockLevel = actualAmount;
			StockDal.UpdateStockInformation(stock);

			foreach (ListViewItem stockItem in lstViewAllStock.Items)
			{
				if (stockItem.SubItems[0].Text == StockDal.GetStockByStockId(item.stockId).stockName)
				{
					lstViewAllStock.Items.Remove(stockItem);
				}
			}
			ShowAuditInfo();
		}

		private void frmCreateAudit_Resize(object sender, EventArgs e)
		{
			lstViewAuditHistory.Height = (pnlAuditHistory.Height - 100);
		}
	}
}
