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
            PopulateComboBox("cBoxStock");

            // make sure it isn't showing anything when initially show into the form
            cBoxStock.DroppedDown = false;

            // hide the confirmation panel
            pnlOrderConfirmation.Visible = false;

            // update the list view to show all items in the order
            UpdateOrderItemListView();

            // check if an order is ready to start or if it is a draft
            if (order.orderStatus == "To Start" || order.orderStatus == "Draft")
            {
                // if it is, show the options buttons
                pnlOptions.Visible = true;
            }
            else
            {
                // if it is not, hide the options buttons
                pnlOptions.Visible = false;
            }
            if (viewToShow == "Edit")
            {
                // if the edit view is to be shown, show the option buttons, show the instructions and allow user to select a full row
                pnlOptions.Visible = true;
                lblInstructions.Visible = true;
                lstViewOrderItems.FullRowSelect = true;
                pnlOrderInfo.Dock = DockStyle.Top;
            }
            if (viewToShow == "View")
            {
                // if the user is only viewing, hide option buttons, instructions and disallow full row selection
                pnlOptions.Visible = false;
                lblInstructions.Visible = false;
                lstViewOrderItems.FullRowSelect = false;
                pnlOrderInfo.Dock = DockStyle.Fill;
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

        // method to give values to the combo box for selection
        private void PopulateComboBox(string comboBoxName)
        {
            if (comboBoxName == "cBoxStock")
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

                // populate the combo box with this new list
                cBoxStock.DataSource = allStockNames;
                cBoxStock.DisplayMember = "Name";
            }
            else if (comboBoxName == "cBoxStaffMembers")
            {
                List<Staff> sortedStaffList = StaffDal.GetAllStaff();
                List<string> staffNames = new List<string>();
                foreach (Staff staff in sortedStaffList)
                {
                    string fullname = $"{staff.forename} {staff.surname}";
                    staffNames.Add(fullname);
                }
                cBoxStaffMembers.DataSource = staffNames;
            }
        }

        /*private void cBoxStock_TextChanged(object sender, EventArgs e)
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
        }*/

        // method to add an item to an order
        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            // create an order item with the data input by the user
            OrderItem newOrderItem = new OrderItem
            {
                stockId = StockDal.GetStockByStockName(cBoxStock.Text).stockId,
                orderItemQuantity = Convert.ToInt32(nUDQuantity.Value),
                orderNumber = this.order.orderNumber
            };
            // add new order item to the order
            OrderDal.AddOrderItem(newOrderItem);

            // refresh the combo box
            PopulateComboBox("cBoxStock");
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
            pnlViewOrderItems.Visible = true;
            pnlAddItemToOrder.Visible = false;
        }

        // method to show the add item to order panel
        private void ShowAddItemToOrder()
        {
            pnlViewOrderItems.Visible = false;
            pnlAddItemToOrder.Visible = true;
            lblOrderNumberItem.Text = "Order Number " + order.orderNumber.ToString();
        }

        // button click to show the add item to order panel
        private void btnAddToStock_Click(object sender, EventArgs e)
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
            pnlOptions.Visible = false;
            pnlOrderNoToStat.Visible = false;
            pnlOrderConfirmation.Visible = true;
            pnlOrderInfo.Size = lstViewOrderItems.Size;

            lblFinalOrderTotal.Text = orderTotal.ToString();
            
            
        }

        private void btnSaveAsDraft_Click(object sender, EventArgs e)
        {
            // set status to a draft and close the form
            order.orderStatus = "Draft";
            OrderDal.UpdateOrderStatus(order);
            this.Close();
        }

        private void btnConfirmAndPlace_Click(object sender, EventArgs e)
        {
            // set the order status to 'placed' and save it
            order.orderStatus = "Placed";
            lblOrderStatus.Text = $"Order Status: {order.orderStatus}";
            OrderDal.UpdateOrderStatus(order);
        }
    }
}