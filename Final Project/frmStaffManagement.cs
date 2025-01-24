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

namespace Final_Project
{
	public partial class frmStaffManagement : Form
	{
		public frmStaffManagement()
		{
			InitializeComponent();
		}
			
		Staff staffToEdit = new Staff();

		private void lstViewOrders_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (e.IsSelected)
			{
				pnlOptionButtons.Visible = true;
				pnlOptionButtons.Dock = DockStyle.Bottom;
				pnlStaffListView.Dock = DockStyle.Fill;

				string forename = e.Item.SubItems[0].Text;
				string surname = e.Item.SubItems[1].Text;

				staffToEdit = StaffDal.GetStaffByStaffFullName(forename, surname);
			}
		}
	}
}
