using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Models
{
	public class Order
	{
		#region Properties
		public int orderNumber { get; set; }
		public DateTime orderDate { get; set; }
		public int orderPlacedByStaffId { get; set; }
		public string orderStatus { get; set; }

		// Status values for orders and order items
		public const string Draft = "Draft";
		public const string Placed = "Placed";
		public const string NotReceived = "Not Received";
		public const string PartFilled = "Part Filled";
		public const string Fulfilled = "Fulfilled";
		public const string Completed = "Completed";

		public string orderPlacedByStaffName { get; set; }
		public DateTime? minDeliveryDueDate { get; set; }
		public DateTime? maxDeliveryDueDate { get; set; }
		public DateTime? lastDeliveryDate { get; set; }


		#endregion Properties
		public Order()
		{
			this.orderNumber = 0;
			this.orderDate = System.DateTime.Now;
			this.orderPlacedByStaffId = 0;
			this.orderStatus = "";
			this.orderPlacedByStaffName = "";
		}
		public Order(int orderNumber, DateTime orderDate, int orderPlacedByStaffId, string orderStatus)
		{
			this.orderNumber = orderNumber;
			this.orderDate = orderDate;
			this.orderPlacedByStaffId = orderPlacedByStaffId;
			this.orderStatus = orderStatus;
			this.orderPlacedByStaffName = "";
		}

		public Order(int orderNumber, DateTime orderDate, int orderPlacedByStaffId, string orderStatus,
			string orderPlacedByStaffName, DateTime? minDeliveryDueDate, DateTime? maxDeliveryDueDate, DateTime? lastDeliveryDate)
		{
			this.orderNumber = orderNumber;
			this.orderDate = orderDate;
			this.orderPlacedByStaffId = orderPlacedByStaffId;
			this.orderStatus = orderStatus;
			this.orderPlacedByStaffName = orderPlacedByStaffName;
			this.minDeliveryDueDate = minDeliveryDueDate;
			this.maxDeliveryDueDate = maxDeliveryDueDate;
			this.lastDeliveryDate = lastDeliveryDate;
		}
	}
}
