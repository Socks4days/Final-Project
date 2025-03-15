using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    // Extended view inheriting from an OrderItem including extra delivery details
	public class OrderItemDeliveredView: OrderItem
    {
        #region Properties
        public DateTime? deliveryDate { get; set; }
        public int? quantityDelivered { get; set; }
        public int? quantityFaulty { get; set; }       

        #endregion Properties

        // Default constructor
        public OrderItemDeliveredView() { }        

        // Main constructor with order item and delivery details
        // Uses base constructor from OrderItem class
        public OrderItemDeliveredView(int orderNumber, int stockId, string stockName, int orderItemQuantity, DateTime? deliveryDate, int? quantityDelivered, int? quantityFaulty): base(orderNumber, stockId, orderItemQuantity)
        {
            this.stockName = stockName;
            this.deliveryDate = deliveryDate;
            this.quantityDelivered = quantityDelivered;
            this.quantityFaulty = quantityFaulty;
        }
    }
}
