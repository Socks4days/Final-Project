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
    public partial class frmRegisterScreen : Form
    {
        public frmRegisterScreen()
        {
            InitializeComponent();
        }

        // List<Staff> staffMembers = StaffDal.GetAllStaff();
        Staff newStaff = new Staff();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Staff staff = new Staff(txtBoxForename.Text, txtBoxSurname.Text, txtBoxUsername.Text, txtBoxPassword.Text, "Newbie", 0);
                                
                newStaff.forename = txtBoxForename.Text;
                newStaff.surname = txtBoxSurname.Text;
                newStaff.staffPosition = "Newbie";
                newStaff.username = txtBoxUsername.Text;
                newStaff.password = txtBoxPassword.Text;
                newStaff.active = 0;
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            StaffDal.AddStaffMember(newStaff);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen.frmMain.OpenChildForm(new frmLoginScreen());
        }
    }
}
