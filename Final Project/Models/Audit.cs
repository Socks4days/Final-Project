using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Final_Project.Models
{
	// Holds details of an audit
	public class Audit
	{
		public int auditId { get; set; }
		public DateTime auditDate { get; set; }
		public int auditedByStaffId { get; set; }

		// Defult constructor method
		public Audit() { }

		// Main constructor method with audit details
		public Audit(int auditId, DateTime auditDate, int auditedByStaffId)
		{
			this.auditId = auditId;
			this.auditDate = auditDate;
			this.auditedByStaffId = auditedByStaffId;
		}
	}
}
