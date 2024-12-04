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

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            OrderItem newOrderItem = new OrderItem();
            newOrderItem.stockId = StockDal.GetStockByStockName(cBoxStock.Text).stockId;
            newOrderItem.orderItemQuantity = Convert.ToInt32(nUDQuantity.Value);
            OrderDal.AddOrderItem(newOrderItem);
            ShowViewOrderItems();
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

        private void btnAddToStock_Click(object sender, EventArgs e)
        {
            ShowAddItemToOrder();
        }

        private void UpdateOrderItemListView()
        {
            List<OrderItem> sortedOrderItemList = OrderDal.GetAllOrderItems();

            // Add each stock in the sorted list to the stock list
            foreach (OrderItem orderItem in sortedOrderItemList)
            {
                // Create an array with stock details
                string[] row = { orderItem.stockName, orderItem.orderItemQuantity.ToString(), orderItem.stockItemOrderQuantity.ToString(), orderItem.unitPrice.ToString(), orderItem.totalPrice.ToString() };

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the stock list view
                lstViewOrderItems.Items.Add(item);
            }
        }
    }
}
