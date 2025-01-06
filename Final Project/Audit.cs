using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
	public class Audit
	{
		private int auditId { get; set; }
		private DateTime auditDate { get; set; }
		private int auditedByStaffId { get; set; }

		public Audit() { }
		public Audit(int auditId, DateTime auditDate, int auditedByStaffId)
		{
			this.auditId = auditId;
			this.auditDate = auditDate;
			this.auditedByStaffId = auditedByStaffId;
		}
	}
}
