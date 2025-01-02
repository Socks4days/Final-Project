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
			List<StockLevelsView> sortedStockList = StockDal.GetStockLevelsView("StockName");

			// Add each stock in the sorted list to the stock list
			foreach (StockLevelsView stockLevel in sortedStockList)
			{
				// Create an array with stock details
				string[] row = { stockLevel.stockName, stockLevel.stockLevel.ToString(), stockLevel.auditDate.ToString(), stockLevel.auditedByStaffFullName };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the stock list view
				lstViewStock.Items.Add(item);
			}
			ShowViewStock();
		}

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

		private void btnAddToStock_Click(object sender, EventArgs e)
		{
			ShowEditStockLevels();
			btnRemoveStock.Visible = false;
			btnAddStock.Visible = true;
			lblStockLevelToEdit.Text = lookupStock.stockName;
			lblCurrentStockLevel.Text = $"Current Stock Level: {lookupStock.stockLevel.ToString()}";
		}

		private void btnRemoveFromStock_Click(object sender, EventArgs e)
		{
			ShowEditStockLevels();
			btnAddStock.Visible = false;
			btnRemoveStock.Visible = true;
			lblStockLevelToEdit.Text = lookupStock.stockName;
			lblCurrentStockLevel.Text = $"Current Stock Level: {lookupStock.stockLevel.ToString()}";
		}

		private void btnAddStock_Click(object sender, EventArgs e)
		{
			int amountToAdd = 0;
			int originalStockLevel = lookupStock.stockLevel;
			try
			{
				amountToAdd = Convert.ToInt32(txtBoxAmountOfStockToChange.Text);
			}
			catch (Exception ex)
			{
				ShowMessageStockLevel("That is not a valid number");
			}
			if (lookupStock.stockLevel + amountToAdd <= lookupStock.maximumLevel)
			{
				lookupStock.stockLevel += amountToAdd;
				StockDal.UpdateStockInformation(lookupStock);
				ShowMessageStockLevel($"Successfully added {amountToAdd} to stock level!");
			}
			else if (lookupStock.stockLevel == lookupStock.maximumLevel)
			{
				ShowMessageStockLevel("This item of stock's storage is full. 0 items added.");
			}
			else
			{
				ShowMessageStockLevel($"The amount you are attempting to add exceeds the maximum capacity for this stock item. 0 items added.");
			}
		}

		private void btnRemoveStock_Click(object sender, EventArgs e)
		{
			int amountToRemove = 0;
			int originalStockLevel = lookupStock.stockLevel;

			try
			{
				amountToRemove = Convert.ToInt32(txtBoxAmountOfStockToChange.Text);
			}
			catch (Exception ex)
			{
				ShowMessageStockLevel("That is not a valid number.");
			}
			if (amountToRemove <= 0)
			{
				ShowMessageStockLevel("That is not a valid number.");
			}
			if (lookupStock.stockLevel - amountToRemove >= 0)
			{
				lookupStock.stockLevel -= amountToRemove;
				StockDal.UpdateStockInformation(lookupStock);
				ShowMessageStockLevel($"Successfully removed {amountToRemove} to stock level!");
			}
			else if (lookupStock.stockLevel == 0)
			{
				ShowMessageStockLevel("This item of stock's storage is empty. 0 items removed.");
			}
			else
			{
				ShowMessageStockLevel($"You don't have that many items in storage. 0 items removed");
			}
		}

		private void ShowMessageStockLevel(string errorMessage)
		{
			// shows an error indicating which boxes need to be filled in to be valid
			lblError.Text = errorMessage;
			lblError.Visible = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearError();
			ShowViewStock();
		}

		private void ShowViewStock()
		{
			pnlEditStockLevels.Visible = false;
			pnlEditStockItem.Visible = false;
			pnlOptionButtons.Visible = false;
			pnlStockList.Visible = true;			
			pnlStockList.Dock = DockStyle.Fill;
			lstViewStock.Height = (pnlStockList.Height - 58);
			lstViewStock.SelectedItems.Clear();
			lblInstructions.Text = "Select an item to manage its level and information";
		}

		private void ShowEditStockLevels()
		{
			pnlStockList.Visible = false;
			pnlEditStockItem.Visible = false;
			pnlOptionButtons.Visible = false;
			pnlEditStockLevels.Visible = true;
			pnlEditStockLevels.Dock = DockStyle.Fill;			
		}

		private void ShowEditStockItem()
		{			
			pnlEditStockLevels.Visible = false;
			pnlStockList.Visible = false;
			pnlOptionButtons.Visible = false;
			pnlEditStockItem.Visible = true;
			pnlEditStockItem.Dock = DockStyle.Fill;
		}

		private void ClearError()
		{
			// hide error message
			lblError.Text = "";
			lblError.Visible = false;
			lblErrorStockEdit.Visible = false;
			lblErrorStockEdit.Text = "";
		}

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

		private void frmEditStockLevels_Resize(object sender, EventArgs e)
		{
			lstViewStock.Height = (pnlStockList.Height - 58);
		}
	}
}
