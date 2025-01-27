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
			// update list view and disable all buttons
			UpdateOrderListView();
			DisableButtons();
		}

		private string orderStatus = "";
		private Order order;		

		#region ButtonPermissions

		// method to disable edit and view buttons 
		private void DisableButtons()
		{
			btnEditOrder.Enabled = false;
			btnViewOrder.Enabled = false;
		}

		#endregion ButtonPermissions

		#region ButtonClicks

		private void btnEditOrder_Click(object sender, EventArgs e)
		{
			// when edit is clicked, show the edit screen on update a order
			frmMainScreen.frmMain.OpenChildForm(new frmCreateOrUpdateOrder(order, "Edit"), frmMainScreen.frmMain.btnViewOrders);
		}

		private void btnViewOrder_Click(object sender, EventArgs e)
		{
			// when view is clicked, show the view order screen on create or update screen
			frmMainScreen.frmMain.OpenChildForm(new frmCreateOrUpdateOrder(order, "View"), frmMainScreen.frmMain.btnViewOrders);
		}

		#endregion ButtonClicks

		#region ListViewFunctions

		// method to update what the order list view shows
		private void UpdateOrderListView()
		{
			// create a list of orders and fill with all orders
			List<Order> sortedOrderItemList = OrderDal.GetAllOrders();

			decimal orderTotal = 0;
			foreach (ListViewItem item in lstViewOrders.Items)
			{
				lstViewOrders.Items.Remove(item);
			}

			// Add each order in the sorted list to the order list
			foreach (Order order in sortedOrderItemList)
			{
				Staff staff = StaffDal.GetStaffByStaffId(order.orderPlacedByStaffId);
				string staffFullName = $"{staff.forename} {staff.surname}";
				// Create an array with order details
				string[] row = { order.orderNumber.ToString(), order.orderStatus, order.orderDate.ToString(), staffFullName };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the order list view
				lstViewOrders.Items.Add(item);
			}
		}

		// method that handles things when an item is selected in the list view
		private void lstViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
			{
				// enable buttons and set order status and then find the order
				btnViewOrder.Enabled = true;
				orderStatus = e.Item.SubItems[1].Text;
				order = OrderDal.GetOrderByOrderNumber(Convert.ToInt32(e.Item.SubItems[0].Text));
			}
			else
			{
				// if the order has no status, disable buttons
				orderStatus = "";
				DisableButtons();
			}
			if (orderStatus == "Draft" || orderStatus == "To Start")
			{
				// if the status is draft or to start, allow the user to edit the order
				btnEditOrder.Enabled = true;
			}
		}

		#endregion ListViewFunctions		

		#region Resizing

		private void frmViewOrders_Resize(object sender, EventArgs e)
		{
			lstViewOrders.Height = pnlOrderInfo.Height - 180;
		}

		#endregion Resizing
	}
}