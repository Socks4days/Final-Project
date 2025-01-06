using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
	public class AuditItem
	{
		private int auditId {  get; set; }
		private int stockId {  get; set; }
		private int predictedAmount { get; set; }
		private int actualAmount { get; set; }

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
