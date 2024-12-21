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
            UpdateOrderListView();
            ShowOrders();
        }

        Order orderToAddDelivery = new Order();
        OrderItem orderItemSelected = new OrderItem();
        List<DeliveryItem> deliveryItemsToBeAdded = new List<DeliveryItem>();

        private void UpdateOrderListView()
        {
            // create a list of orders and fill with all orders
            List<Order> sortedOrderList = OrderDal.GetAllOrders();

            foreach (ListViewItem item in lstViewOrders.Items)
            {
                lstViewOrders.Items.Remove(item);
            }

            // Add each order in the sorted list to the order list
            foreach (Order order in sortedOrderList)
            {
                if (order.orderStatus == "Placed")
                {
                    // Create an array with order details
                    string[] row = { order.orderNumber.ToString(), order.orderDate.ToString() };

                    // Create a new list item based on the array
                    ListViewItem item = new ListViewItem(row);

                    // Add the list item to the order list view
                    lstViewOrders.Items.Add(item);
                }
            }
        }
        private void UpdateOrderItemListView(int orderNumber)
        {
            // create a list of orders and fill with all orders
            List<OrderItem> sortedOrderItemList = OrderDal.GetAllOrderItems(orderNumber);

            foreach (ListViewItem item in lstViewOrderItems.Items)
            {
                lstViewOrderItems.Items.Remove(item);
            }

            // Add each order in the sorted list to the order list
            foreach (OrderItem orderItem in sortedOrderItemList)
            {
                // Create an array with order details
                string[] row = { orderItem.stockName, orderItem.orderItemQuantity.ToString() };

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the order list view
                lstViewOrderItems.Items.Add(item);
            }
        }

        private void UpdateDeliveryItemListView(int orderNumber)
        {
            // create a list of orders and fill with all orders
            List<DeliveryItemsView> sortedDeliveryItemList = DeliveryDal.GetDeliveryItemsView(orderNumber);

            foreach (ListViewItem item in lstViewDeliveryItems.Items)
            {
                lstViewDeliveryItems.Items.Remove(item);
            }

            // Add each order in the sorted list to the order list
            foreach (DeliveryItemsView deliveryItem in sortedDeliveryItemList)
            {
                string delivered = "Not Received";
                string quantityReceived = "";
                string quantityFaulty = "";

                if (deliveryItem.deliveryDate.HasValue)
                {
                    delivered = deliveryItem.deliveryDate.ToString();
                }

                if (deliveryItem.quantityDelivered.HasValue)
                {
                    quantityReceived = deliveryItem.quantityDelivered.ToString();
                }

                if (deliveryItem.quantityFaulty.HasValue)
                {
                    quantityFaulty = deliveryItem.quantityFaulty.ToString();
                }

                // Create an array with order details
                string[] row = { deliveryItem.stockName, deliveryItem.orderItemQuantity.ToString(), delivered, quantityReceived, quantityFaulty };

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the order list view
                lstViewDeliveryItems.Items.Add(item);
            }
        }
        private void lstViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // if an item in the list view is selected, set instructions text, enable the buttons and find the stock that is selected
            if (e.IsSelected)
            {
                btnRecordDelivery.Enabled = true;
                string orderNumber = e.Item.SubItems[0].Text;
                orderToAddDelivery = OrderDal.GetOrderByOrderNumber(Convert.ToInt32(orderNumber));
            }
        }

        private void btnRecordDelivery_Click(object sender, EventArgs e)
        {
            ShowDelivery();                       
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ShowOrderItems();
        }

        private void ShowOrders()
        {
            pnlDelivery.Visible = false;
            pnlOrderItems.Visible = false;
            pnlOrders.Visible = true;
            pnlItemToAddToDelivery.Visible = false;
        }

        private void ShowOrderItems()
        {
            pnlDelivery.Visible = false;
            pnlOrderItems.Visible = true;
            pnlOrders.Visible = false;
            pnlItemToAddToDelivery.Visible = false;
            UpdateOrderItemListView(orderToAddDelivery.orderNumber);
        }

        private void ShowDelivery()
        {
            pnlDelivery.Visible = true;
            pnlOrderItems.Visible = false;
            pnlOrders.Visible = false;
            pnlItemToAddToDelivery.Visible = false;
            lblOrderNumber.Text = orderToAddDelivery.orderDate.ToString();
            UpdateDeliveryItemListView(orderToAddDelivery.orderNumber); 
        }

        private void ShowItemToAddToDelivery()
        {
            pnlDelivery.Visible = false;
            pnlOrderItems.Visible = false;
            pnlOrders.Visible = false;
            pnlItemToAddToDelivery.Visible = true;
            lblSelectedItem.Text = $"Item To Add: {orderItemSelected.stockName}";
            lblSelectedItemQuantity.Text = $"Quantity Ordered: {orderItemSelected.orderItemQuantity}";
        }

        private void lstViewOrderItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // if an item in the list view is selected, set instructions text, enable the buttons and find the stock that is selected
            if (e.IsSelected)
            {
                btnRecordItem.Enabled = true;
                btnRecordDelivery.Enabled = true;
                string stockName = e.Item.SubItems[0].Text;
                int stockId = StockDal.GetStockByStockName(stockName).stockId;
                orderItemSelected = OrderDal.GetOrderItemByOrderNumberAndStockId(orderItemSelected.orderNumber, stockId);
            }
        }

        private void btnRecordItem_Click(object sender, EventArgs e)
        {

        }
    }
}
