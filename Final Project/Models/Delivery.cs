using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	// Holds details of a delivery for an order
	public class Delivery
	{
		public int deliveryNumber { get; set; }
		public int orderNumber { get; set; }
		public DateTime deliveryDate { get; set; }
		public int deliveryCheckedByStaffId { get; set; }

		// Defult constructor method
		public Delivery() { }

		// Main constructor method with delivery details
		public Delivery(int deliveryNumber, int orderNumber, DateTime deliveryDate, int deliveryCheckedByStaffId)
		{
			this.deliveryNumber = deliveryNumber;
			this.orderNumber = orderNumber;
			this.deliveryDate = deliveryDate;
			this.deliveryCheckedByStaffId = deliveryCheckedByStaffId;
		}
	}
}
