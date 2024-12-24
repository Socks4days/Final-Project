using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Models;

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
        OrderItemsDeliveredView selectedOrderItemsDeliveredView = new OrderItemsDeliveredView();
        List<OrderItemsDeliveredView> sortedOrderItemsDelivered = new List<OrderItemsDeliveredView>();
        List<DeliveryItemsView> sortedDeliveryItems = new List<DeliveryItemsView>();

        Delivery delivery;

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

        private void UpdateOrderItemsDeliveredListView(int orderNumber)
        {
            // create a list of orders and fill with all orders
            sortedOrderItemsDelivered = DeliveryDal.GetOrderItemsDeliveredView(orderNumber);

            foreach (ListViewItem item in lstViewOrderItemsDelivered.Items)
            {
                lstViewOrderItemsDelivered.Items.Remove(item);
            }

            // Add each order in the sorted list to the order list
            foreach (OrderItemsDeliveredView orderItemDelivered in sortedOrderItemsDelivered)
            {
                string orderItemStatus = "Not Received";
                string quantityReceived = "";
                string quantityFaulty = "";

                if (orderItemDelivered.quantityDelivered - orderItemDelivered.quantityFaulty >= orderItemDelivered.orderItemQuantity)
                {
                    orderItemStatus = "Fulfilled";
                }
                else if(orderItemDelivered.quantityDelivered - orderItemDelivered.quantityFaulty > 0)
                {
                    orderItemStatus = "Part Filled";
                }

                if (orderItemDelivered.quantityDelivered.HasValue)
                {
                    quantityReceived = orderItemDelivered.quantityDelivered.ToString();
                }

                if (orderItemDelivered.quantityFaulty.HasValue)
                {
                    quantityFaulty = orderItemDelivered.quantityFaulty.ToString();
                }

                // Create an array with order details
                string[] row = { orderItemDelivered.stockName, orderItemDelivered.orderItemQuantity.ToString(), orderItemStatus, quantityReceived, quantityFaulty };

                // Create a new list item based on the array
                ListViewItem item = new ListViewItem(row);

                // Add the list item to the order list view
                lstViewOrderItemsDelivered.Items.Add(item);
            }
        }

        private void UpdateDeliveryItemsListView()
        {
            foreach (ListViewItem item in lstViewDeliveryItems.Items)
            {
                lstViewDeliveryItems.Items.Remove(item);
            }

            // create a list of orders and fill with all orders
            sortedDeliveryItems = DeliveryDal.GetDeliveryItemsView(delivery.deliveryNumber);

            // Add each order in the sorted list to the order list
            foreach (DeliveryItemsView deliveryItem in sortedDeliveryItems)
            {
                // Create an array with order details
                string[] row = { deliveryItem.stockName, deliveryItem.quantityDelivered.ToString(), deliveryItem.quantityFaulty.ToString() };

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
                btnViewOrRecordDelivery.Enabled = true;
                string orderNumber = e.Item.SubItems[0].Text;
                orderToAddDelivery = OrderDal.GetOrderByOrderNumber(Convert.ToInt32(orderNumber));
            }
        }

        private void lstViewDeliveryItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // if an item in the list view is selected, set instructions text, enable the buttons and find the stock that is selected
            if (e.IsSelected)
            {
                btnAddItem.Enabled = true;
                string stockName = e.Item.SubItems[0].Text;
                //int stockId = StockDal.GetStockByStockName(stockName).stockId;
                //orderItemSelected = OrderDal.GetOrderItemByOrderNumberAndStockId(Convert.ToInt32(orderToAddDelivery.orderNumber), Convert.ToInt32(stockId));
                foreach (OrderItemsDeliveredView dIV in sortedOrderItemsDelivered)
                {
                    if (dIV.stockName == stockName)
                    {
                        selectedOrderItemsDeliveredView = dIV;
                    }
                }
            }
        }

        private void btnRecordDelivery_Click(object sender, EventArgs e)
        {
            ShowDelivery();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ShowItemToAddToDelivery();
        }

        private void ShowOrders()
        {
            btnViewOrRecordDelivery.Enabled = false;
            pnlDelivery.Visible = false;
            pnlOrders.Visible = true;
            pnlItemToAddToDelivery.Visible = false;
        }

        private void ShowDelivery()
        {
            btnAddItem.Enabled = false;
            pnlDelivery.Visible = true;
            pnlOrders.Visible = false;
            pnlDeliveryDetails.Visible = false;
            pnlItemToAddToDelivery.Visible = false;
            lblOrderNumber.Text = $"Order Number: {orderToAddDelivery.orderNumber}";
            lblOrderDate.Text = $"Order Date: {orderToAddDelivery.orderDate}";
            UpdateOrderItemsDeliveredListView(orderToAddDelivery.orderNumber);
        }

        private void ShowItemToAddToDelivery()
        {
            pnlDelivery.Visible = false;
            pnlOrders.Visible = false;
            pnlItemToAddToDelivery.Visible = true;
            lblSelectedItem.Text = $"Item To Add: {selectedOrderItemsDeliveredView.stockName}";
            lblSelectedItemQuantity.Text = $"Quantity Ordered: {selectedOrderItemsDeliveredView.orderItemQuantity}";
            SetNumberUpDownValues();
        }

        private void ShowDeliveryDetails()
        {
            pnlDeliveryDetails.Visible = true;
            btnRecordDeliveryForOrder.Enabled = false;
            lblDeliveryNumber.Text = $"Delivery Number: {delivery.deliveryNumber}";
            lblDeliveryDate.Text = $"Delivery Date: {delivery.deliveryDate}";
            UpdateDeliveryItemsListView();
        }

        private void SetNumberUpDownValues()
        {
            nUDQuantityDelivered.Maximum = selectedOrderItemsDeliveredView.orderItemQuantity;
            nUDQuantityFaulty.Maximum = selectedOrderItemsDeliveredView.orderItemQuantity;
            nUDQuantityDelivered.Value = 1;
            nUDQuantityFaulty.Value = 0;
        }

        private void btnAddItemToDelivery_Click(object sender, EventArgs e)
        {
            int quantityDelivered = (int)nUDQuantityDelivered.Value;
            int quantityFaulty = (int)nUDQuantityFaulty.Value;
            DeliveryItem item = new DeliveryItem();
            item.quantityDelivered = quantityDelivered;
            item.quantityFaulty = quantityFaulty;
            item.deliveryNumber = delivery.deliveryNumber;
            item.stockId = selectedOrderItemsDeliveredView.stockId;
            DeliveryDal.AddDeliveryItem(item);

            Stock stock = StockDal.GetStockByStockId(orderItemSelected.stockId);
            stock.stockLevel = stock.stockLevel + quantityDelivered - quantityFaulty;
            StockDal.UpdateStockInformation(stock);

            ShowDelivery();
            ShowDeliveryDetails();
        }

        private void btnRecordDeliveryForOrder_Click(object sender, EventArgs e)
        {
            delivery = new Delivery();
            delivery.deliveryDate = DateTime.Now;
            delivery.orderNumber = orderToAddDelivery.orderNumber;
            delivery = DeliveryDal.AddDelivery(delivery);
            ShowDeliveryDetails();
        }

        private void btnMarkDeliveryAsCompleted_Click(object sender, EventArgs e)
        {
            pnlDeliveryDetails.Visible = false;
            btnRecordDeliveryForOrder.Enabled = true;
        }
    }
}