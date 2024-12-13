using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Order
    {
        #region Properties
        public int orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public int orderPlacedByStaffId { get; set; }
        public string orderStatus { get; set; }

        #endregion Properties
        public Order()
        {

        }
        public Order(int orderNumber, DateTime orderDate, int orderPlacedByStaffId, string orderStatus)
        {
            this.orderNumber = orderNumber;
            this.orderDate = orderDate;
            this.orderPlacedByStaffId = orderPlacedByStaffId;
            this.orderStatus = orderStatus;
        }
    }
}
