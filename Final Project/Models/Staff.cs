using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	// Staff member class
	public class Staff
	{
		public int staffId { get; set; }
		public string forename { get; set; }
		public string surname { get; set; }
		public string password { get; set; }
		public string username { get; set; }
		public string staffPosition { get; set; }
		public int active { get; set; }

		public Staff()
		{
			this.forename = "";
			this.surname = "";
			this.username = "";
			this.password = "";
			this.staffPosition = "";
			this.active = 1;
		}

		// Create staff object without an id (used when creating a new staff member)
		public Staff(string forename, string surname, string username, string password, string staffPosition, int active)
		{
			this.forename = forename;
			this.surname = surname;
			this.username = username;
			this.password = password;
			this.staffPosition = staffPosition;
			this.active = active;
		}

		// Create a staff object with an id (used when getting an existing staff member)
		public Staff(int staffId, string forename, string surname, string username, string password, string staffPosition, int active)
		{
			this.staffId = staffId;
			this.forename = forename;
			this.surname = surname;
			this.username = username;
			this.password = password;
			this.staffPosition = staffPosition;
			this.active = active;
		}
	}
}
