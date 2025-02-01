using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class OrderItemsDeliveredView: OrderItem
    {
        #region Properties
        public string stockName { get; set; }
        public DateTime? deliveryDate { get; set; }
        public int? quantityDelivered { get; set; }
        public int? quantityFaulty { get; set; }       

        #endregion Properties

        public OrderItemsDeliveredView()
        {

        }

        public OrderItemsDeliveredView(int orderNumber, int stockId, string stockName, int orderItemQuantity, DateTime? deliveryDate, int? quantityDelivered, int? quantityFaulty): base(orderNumber, stockId, orderItemQuantity)
        {
            this.stockName = stockName;
            this.deliveryDate = deliveryDate;
            this.quantityDelivered = quantityDelivered;
            this.quantityFaulty = quantityFaulty;
        }
    }
}
