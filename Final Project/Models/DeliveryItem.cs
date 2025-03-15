using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	// Holds details of the specific stock items received as part of a delivery
	public class DeliveryItem
	{
		public int deliveryNumber { get; set; }
		public int stockId { get; set; }
		public int quantityDelivered { get; set; }
		public int quantityFaulty { get; set; }

		// Defult constructor method

		public DeliveryItem() { }

		// Main constructor method with delivery details
		public DeliveryItem(int deliveryNumber, int stockId, int quantityDelivered, int quantityFaulty)
		{
			this.deliveryNumber = deliveryNumber;
			this.stockId = stockId;
			this.quantityDelivered = quantityDelivered;
			this.quantityFaulty = quantityFaulty;
		}
	}
}
