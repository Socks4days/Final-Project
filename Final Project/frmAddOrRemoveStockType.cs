using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmAddOrRemoveStockType : Form
    {
        private System.Timers.Timer timer;
        private int count = 0;
        public frmAddOrRemoveStockType(string panelToShow)
        {
            InitializeComponent();

            if(panelToShow == "Add Stock")
            {
                ShowStockDetails();
                lblError.Visible = false;
            }
            else if(panelToShow == "Remove Stock")
            {
                ShowRemoveStock();
                lblErrorRemoveStock.Visible = false;
            }
            lblSuccess.Visible = false;

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
        }
        Stock stockToAdd = new Stock();
        Stock stockToRemove = new Stock();

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
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
                lblError.Visible = true;
                lblError.Text = "Insufficient details have been provided, please try again.";
                return;
            }

            ShowConfirmation();
            lblStockTo.Text = "Stock To Add:";
            lblStockName.Text = $"Stock Name: {stockToAdd.stockName}";
            lblStockDescription.Text = $"Stock Description: {stockToAdd.stockDescription}";
            lblPrice.Text = $"Price: {stockToAdd.price}";
            lblMaximumLevel.Text = $"Maximum Level: {stockToAdd.maximumLevel}";
            lblMinimumLevel.Text = $"Minimum Level: {stockToAdd.minimumLevel}";
        }

        private void ShowConfirmation()
        {
            pnlConfirmation.Visible = true;
            pnlAddNewStock.Visible = false;
            pnlRemoveStock.Visible = false;
        }

        private void ShowStockDetails()
        {
            pnlAddNewStock.Visible = true;
            pnlConfirmation.Visible = false;
            pnlRemoveStock.Visible = false;
        }

        private void ShowRemoveStock()
        {
            pnlRemoveStock.Visible = true;
            pnlAddNewStock.Visible = false;
            pnlConfirmation.Visible = false;
        }

        private void btnConfirmed_Click(object sender, EventArgs e)
        {
            count = 0;
            timer.Start();
            lblSuccess.Visible = true;

            if (stockToAdd.stockName != null)
            {
                lblSuccess.Text = "New stock added successfully! Returning to previous screen in 3 seconds...";
                StockDal.AddNewStock(stockToAdd);
            }
            else if (stockToRemove.stockName != null)
            {
                lblSuccess.Text = "Stock removed successfully! Returning to previous screen in 3 seconds...";
                StockDal.RemoveStock(stockToRemove);
            }            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ShowStockDetails();
            lblError.Visible = false;
            txtBoxNewStockName.Text = stockToAdd.stockName;
            txtBoxNewStockDescription.Text = stockToAdd.stockDescription;
            txtBoxNewStockPrice.Text = stockToAdd.price.ToString();
            txtBoxNewMaximumLevel.Text = stockToAdd.maximumLevel.ToString();
            txtBoxNewMinimumLevel.Text = stockToAdd.minimumLevel.ToString();
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            count++;
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
                    if (stockToAdd != null)
                    {
                        pnlAddNewStock.Visible = true;
                    }
                    else if (stockToRemove != null) 
                    {
                        pnlRemoveStock.Visible = true;
                    }
                    
                    pnlConfirmation.Visible = false;
                });
            }
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            try
            {
                stockToRemove.stockName = txtBoxRemoveStockName.Text;
            }
            catch (Exception ex) 
            {
                lblErrorRemoveStock.Visible = true;
                lblErrorRemoveStock.Text = "There is no stock with that name, please try again...";
            }

            List<Stock> allStock = StockDal.GetAllStock();
            foreach (Stock stock in allStock) 
            {
                if(stock.stockName == stockToRemove.stockName)
                {
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
    }
}
