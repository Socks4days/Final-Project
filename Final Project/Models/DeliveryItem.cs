using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	// Holds details of the specific stock items received as part of a delivery
	// Used when adding a new delivery item
	// The DeliveryItemView is used to give an extended view when retrieving the list of existing items for a delivery
	public class DeliveryItem
	{
		public int deliveryNumber { get; set; }
		public int stockId { get; set; }
		public int quantityDelivered { get; set; }
		public int quantityFaulty { get; set; }

		// Default constructor method
		public DeliveryItem() { }

	}
}
