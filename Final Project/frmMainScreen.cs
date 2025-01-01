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
	public partial class frmMainScreen : Form
	{
		public static frmMainScreen frmMain;

		public frmMainScreen()
		{
			InitializeComponent();
			frmMainScreen.frmMain = this;
			OpenChildForm(new frmLoginScreen(), null);
			hideSubMenus();
			SetLogo();
		}

		private Form activeForm = null;
		private Button activeMenuButton = null;
		private Button parentMenuButton = null;

		public void OpenChildForm(Form childForm, Button menuButton)
		{
			// Check if title/side panels should be display
			if (childForm == null || (childForm.Name != "frmLoginScreen" && childForm.Name != "frmRegisterScreen"))
			{
				showMenus();
			}
			else
			{
				hideMenus();
			}

			// If an existing child form is already open, close it
			CloseChildForm();

			// If a new child form has been passed in, open it
			if (childForm != null)
			{
				// Add the new child form in the main menu container 
				activeForm = childForm;
				childForm.TopLevel = false;
				childForm.FormBorderStyle = FormBorderStyle.None;
				childForm.Dock = DockStyle.Fill;
				pnlFormContainer.Controls.Add(childForm);
				childForm.BringToFront();
				childForm.Show();
			}

			// If a button has been passed in, set the colour theme
			if (menuButton != null)
			{
				activeMenuButton = menuButton;
				lblTitle.Text = menuButton.Text;
				string name = menuButton.Text;

				if (name == "Manage Stock" || name == "Add New Stock" || name == "Retire Stock")
				{
					btnStock.BackColor = Color.FromArgb(24, 105, 170);
					pnlTitleBar.BackColor = Color.FromArgb(33, 150, 243);
					switch (name)
					{
						case "Manage Stock":
							btnManageStockLevels.BackColor = Color.FromArgb(33, 150, 243);
							break;
						case "Add New Stock":
							btnAddNewStock.BackColor = Color.FromArgb(33, 150, 243);
							break;
						case "Retire Stock":
							btnRetireStock.BackColor = Color.FromArgb(33, 150, 243);
							break;
					}
				}
				else if (name == "Order Stock" || name == "View Orders")
				{
					btnOrder.BackColor = Color.FromArgb(112, 21, 62);
					pnlTitleBar.BackColor = Color.FromArgb(161, 32, 89);
					switch (name)
					{
						case "Order Stock":
							btnOrderStock.BackColor = Color.FromArgb(161, 32, 89);
							break;
						case "View Orders":
							btnViewOrders.BackColor = Color.FromArgb(161, 32, 89);
							break;
					}
				}
				else if (name == "View Deliveries")
				{
					btnDelivery.BackColor = Color.FromArgb(0, 92, 83);
					pnlTitleBar.BackColor = Color.FromArgb(0, 151, 136);
					switch (name)
					{
						case "ADD ANOTHER HERE?":
							btnOrderStock.BackColor = Color.FromArgb(0, 151, 136);
							break;
						case "View Deliveries":
							btnViewDeliveries.BackColor = Color.FromArgb(0, 151, 136);
							break;
					}
				}
				else if (name == "Create Audit")
				{
					btnAudits.BackColor = Color.FromArgb(255, 76, 5);
					pnlTitleBar.BackColor = Color.FromArgb(255, 138, 98);
					switch (name)
					{
						case "Create Audit":
							btnCreateAudit.BackColor = Color.FromArgb(255, 138, 98);
							break;
						case "ADD ANOTHER HERE?":
							btnOrderStock.BackColor = Color.FromArgb(0, 151, 136);
							break;
						
					}
				}
			}
		}

		// Close the child form if one is open
		public void CloseChildForm()
		{
			if (activeForm != null)
			{
				activeForm.Close();
				activeForm = null;
			}

			if (activeMenuButton != null)
			{
				activeMenuButton.BackColor = Color.Transparent;
				activeMenuButton = null;
				parentMenuButton.BackColor = Color.Transparent;
			}


			pnlTitleBar.BackColor = Color.FromArgb(51, 51, 79);
			lblTitle.Text = "Movers Maintenance Garage Stock Control System";
		}

		#region toggleSubMenus
		private void btnStock_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			toggleSubMenu(pnlStock);
			ResetMainButtonColours();
			if (pnlStock.Visible == true)
			{
				btnStock.BackColor = Color.FromArgb(33, 150, 243);
			}
			else
			{
				btnStock.BackColor = Color.FromArgb(51, 51, 79);
			}
			parentMenuButton = btnStock;
		}

		private void btnOrder_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			toggleSubMenu(pnlOrder);
			ResetMainButtonColours();
			if (pnlOrder.Visible == true)
			{
				btnOrder.BackColor = Color.FromArgb(161, 32, 89);
			}
			else
			{
				btnOrder.BackColor = Color.FromArgb(51, 51, 79);
			}
			parentMenuButton = btnOrder;
		}

		private void btnDelivery_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			toggleSubMenu(pnlDelivery);
			ResetMainButtonColours();
			if (pnlDelivery.Visible == true)
			{
				btnDelivery.BackColor = Color.FromArgb(0, 151, 136);
			}
			else
			{
				btnDelivery.BackColor = Color.FromArgb(51, 51, 79);
			}			
			parentMenuButton = btnDelivery;
		}

		private void btnAudits_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			toggleSubMenu(pnlAudits);
			ResetMainButtonColours();
			if (pnlAudits.Visible == true)
			{
				btnAudits.BackColor = Color.FromArgb(255, 138, 98);
			}
			else
			{
				btnAudits.BackColor = Color.FromArgb(51, 51, 79);
			}			
			parentMenuButton = btnAudits;
		}

		private void ResetMainButtonColours()
		{
			btnStock.BackColor = Color.FromArgb(51, 51, 79);
			btnOrder.BackColor = Color.FromArgb(51, 51, 79);
			btnDelivery.BackColor = Color.FromArgb(51, 51, 79);
			btnAudits.BackColor = Color.FromArgb(51, 51, 79);
		}

		// Hide the settings and admin submenus when a menu option is clicked
		public void hideSubMenus()
		{			
			pnlStock.Visible = false;
			pnlOrder.Visible = false;
			pnlDelivery.Visible = false;
			pnlAudits.Visible = false;				
		}

		// Hide the main menu and title bar
		public void hideMenus()
		{
			pnlSideBar.Visible = false;
			pnlTitleBar.Visible = false;
		}

		// Show the main menu and title bar
		public void showMenus()
		{
			pnlSideBar.Visible = true;
			pnlTitleBar.Visible = true;
		}

		// Show or hide the sub menu when it is clicked
		public void toggleSubMenu(Panel selectedSubMenu)
		{
			if (selectedSubMenu.Visible == true)
			{
				hideSubMenus();
			}
			else
			{
				hideSubMenus();
				selectedSubMenu.Visible = true;
			}
		}

		#endregion toggleSubMenus

		private void SetLogo()
		{
			pctBoxLogo.ImageLocation = @"C:\Users\andre\OneDrive\Desktop\A2 SSD\Tasks\Final Project\TitleIcon.ico";
			pctBoxSmallLogo.ImageLocation = @"C:\Users\andre\OneDrive\Desktop\A2 SSD\Tasks\Final Project\TitleIcon.ico";
		}

		private void btnManageStockLevels_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmEditStockLevels(), (Button)sender);
		}

		private void btnAddNewStock_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmAddOrRetireStockType("Add Stock"), (Button)sender);
		}

		private void btnRetireStock_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmAddOrRetireStockType("Retire Stock"), (Button)sender);
		}

		private void btnOrderStock_Click(object sender, EventArgs e)
		{
			Order newOrder = new Order();
			newOrder.orderStatus = "Draft";
			newOrder.orderDate = DateTime.Now;
			newOrder = OrderDal.AddOrder(newOrder);
			OpenChildForm(new frmCreateOrUpdateOrder(newOrder, "Edit"), (Button)sender);
		}

		private void btnViewOrders_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmViewOrders(), (Button)sender);
		}

		private void btnViewDeliveries_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmAddDelivery(), (Button)sender);
		}

		private void btnCreateAudit_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmCreateAudit(), (Button)sender);
		}
	}
}
