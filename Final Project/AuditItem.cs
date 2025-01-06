using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
	public class AuditItem
	{
		public int auditId {  get; set; }
		public int stockId {  get; set; }
		public int predictedAmount { get; set; }
		public int actualAmount { get; set; }

		public AuditItem() { }
		public AuditItem(int auditId, int stockId, int predictedAmount, int actualAmount)
		{
			this.auditId = auditId;
			this.stockId = stockId;
			this.predictedAmount = predictedAmount;
			this.actualAmount = actualAmount;
		}
	}
}
