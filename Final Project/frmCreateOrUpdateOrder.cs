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
	public partial class frmCreateOrUpdateOrder : Form
	{
		public frmCreateOrUpdateOrder(Order order, string viewToShow)
		{
			InitializeComponent();
			// create an instance of the order passed in
			this.order = order;

			// creates a list of order items for an order
			this.sortedOrderItemList = new List<OrderItem>();

			// add values to the combo box for stock
			PopulateComboBox();

			// make sure it isn't showing anything when initially show into the form
			cBoxStock.DroppedDown = false;
			cBoxStock.Text = "";

			// hide the confirmation panel
			pnlOrderConfirmation.Visible = false;
			pnlAddItemToOrder.Visible = false;

			// update the list view to show all items in the order
			UpdateOrderItemListView();

			// check if an order is ready to start or if it is a draft
			if (order.orderStatus == "Draft" && viewToShow == "Edit")
			{
				// if it is, show the options buttons
				btnAddAnItemToOrder.Visible = true;
				btnRemoveFromOrder.Visible = true;
				btnSaveAsDraft.Visible = true;
				btnPlaceOrder.Visible = true;
				lstViewOrderItems.FullRowSelect = true;
			}
			else
			{
				// if it is not, hide the options buttons
				btnAddAnItemToOrder.Visible = false;
				btnRemoveFromOrder.Visible = false;
				btnSaveAsDraft.Visible = false;
				btnPlaceOrder.Visible = false;
			}

			if (viewToShow == "Edit")
			{
				// if the edit view is to be shown, show the option buttons, show the instructions and allow user to select a full row
				lblInstructions.Visible = true;
				lstViewOrderItems.FullRowSelect = true;
			}
			if (viewToShow == "View")
			{
				// if the user is only viewing, hide option buttons, instructions and disallow full row selection
				lblInstructions.Visible = false;
				lstViewOrderItems.FullRowSelect = false;
				lblWarning.Visible = false;
			}
			// show the view table
			ShowViewOrderItems();

			// set labels to appropriate data depending on the order
			lblOrderNumberOrder.Text = "Order Number " + order.orderNumber.ToString();
			lblOrderStatus.Text = "Order Status: " + order.orderStatus;
		}

		// lists and order for use throughout the form
		Order order;
		List<Stock> allStock = StockDal.GetAllStock();
		List<string> allStockNames = new List<string>();
		List<OrderItem> sortedOrderItemList;
		int warningNumber = 0;

		// method to give values to the combo box for selection
		private void PopulateComboBox()
		{
			// get a list of all items in an order 
			sortedOrderItemList = OrderDal.GetAllOrderItems(this.order.orderNumber);
			allStockNames.Clear();
			// add all stock names to a list
			foreach (Stock stock in allStock)
			{
				allStockNames.Add(stock.stockName);
			}

			// remove all stock names of each order item from the stock name list
			foreach (OrderItem orderItem in sortedOrderItemList)
			{
				allStockNames.Remove(orderItem.stockName);
			}

			allStockNames = allStockNames.OrderBy(x => x).ToList();

			// populate the combo box with this new list
			cBoxStock.DataSource = allStockNames;
		}

		// method to add an item to an order
		private void btnAddToOrder_Click(object sender, EventArgs e)
		{
			if (cBoxStock.Text == "")
			{
				lblWarning.Visible = true;
				lblWarning.Text = "Select an item to add to order.";
				return;
			}

			Stock stockToAdd = StockDal.GetStockByStockName(cBoxStock.Text);
			if (((stockToAdd.stockLevel + (nUDQuantity.Value * stockToAdd.orderQuantity)) > stockToAdd.maximumLevel) && (warningNumber == 0))
			{
				lblWarning.Visible = true;
				lblWarning.Text = "This amount is greater than storage can hold. Click 'Add To Order' again to continue.";
				warningNumber = 1;
				return;
			}

			// create an order item with the data input by the user
			OrderItem newOrderItem = new OrderItem
			{
				stockId = StockDal.GetStockByStockName(cBoxStock.Text).stockId,
				orderItemQuantity = Convert.ToInt32(nUDQuantity.Value),
				orderNumber = this.order.orderNumber
			};
			// add new order item to the order
			OrderDal.AddOrderItem(newOrderItem);
			cBoxStock.DataSource = null;
			allStockNames.Remove(stockToAdd.stockName);
			cBoxStock.DataSource = allStockNames;
			cBoxStock.Text = "";

			// refresh the list view
			UpdateOrderItemListView();
			// show the list view of order items
			ShowViewOrderItems();
		}

		// method to remove an item from an order
		private void btnRemoveFromOrder_Click(object sender, EventArgs e)
		{
			// create new instance of an order item
			OrderItem item = new OrderItem();
			// give values to order item
			item.stockId = frmEditStockLevels.lookupStock.stockId;
			item.orderNumber = order.orderNumber;
			// remove item from order
			OrderDal.RemoveOrderItem(item);
			// update list view to show change
			UpdateOrderItemListView();
		}

		// method to cancel adding a new item to an order
		private void btnCancel_Click(object sender, EventArgs e)
		{
			// go back to the view of order items
			ShowViewOrderItems();
		}

		// method to show the view order items panel
		private void ShowViewOrderItems()
		{
			pnlAddItemToOrder.Visible = false;
			pnlOrderConfirmation.Visible = false;
			pnlViewOrderItems.Visible = true;
			pnlViewOrderItems.Dock = DockStyle.Fill;
			pnlOrderNoToStat.Dock = DockStyle.Bottom;
			pnlOrderInfo.Dock = DockStyle.Fill;
		}

		// method to show the add item to order panel
		private void ShowAddItemToOrder()
		{
			pnlViewOrderItems.Visible = false;
			pnlAddItemToOrder.Visible = true;
			lblWarning.Visible = false;
			lblOrderNumberItem.Text = "Order Number " + order.orderNumber.ToString();
			warningNumber = 0;
		}

		// button click to show the add item to order panel
		private void btnAddAnItemToOrder_Click(object sender, EventArgs e)
		{
			ShowAddItemToOrder();
		}

		decimal orderTotal = 0;

		// method to update the list view of items in an order
		private void UpdateOrderItemListView()
		{
			// create a list of items that are equal to all of the order items for a specific order
			List<OrderItem> sortedOrderItemList = OrderDal.GetAllOrderItems(this.order.orderNumber);


			foreach (ListViewItem item in lstViewOrderItems.Items)
			{
				// reset list view back to nothing
				lstViewOrderItems.Items.Remove(item);
			}

			// Reset order total to 0
			orderTotal = 0;
			// Add each stock in the sorted list to the stock list
			foreach (OrderItem orderItem in sortedOrderItemList)
			{
				// Create an array with information of each order item in an order
				string[] row = { orderItem.stockName, orderItem.unitSize.ToString(), orderItem.unitPrice.ToString(), orderItem.orderItemQuantity.ToString(), orderItem.totalPrice.ToString() };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the order item list view
				lstViewOrderItems.Items.Add(item);

				// add each items price to the total
				orderTotal += orderItem.totalPrice;
			}
			// set the value of the order total to the label
			lblOrderTotal.Text = $"Order Total: £{orderTotal}";
		}
		private void lstViewOrderItems_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// if an item in the list view is selected, set instructions text, enable the buttons and find the stock that is selected
			if (e.IsSelected)
			{
				lblInstructions.Text = "Select an option to proceed";
				btnRemoveFromOrder.Enabled = true;
				btnPlaceOrder.Enabled = true;
				btnSaveAsDraft.Enabled = true;
				string stockName = e.Item.SubItems[0].Text;
				frmEditStockLevels.LookupStock(stockName);
			}
		}

		private void btnPlaceOrder_Click(object sender, EventArgs e)
		{
			pnlOrderInfo.Dock = DockStyle.Top;
			pnlOrderNoToStat.Visible = false;
			pnlOrderConfirmation.Visible = true;
			pnlOrderConfirmation.Dock = DockStyle.Bottom;
			pnlOrderInfo.Dock = DockStyle.Fill;
			btnConfirmAndPlace.Enabled = true;
			lblFinalOrderTotal.Text = $"Order Total: £{orderTotal.ToString()}";
			lblDeliveringTo.Text = $"Order For: Maintenance Department, Movers Ltd";
		}

		private void btnSaveAsDraft_Click(object sender, EventArgs e)
		{
			// set status to a draft and close the form
			order.orderStatus = "Draft";
			OrderDal.UpdateOrderStatus(order);
			frmMainScreen.frmMain.OpenChildForm(new frmViewOrders(), frmMainScreen.frmMain.btnViewOrders);
		}

		private void btnConfirmAndPlace_Click(object sender, EventArgs e)
		{
			btnConfirmAndPlace.Enabled = false;
			// set the order status to 'placed' and save it
			order.orderStatus = "Placed";
			lblOrderStatus.Text = $"Order Status: {order.orderStatus}";
			OrderDal.UpdateOrderStatus(order);
			frmMainScreen.frmMain.OpenChildForm(new frmViewOrders(), frmMainScreen.frmMain.btnViewOrders);
		}

		private void btnReturnToEditScreen_Click(object sender, EventArgs e)
		{
			pnlOrderNoToStat.Visible = true;
			pnlOrderConfirmation.Visible = false;
			pnlOrderInfo.Height = (lstViewOrderItems.Height + pnlOrderNoToStat.Height);
			pnlViewOrderItems.Height = pnlOrderInfo.Height;
		}

		private void cBoxStock_SelectionChangeCommitted(object sender, EventArgs e)
		{
			string stockName = cBoxStock.Text;
			Stock selectedStock = StockDal.GetStockByStockName(stockName);
			lblCurrentStockLevel.Text = $"Current Stock Level: {selectedStock.stockLevel}";
		}

		private void pnlOrderInfo_Resize(object sender, EventArgs e)
		{
			lstViewOrderItems.Height = pnlOrderInfo.Height - 50;
		}

		
	}
}