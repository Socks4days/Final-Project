using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmAddOrRemoveStockType : Form
    {
        public frmAddOrRemoveStockType()
        {
            InitializeComponent();
            ShowStockDetails();
        }
        Stock newStock = new Stock();

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {

            newStock.stockName = txtBoxNewStockName.Text;
            newStock.stockDescription = txtBoxNewStockDescription.Text;
            newStock.price = Convert.ToDecimal(txtBoxNewStockPrice.Text);
            newStock.maximumLevel = Convert.ToInt32(txtBoxNewMaximumLevel.Text);
            newStock.minimumLevel = Convert.ToInt32(txtBoxNewMinimumLevel.Text);

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
            StockDal.AddNewStock(newStock);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ShowStockDetails();
            txtBoxNewStockName.Text = newStock.stockName;
            txtBoxNewStockDescription.Text = newStock.stockDescription;
            txtBoxNewStockPrice.Text = newStock.price.ToString();
            txtBoxNewMaximumLevel.Text = newStock.maximumLevel.ToString();
            txtBoxNewMinimumLevel.Text = newStock.minimumLevel.ToString();
        }
    }
}
