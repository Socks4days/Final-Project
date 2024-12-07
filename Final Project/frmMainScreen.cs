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
            OpenChildForm(new frmLoginScreen());
            hideSubMenus();
        }

        private Form activeForm = null;

        public void OpenChildForm(Form childForm)
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
        }

        // Close the child form if one is open
        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
        }

        #region toggleSubMenus
        private void btnStock_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            toggleSubMenu(pnlStock);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            CloseChildForm();
            toggleSubMenu(pnlOrder);
        }

        // Hide the settings and admin submenus when a menu option is clicked
        private void hideSubMenus()
        {
            pnlStock.Visible = false;
            pnlOrder.Visible = false;
        }

        // Hide the main menu and title bar
        private void hideMenus()
        {
            pnlSideBar.Visible = false;
        }

        // Show the main menu and title bar
        private void showMenus()
        {
            pnlSideBar.Visible = true;
        }

        // Show or hide the sub menu when it is clicked
        private void toggleSubMenu(Panel selectedSubMenu)
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
            //  pctBoxLogo.Image = Resources.TitleIcon;
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditStockLevels());
        }

        private void btnEditStockLevels_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStockManagement());
        }

        private void btnAddNewStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddOrRemoveStockType("Add Stock"));
        }

        private void btnRemoveStock_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAddOrRemoveStockType("Remove Stock"));
        }

        private void btnOrderStock_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            newOrder.orderStatus = "Draft";
            newOrder.orderDate = DateTime.Now;
            newOrder = OrderDal.AddOrder(newOrder);
            OpenChildForm(new frmCreateOrUpdateOrder(newOrder, "Edit"));
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmViewOrders());
        }
    }
}
