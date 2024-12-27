using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmLoginScreen : Form
    {
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
                    // when the enter key is hit it will attempt to run the method called when submit button activates to find out if a valid user is trying to log in
                    btnSubmit_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        // get list of all staff
        public List<Staff> staffList = StaffDal.GetAllStaff();

        public static Staff loggedInStaff = new Staff();

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // create default username and password strings
            string username = "";
            string password = "";

            // try set values entered by user to the default ones 
            try
            {
                username = (txtBoxUsername.Text);
                password = txtBoxPassword.Text;
            }
            catch (Exception ex)
            {
                // if invalid, let user know
                ShowError("Invalid data entered, please try again");
            }


            foreach (Staff staff in staffList)
            {
                // if user is found, proceed to main menu
                if (staff.username == username && staff.password == password)
                {
                    loggedInStaff = staff;
                    frmMainScreen.frmMain.OpenChildForm(null, null);
                    break;
                }
                // if only username is correct, tell them password is incorrect
                else if (staff.username == username)
                {
                    ShowError("The password you have entered is invalid");
                    break;
                }
                // if only password is correct, say that the username is incorrect
                else if (staff.password == password)
                {
                    ShowError("The username you have entered is invalid");
                    break;
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // show the register screen
            frmMainScreen.frmMain.OpenChildForm(new frmRegisterScreen(), null);
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
