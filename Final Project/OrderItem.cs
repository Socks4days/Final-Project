using Final_Project.Models;
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
        public string stockName { get; set; }
        public decimal unitPrice { get; set; }
        public decimal totalPrice { get; set; }
        public int orderItemQuantity { get; set; }
        public int unitSize { get; set; }

        #endregion Properties

        public OrderItem()
        {

        }

        public OrderItem(int orderNumber, int stockId, int orderItemQuantity)
        {
            this.orderNumber = orderNumber;
            this.stockId = stockId;
            this.orderItemQuantity = orderItemQuantity;
            Stock stock = StockDal.GetStockByStockId(stockId);
            this.stockName = stock.stockName;
            this.unitPrice = stock.price;
            this.totalPrice = this.unitPrice * this.orderItemQuantity;
            this.unitSize = stock.orderQuantity;
        }
    }
}
