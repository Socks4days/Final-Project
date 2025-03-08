using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	public class DeliveryItem
	{
		public int deliveryNumber { get; set; }
		public int stockId { get; set; }
		public int quantityDelivered { get; set; }
		public int quantityFaulty { get; set; }

		public DeliveryItem() { }

		public DeliveryItem(int deliveryNumber, int stockId, int quantityDelivered, int quantityFaulty)
		{
			this.deliveryNumber = deliveryNumber;
			this.stockId = stockId;
			this.quantityDelivered = quantityDelivered;
			this.quantityFaulty = quantityFaulty;
		}
	}
}
