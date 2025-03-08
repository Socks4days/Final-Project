using Final_Project.Models;
using System.Text.RegularExpressions;

namespace Final_Project
{
	public partial class frmEditStockLevels : Form
	{
		public frmEditStockLevels()
		{
			InitializeComponent();			
			ShowViewStock();
		}

		#region PanelShowing
		private void ShowViewStock()
		{
			foreach (ListViewItem item in lstViewStock.Items)
			{
				lstViewStock.Items.Remove(item);
			}

			List<Stock> sortedStockList = StockDal.GetAllActiveStock();

			// Add each stock in the sorted list to the stock list
			foreach (Stock stock in sortedStockList)
			{				
				string stockLevelStatus = "In stock";
				if (stock.stockLevel == 0)
				{
					stockLevelStatus = "Out of stock";
				}
				else if (stock.stockLevel <= stock.minimumLevel)
				{
					stockLevelStatus = "Low stock";
				}
				else if (stock.stockLevel >= stock.maximumLevel)
				{
					stockLevelStatus = "Storage full";
				}

				// Create an array with stock details
				string[] row = { stock.stockName, stock.stockLevel.ToString(), stock.minimumLevel.ToString(), stock.maximumLevel.ToString(), stockLevelStatus, };

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
			nUDStockLevel.Value = 0;
			lblCurrentStockLevel.Text = $"Current Stock Level: {lookupStock.stockLevel.ToString()}";
			lblStockLevelToEdit.Text = lookupStock.stockName;
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

		#endregion PanelShowing		

		#region TakingAndReturningStock
		private void btnReturnStock_Click(object sender, EventArgs e)
		{
			btnTakeOutStockConfirm.Visible = false;
			btnReturnStockConfirm.Visible = true;
			frmMainScreen.frmMain.lblTitle.Text = "Return Stock";
			nUDStockLevel.Maximum = lookupStock.maximumLevel - lookupStock.stockLevel;
			ShowEditStockLevels();			
		}

		private void btnTakeOutStock_Click(object sender, EventArgs e)
		{
			btnReturnStockConfirm.Visible = false;
			btnTakeOutStockConfirm.Visible = true;
			frmMainScreen.frmMain.lblTitle.Text = "Take Out Stock";
			nUDStockLevel.Maximum = lookupStock.stockLevel;
			ShowEditStockLevels();			
		}

		private void btnReturnStockConfirm_Click(object sender, EventArgs e)
		{
			int amountToAdd = 0;
			int originalStockLevel = lookupStock.stockLevel;
			amountToAdd = (int)nUDStockLevel.Value;
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
			amountToRemove = (int)nUDStockLevel.Value;
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
			if((txtBoxName.Text != "") && (txtBoxDescription.Text != ""))
			{
				lookupStock.stockName = txtBoxName.Text;
				lookupStock.stockDescription = txtBoxDescription.Text;
			}
			else
			{
				ShowErrorStockItem("Please complete all fields before saving changes.");
				return;
			}
			
			try
			{
				lookupStock.minimumLevel = Convert.ToInt32(txtBoxMinimumLevel.Text);
				lookupStock.maximumLevel = Convert.ToInt32(txtBoxMaximumLevel.Text);
				lookupStock.orderQuantity = Convert.ToInt32(txtBoxOrderQuantity.Text);
				lookupStock.price = Convert.ToDecimal(txtBoxPrice.Text);
				lookupStock.deliveryTimeDays = Convert.ToInt32(txtBoxDeliveryTime.Text);
				lookupStock.stockCheckFrequency = Convert.ToInt32(txtBoxStockCheckFrequency.Text);
			}
			catch (Exception)
			{
				ShowErrorStockItem("Numerical data is not in correct format. Ensure all fields excluding name and description are valid numbers.");
				return;
			}

			List<StockLevelsView> allStock = StockDal.GetStockLevelsView("StockName");

			foreach(StockLevelsView stock in allStock)
			{
				if(lookupStock.stockName == stock.stockName)
				{
					ShowErrorStockItem("There is already a stock with that name!");
					return;
				}					
			}

			StockDal.UpdateStockInformation(lookupStock);
			ShowViewStock();
		}

		private void btnCancelStockEdit_Click(object sender, EventArgs e)
		{
			ClearError();
			ShowViewStock();
		}

		#endregion EditingStock		

		#region GoingBack

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearError();
			ShowViewStock();
		}

		#endregion GoingBack

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

		#region ListViewSelecting
		private void lstViewStock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
			{
				pnlOptionButtons.Visible = true;
				pnlOptionButtons.Dock = DockStyle.Bottom;
				pnlStockList.Dock = DockStyle.Fill;
				lblInstructions.Text = "Select an option to proceed";

				string stockName = e.Item!.SubItems[0].Text;
				LookupStock(stockName);
			}
		}

		#endregion ListViewSelecting

		#region LookupStock

		public static Stock lookupStock = new Stock();

		public static void LookupStock(string stockName)
		{
			List<Stock> allStock = StockDal.GetAllActiveStock();
			foreach (Stock stock in allStock)
			{
				if (stock.stockName.ToString() == stockName)
				{
					lookupStock = StockDal.GetStockByStockId(stock.stockId);
				}
			}
		}

		#endregion LookupStock

		#region ErrorHandling
		private void ShowErrorStockLevel(string errorMessage)
		{
			// shows an error indicating which boxes need to be filled in to be valid
			lblError.Text = errorMessage;
			lblError.Visible = true;
		}

		private void ShowErrorStockItem(string errorMessage)
		{
			// shows an error indicating which boxes need to be filled in to be valid
			lblErrorStockEdit.Text = errorMessage;
			lblErrorStockEdit.Visible = true;
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

		#region Resizing
		private void frmEditStockLevels_Resize(object sender, EventArgs e)
		{
			lstViewStock.Height = (pnlStockList.Height - 58);
		}

		#endregion Resizing
	}
}
