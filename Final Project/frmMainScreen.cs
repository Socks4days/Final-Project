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
			HideSubMenus();
			SetLogo();
		}

		#region LogoHandling

		private void SetLogo()
		{
			pctBoxLogo.ImageLocation = @"C:\Users\andre\OneDrive\Desktop\A2 SSD\Tasks\Final Project\Movers Logo Black.png";
			pctBoxSmallLogo.ImageLocation = @"C:\Users\andre\OneDrive\Desktop\A2 SSD\Tasks\Final Project\Movers Logo White.png";
		}

		private void pctBoxSmallLogo_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			HideSubMenus();
		}

		#endregion LogoHandling

		#region FormNavigation

		private Form activeForm = null;
		private Button activeMenuButton = null;
		private Button parentMenuButton = null;

		public void OpenChildForm(Form childForm, Button menuButton)
		{
			// Check if title/side panels should be display
			if (childForm == null || (childForm.Name != "frmLoginScreen" && childForm.Name != "frmRegisterScreen"))
			{
				ShowMenus();
			}
			else
			{
				HideMenus();
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

			#region Colouring

			// If a button has been passed in, set the colour theme
			if (menuButton != null)
			{
				activeMenuButton = menuButton;
				lblTitle.Text = menuButton.Text;
				string name = menuButton.Text;

				if (name == "Manage Stock" || name == "New Stock Item" || name == "Retire Stock Item")
				{
					btnStock.BackColor = Color.FromArgb(24, 105, 170);
					pnlTitleBar.BackColor = Color.FromArgb(33, 150, 243);
					switch (name)
					{
						case "Manage Stock":
							btnManageStockLevels.BackColor = Color.FromArgb(33, 150, 243);
							break;
						case "New Stock Item":
							btnNewStockItem.BackColor = Color.FromArgb(33, 150, 243);
							break;
						case "Retire Stock Item":
							btnRetireStockItem.BackColor = Color.FromArgb(33, 150, 243);
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
					btnViewDeliveries.BackColor = Color.FromArgb(0, 151, 136);					
				}
				else if (name == "Create Audit" || name == "Audit History")
				{
					btnAudits.BackColor = Color.FromArgb(255, 76, 5);
					pnlTitleBar.BackColor = Color.FromArgb(255, 138, 98);
					switch (name)
					{
						case "Create Audit":
							btnCreateAudit.BackColor = Color.FromArgb(255, 138, 98);
							break;
						case "Audit History":
							btnAuditHistory.BackColor = Color.FromArgb(255, 138, 98);
							break;

					}
				}
				else if (name == "Manage Staff")
				{
					btnStaff.BackColor = Color.FromArgb(100, 12, 100);
					pnlTitleBar.BackColor = Color.FromArgb(150, 12, 150);
					btnManageStaff.BackColor = Color.FromArgb(150, 12, 150);
				}
			}

			#endregion Colouring
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

		#endregion FormNavigation

		#region ToggleSubMenus
		private void btnStock_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			ToggleSubMenu(pnlStock);
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
			ToggleSubMenu(pnlOrder);
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
			ToggleSubMenu(pnlDelivery);
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
			ToggleSubMenu(pnlAudits);
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

		private void btnStaff_Click(object sender, EventArgs e)
		{
			CloseChildForm();
			ToggleSubMenu(pnlStaff);
			ResetMainButtonColours();
			if (pnlStaff.Visible == true)
			{
				btnStaff.BackColor = Color.FromArgb(150, 12, 150);
			}
			else
			{
				btnStaff.BackColor = Color.FromArgb(51, 51, 79);
			}
			parentMenuButton = btnStaff;
		}

		private void ResetMainButtonColours()
		{
			btnStock.BackColor = Color.FromArgb(51, 51, 79);
			btnOrder.BackColor = Color.FromArgb(51, 51, 79);
			btnDelivery.BackColor = Color.FromArgb(51, 51, 79);
			btnAudits.BackColor = Color.FromArgb(51, 51, 79);
			btnStaff.BackColor = Color.FromArgb(51, 51, 79);
		}

		// Hide the settings and admin submenus when a menu option is clicked
		public void HideSubMenus()
		{
			pnlStock.Visible = false;
			pnlOrder.Visible = false;
			pnlDelivery.Visible = false;
			pnlAudits.Visible = false;
			pnlStaff.Visible = false;
		}

		// Hide the main menu and title bar
		public void HideMenus()
		{
			pnlSideBar.Visible = false;
			pnlTitleBar.Visible = false;
		}

		// Show the main menu and title bar
		public void ShowMenus()
		{
			pnlSideBar.Visible = true;
			pnlTitleBar.Visible = true;
		}

		// Show or hide the sub menu when it is clicked
		public void ToggleSubMenu(Panel selectedSubMenu)
		{
			if (selectedSubMenu.Visible == true)
			{
				HideSubMenus();
			}
			else
			{
				HideSubMenus();
				selectedSubMenu.Visible = true;
			}
		}

		#endregion ToggleSubMenus

		#region ButtonNavigation
		private void btnManageStockLevels_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmEditStockLevels(), (Button)sender);
		}

		private void btnNewStockItem_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmAddOrRetireStockType("Add Stock"), (Button)sender);
		}

		private void btnRetireStockItem_Click(object sender, EventArgs e)
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
			Audit newAudit = new Audit();
			newAudit.auditDate = DateTime.Now;
			newAudit.auditedByStaffId = frmLoginScreen.loggedInStaff.staffId;
			newAudit = AuditDal.AddAudit(newAudit);
			OpenChildForm(new frmCreateAudit(newAudit, "Create Audit"), (Button)sender);
		}

		private void btnAuditHistory_Click(object sender, EventArgs e)
		{
			Audit audit = new Audit();
			OpenChildForm(new frmCreateAudit(audit, "Audit History"), (Button)sender);
		}

		private void btnManageStaff_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmStaffManagement(), (Button)sender);
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			OpenChildForm(new frmLoginScreen(), null);
		}

		#endregion ButtonNavigation

		#region PermissionHandling		

		public void SetUserPermissions(Staff loggedInStaff)
		{
			string staffPosition = loggedInStaff.staffPosition;
			ResetButtonVisibilities();

			// If the user is an initiate, they will only be able to take out stock and return stock
			if (staffPosition == "Initiate")
				Initiate();

			// If the user is a mechanic, they can do what an initate can, as well as perform stock audits
			else if (staffPosition == "Mechanic")
				Mechanic();

			// If the user is a senior mechanic, they can do what a mechanic can, as well as add and retire stock items
			else if (staffPosition == "Senior Mechanic")
				SeniorMechanic();			

			// If the user is another level, e.g. CEO or Manager, they will have access to the full system

			HideSubMenus();
			ResetMainButtonColours();
		}

		private void Initiate()
		{
			pnlStock.Height = btnManageStockLevels.Height;
			btnOrder.Visible = false;
			btnDelivery.Visible = false;
			btnAudits.Visible = false;
			btnStaff.Visible = false;
		}

		private void Mechanic()
		{
			pnlStock.Height = btnManageStockLevels.Height;
			btnOrder.Visible = false;
			btnDelivery.Visible = false;
			btnStaff.Visible = false;
		}

		private void SeniorMechanic()
		{
			btnOrder.Visible = false;
			btnDelivery.Visible = false;
			btnStaff.Visible = false;
		}		

		private void ResetButtonVisibilities()
		{
			pnlStock.Height = btnManageStockLevels.Height * 3;
			btnOrder.Visible = true;
			btnDelivery.Visible = true;
			btnAudits.Visible = true;
			btnStaff.Visible = true;
		}

		#endregion PermissionHandling		

		#region Exiting

		private void frmMainScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			
		}

		#endregion Exiting


	}
}