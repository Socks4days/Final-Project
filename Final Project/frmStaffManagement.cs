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
			if (e.IsSelected)
			{
				pnlOptionButtons.Visible = true;
				pnlOptionButtons.Dock = DockStyle.Bottom;
				pnlStaffListView.Dock = DockStyle.Fill;
				pnlStaffListView.BringToFront();

				string forename = e.Item.SubItems[0].Text;
				string surname = e.Item.SubItems[1].Text;

				staffToEdit = StaffDal.GetStaffByStaffFullName(forename, surname);
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

			// Remove the logged in staff member from the list
			foreach (ListViewItem item in lstViewStaffMembers.Items)
			{
				if (item.SubItems[0].Text == frmLoginScreen.loggedInStaff.forename && item.SubItems[1].Text == frmLoginScreen.loggedInStaff.surname)
				{
					lstViewStaffMembers.Items.Remove(item);
				}				
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
				if (staff.forename == forename && staff.surname == surname)
				{
					ShowErrorStaffLevel("There is already a staff member with that name!");
					return;
				}
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

		private void btnEditPosition_Click(object sender, EventArgs e)
		{
			ShowEditStaffPosition();
		}

		private void btnConfirmEditStaffPositionChanges_Click(object sender, EventArgs e)
		{
			staffToEdit.staffPosition = cBoxStaffPositions.Text;
			StaffDal.UpdateStaffPosition(staffToEdit);
			ShowStaffInfo();
		}
	}
}