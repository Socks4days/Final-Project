using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Stock
    {

        #region Properties
        public int stockId {  get; set; }

        public string stockName { get; set; }

        public string stockDescription { get; set; }

        public decimal price { get; set; }

        public int deliveryTimeDays { get; set; }

        public int maximumLevel { get; set; }   

        public int minimumLevel { get; set; }

        public int orderQuantity { get; set; }

        public int stockCheckFrequency { get; set; }

        public int stockLevel { get; set; } 

        public int lastUpdatedByStaffId { get; set; }
        public bool active { get; set; } = true;

        public int? numberOnOrder { get; set; }

#endregion Properties

        public Stock()
		{
			this.stockName = "";
			this.stockDescription = "";
		}

		public Stock(string stockName, string stockDescription, decimal price, int deliveryTimeDays, int maximumLevel, int minimumLevel, int orderQuantity, int stockCheckFrequency, int stockLevel, int lastUpdatedByStaffId, bool active)
		{
			this.stockName = stockName;
			this.stockDescription = stockDescription!;
			this.price = price;
			this.deliveryTimeDays = deliveryTimeDays;
			this.maximumLevel = maximumLevel;
			this.minimumLevel = minimumLevel;
			this.orderQuantity = orderQuantity;
			this.stockCheckFrequency = stockCheckFrequency;
			this.stockLevel = stockLevel;
			this.lastUpdatedByStaffId = lastUpdatedByStaffId;
			this.active = active;
		}

		public Stock (string stockName, string stockDescription, decimal price, int deliveryTimeDays, int maximumLevel, int minimumLevel, int orderQuantity, int stockCheckFrequency, int stockLevel, int lastUpdatedByStaffId) :
            this(stockName, stockDescription, price, deliveryTimeDays, maximumLevel, minimumLevel, orderQuantity, stockCheckFrequency, stockLevel, lastUpdatedByStaffId, true) { }

		public Stock(int stockId, string stockName, string stockDescription, decimal price, int deliveryTimeDays, int maximumLevel, int minimumLevel, int orderQuantity, int stockCheckFrequency, int stockLevel, int lastUpdatedByStaffId, bool active) :
			this(stockName, stockDescription, price, deliveryTimeDays, maximumLevel, minimumLevel, orderQuantity, stockCheckFrequency, stockLevel, lastUpdatedByStaffId, active)
		{
			this.stockId = stockId;
		}

	}
}
