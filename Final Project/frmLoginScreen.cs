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
    public partial class frmLoginScreen : Form
    {
        public static frmMain mainMenu ;
        public frmLoginScreen()
        {
            InitializeComponent();
            lblError.Visible = false;
            // Code to be able to hit enter to do same thing as submit when in the password textbox
            txtBoxPassword.KeyDown += KeyPressedDown;
            KeyDown += KeyPressedDown;
        }

        private void KeyPressedDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    // when the enter key is hit it will attemp to run the Verification method to find out if a valid user is trying to log in
                    btnSubmit_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        public List<Staff> staffList = StaffDal.GetAllStaff();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            try
            {
                username = (txtBoxUsername.Text);
                password = txtBoxPassword.Text;
            }
            catch (Exception ex)
            {
                ShowError("Invalid data entered, please try again");
            }


            foreach (Staff staff in staffList)
            {
                if (staff.username == username && staff.password == password)
                {
                    this.Hide();
                    MessageBox.Show($"Welcome {staff.forename}", "Welcome");
                    mainMenu = new frmMain();
                    mainMenu.Show();
                    break;
                }
                else if (staff.username == username)
                {
                    ShowError("The password you have entered is invalid");
                    break;
                }
                else if (staff.password == password)
                {
                    ShowError("The Staff ID you have entered is invalid");
                    break;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear fields and set focus on username text box
            // and hide any previously shown error messages
            ClearError();
            txtBoxUsername.Text = "";
            txtBoxPassword.Text = "";
            this.ActiveControl = txtBoxUsername;
            txtBoxPassword.PasswordChar = '*';
        }

        private void ShowError(string errorMessage)
        {
            // shows an error indicating which boxes need to be filled in to be valid
            lblError.Text = errorMessage;
            lblError.Visible = true;
            this.ActiveControl = txtBoxUsername;
        }

        private void ClearError()
        {
            // hide error message
            lblError.Text = "";
            lblError.Visible = false;
        }

        private void frmLoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // exits the program if window is closed
            System.Windows.Forms.Application.Exit();
        }

        private void cBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxPassword.Checked)
            {
                // when the check box is ticked, the user will be able to see what they have input
                txtBoxPassword.PasswordChar = '\0';
            }
            else
            {
                // when the check box is unticked, the user will only be able to see * so the password is hidden
                txtBoxPassword.PasswordChar = '*';
            }
        }
    }
}
