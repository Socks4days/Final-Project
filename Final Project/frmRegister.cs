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

        List<Staff> staffMembers = StaffDal.GetAllStaff();

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}
