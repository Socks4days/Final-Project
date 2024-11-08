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
    public partial class frmMainScreen: Form
    {
        public static frmMainScreen frmMain;

        public frmMainScreen()
        {
            InitializeComponent();
            frmMainScreen.frmMain = this;
            //OpenChildForm(null);
            OpenChildForm(new frmLoginScreen());
        }

        private Form activeForm = null;
       
        public void OpenChildForm(Form childForm)
        {
            // Check if title/side panels should be display
            if (childForm == null || (childForm.Name != "frmLoginScreen" && childForm.Name != "frmRegister"))
            {
                pnlTitleBar.Visible = true;
                pnlSideBar.Visible = true;
            }
            else
            {
                pnlSideBar.Visible = false;
                pnlTitleBar.Visible = false;
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
    }
}
