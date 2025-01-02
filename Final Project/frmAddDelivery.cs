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
			orderToAddDelivery = null;			
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
				if (order.orderStatus == Order.Placed || order.orderStatus == Order.PartFilled || order.orderStatus == Order.Fulfilled)
				{
					// Create an array with order details
					string[] row = { order.orderNumber.ToString(), order.orderDate.ToString(), order.orderStatus };

					// Create a new list item based on the array
					ListViewItem item = new ListViewItem(row);

					// Add the list item to the order list view
					lstViewOrders.Items.Add(item);
				}
			}
		}

		string orderItemStatus = Order.NotReceived;

		private void UpdateOrderItemsDeliveredListView(int orderNumber)
		{
			// create a list of orders and fill with all orders
			sortedOrderItemsDelivered = DeliveryDal.GetOrderItemsDeliveredView(orderNumber);

			foreach (ListViewItem item in lstViewOrderItemsDelivered.Items)
			{
				lstViewOrderItemsDelivered.Items.Remove(item);
			}

			string currentOrderStatus = orderToAddDelivery.orderStatus;
			string newOrderStatus = currentOrderStatus;
			bool allOrderItemsFulfilled = true;
			bool allOrderItemsNotReceived = true;

			// Add each order in the sorted list to the order list
			foreach (OrderItemsDeliveredView orderItemDelivered in sortedOrderItemsDelivered)
			{
				string quantityReceived = "";
				string quantityFaulty = "";

				if (orderItemDelivered.quantityDelivered - orderItemDelivered.quantityFaulty >= orderItemDelivered.orderItemQuantity)
				{
					// Order item fulfilled
					orderItemStatus = Order.Fulfilled;
					allOrderItemsNotReceived = false;
				}
				else if (orderItemDelivered.quantityDelivered - orderItemDelivered.quantityFaulty > 0)
				{
					// Order item part filled
					orderItemStatus = Order.PartFilled;
					allOrderItemsNotReceived = false;
					allOrderItemsFulfilled = false;
				}
				else
				{
					// Order item not received
					orderItemStatus = Order.NotReceived;
					allOrderItemsFulfilled = false;
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

			// Check if overall order status needs updated
			if (allOrderItemsFulfilled == true)
			{
				// If all order items are fulfilled, set the order status to fulfilled
				newOrderStatus = Order.Fulfilled;
			}
			else if (allOrderItemsNotReceived == true)
			{
				// If all order items are still not received, leave the order status as placed
				newOrderStatus = Order.Placed;
			}
			else
			{
				// Otherwise set the order status to part filled
				newOrderStatus = Order.PartFilled;
			}

			if (newOrderStatus != currentOrderStatus)
			{
				// Order status has changed so update it
				orderToAddDelivery.orderStatus = newOrderStatus;
				OrderDal.UpdateOrderStatus(orderToAddDelivery);
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

		private void lstViewOrderItemsDelivered_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// if an item in the list view is selected, set instructions text, enable the buttons and find the stock that is selected
			if (e.IsSelected)
			{
				btnAddItem.Enabled = true;
				string stockName = e.Item.SubItems[0].Text;
				orderItemStatus = e.Item.SubItems[2].Text;
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
			if (orderToAddDelivery != null)
			{
				ShowDelivery();
			}
			else
			{
				lblOrderError.Visible = true;
				lblOrderError.Text = "Select an order to add a delivery!";
			}
		}

		private void btnAddItem_Click(object sender, EventArgs e)
		{
			if (orderItemStatus != Order.Fulfilled)
			{
				foreach(ListViewItem item in lstViewDeliveryItems.Items)
				{
					if (item.SubItems[0].Text == selectedOrderItemsDeliveredView.stockName)
					{
						lblDeliveryItemError.Visible = true;
						lblDeliveryItemError.Text = "You have already added that item in this delivery";
						return;
					}			
				}
				ShowItemToAddToDelivery();
			}
				
			else 
			{
				lblDeliveryItemError.Visible = true;
				lblDeliveryItemError.Text = "Item already fully delivered!";
			}
		}

		private void ShowOrders()
		{
			pnlDelivery.Visible = false;
			pnlOrders.Visible = true;
			pnlItemToAddToDelivery.Visible = false;
			lblOrderError.Visible = false;
			UpdateOrderListView();
		}

		private void ShowDelivery()
		{
			btnAddItem.Enabled = false;
			pnlDelivery.Visible = true;
			pnlOrders.Visible = false;
			pnlDeliveryDetails.Visible = false;
			pnlItemToAddToDelivery.Visible = false;
			lblDeliveryItemError.Visible = false;
			lblOrderNumber.Text = $"Order Number: {orderToAddDelivery.orderNumber}";
			lblOrderDateAndStatus.Text = $"Placed On: {orderToAddDelivery.orderDate}  ({orderToAddDelivery.orderStatus})";
			UpdateOrderItemsDeliveredListView(orderToAddDelivery.orderNumber);
		}

		private int itemsOrdered;
		private int itemsReceived;
		private int itemsFaulty;
		private int itemsRemaining;
		private void ShowItemToAddToDelivery()
		{
			itemsOrdered = selectedOrderItemsDeliveredView.orderItemQuantity;
			if (selectedOrderItemsDeliveredView.quantityDelivered == null)
			{
				itemsReceived = 0;
			}
			else
			{
				itemsReceived = (int) selectedOrderItemsDeliveredView.quantityDelivered;
			}
			if (selectedOrderItemsDeliveredView.quantityFaulty == null)
			{
				itemsFaulty = 0;
			}
			else
			{
				itemsFaulty = (int)selectedOrderItemsDeliveredView.quantityFaulty;
			}
			itemsRemaining = itemsOrdered - itemsReceived + itemsFaulty;
			pnlDelivery.Visible = false;
			pnlOrders.Visible = false;
			pnlItemToAddToDelivery.Visible = true;
			lblSelectedItem.Text = $"Item: {selectedOrderItemsDeliveredView.stockName}";
			lblSelectedItemQuantity.Text = $"Ordered: {itemsOrdered}\n"
				+ $"Received: {itemsReceived}\n"
				+ $"Faulty: {itemsFaulty}\n"
				+ $"Remaining: {itemsRemaining}";
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
			nUDQuantityDelivered.Maximum = itemsRemaining;
			nUDQuantityFaulty.Maximum = itemsRemaining;
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
			if (orderToAddDelivery.orderStatus != Order.Fulfilled && orderToAddDelivery.orderStatus != Order.Completed)
			{
				delivery = new Delivery();
				delivery.deliveryDate = DateTime.Now;
				delivery.orderNumber = orderToAddDelivery.orderNumber;
				delivery = DeliveryDal.AddDelivery(delivery);
				ShowDeliveryDetails();
			}
			else
			{
				lblDeliveryItemError.Visible = true;
				lblDeliveryItemError.Text = "All items are fully delivered!";
			}
		}

		private void btnMarkDeliveryAsCompleted_Click(object sender, EventArgs e)
		{
			pnlDeliveryDetails.Visible = false;
			btnRecordDeliveryForOrder.Enabled = true;
		}

		private void frmAddDelivery_Resize(object sender, EventArgs e)
		{
			lstViewOrders.Height = pnlOrders.Height - 282;
		}

		private void btnMarkOrderAsCompleted_Click(object sender, EventArgs e)
		{
			orderToAddDelivery.orderStatus = Order.Completed;
			OrderDal.UpdateOrderStatus(orderToAddDelivery);
			ShowOrders();
		}

		
	}
}