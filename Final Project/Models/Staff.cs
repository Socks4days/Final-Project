using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	public class Staff
	{
		public int staffId { get; set; }
		public string forename { get; set; }
		public string surname { get; set; }
		public string password { get; set; }
		public string username { get; set; }
		public string staffPosition { get; set; }
		public int active { get; set; }

		public Staff() { }

		public Staff(string forename, string surname, string username, string password, string staffPosition, int active)
		{
			this.forename = forename;
			this.surname = surname;
			this.username = username;
			this.password = password;
			this.staffPosition = staffPosition;
			this.active = active;
		}
	}
}
