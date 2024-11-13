using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmViewStock : Form
    {
        public frmViewStock()
        {
            InitializeComponent();
            List<Stock> sortedStockList = StockDal.GetAllStock();

            // Add each stock in the sorted list to the stock list
            foreach (Stock stock in sortedStockList)
            {
                // Create an array with the player's username and highscore
                string[] row = { stock.stockName, stock.stockLevel.ToString()};

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the leader board list view
                lstViewStock.Items.Add(item);
            }
        }
    }
}
