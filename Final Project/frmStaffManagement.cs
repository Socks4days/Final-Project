using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project.Models;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
	public partial class frmStaffManagement : Form
	{
		public frmStaffManagement(string viewToShow)
		{
			InitializeComponent();
			viewing = viewToShow;
			if(viewToShow == "All Staff")
				ShowStaffInfo();
			else if(viewToShow == "My Details")
				ShowMyDetails();
		}

		Staff staffToEdit = new Staff();
		List<Staff> staffList = StaffDal.GetAllStaff();
		string[] positions = { "Initiate", "Mechanic", "Senior Mechanic", "Manager" };
		string viewing = "";

		#region ListViewHandling

		private void lstViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected && e.Item != null)
			{
				pnlOptionButtons.Visible = true;
				pnlOptionButtons.Dock = DockStyle.Bottom;
				pnlStaffListView.Dock = DockStyle.Fill;
				pnlStaffListView.BringToFront();

				string username = e.Item.SubItems[0].Text;

				staffToEdit = StaffDal.GetStaffByStaffUsername(username);

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
				string[] row = { staff.username, string.Concat(staff.forename, " ", staff.surname), staff.staffPosition, active };

				// Create a new list item based on the array
				ListViewItem item = new ListViewItem(row);

				// Add the list item to the stock list view
				lstViewStaffMembers.Items.Add(item);
			}

			lstViewStaffMembers.SelectedItems.Clear();
		}

		#endregion ListViewHandling

		#region PanelShowing

		private void ShowStaffInfo()
		{
			pnlStaffInfo.Visible = true;
			pnlOptionButtons.Visible = false;
			pnlEditStaffMember.Visible = false;
			pnlEditStaffPosition.Visible = false;
			pnlMyDetails.Visible = false;
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
			pnlMyDetails.Visible = false;
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
			pnlMyDetails.Visible = false;
			pnlEditStaffPosition.Visible = true;
			pnlEditStaffPosition.Dock = DockStyle.Fill;
			cBoxStaffPositions.DataSource = positions;
			lblStaffToEditPosition.Text = $"Editing position for: {staffToEdit.forename} {staffToEdit.surname}";
		}

		private void ShowMyDetails()
		{
			Staff me = frmLoginScreen.loggedInStaff;
			pnlStaffInfo.Visible = false;
			pnlEditStaffMember.Visible = false;
			pnlEditStaffPosition.Visible = false;
			pnlMyDetails.Visible = true;
			pnlMyDetails.Dock = DockStyle.Fill;
			lblMyForename.Text = $"Forename: {me.forename}";
			lblMySurname.Text = $"Surname: {me.surname}";
			lblMyUsername.Text = $"Username: {me.username}";
		}

		#endregion PanelShowing		

		#region Resizing

		private void frmStaffManagement_Resize(object sender, EventArgs e)
		{
			lstViewStaffMembers.Height = pnlStaffListView.Height - 100;
		}

		#endregion Resizing

		#region EditingStaffMemberButtonClicks

		private void btnEditStaffMember_Click(object sender, EventArgs e)
		{
			ShowEditStaffMember();
		}

		private void btnConfirmEditStaff_Click(object sender, EventArgs e)
		{
			string forename = txtBoxForename.Text;
			string surname = txtBoxSurname.Text;
			string username = txtBoxUsername.Text;
			string password = txtBoxPassword.Text;

			string errorMessage = frmRegisterScreen.AccountValidation(staffToEdit.staffId, forename, surname, username, password);

			if (errorMessage == "")
			{
				staffToEdit.forename = forename;
				staffToEdit.surname = surname;
				staffToEdit.username = username;
				staffToEdit.password = password;

				StaffDal.UpdateStaffInformation(staffToEdit);
				ShowStaffInfo();
			}
			else
			{
				ShowError(errorMessage);
			}			
		}

		private void btnCancelStaffEdit_Click(object sender, EventArgs e)
		{
			if (viewing == "All Staff")
				ShowStaffInfo();
			else if (viewing == "My Details")
				ShowMyDetails();
		}

		#endregion EditingStaffMemberButtonClicks

		#region EditingMyDetailsButtonClicks

		private void btnEditMyDetails_Click(object sender, EventArgs e)
		{
			staffToEdit = frmLoginScreen.loggedInStaff;
			ShowEditStaffMember();
		}

		#endregion EditingMyDetailsButtonClicks

		#region EditingStaffMemberPositionButtonClicks

		private void btnEditStaffPosition_Click(object sender, EventArgs e)
		{
			ShowEditStaffPosition();
		}

		private void btnConfirmEditStaffPositionChanges_Click(object sender, EventArgs e)
		{
			staffToEdit.staffPosition = cBoxStaffPositions.Text;
			StaffDal.UpdateStaffPosition(staffToEdit);
			ShowStaffInfo();
		}

		private void btnCancelEditStaffPosition_Click(object sender, EventArgs e)
		{
			ShowStaffInfo();
		}

		#endregion EditingStaffMemberPositionButtonClicks

		#region FireStaffButtonClicks

		private void btnFireStaffMember_Click(object sender, EventArgs e)
		{
			staffToEdit.active = 0;
			StaffDal.UpdateStaffStatus(staffToEdit);
			UpdateStaffListView();
		}

		#endregion FireStaffButtonClicks

		#region ErrorHandling

		private void ShowError(string errorMessage)
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

		#endregion ErrorHandling			
	}
}