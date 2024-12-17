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
    public partial class frmAddDelivery : Form
    {
        public frmAddDelivery()
        {
            InitializeComponent();
            UpdateDeliveryListView();
        }

        private void UpdateDeliveryListView()
        {
            // create a list of orders and fill with all orders
            List<Delivery> sortedDeliveryList = DeliveryDal.GetAllDeliveries();

            foreach (ListViewItem item in lstViewDeliveries.Items)
            {
                lstViewDeliveries.Items.Remove(item);
            }

            // Add each order in the sorted list to the order list
            foreach (Delivery delivery in sortedDeliveryList)
            {
                // Create an array with order details
                string[] row = { delivery.deliveryNumber.ToString(), delivery.deliveryDate.ToString(), delivery.orderNumber.ToString() };

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the order list view
                lstViewDeliveries.Items.Add(item);
            }
        }

        private void lstViewDeliveries_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }
    }
}
