using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
		
		string forename = "";
		string surname = "";
		string username = "";
		string password = "";

		#region RegisteringProcess
		private void btnRegister_Click(object sender, EventArgs e)
		{
			// Hide any previously shown error message
			ClearError();

			forename = txtBoxForename.Text;
			surname = txtBoxSurname.Text;
			username = txtBoxUsername.Text;
			password = txtBoxPassword.Text;

			string errorMessage = AccountValidation(forename, surname, username, password);
			if (errorMessage == "") 
			{
				Register();
			}
			else
			{
				ShowError(errorMessage);
			}
		}	

		public static string AccountValidation(string forename, string surname, string username, string password)
		{
			List<Staff> allStaff = StaffDal.GetAllStaff();

			if (forename == "" || surname == "" || username == "" || password == "")
			{
				return("Fill all fields before confirming changes!");
			}

			foreach (Staff staff in allStaff)
			{
				// Check that there aren't any other staff members with the same name forename and surname
				if (staff.username != username && staff.forename == forename && staff.surname == surname)
				{
					return ("There is already another staff member with that name!");
				}
			}

			if (!IsValidUsername(username))
			{
				return ("Invalid username, must only contain letters or numbers, at least 4 characters");
			}
			if (!IsValidName(forename))
			{
				return ("Invalid forename");
			}
			if (!IsValidName(surname))
			{
				return ("Invalid surname");				
			}

			// Password validation

			// Check length
			if (password.Length < 8 || password.Length > 15)
			{
				return ("Password must be between 8 and 15 characters long.");
			}

			// Check for uppercase letter
			if (!Regex.IsMatch(password, @"[A-Z]"))
			{
				return ("Password must include at least one uppercase letter.");
			}

			// Check for numbers
			if (!Regex.IsMatch(password, @"[0-9]"))
			{
				return ("Password must include at least one number.");
			}

			// Check for symbols
			if (!Regex.IsMatch(password, @"[!@#$%^&*()_+\-=$$$${};':\\|,.<>\/?]"))
			{
				return ("Password must include at least one symbol.");
			}

			return "";
		}

		public static bool IsValidUsername(string username)
		{
			// Regular expression to match usernames containing only letters and/or numbers with at least 4 characters
			string pattern = @"^(?=.*[a-zA-Z0-9]).{4,}$";
			Match match = Regex.Match(username, pattern);
			return match.Success;
		}

		public static bool IsValidName(string name)
		{
			// Regular expression to match names containing letters, apostrophe, spaces or dashes
			string pattern = @"^[a-zA-Z' \-]+$";
			Match match = Regex.Match(name, pattern);
			return match.Success;
		}

		public void Register()
		{
			newStaff.forename = forename;
			newStaff.surname = surname;
			newStaff.staffPosition = "Initiate";
			newStaff.username = username;
			newStaff.password = password;
			newStaff.active = 1;
			StaffDal.AddStaffMember(newStaff);
			MessageBox.Show("Account Created\nReturning to login screen now");
			frmMainScreen.frmMain.OpenChildForm(new frmLoginScreen(), null);
		}

		#endregion RegisteringProcess

		#region ErrorHandling

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

		#endregion ErrorHandling

		#region Clearing
		private void btnClear_Click(object sender, EventArgs e)
		{
			// when button is clicked, run the clear method
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

		#endregion Clearing

		#region GoingBack

		private void btnBack_Click(object sender, EventArgs e)
		{
			frmMainScreen.frmMain.OpenChildForm(new frmLoginScreen(), null);
		}

		#endregion GoingBack
	}
}
