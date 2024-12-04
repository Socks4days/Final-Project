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
    public partial class frmCreateOrder : Form
    {
        public frmCreateOrder()
        {
            InitializeComponent();
            PopulateComboBoxes();
            cBoxStock.DroppedDown = false;
            ShowViewOrderItems();
        }

        List<Stock> allStock = StockDal.GetAllStock();
        List<string> allStockNames = new List<string>();

        private void PopulateComboBoxes()
        {
            foreach (Stock stock in allStock)
            {
                allStockNames.Add(stock.stockName);
            }

            cBoxStock.DataSource = allStockNames;
            cBoxStock.DisplayMember = "Name";
        }

        private void cBoxStock_TextChanged(object sender, EventArgs e)
        {
            string filter = cBoxStock.Text.ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                cBoxStock.DataSource = allStockNames; // Reset to original list
            }
            else
            {
                var filteredList = allStockNames.Where(obj => obj.ToLower().Contains(filter)).ToList();
                cBoxStock.DataSource = filteredList;
                cBoxStock.DroppedDown = true;
            }
            cBoxStock.SelectionStart = cBoxStock.Text.Length;

        }

        private void btnAddToBasket_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowViewOrderItems();
        }

        private void ShowViewOrderItems()
        {
            pnlViewOrderItems.Visible = true;
            pnlAddItemToOrder.Visible = false;
        }

        private void ShowAddItemToOrder()
        {
            pnlViewOrderItems.Visible = false;
            pnlAddItemToOrder.Visible = true;
        }
    }
}
