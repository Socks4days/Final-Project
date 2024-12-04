using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class OrderItem
    {
        #region Properties

        public int orderNumber { get; set; }
        public int stockId { get; set; }
        public int orderItemQuantity { get; set; }

        #endregion Properties

        public OrderItem()
        {

        }

        public OrderItem(int orderNumber, int stockId, int orderItemQuantity)
        {
            this.orderNumber = orderNumber;
            this.stockId = stockId;
            this.orderItemQuantity = orderItemQuantity;
        }
    }
}
