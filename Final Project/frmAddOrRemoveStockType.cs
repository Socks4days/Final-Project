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
    public partial class frmAddOrRemoveStockType : Form
    {
        // create a timer
        private System.Timers.Timer timer;

        private int count = 0;

        // class takes a panel as a parameter to check which panel to show first
        public frmAddOrRemoveStockType(string panelToShow)
        {
            InitializeComponent();

            // if the panel is "Add Stock" the form to add a new stock will be shown first
            if(panelToShow == "Add Stock")
            {
                ShowAddStock();
                lblError.Visible = false;
            }

            // if the panel is "Remove Stock" the form to remove the stock will be shown first
            else if(panelToShow == "Remove Stock")
            {
                ShowRemoveStock();
                lblErrorRemoveStock.Visible = false;
            }
            lblSuccess.Visible = false;

            // sets the timer to one that ticks every second
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
        }

        // base stock objects to hold information about the stock to add or delete
        Stock stockToAdd = new Stock();
        Stock stockToRemove = new Stock();

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            // system will try to set each to an appropriate piece of information, catching any errors
            try
            {
                stockToAdd.stockName = txtBoxNewStockName.Text;
                stockToAdd.stockDescription = txtBoxNewStockDescription.Text;
                stockToAdd.price = Convert.ToDecimal(txtBoxNewStockPrice.Text);
                stockToAdd.maximumLevel = Convert.ToInt32(txtBoxNewMaximumLevel.Text);
                stockToAdd.minimumLevel = Convert.ToInt32(txtBoxNewMinimumLevel.Text);
            }
            catch (Exception ex)
            {
                // if there are any errors, the system rejects it and the user is told to try give better information
                lblError.Visible = true;
                lblError.Text = "Insufficient details have been provided, please try again.";
                return;
            }
            // if all information looks good, show a panel with the information they input, allowing them to confirm if it is correct
            ShowConfirmation();
            lblStockTo.Text = "Stock To Add:";
            lblStockName.Text = $"Stock Name: {stockToAdd.stockName}";
            lblStockDescription.Text = $"Stock Description: {stockToAdd.stockDescription}";
            lblPrice.Text = $"Price: {stockToAdd.price}";
            lblMaximumLevel.Text = $"Maximum Level: {stockToAdd.maximumLevel}";
            lblMinimumLevel.Text = $"Minimum Level: {stockToAdd.minimumLevel}";
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            // try to set a value for the stock to remove
            try
            {
                stockToRemove.stockName = txtBoxRemoveStockName.Text;
            }
            catch (Exception ex)
            {
                // if not valid, alert user
                lblErrorRemoveStock.Visible = true;
                lblErrorRemoveStock.Text = "There is no stock with that name, please try again...";
            }

            // get a list of all stock
            List<Stock> allStock = StockDal.GetAllStock();

            // go through each stock to find the stock the user input
            foreach (Stock stock in allStock)
            {
                if (stock.stockName == stockToRemove.stockName)
                {
                    // if found, show confirmation with the values of the input stock
                    stockToRemove = stock;
                    ShowConfirmation();
                    lblStockTo.Text = "Stock To Remove:";
                    lblStockName.Text = $"Stock Name: {stockToRemove.stockName}";
                    lblStockDescription.Text = $"Stock Description: {stockToRemove.stockDescription}";
                    lblPrice.Text = $"Price: {stockToRemove.price}";
                    lblMaximumLevel.Text = $"Maximum Level: {stockToRemove.maximumLevel}";
                    lblMinimumLevel.Text = $"Minimum Level: {stockToRemove.minimumLevel}";
                }
            }
        }

        private void ShowConfirmation()
        {
            // shows the confirmation panel
            pnlConfirmation.Visible = true;
            pnlAddNewStock.Visible = false;
            pnlRemoveStock.Visible = false;
        }

        private void ShowAddStock()
        {
            // shows the panel to add a new stock
            pnlAddNewStock.Visible = true;
            pnlConfirmation.Visible = false;
            pnlRemoveStock.Visible = false;
        }

        private void ShowRemoveStock()
        {
            // shows the panel to remove a stock
            pnlRemoveStock.Visible = true;
            pnlAddNewStock.Visible = false;
            pnlConfirmation.Visible = false;
        }

        private void btnConfirmed_Click(object sender, EventArgs e)
        {
            // starts the timer when button is clicked
            count = 0;
            timer.Start();
            lblSuccess.Visible = true;

            // if the add stock object isn't null, it will add the stock to the database
            if (stockToAdd.stockName != null)
            {
                lblSuccess.Text = "New stock added successfully! Returning to previous screen in 3 seconds...";
                StockDal.AddNewStock(stockToAdd);
            }
            // if the remove stock object isn't null, it will remove the stock from the database
            else if (stockToRemove.stockName != null)
            {
                lblSuccess.Text = "Stock removed successfully! Returning to previous screen in 3 seconds...";
                StockDal.RemoveStock(stockToRemove);
            }            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // if the return button is clicked, the information the user entered will reappear in the textbox(es)
            if (stockToAdd.stockName != null) 
            {
                ShowAddStock();
                lblError.Visible = false;
                txtBoxNewStockName.Text = stockToAdd.stockName;
                txtBoxNewStockDescription.Text = stockToAdd.stockDescription;
                txtBoxNewStockPrice.Text = stockToAdd.price.ToString();
                txtBoxNewMaximumLevel.Text = stockToAdd.maximumLevel.ToString();
                txtBoxNewMinimumLevel.Text = stockToAdd.minimumLevel.ToString();
            }
            else if(stockToRemove.stockName != null)
            {
                ShowRemoveStock();
                lblErrorRemoveStock.Visible = false;
                txtBoxRemoveStockName.Text = stockToRemove.stockName;
            }            
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // every time the timer ticks, it adds 1 to the count variable
            count++;

            // when the count variable gets to 3, it resets the textboxes
            if (count >= 3)
            {
                timer.Stop(); // Stop the timer after 3 seconds
                lblError.Visible = false;
                this.Invoke((MethodInvoker)delegate
                {
                    txtBoxNewStockName.Text = "";
                    txtBoxNewStockDescription.Text = "";
                    txtBoxNewStockPrice.Text = "";
                    txtBoxNewMaximumLevel.Text = "";
                    txtBoxNewMinimumLevel.Text = "";
                    txtBoxRemoveStockName.Text = "";

                    // check to see which panel to show and then show the respective panel
                    if (stockToAdd != null)
                    {
                        pnlAddNewStock.Visible = true;
                    }
                    else if (stockToRemove != null) 
                    {
                        pnlRemoveStock.Visible = true;
                    }
                    // hides the confirmation panel
                    pnlConfirmation.Visible = false;
                });
            }
        }        
    }
}
