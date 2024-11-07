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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

       // List<Staff> staffMembers = StaffDal.GetAllStaff();
        Staff newStaff =  new Staff();

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                newStaff.username = txtBoxUsername.Text;
                newStaff.password = txtBoxPassword.Text;
                newStaff.forename = txtBoxForename.Text;
                newStaff.surname = txtBoxSurname.Text;
                newStaff.staffPosition = "Newbie";
                newStaff.active = 0;
            }
            catch (Exception ex) 
            { 
                lblError.Text = ex.Message;
            }

            StaffDal.AddStaffMember(newStaff);
        }
    }
}
