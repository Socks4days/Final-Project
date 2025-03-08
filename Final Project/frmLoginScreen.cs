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
            txtBoxPassword.KeyDown += KeyPressedDown!;
            txtBoxUsername.KeyDown += KeyPressedDown!;
            KeyDown += KeyPressedDown!;
        }

		#region EnterKeyLogic
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

		#endregion EnterKeyLogic

		#region StaffInfo

		// get list of all staff
		public List<Staff> staffList = StaffDal.GetAllStaff();
        public static Staff loggedInStaff = new Staff();

		#endregion StaffInfo

        #region ButtonClicks
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
            catch (Exception)
            {
                // if invalid, let user know
                ShowError("Invalid data entered, please try again");
            }


            foreach (Staff staff in staffList)
            {
                // if user is found, proceed to main menu
                if(staff.username == username && staff.password == password)
                {
                    if(staff.active == 1)
                    {
						loggedInStaff = staff;
						frmMainScreen.frmMain.OpenChildForm(null, null);
						frmMainScreen.frmMain.SetUserPermissions(staff);
						return;
					}
                    else
                    {
                        ShowError("You do not have access to the system");
                        return;
                    }
                    
                }                
            }	
            ShowError("The details you have entered are invalid");			
		}

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // show the register screen
            frmMainScreen.frmMain!.OpenChildForm(new frmRegisterScreen(), null);
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

		#endregion ButtonClicks

		#region ErrorHandling
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

		#endregion ErrorHandling

		#region PasswordHashing

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

		#endregion PasswordHashing
	}
}
