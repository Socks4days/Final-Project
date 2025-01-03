using Final_Project.Models;
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
				lblErrorAddNewStock.Visible = false;
			}

			// if the panel is "Remove Stock" the form to remove the stock will be shown first
			else if (panelToShow == "Retire Stock")
			{
				ShowRetireStock();
				lblErrorRetireStock.Visible = false;
			}

			
		}

		// base stock objects to hold information about the stock to add or delete
		Stock stockToAdd = new Stock();
		Stock stockToRetire = new Stock();

		// get a list of all stock
		List<Stock> allStock = StockDal.GetAllStock();

		private void btnAddNewStock_Click(object sender, EventArgs e)
		{
			// system will try to set each to an appropriate piece of information, catching any errors
			try
			{
				stockToAdd.stockName = txtBoxNewStockName.Text;
				stockToAdd.stockDescription = txtBoxNewStockDescription.Text;
				stockToAdd.price = Convert.ToDecimal(txtBoxNewStockPrice.Text);
				stockToAdd.orderQuantity = Convert.ToInt32(txtBoxNewOrderQuantity.Text);
				stockToAdd.maximumLevel = Convert.ToInt32(txtBoxNewMaximumLevel.Text);
				stockToAdd.minimumLevel = Convert.ToInt32(txtBoxNewMinimumLevel.Text);
				stockToAdd.stockLevel = 0;
				stockToAdd.stockCheckFrequency = Convert.ToInt32(txtBoxNewStockCheckFrequency.Text);
				stockToAdd.deliveryTimeDays = Convert.ToInt32(txtBoxNewDeliveryTime.Text);
			}
			catch (Exception ex)
			{
				// if there are any errors, the system rejects it and the user is told to try give better information
				lblErrorAddNewStock.Visible = true;
				lblErrorAddNewStock.Text = "Insufficient details have been provided, please try again.";
				return;
			}
			// if all information looks good, show a panel with the information they input, allowing them to confirm if it is correct

			foreach (Stock stock in allStock)
			{
				if(stock.stockName == stockToAdd.stockName)
				{
					lblErrorAddNewStock.Text = "There is already a stock item with that name, please enter another";
					lblErrorAddNewStock.Visible = true;
					return;
				}				
			}
			ShowConfirmation();
			lblStockTo.Text = "Stock To Add:";
			lblStockName.Text = $"Stock Name: {stockToAdd.stockName}";
			lblStockDescription.Text = $"Stock Description: {stockToAdd.stockDescription}";
			lblPrice.Text = $"Price: {stockToAdd.price}";
			lblMaximumLevel.Text = $"Maximum Level: {stockToAdd.maximumLevel}";
			lblMinimumLevel.Text = $"Minimum Level: {stockToAdd.minimumLevel}";
		}

		private void btnRetireStock_Click(object sender, EventArgs e)
		{
			// try to set a value for the stock to remove
			try
			{
				stockToRetire.stockName = txtBoxRetireStockName.Text;
			}
			catch (Exception ex)
			{
				// if not valid, alert user
				lblErrorRetireStock.Visible = true;
				lblErrorRetireStock.Text = "There is no stock with that name, please try again...";
			}

			if(txtBoxRetireStockName.Text == "")
			{
				// if not valid, alert user
				lblErrorRetireStock.Visible = true;
				lblErrorRetireStock.Text = "There is no stock with that name, please try again...";
			}

			// go through each stock to find the stock the user input
			foreach (Stock stock in allStock)
			{
				if (stock.stockName == stockToRetire.stockName && stock.stockLevel == 0)
				{
					// if found, show confirmation with the values of the input stock
					stockToRetire = stock;
					ShowConfirmation();
					lblStockTo.Text = "Stock To Remove:";
					lblStockName.Text = $"Stock Name: {stockToRetire.stockName}";
					lblStockDescription.Text = $"Stock Description: {stockToRetire.stockDescription}";
					lblPrice.Text = $"Price: {stockToRetire.price}";
					lblMaximumLevel.Text = $"Maximum Level: {stockToRetire.maximumLevel}";
					lblMinimumLevel.Text = $"Minimum Level: {stockToRetire.minimumLevel}";
				}
				else if(stock.stockName == stockToRetire.stockName && stock.stockLevel != 0)
				{
					lblErrorRetireStock.Visible = true;
					lblErrorRetireStock.Text = "Use all items of this stock first before retiring!";
					return;
				}
			}
		}

		private void ShowConfirmation()
		{
			// shows the confirmation panel
			pnlConfirmation.Visible = true;
			pnlAddNewStock.Visible = false;
			pnlRetireStock.Visible = false;
			pnlConfirmation.Dock = DockStyle.Fill;
		}

		string actionTakingPlace = "";
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
		}

		private void btnConfirmed_Click(object sender, EventArgs e)
		{		
			// if the add stock object isn't null, it will add the stock to the database
			if (stockToAdd.stockName != null)
			{
				StockDal.AddNewStock(stockToAdd);
				ReturnToPreviousScreen();
			}
			// if the remove stock object isn't null, it will remove the stock from the database
			else if (stockToRetire.stockName != null)
			{
				stockToRetire.active = false;
				StockDal.UpdateStockInformation(stockToRetire);
				ReturnToPreviousScreen();
			}
		}
		
		private void btnReturn_Click(object sender, EventArgs e)
		{
			// if the return button is clicked, the information the user entered will reappear in the textbox(es)
			if (stockToAdd.stockName != null)
			{
				ShowAddStock();
				lblErrorAddNewStock.Visible = false;
				txtBoxNewStockName.Text = stockToAdd.stockName;
				txtBoxNewStockDescription.Text = stockToAdd.stockDescription;
				txtBoxNewStockPrice.Text = stockToAdd.price.ToString();
				txtBoxNewMaximumLevel.Text = stockToAdd.maximumLevel.ToString();
				txtBoxNewMinimumLevel.Text = stockToAdd.minimumLevel.ToString();
			}
			else if (stockToRetire.stockName != null)
			{
				ShowRetireStock();
				lblErrorRetireStock.Visible = false;
				txtBoxRetireStockName.Text = stockToRetire.stockName;
			}
		}

		private void ReturnToPreviousScreen()
		{
			lblErrorAddNewStock.Visible = false;

			txtBoxNewStockName.Text = "";
			txtBoxNewStockDescription.Text = "";
			txtBoxNewMinimumLevel.Text = "";
			txtBoxNewMaximumLevel.Text = "";
			txtBoxNewOrderQuantity.Text = "";
			txtBoxNewStockPrice.Text = "";
			txtBoxNewStockCheckFrequency.Text = "";
			txtBoxNewDeliveryTime.Text = "";	
			
			txtBoxRetireStockName.Text = "";

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
	}
}
