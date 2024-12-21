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

        #endregion Properties

        public StockLevelsView() { }

        public StockLevelsView(int StockId, string stockName, int stockLevel, DateTime? auditDate, int auditedByStaffId, string auditedByStaffFullName)
        {
            this.stockId = StockId;
            this.stockName = stockName;            
            this.stockLevel = stockLevel;
            this.auditDate = auditDate;                      
            this.auditedByStaffId = auditedByStaffId;
            this.auditedByStaffFullName = auditedByStaffFullName;
        }
    }
}
