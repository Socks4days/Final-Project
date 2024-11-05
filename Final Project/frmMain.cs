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
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            // If an existing child form is already open, close it
            if (activeForm != null)
                activeForm.Close();

            // Add the new child form in the main menu container 
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormContainer.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        // Close the child form if one is open
        private void CloseChildForm()
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
    }
}
