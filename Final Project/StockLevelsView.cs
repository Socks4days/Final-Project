using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class StockLevelsView
    {
        #region Properties
        public int stockId { get; set; }
        public string stockName { get; set; }  
        public int stockLevel { get; set; }
        public int auditedByStaffId { get; set; }
        public string auditedByStaffFullName { get; set; }
        public DateTime? auditDate { get; set; }
		public DateTime? nextAuditDueDate { get; set; }
        public int daysToNextAudit { get; set; }

		#endregion Properties

		public StockLevelsView() { }

        public StockLevelsView(int stockId, string stockName, int stockLevel, DateTime? auditDate, int auditedByStaffId, string auditedByStaffFullName, DateTime? nextAuditDueDate, int daysToNextAudit)
        {
            this.stockId = stockId;
            this.stockName = stockName;            
            this.stockLevel = stockLevel;
            this.auditDate = auditDate;                      
            this.auditedByStaffId = auditedByStaffId;
            this.auditedByStaffFullName = auditedByStaffFullName;
            this.nextAuditDueDate = nextAuditDueDate;
            this.daysToNextAudit = daysToNextAudit;
        }
    }
}
