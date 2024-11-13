using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
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
            ClearError();
        }

        Staff newStaff = new Staff();
        List<Staff> allStaff = StaffDal.GetAllStaff();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Hide any previously shown error message
            ClearError();



            // when register button is clicked, check to see if any of the textboxes have been left empty
            // if so, throw an error message addressing this
            if ((txtBoxUsername.Text == "") || (txtBoxPassword.Text == "") || (txtBoxForename.Text == "")
                    || (txtBoxSurname.Text == ""))
            {
                ShowError("Please complete all indicated fields");
                return;
            }
            if ((txtBoxUsername.Text.Contains(',')) || (txtBoxPassword.Text.Contains(',')) || (txtBoxForename.Text.Contains(','))
                    || (txtBoxSurname.Text.Contains(',')))
            {
                ShowError("All fields, including passwords, cannot contain any commas\nPlease remove any commas and try again...");
                return;
            }
            else
            {
                // if all are filled in, then begin the Verification process
                UsernameAndPasswordValidation();
            }
        }

        public void UsernameAndPasswordValidation()
        {
            // Check if the username is already taken
            foreach (Staff staff in allStaff)
            {
                if (staff.username == txtBoxUsername.Text)
                {
                    // if someone already has already got the same username, then an error message is thrown saying they have to change it
                    ShowError("Sorry, that username is already taken.\nPlease try a different one...");
                    //sets mouse to go to the username textbox
                    this.ActiveControl = txtBoxUsername;
                    return;
                }
            }
            // setting variable equal to what the user inputs for password
            string password = txtBoxPassword.Text;

            // checks to see if the input password passes all the checks: More than 8 chatacters, contain a capital, contain a number
            if (!((password.Length >= 8) && (password.Length <= 15)
                && (password.Any(char.IsUpper)) && (password.Any(char.IsDigit))))
            {
                // if it fails, a list of the password requirements are shown
                ShowError("Enter a password between 8-15 characters, with at least\n1 number, 1 capital letter and 1 symbol");
                return;
            }

            // Creates a list of valid password symbols and populates it
            List<char> symbols = new List<char>()
                { '!', '<', '>', '*', '-', '£', '$', '%', '&', '^', '.',':', ';', '/', '?', '#', '@',};


            bool hasSymbol = false;
            // checks to see if the input password contains one of these symbols and if so registers the user
            foreach (char sym in symbols)
            {
                if (password.Contains(sym))
                {
                    // if it does, then the program runs the register method which will register the user as a valid user
                    hasSymbol = true;
                }
            }
            if (!hasSymbol)
                ShowError("Your password does not have a valid symbol, the following are acceptable: ! < > * - £ $ % & ^ . : ; / ? # @");
            else Register();
        }

        public void Register()
        {
            try
            {
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
            MessageBox.Show("Account Created \nReturning to login screen now");
            frmMainScreen.frmMain.OpenChildForm(new frmLoginScreen());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainScreen.frmMain.OpenChildForm(new frmLoginScreen());
        }

        private void ShowError(string errorMessage)
        {
            // shows an error indicating which boxes need to be filled in to be valid
            if (txtBoxUsername.Text == "") lblErrorUsername.Visible = true;
            if (txtBoxPassword.Text == "") lblErrorPassword.Visible = true;
            if (txtBoxForename.Text == "") lblErrorForename.Visible = true;
            if (txtBoxSurname.Text == "") lblErrorSurname.Visible = true;
            lblError.Text = errorMessage;
            lblError.Visible = true;          
        }

        private void ClearError()
        {
            // hide error message
            lblErrorUsername.Visible = false;
            lblErrorPassword.Visible = false;
            lblErrorForename.Visible = false;
            lblErrorSurname.Visible = false;
            lblError.Text = "";
            lblError.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // when button is clicked, run the reset method
            Clear();
        }

        public void Clear()
        {
            // When pressed, all textboxes will be cleared
            // and any previously shown error message hidden
            ClearError();
            txtBoxUsername.Clear();
            txtBoxPassword.Clear();
            txtBoxForename.Clear();
            txtBoxSurname.Clear();
        }
    }
}
