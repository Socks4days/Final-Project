using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
	public partial class frmEditStockLevels : Form
	{
		public frmEditStockLevels()
		{
			InitializeComponent();
			
			ShowViewStock();
		}

		#region PanelViewing
		private void ShowViewStock()
		{
			foreach (ListViewItem item in lstViewStock.Items)
			{
				lstViewStock.Items.Remove(item);
			}

			List<StockLevelsView> sortedStockList = StockDal.GetStockLevelsView("StockName");

			// Add each stock in the sorted list to the stock list
			foreach (StockLevelsView stockLevel in sortedStockList)
			{
				string nextCheckDue = "Overdue";

				if (stockLevel.daysToNextAudit == 0)
					nextCheckDue = "Today";
				else if (stockLevel.daysToNextAudit == 1)
					nextCheckDue = $"Tomorrow";
				else if (stockLevel.daysToNextAudit > 1)
					nextCheckDue = $"{stockLevel.daysToNextAudit} days";

				// Create an array with stock details
				string[] row = { stockLevel.stockName, stockLevel.stockLevel.ToString(), stockLevel.auditDate.ToString(), stockLevel.auditedByStaffFullName, nextCheckDue };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the stock list view
				lstViewStock.Items.Add(item);
			}

			pnlEditStockLevels.Visible = false;
			pnlEditStockItem.Visible = false;
			pnlOptionButtons.Visible = false;
			pnlStockList.Visible = true;
			pnlStockList.Dock = DockStyle.Fill;
			lstViewStock.Height = (pnlStockList.Height - 58);
			lstViewStock.SelectedItems.Clear();
			lblInstructions.Text = "Select an item to manage its level and information";
			frmMainScreen.frmMain.lblTitle.Text = "Manage Stock";
		}

		private void ShowEditStockLevels()
		{
			txtBoxAmountOfStockToChange.Text = "1";
			pnlStockList.Visible = false;
			pnlEditStockItem.Visible = false;
			pnlOptionButtons.Visible = false;
			pnlEditStockLevels.Visible = true;
			pnlEditStockLevels.Dock = DockStyle.Fill;
		}

		private void ShowEditStockItem()
		{
			frmMainScreen.frmMain.lblTitle.Text = "Edit Stock Item";
			pnlEditStockLevels.Visible = false;
			pnlStockList.Visible = false;
			pnlOptionButtons.Visible = false;
			pnlEditStockItem.Visible = true;
			pnlEditStockItem.Dock = DockStyle.Fill;
		}

		#endregion PanelViewing

		#region LookupStock

		public static Stock lookupStock = new Stock();

		public static void LookupStock(string stockName)
		{
			List<Stock> allStock = StockDal.GetAllStock();
			foreach (Stock stock in allStock)
			{
				if (stock.stockName.ToString() == stockName)
				{
					lookupStock = StockDal.GetStockByStockId(stock.stockId);
				}
			}
		}

		#endregion LookupStock

		#region TakingAndReturningStock
		private void btnReturnStock_Click(object sender, EventArgs e)
		{
			ShowEditStockLevels();
			btnTakeOutStockConfirm.Visible = false;
			btnReturnStockConfirm.Visible = true;
			lblStockLevelToEdit.Text = lookupStock.stockName;
			frmMainScreen.frmMain.lblTitle.Text = "Return Stock";
			lblCurrentStockLevel.Text = $"Current Stock Level: {lookupStock.stockLevel.ToString()}";
		}

		private void btnTakeOutStock_Click(object sender, EventArgs e)
		{
			ShowEditStockLevels();
			btnReturnStockConfirm.Visible = false;
			btnTakeOutStockConfirm.Visible = true;
			lblStockLevelToEdit.Text = lookupStock.stockName;
			frmMainScreen.frmMain.lblTitle.Text = "Take Out Stock";
			lblCurrentStockLevel.Text = $"Current Stock Level: {lookupStock.stockLevel.ToString()}";
		}

		private void btnReturnStockConfirm_Click(object sender, EventArgs e)
		{
			int amountToAdd = 0;
			int originalStockLevel = lookupStock.stockLevel;
			try
			{
				amountToAdd = Convert.ToInt32(txtBoxAmountOfStockToChange.Text);
			}
			catch (Exception ex)
			{
				ShowErrorStockLevel("That is not a valid number");
			}
			if (lookupStock.stockLevel + amountToAdd <= lookupStock.maximumLevel)
			{
				lookupStock.stockLevel += amountToAdd;
				StockDal.UpdateStockInformation(lookupStock);
				ShowViewStock();
			}
			else if (lookupStock.stockLevel == lookupStock.maximumLevel)
			{
				ShowErrorStockLevel("This item of stock's storage is full. 0 items added.");
			}
			else
			{
				ShowErrorStockLevel($"The amount you are attempting to add exceeds the maximum capacity for this stock item. 0 items added.");
			}
		}

		private void btnTakeOutStockConfirm_Click(object sender, EventArgs e)
		{
			int amountToRemove = 0;
			int originalStockLevel = lookupStock.stockLevel;

			try
			{
				amountToRemove = Convert.ToInt32(txtBoxAmountOfStockToChange.Text);
			}
			catch (Exception ex)
			{
				ShowErrorStockLevel("That is not a valid number.");
			}
			if (amountToRemove <= 0)
			{
				ShowErrorStockLevel("That is not a valid number.");
			}
			if (lookupStock.stockLevel - amountToRemove >= 0)
			{
				lookupStock.stockLevel -= amountToRemove;
				StockDal.UpdateStockInformation(lookupStock);
				ShowViewStock();
			}
			else if (lookupStock.stockLevel == 0)
			{
				ShowErrorStockLevel("This item of stock's storage is empty. 0 items removed.");
			}
			else
			{
				ShowErrorStockLevel($"You don't have that many items in storage. 0 items removed");
			}
		}

		#endregion TakingAndReturningStock

		#region ErrorHandling
		private void ShowErrorStockLevel(string errorMessage)
		{
			// shows an error indicating which boxes need to be filled in to be valid
			lblError.Text = errorMessage;
			lblError.Visible = true;
		}

		private void ClearError()
		{
			// hide error message
			lblError.Text = "";
			lblError.Visible = false;
			lblErrorStockEdit.Visible = false;
			lblErrorStockEdit.Text = "";
		}

		#endregion ErrorHandling

		#region EditingStock
		private void btnEditStock_Click(object sender, EventArgs e)
		{
			ShowEditStockItem();
			ClearError();
			txtBoxName.Text = lookupStock.stockName;
			txtBoxDescription.Text = lookupStock.stockDescription;			
			txtBoxMinimumLevel.Text = lookupStock.minimumLevel.ToString();
			txtBoxMaximumLevel.Text = lookupStock.maximumLevel.ToString();
			txtBoxOrderQuantity.Text = lookupStock.orderQuantity.ToString();
			txtBoxPrice.Text = lookupStock.price.ToString();
			txtBoxDeliveryTime.Text = lookupStock.deliveryTimeDays.ToString();
			txtBoxStockCheckFrequency.Text = lookupStock.stockCheckFrequency.ToString();
		}

		private void btnEditStockItem_Click(object sender, EventArgs e)
		{
			lookupStock.stockName = txtBoxName.Text;
			lookupStock.stockDescription = txtBoxDescription.Text;
			lookupStock.minimumLevel = Convert.ToInt32(txtBoxMinimumLevel.Text);
			lookupStock.maximumLevel = Convert.ToInt32(txtBoxMaximumLevel.Text);
			lookupStock.orderQuantity = Convert.ToInt32(txtBoxOrderQuantity.Text);
			lookupStock.price = Convert.ToInt32(txtBoxPrice.Text);
			lookupStock.deliveryTimeDays = Convert.ToInt32(txtBoxDeliveryTime.Text);
			lookupStock.stockCheckFrequency = Convert.ToInt32(txtBoxStockCheckFrequency.Text);

			StockDal.UpdateStockInformation(lookupStock);
			ShowViewStock();
		}

		private void btnCancelStockEdit_Click(object sender, EventArgs e)
		{
			ClearError();
			ShowViewStock();
		}

		#endregion EditingStock

		#region PanelClicks
		private void pnlOptionButtons_Click(object sender, EventArgs e)
		{
			pnlOptionButtons.Visible = false;
			lstViewStock.SelectedItems.Clear();
			pnlStockList.Dock = DockStyle.Fill;
			lblInstructions.Text = "Select an item to manage its level and information";
		}

		private void pnlStockList_Click(object sender, EventArgs e)
		{
			pnlOptionButtons.Visible = false;
			lstViewStock.SelectedItems.Clear();
			pnlStockList.Dock = DockStyle.Fill;
			lblInstructions.Text = "Select an item to manage its level and information";
		}

		#endregion PanelClicks

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearError();
			ShowViewStock();
		}

		#region ListViewClick
		private void lstViewStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
			{
				pnlOptionButtons.Visible = true;
				pnlOptionButtons.Dock = DockStyle.Bottom;
				pnlStockList.Dock = DockStyle.Fill;
				lblInstructions.Text = "Select an option to proceed";

				string stockName = e.Item.SubItems[0].Text;
				LookupStock(stockName);
			}
		}

		#endregion ListViewClick

		#region Resizing
		private void frmEditStockLevels_Resize(object sender, EventArgs e)
		{
			lstViewStock.Height = (pnlStockList.Height - 58);
		}

		#endregion Resizing
	}
}
