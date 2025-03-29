using Final_Project.Models;
using Microsoft.Data.SqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Final_Project
{
	public partial class frmAddOrRetireStockType : Form
	{
		// class takes a panel as a parameter to check which panel to show first
		public frmAddOrRetireStockType(string panelToShow)
		{
			InitializeComponent();

			// if the panel is "Add Stock" the form to add a new stock will be shown first
			if (panelToShow == "Add Stock")
			{
				ShowAddStock();				
			}

			// if the panel is "Remove Stock" the form to remove the stock will be shown first
			else if (panelToShow == "Retire Stock")
			{
				ShowRetireStock();				
			}

			// Hide the error messages
			ClearError();
		}

		// base stock objects to hold information about the stock to add or retire
		Stock stockToAddOrRetire = new Stock();

		// get a list of all stock
		List<Stock> allStock = StockDal.GetAllActiveStock();

		string actionTakingPlace = "";

		#region AddingNewStock

		string name = "";
		string description = "";
		decimal price = -1;
		int orderQuantity = -1;
		int maximumLevel = -1;
		int minimumLevel = -1;
		int stockLevel = -1;
		int stockCheckFrequency = -1;
		int deliveryTimeDays = -1;

		public static string StockValidation(int stockId, string name, string description, decimal price, int orderQuantity, int maximumLevel, int minimumLevel, int stockLevel, int stockCheckFrequency, int deliveryTimeDays)
		{
			List<Stock> allStock = StockDal.GetAllActiveStock();

			// Ensure there are no blank inputs
			if (name == "" || description == "")
				return "Fill all fields before confirming changes!";

			if (price <= 0)
				return "Price cannot be negative or 0!";

			if (orderQuantity <= 0)
				return "Order quantity cannot be negative or 0!";

			if (minimumLevel < 1)
				return "Minimum level must be at least 1!";

			if (maximumLevel < 1)
				return "Maximum level must be at least 1!";

			if (maximumLevel < minimumLevel)
				return "Maximum level cannot be less than the minimum level!";

			if (stockCheckFrequency < 1)
				return "Stock check frequency cannot be less than 1!";

			if (deliveryTimeDays < 0)
				return "Delivery time cannot be less than 0!";

			if (orderQuantity > maximumLevel)
				return "Order quantity cannot be more than the maximum level!";

			foreach (Stock stock in allStock)
			{
				if (stock.stockName == name && stock.stockId != stockId)
				{
					return "There is already a stock item with that name, please try another";					
				}
			}

			return "";
		}

		private void btnAddNewStock_Click(object sender, EventArgs e)
		{	
			name = txtBoxNewStockName.Text;
			description = txtBoxNewStockDescription.Text;

			// system will try to set each to an appropriate piece of information, catching any errors
			try
			{
				price = Math.Round(Convert.ToDecimal(txtBoxNewStockPrice.Text), 2);
				orderQuantity = Convert.ToInt32(txtBoxNewOrderQuantity.Text);
				maximumLevel = Convert.ToInt32(txtBoxNewMaximumLevel.Text);
				minimumLevel = Convert.ToInt32(txtBoxNewMinimumLevel.Text);
				stockLevel = 0;
				stockCheckFrequency = Convert.ToInt32(txtBoxNewStockCheckFrequency.Text);
				deliveryTimeDays = Convert.ToInt32(txtBoxNewDeliveryTime.Text);
			}
			catch (Exception)
			{
				// if there are any errors, the system rejects it and the user is told to try give better information				
				ShowErrorAddStock("Numerical data is not in correct format. Ensure numerical fields are valid numbers.");
				return;
			}
			
			string errorMessage = StockValidation(0, name, description, price, orderQuantity, maximumLevel, minimumLevel, stockLevel, stockCheckFrequency, deliveryTimeDays);

			if(errorMessage != "")
			{
				ShowErrorAddStock(errorMessage);
				return;
			}
					
			// if all information looks good, show a panel with the information they input, allowing them to confirm if it is correct			
			ShowConfirmation();
			lblStockTo.Text = "Stock To Add:";
			lblStockName.Text = $"Stock Name: {name}";
			lblStockDescription.Text = $"Stock Description: {description}";
			lblPrice.Text = $"Price: {price}";
			lblMaximumLevel.Text = $"Maximum Level: {maximumLevel}";
			lblMinimumLevel.Text = $"Minimum Level: {minimumLevel}";
		}

		#endregion AddingNewStock

		#region RetiringStock

		private void btnRetireStock_Click(object sender, EventArgs e)
		{
			if(cBoxStockItemsToRetire.Text != "")
			{
				stockToAddOrRetire.stockName = cBoxStockItemsToRetire.Text;
			}
			else
			{
				ShowErrorRetireStock("Select a stock to retire!");
				return;
			}			

			// go through each stock to find the stock the user input
			foreach (Stock stock in allStock)
			{
				if (stock.stockName == stockToAddOrRetire.stockName && stock.stockLevel == 0)
				{
					// if found, show confirmation with the values of the input stock
					stockToAddOrRetire = stock;
					ShowConfirmation();
					lblStockTo.Text = "Stock To Remove:";
					lblStockName.Text = $"Stock Name: {stockToAddOrRetire.stockName}";
					lblStockDescription.Text = $"Stock Description: {stockToAddOrRetire.stockDescription}";
					lblPrice.Text = $"Price: {stockToAddOrRetire.price}";
					lblMaximumLevel.Text = $"Maximum Level: {stockToAddOrRetire.maximumLevel}";
					lblMinimumLevel.Text = $"Minimum Level: {stockToAddOrRetire.minimumLevel}";
				}
				else if (stock.stockName == stockToAddOrRetire.stockName && stock.stockLevel != 0)
				{
					ShowErrorRetireStock("Use all items of this stock first before retiring!");
					return;
				}
				else
				{
					ShowErrorRetireStock("That stock item does not exist.");					
				}
			}
		}

		#endregion RetiringStock

		#region PanelShowing
		private void ShowConfirmation()
		{
			// shows the confirmation panel
			pnlConfirmation.Visible = true;
			pnlAddNewStock.Visible = false;
			pnlRetireStock.Visible = false;
			pnlConfirmation.Dock = DockStyle.Fill;
		}
		
		private void ShowAddStock()
		{
			// shows the panel to add a new stock
			pnlAddNewStock.Visible = true;
			pnlConfirmation.Visible = false;
			pnlRetireStock.Visible = false;
			pnlAddNewStock.Dock = DockStyle.Fill;
			actionTakingPlace = "Add Stock";
		}

		private void ShowRetireStock()
		{
			// shows the panel to remove a stock
			pnlRetireStock.Visible = true;
			pnlAddNewStock.Visible = false;
			pnlConfirmation.Visible = false;
			pnlRetireStock.Dock = DockStyle.Fill;
			actionTakingPlace = "Retire Stock";

			List<Stock> stockToRetire = StockDal.GetAllActiveStock();
			List<string> stockNamesToRetire = new List<string>();
			foreach (Stock stock in stockToRetire)
			{
				stockNamesToRetire.Add(stock.stockName);
			}
			cBoxStockItemsToRetire.DataSource = stockNamesToRetire;
		}

		#endregion PanelShowing

		#region Ending
		private void btnConfirmed_Click(object sender, EventArgs e)
		{		
			// if the add stock object isn't null, it will add the stock to the database
			if (name != "")
			{
				stockToAddOrRetire.stockName = name;
				stockToAddOrRetire.stockDescription = description;
				stockToAddOrRetire.price = price;
				stockToAddOrRetire.minimumLevel = minimumLevel;
				stockToAddOrRetire.maximumLevel = maximumLevel;
				stockToAddOrRetire.orderQuantity = orderQuantity;
				stockToAddOrRetire.stockCheckFrequency = stockCheckFrequency;
				stockToAddOrRetire.deliveryTimeDays = deliveryTimeDays;
				StockDal.AddNewStock(stockToAddOrRetire);
				ReturnToPreviousScreen();
			}
			// if the remove stock object isn't null, it will remove the stock from the database
			else if (stockToAddOrRetire.stockName != null)
			{
				stockToAddOrRetire.active = false;
				StockDal.UpdateStockInformation(stockToAddOrRetire);
				ReturnToPreviousScreen();
			}
		}

		private void ReturnToPreviousScreen()
		{
			ClearError();

			txtBoxNewStockName.Text = "";
			txtBoxNewStockDescription.Text = "";
			txtBoxNewMinimumLevel.Text = "";
			txtBoxNewMaximumLevel.Text = "";
			txtBoxNewOrderQuantity.Text = "";
			txtBoxNewStockPrice.Text = "";
			txtBoxNewStockCheckFrequency.Text = "";
			txtBoxNewDeliveryTime.Text = "";

			cBoxStockItemsToRetire.Text = "";
			// check to see which panel to show and then show the respective panel
			if (actionTakingPlace == "Add Stock")
			{
				pnlAddNewStock.Visible = true;
			}
			else if (actionTakingPlace == "Retire Stock")
			{
				pnlRetireStock.Visible = true;
			}
			// hides the confirmation panel
			pnlConfirmation.Visible = false;
		}

		#endregion Ending

		#region Return
		private void btnReturn_Click(object sender, EventArgs e)
		{
			// if the return button is clicked, the information the user entered will reappear in the textbox(es)
			if (actionTakingPlace == "Add Stock")
			{
				ShowAddStock();
				lblErrorAddNewStock.Visible = false;
				txtBoxNewStockName.Text = name;
				txtBoxNewStockDescription.Text = description;
				txtBoxNewMinimumLevel.Text = minimumLevel.ToString();
				txtBoxNewMaximumLevel.Text = maximumLevel.ToString();
				txtBoxNewOrderQuantity.Text = orderQuantity.ToString();
				txtBoxNewStockPrice.Text = price.ToString();
				txtBoxNewStockCheckFrequency.Text = stockCheckFrequency.ToString();
				txtBoxNewDeliveryTime.Text = deliveryTimeDays.ToString();
			}
			else if (actionTakingPlace == "Retire Stock")
			{
				ShowRetireStock();
				lblErrorRetireStock.Visible = false;
				cBoxStockItemsToRetire.Text = stockToAddOrRetire.stockName;
			}
		}

		#endregion Return

		#region ErrorHandling

		private void ShowErrorAddStock(string errorMessage)
		{
			lblErrorAddNewStock.Text = errorMessage;
			lblErrorAddNewStock.Visible = true;
		}

		private void ShowErrorRetireStock(string errorMessage)
		{
			lblErrorRetireStock.Text = errorMessage;
			lblErrorRetireStock.Visible = true;
		}

		private void ClearError()
		{
			lblErrorAddNewStock.Visible = false;
			lblErrorRetireStock.Visible = false;
		}

		#endregion ErrorHandling
	}
}
