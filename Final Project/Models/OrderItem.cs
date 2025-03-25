using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Final_Project.Models
{
	// Holds details of an order line for an order
	public class OrderItem
	{
		#region Properties
		public int orderNumber { get; set; }
		public int stockId { get; set; }
		public string stockName { get; set; }
		public decimal unitPrice { get; set; }
		public decimal totalPrice { get; set; }
		public int orderItemQuantity { get; set; }
		public int recommendedOrderItemQuantity { get; set; }
		#endregion Properties

		// Default constructor method
		public OrderItem()
		{
			stockName = "";
		}

		// Main constructor method with order item details
		public OrderItem(int orderNumber, int stockId, int orderItemQuantity)
		{
			this.orderNumber = orderNumber;
			this.stockId = stockId;
			this.orderItemQuantity = orderItemQuantity;
			Stock stock = StockDal.GetStockByStockId(stockId);
			stockName = stock.stockName;
			unitPrice = stock.price;
			totalPrice = unitPrice * this.orderItemQuantity;
			recommendedOrderItemQuantity = stock.orderQuantity;
		}
	}
}
