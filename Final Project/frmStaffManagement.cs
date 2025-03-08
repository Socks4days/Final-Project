using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Models;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
	public partial class frmStaffManagement : Form
	{
		public frmStaffManagement()
		{
			InitializeComponent();
			ShowStaffInfo();
		}

		Staff staffToEdit = new Staff();
		List<Staff> staffList = StaffDal.GetAllStaff();
		string[] positions = { "Initiate", "Mechanic", "Senior Mechanic", "Manager" };

		private void lstViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected && e.Item != null)
			{
				pnlOptionButtons.Visible = true;
				pnlOptionButtons.Dock = DockStyle.Bottom;
				pnlStaffListView.Dock = DockStyle.Fill;
				pnlStaffListView.BringToFront();

				string forename = e.Item.SubItems[0].Text;
				string surname = e.Item.SubItems[1].Text;

				staffToEdit = StaffDal.GetStaffByStaffFullName(forename, surname);

				if (frmLoginScreen.loggedInStaff.staffPosition == "Manager")
				{
					if (staffToEdit.staffId == frmLoginScreen.loggedInStaff.staffId)
					{
						btnEditStaffPosition.Enabled = false;
						btnFireStaffMember.Enabled = false;
					}
					else
					{
						btnEditStaffPosition.Enabled = true;
						btnFireStaffMember.Enabled = true;
					}
				}
				else
				{
					if (staffToEdit.staffId == frmLoginScreen.loggedInStaff.staffId)
					{
						btnEditStaffMember.Enabled = true;
					}
					else
					{
						btnEditStaffMember.Enabled = false;
					}
				}			
			}
		}

		private void ShowStaffInfo()
		{
			pnlStaffInfo.Visible = true;
			pnlOptionButtons.Visible = false;
			pnlEditStaffMember.Visible = false;
			pnlEditStaffPosition.Visible = false;
			pnlStaffListView.Dock = DockStyle.Fill;
			pnlStaffInfo.Dock = DockStyle.Fill;
			UpdateStaffListView();

			if (staffToEdit.staffPosition != "Manager")
			{
				btnFireStaffMember.Enabled = false;
				btnEditStaffPosition.Enabled = false;
			}
		}

		private void ShowEditStaffMember()
		{
			pnlStaffInfo.Visible = false;
			pnlEditStaffMember.Visible = true;
			pnlEditStaffPosition.Visible = false;
			pnlEditStaffMember.Dock = DockStyle.Fill;

			ClearError();
			txtBoxForename.Text = staffToEdit.forename;
			txtBoxSurname.Text = staffToEdit.surname;
			txtBoxUsername.Text = staffToEdit.username;
			txtBoxPassword.Text = staffToEdit.password;
		}

		private void ShowEditStaffPosition()
		{
			pnlStaffInfo.Visible = false;
			pnlEditStaffMember.Visible = false;
			pnlEditStaffPosition.Visible = true;
			pnlEditStaffPosition.Dock = DockStyle.Fill;
			cBoxStaffPositions.DataSource = positions;
			lblStaffToEditPosition.Text = $"Editing position for: {staffToEdit.forename} {staffToEdit.surname}";
		}

		private void UpdateStaffListView()
		{
			foreach (ListViewItem item in lstViewStaffMembers.Items)
			{
				lstViewStaffMembers.Items.Remove(item);
			}

			staffList = StaffDal.GetAllStaff();

			// Add each stock in the sorted list to the stock list
			foreach (Staff staff in staffList)
			{
				string active = "Inactive";

				if (staff.active == 1)
				{
					active = "Active";
				}

				// Create an array with stock details
				string[] row = { staff.forename, staff.surname, staff.staffPosition, active };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the stock list view
				lstViewStaffMembers.Items.Add(item);
			}

			lstViewStaffMembers.SelectedItems.Clear();
		}

		private void frmStaffManagement_Resize(object sender, EventArgs e)
		{
			lstViewStaffMembers.Height = pnlStaffListView.Height - 80;
		}

		private void btnEditStaffMember_Click(object sender, EventArgs e)
		{
			ShowEditStaffMember();
		}

		private void btnCancelStaffEdit_Click(object sender, EventArgs e)
		{
			ShowStaffInfo();
		}

		private void btnCancelEditStaffPosition_Click(object sender, EventArgs e)
		{
			ShowStaffInfo();
		}

		private void btnConfirmEditStaff_Click(object sender, EventArgs e)
		{
			string forename = txtBoxForename.Text;
			string surname = txtBoxSurname.Text;
			string username = txtBoxUsername.Text;
			string password = txtBoxPassword.Text;

			if (forename == "" || surname == "" || username == "" || password == "")
			{
				ShowErrorStaffLevel("Fill all fields before confirming changes!");
				return;
			}

			foreach (Staff staff in staffList)
			{
				// Check that there aren't any other staff members with the same name forename and surname
				if (staff.username != username && staff.forename == forename && staff.surname == surname)
				{
					ShowErrorStaffLevel("There is already another staff member with that name!");
					return;
				}
			}

			if (!frmRegisterScreen.IsValidUsername(username))
			{
				ShowErrorStaffLevel("Invalid username, must be in the format Example123, at least 5 characters");
				return;
			}
			if (!frmRegisterScreen.IsValidName(forename))
			{
				ShowErrorStaffLevel("Invalid forename, must be only letters");
				return;
			}
			if (!frmRegisterScreen.IsValidName(surname))
			{
				ShowErrorStaffLevel("Invalid surname, must be only letters");
				return;
			}

			// checks to see if the input password passes all the checks: More than 8 chatacters, contain a capital, contain a number
			if (!((password.Length >= 8) && (password.Length <= 15)
				&& (password.Any(char.IsUpper)) && (password.Any(char.IsDigit))))
			{
				// if it fails, a list of the password requirements are shown
				ShowErrorStaffLevel("Enter a password between 8-15 characters, with at least\n1 number, 1 capital letter and 1 symbol");
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
			{
				ShowErrorStaffLevel("Your password does not have a valid symbol, the following are acceptable: ! < > * - £ $ % & ^ . : ; / ? # @");
				return;
			}


			staffToEdit.forename = forename;
			staffToEdit.surname = surname;
			staffToEdit.username = username;
			staffToEdit.password = password;

			StaffDal.UpdateStaffInformation(staffToEdit);
			ShowStaffInfo();
		}



		private void ShowErrorStaffLevel(string errorMessage)
		{
			// shows an error indicating which boxes need to be filled in to be valid
			lblErrorStaffEdit.Text = errorMessage;
			lblErrorStaffEdit.Visible = true;
		}

		private void ClearError()
		{
			// hide error message			
			lblErrorStaffEdit.Visible = false;
			lblErrorStaffEdit.Text = "";
		}

		private void btnConfirmEditStaffPositionChanges_Click(object sender, EventArgs e)
		{
			staffToEdit.staffPosition = cBoxStaffPositions.Text;
			StaffDal.UpdateStaffPosition(staffToEdit);
			ShowStaffInfo();
		}

		private void btnEditStaffPosition_Click(object sender, EventArgs e)
		{
			ShowEditStaffPosition();
		}

		private void btnFireStaffMember_Click(object sender, EventArgs e)
		{
			staffToEdit.active = 0;
			StaffDal.UpdateStaffStatus(staffToEdit);
			UpdateStaffListView();
		}		
	}
}