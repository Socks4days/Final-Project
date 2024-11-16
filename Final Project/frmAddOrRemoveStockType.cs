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
        public frmAddOrRemoveStockType()
        {
            InitializeComponent();
            ShowStockDetails();
            lblError.Visible = false;
            lblSuccess.Visible = false;
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
        }
        Stock newStock = new Stock();

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            try
            {
                newStock.stockName = txtBoxNewStockName.Text;
                newStock.stockDescription = txtBoxNewStockDescription.Text;
                newStock.price = Convert.ToDecimal(txtBoxNewStockPrice.Text);
                newStock.maximumLevel = Convert.ToInt32(txtBoxNewMaximumLevel.Text);
                newStock.minimumLevel = Convert.ToInt32(txtBoxNewMinimumLevel.Text);
            }
            catch(Exception ex)
            {
                lblError.Visible = true;
                lblError.Text = "Insufficient details have been provided, please try again.";
                return;
            }            

            ShowConfirmation();
            lblStockTo.Text = "Stock To Add:";
            lblStockName.Text = $"Stock Name: {newStock.stockName}";
            lblStockDescription.Text = $"Stock Description: {newStock.stockDescription}";
            lblPrice.Text = $"Price: {newStock.price}";
            lblMaximumLevel.Text = $"Maximum Level: {newStock.maximumLevel}";
            lblMinimumLevel.Text = $"Minimum Level: {newStock.minimumLevel}";
        }

        private void ShowConfirmation()
        {
            pnlConfirmation.Visible = true;
            pnlAddNewStock.Visible = false;
        }

        private void ShowStockDetails()
        {
            pnlAddNewStock.Visible = true;
            pnlConfirmation.Visible = false;
        }
               
        private void btnConfirmed_Click(object sender, EventArgs e)
        {
            count = 0;
            timer.Start();
            lblSuccess.Visible = true;
            lblSuccess.Text = "New stock added successfully! Returning to previous screen in 3 seconds...";
            StockDal.AddNewStock(newStock);           
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ShowStockDetails();
            lblError.Visible = false;
            txtBoxNewStockName.Text = newStock.stockName;
            txtBoxNewStockDescription.Text = newStock.stockDescription;
            txtBoxNewStockPrice.Text = newStock.price.ToString();
            txtBoxNewMaximumLevel.Text = newStock.maximumLevel.ToString();
            txtBoxNewMinimumLevel.Text = newStock.minimumLevel.ToString();
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
                    pnlAddNewStock.Visible = true;
                    pnlConfirmation.Visible = false;
                });
            }
        }
    }
}
