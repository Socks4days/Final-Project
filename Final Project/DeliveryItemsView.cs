using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class DeliveryItemsView
    {
        public int orderNumber {  get; set; }
        public int? deliveryNumber { get; set; }
        public DateTime? deliveryDate { get; set; }
        public int stockId { get; set; }
        public string stockName { get; set; }
        public int? quantityDelivered { get; set; }
        public int? quantityFaulty { get; set; }

        public DeliveryItemsView() { }
        
        public DeliveryItemsView(int orderNumber, int? deliveryNumber, DateTime? deliveryDate, int stockId, string stockName, int? quantityDelivered, int? quantityFaulty)
        {
            this.orderNumber = orderNumber;
            this.deliveryNumber = deliveryNumber;
            this.deliveryDate = deliveryDate;
            this.stockId = stockId;
            this.stockName = stockName;
            this.quantityDelivered = quantityDelivered;
            this.quantityFaulty = quantityFaulty;
        }   
    }
}
