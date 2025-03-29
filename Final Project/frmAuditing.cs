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
	public partial class frmAuditing : Form
	{
		public frmAuditing(Audit audit, string viewToShow)
		{
			InitializeComponent();
			this.audit = audit;
			UpdateStockItems();

			if (viewToShow == "Create Audit")
				ShowAuditInfo();
			else if (viewToShow == "Audit History")
				ShowAuditHistory();
		}

		// values to be used throughout form
		Audit audit;
		Stock stockToAudit = new Stock();
		List<AuditItem> auditItems = new List<AuditItem>();
		List<Audit> audits = new List<Audit>();		

		#region ListViewUpdating

		private void UpdateStockItems()
		{
			foreach (ListViewItem item in lstViewAllStock.Items)
			{
				lstViewAllStock.Items.Remove(item);
			}

			List<StockLevelAuditView> sortedStockList = StockDal.GetStockLevelAuditView("NextAuditDueDate");

			// Add each stock in the sorted list to the stock list
			foreach (StockLevelAuditView stockLevel in sortedStockList)
			{
				string nextCheckDue = "Overdue";

				if (stockLevel.daysToNextAudit == 0)
					nextCheckDue = "Today";
				else if (stockLevel.daysToNextAudit == 1)
					nextCheckDue = $"Tomorrow";
				else if (stockLevel.daysToNextAudit > 1)
					nextCheckDue = $"{stockLevel.daysToNextAudit} days";

				// Create an array with stock details
				string[] row = { stockLevel.stockName, stockLevel.auditDate.ToString()!, stockLevel.auditedByStaffFullName, nextCheckDue };

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

		private void UpdateAuditHistory()
		{
			lstViewAuditHistory.SelectedItems.Clear();

			foreach (ListViewItem item in lstViewAuditHistory.Items)
			{
				lstViewAuditHistory.Items.Remove(item);
			}

			audits = AuditDal.GetAllAudits();

			foreach (Audit audit in audits)
			{
				Staff staff = StaffDal.GetStaffByStaffId(audit.auditedByStaffId);
				string fullname = string.Concat($"{staff.forename} {staff.surname}");

				auditItems = AuditDal.GetAllAuditItems(audit.auditId);

				int noCorrect = 0;
				int noIncorrect = 0;

				string auditDate = audit.auditDate.Date.ToString("dd/MM/yyyy");

				foreach (AuditItem auditItem in auditItems)
				{
					if (auditItem.predictedAmount == auditItem.actualAmount)
					{
						noCorrect++;
					}
					else
					{
						noIncorrect++;
					}
				}
				// Create an array with order details
				string[] row = { audit.auditId.ToString(), auditDate, fullname, noCorrect.ToString(), noIncorrect.ToString() };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the order list view
				lstViewAuditHistory.Items.Add(item);
			}
		}

		private void UpdateAuditHistoryDetails()
		{
			foreach (ListViewItem item in lstViewAuditHistoryDetails.Items)
			{
				lstViewAuditHistoryDetails.Items.Remove(item);
			}

			foreach (AuditItem auditItem in auditItems)
			{
				Stock stock = StockDal.GetStockByStockId(auditItem.stockId);

				string[] row = { stock.stockName, auditItem.predictedAmount.ToString(), auditItem.actualAmount.ToString() };

				ListViewItem item = new ListViewItem(row);

				lstViewAuditHistoryDetails.Items.Add(item);
			}
		}

		#endregion ListViewUpdating

		#region ListViewSelecting

		private void lstViewAllStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected && e.Item != null)
			{
				btnAddItemToAudit.Enabled = true;
				string stockName = e.Item.SubItems[0].Text;
				stockToAudit = StockDal.GetStockByStockName(stockName);
			}
		}

		private void lstViewAuditHistory_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected && e.Item != null)
			{
				btnViewAuditDetails.Enabled = true;

				auditItems = AuditDal.GetAllAuditItems(Convert.ToInt32(e.Item.SubItems[0].Text));
			}
		}

		#endregion ListViewSelecting

		#region PanelShowing

		private void ShowAuditInfo()
		{
			pnlAuditInfo.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditHistory.Visible = false;
			lblAuditError.Visible = false;
			pnlAuditHistoryDetails.Visible = false;
			lblAuditNumber.Text = $"Audit Number: {audit.auditId}";
			btnAddItemToAudit.Enabled = false;
			lstViewAllStock.SelectedItems.Clear();
			UpdateAuditItems();
		}

		private void ShowCreateAudit()
		{
			pnlCreateAudit.Visible = true;
			pnlAuditInfo.Visible = false;
			pnlAuditHistory.Visible = false;
			pnlAuditHistoryDetails.Visible = false;
			lblNoExpectedInStock.Text = $"Number expected in stock: {stockToAudit.stockLevel}";
			lblStockToAudit.Text = $"You are auditing: {stockToAudit.stockName}";
			nUDNoInStockActual.Maximum = stockToAudit.maximumLevel;
			nUDNoInStockActual.Value = 0;
		}

		private void ShowAuditHistory()
		{
			pnlAuditHistory.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditInfo.Visible = false;
			pnlAuditHistoryDetails.Visible = false;
			btnViewAuditDetails.Enabled = false;
			pnlAuditHistory.Dock = DockStyle.Fill;
			UpdateAuditHistory();
		}

		private void ShowAuditHistoryDetails()
		{
			pnlAuditHistoryDetails.Visible = true;
			pnlCreateAudit.Visible = false;
			pnlAuditInfo.Visible = false;
			pnlAuditHistory.Visible = false;
			pnlAuditHistoryDetails.Dock = DockStyle.Fill;
			lstViewAuditHistoryDetails.Height = (pnlAuditHistoryDetails.Height - 130);
			UpdateAuditHistoryDetails();
		}

		#endregion PanelShowing

		#region AuditButtonClicks

		private void btnCreateAudit_Click(object sender, EventArgs e)
		{
			int actualAmount = (int)nUDNoInStockActual.Value;
			int predictedAmount = stockToAudit.stockLevel;

			if(actualAmount > stockToAudit.maximumLevel)
			{
				lblAuditError.Visible = true;
				lblAuditError.Text = "You cannot have more than the maximum level in stock";
				return;
			}				

			AuditItem item = new AuditItem();
			item.auditId = audit.auditId;
			item.stockId = stockToAudit.stockId;
			item.predictedAmount = predictedAmount;
			item.actualAmount = actualAmount;
			AuditDal.AddAuditItem(item);

			Stock stock = StockDal.GetStockByStockId(stockToAudit.stockId);
			stock.stockLevel = actualAmount;
			StockDal.UpdateStockLevel(stock);

			foreach (ListViewItem stockItem in lstViewAllStock.Items)
			{
				if (stockItem.SubItems[0].Text == StockDal.GetStockByStockId(item.stockId).stockName)
				{
					lstViewAllStock.Items.Remove(stockItem);
				}
			}
			ShowAuditInfo();
		}

		private void btnAddItemToAudit_Click(object sender, EventArgs e)
		{
			ShowCreateAudit();
		}

		private void btnCompleteAudit_Click(object sender, EventArgs e)
		{
			ShowAuditHistory();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			lstViewAllStock.SelectedItems.Clear();
			ShowAuditInfo();
		}

		#endregion AuditButtonClicks

		#region AuditHistoryButtonClicks

		private void btnViewAuditDetails_Click(object sender, EventArgs e)
		{
			ShowAuditHistoryDetails();
		}

		private void btnBackToAuditHistory_Click(object sender, EventArgs e)
		{
			ShowAuditHistory();
		}

		#endregion AuditHistoryButtonClicks

		#region Resizing

		private void frmCreateAudit_Resize(object sender, EventArgs e)
		{
			lstViewAuditHistory.Height = (pnlAuditHistory.Height - 130);
			lstViewAuditHistoryDetails.Height = (pnlAuditHistoryDetails.Height - 130);
		}

		#endregion Resizing
	}
}