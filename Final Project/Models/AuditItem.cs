using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	// Holds details of teh specific stock items that were checked as part of an audit
	public class AuditItem
	{
		public int auditId { get; set; }
		public int stockId { get; set; }
		public int predictedAmount { get; set; }
		public int actualAmount { get; set; }

		// Defult constructor method
		public AuditItem() { }

		// Main constructor method with audit item details
		public AuditItem(int auditId, int stockId, int predictedAmount, int actualAmount)
		{
			this.auditId = auditId;
			this.stockId = stockId;
			this.predictedAmount = predictedAmount;
			this.actualAmount = actualAmount;
		}
	}
}
