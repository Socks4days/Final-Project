using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Models;

namespace Final_Project
{
    public partial class frmViewOrders : Form
    {
        public frmViewOrders()
        {
            InitializeComponent();
            UpdateOrderListView();
            DisableButtons();
        }

        private void UpdateOrderListView()
        {
            List<Order> sortedOrderItemList = OrderDal.GetAllOrders();

            decimal orderTotal = 0;
            foreach (ListViewItem item in lstViewOrders.Items)
            {
                lstViewOrders.Items.Remove(item);
            }

            // Add each stock in the sorted list to the stock list
            foreach (Order order in sortedOrderItemList)
            {
                // Create an array with stock details
                string[] row = { order.orderNumber.ToString(), order.orderStatus, order.orderDate.ToString() };

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the stock list view
                lstViewOrders.Items.Add(item);
            }
        }

        private void DisableButtons()
        {
            btnEditOrder.Enabled = false;
            btnViewOrder.Enabled = false;
        }

        private string orderStatus = "";
        private Order order;
        private void lstViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                btnViewOrder.Enabled = true;
                orderStatus = e.Item.SubItems[1].Text;
                order = OrderDal.GetOrderByOrderNumber(Convert.ToInt32(e.Item.SubItems[0].Text));
            }
            else
            {
                orderStatus = "";
                DisableButtons();
            }
            if (orderStatus == "Draft" || orderStatus == "To Start")
            {
                btnEditOrder.Enabled = true;
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            frmMainScreen.frmMain.OpenChildForm(new frmCreateOrUpdateOrder(order));
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            frmMainScreen.frmMain.OpenChildForm(new frmCreateOrUpdateOrder(order));
        }
    }
}
