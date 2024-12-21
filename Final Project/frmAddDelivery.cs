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
        DeliveryItemsView selectedDeliveryItemsView = new DeliveryItemsView();
        List<DeliveryItemsView> sortedDeliveryItemList = new List<DeliveryItemsView>();
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

        private void UpdateDeliveryItemListView(int orderNumber)
        {
            // create a list of orders and fill with all orders
            sortedDeliveryItemList = DeliveryDal.GetDeliveryItemsView(orderNumber);

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

        private void lstViewDeliveryItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // if an item in the list view is selected, set instructions text, enable the buttons and find the stock that is selected
            if (e.IsSelected)
            {
                btnAddItem.Enabled = true;
                string stockName = e.Item.SubItems[0].Text;
                //int stockId = StockDal.GetStockByStockName(stockName).stockId;
                //orderItemSelected = OrderDal.GetOrderItemByOrderNumberAndStockId(Convert.ToInt32(orderToAddDelivery.orderNumber), Convert.ToInt32(stockId));
                foreach (DeliveryItemsView dIV in sortedDeliveryItemList)
                {
                    if (dIV.stockName == stockName)
                    {
                        selectedDeliveryItemsView = dIV;
                    }
                }
            }
        }

        private void btnRecordDelivery_Click(object sender, EventArgs e)
        {
            delivery = new Delivery();
            delivery.deliveryDate = DateTime.Now;
            delivery.orderNumber = orderToAddDelivery.orderNumber;
            delivery = DeliveryDal.AddDelivery(delivery);
            ShowDelivery();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            ShowItemToAddToDelivery();
        }

        private void ShowOrders()
        {
            btnRecordDelivery.Enabled = false;
            pnlDelivery.Visible = false;
            pnlOrders.Visible = true;
            pnlItemToAddToDelivery.Visible = false;
        }

        private void ShowDelivery()
        {
            btnAddItem.Enabled = false;
            pnlDelivery.Visible = true;
            pnlOrders.Visible = false;
            pnlItemToAddToDelivery.Visible = false;
            lblOrderNumber.Text = $"Order Number: {orderToAddDelivery.orderNumber}";
            lblDate.Text = $"Order Date: {orderToAddDelivery.orderDate}";
            UpdateDeliveryItemListView(orderToAddDelivery.orderNumber);
        }

        private void ShowItemToAddToDelivery()
        {
            pnlDelivery.Visible = false;
            pnlOrders.Visible = false;
            pnlItemToAddToDelivery.Visible = true;
            lblSelectedItem.Text = $"Item To Add: {selectedDeliveryItemsView.stockName}";
            lblSelectedItemQuantity.Text = $"Quantity Ordered: {selectedDeliveryItemsView.orderItemQuantity}";
            SetNumberUpDownValues();
        }

        private void SetNumberUpDownValues()
        {
            nUDQuantityDelivered.Maximum = selectedDeliveryItemsView.orderItemQuantity;
            nUDQuantityFaulty.Maximum = selectedDeliveryItemsView.orderItemQuantity;
        }

        private void btnAddItemToDelivery_Click(object sender, EventArgs e)
        {
            int quantityDelivered = (int)nUDQuantityDelivered.Value;
            int quantityFaulty = (int)nUDQuantityFaulty.Value;
            DeliveryItem item = new DeliveryItem();
            item.quantityDelivered = quantityDelivered;
            item.quantityFaulty = quantityFaulty;
            item.deliveryNumber = delivery.deliveryNumber;
            item.stockId = selectedDeliveryItemsView.stockId;
            DeliveryDal.AddDeliveryItem(item);

            Stock stock = StockDal.GetStockByStockId(orderItemSelected.stockId);
            stock.stockLevel = stock.stockLevel + quantityDelivered - quantityFaulty;
            StockDal.UpdateStockInformation(stock);

            ShowDelivery();
        }
    }
}