using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Final_Project.Models;


namespace Final_Project
{
    public class OrderDal
    {
        private static string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string projectDirectoryPath = Directory.GetParent(workingDirectoryPath).Parent.Parent.Parent.FullName;
        private static string _connectionstring = string.Format(ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ConnectionString, projectDirectoryPath);

		public static Order AddOrder(Order newOrder)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand insertOrderCommand = new SqlCommand();
				insertOrderCommand.Connection = connection;

				insertOrderCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertOrderCommand.CommandText = "AddOrder";

				SqlParameter dbOrderNumber = new SqlParameter("@OrderNumber", newOrder.orderNumber);
				dbOrderNumber.Direction = System.Data.ParameterDirection.Output;

				insertOrderCommand.Parameters.Add(dbOrderNumber);
				insertOrderCommand.Parameters.Add(new SqlParameter("@OrderDate", newOrder.orderDate));
				insertOrderCommand.Parameters.Add(new SqlParameter("@OrderPlacedByStaffId", newOrder.orderPlacedByStaffId));
				insertOrderCommand.Parameters.Add(new SqlParameter("@OrderStatus", newOrder.orderStatus));

				int rowsAffected = insertOrderCommand.ExecuteNonQuery();

				newOrder.orderNumber = Convert.ToInt32(dbOrderNumber.Value);

				connection.Close();
				return newOrder;
			}
		}

		public static int AddOrderItem(OrderItem newOrderItem)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand insertOrderItemCommand = new SqlCommand();
				insertOrderItemCommand.Connection = connection;

				insertOrderItemCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertOrderItemCommand.CommandText = "AddOrderItem";

				insertOrderItemCommand.Parameters.Add(new SqlParameter("@OrderNumber", newOrderItem.orderNumber));
				insertOrderItemCommand.Parameters.Add(new SqlParameter("@StockId", newOrderItem.stockId));
				insertOrderItemCommand.Parameters.Add(new SqlParameter("@OrderItemQuantity", newOrderItem.orderItemQuantity));

				int rowsAffected = insertOrderItemCommand.ExecuteNonQuery();

				connection.Close();

				return rowsAffected;
			}
		}

		public static void UpdateOrderStatus(Order order)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand insertOrderStatusCommand = new SqlCommand();
				insertOrderStatusCommand.Connection = connection;

				insertOrderStatusCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertOrderStatusCommand.CommandText = "UpdateOrderStatus";

				insertOrderStatusCommand.Parameters.Add(new SqlParameter("@OrderNumber", order.orderNumber));
				insertOrderStatusCommand.Parameters.Add(new SqlParameter("@OrderStatus", order.orderStatus));

				insertOrderStatusCommand.ExecuteNonQuery();
				connection.Close();
			}
		}

		public static void SetOrderPlacedBy(Order newOrder)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand insertOrderPlacedByCommand = new SqlCommand();
				insertOrderPlacedByCommand.Connection = connection;

				insertOrderPlacedByCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertOrderPlacedByCommand.CommandText = "SetOrderPlacedBy";

				insertOrderPlacedByCommand.Parameters.Add(new SqlParameter("@OrderNumber", newOrder.orderNumber));
				insertOrderPlacedByCommand.Parameters.Add(new SqlParameter("@OrderPlacedByStaffId", newOrder.orderPlacedByStaffId));

				insertOrderPlacedByCommand.ExecuteNonQuery();

				connection.Close();
			}
		}

		public static int RemoveOrderItem(OrderItem orderItemToRemove)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand removeOrderItemCommand = new SqlCommand();
				removeOrderItemCommand.Connection = connection;

				removeOrderItemCommand.CommandType = System.Data.CommandType.StoredProcedure;
				removeOrderItemCommand.CommandText = "RemoveOrderItem";

				removeOrderItemCommand.Parameters.Add(new SqlParameter("@OrderNumber", orderItemToRemove.orderNumber));
				removeOrderItemCommand.Parameters.Add(new SqlParameter("@StockId", orderItemToRemove.stockId));

				int rowsAffected = removeOrderItemCommand.ExecuteNonQuery();

				connection.Close();

				return rowsAffected;
			}
		}

		public static List<Order> GetAllOrders(string orderBy)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				List<Order> orders = new List<Order>();
				connection.Open();

				string sqlQuery = "SELECT * FROM [Order] ORDER BY OrderNumber ";

				if (orderBy == "DESC")
					sqlQuery += "DESC";
				else if (orderBy == "ASC")
					sqlQuery += "ASC";

				SqlCommand getAllOrdersCommand = new SqlCommand(sqlQuery, connection);

				SqlDataReader sqlDataReader = getAllOrdersCommand.ExecuteReader();

				while (sqlDataReader.Read())
				{
					Order order = new Order(

						(int)sqlDataReader["OrderNumber"],
						(DateTime)sqlDataReader["OrderDate"],
						(int)sqlDataReader["OrderPlacedByStaffId"],
						(string)sqlDataReader["OrderStatus"]
					);
					orders.Add(order);
				}

				connection.Close();
				return orders;
			}
		}

		public static List<OrderItem> GetAllOrderItems(int orderNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<OrderItem> orderItems = new List<OrderItem>();
                connection.Open();

                string sqlQuery = $"SELECT * FROM OrderItem WHERE OrderNumber = {orderNumber}";

                SqlCommand getAllOrderItemsCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllOrderItemsCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    OrderItem orderItem = new OrderItem(

                        (int)sqlDataReader["OrderNumber"],
                        (int)sqlDataReader["StockId"],
                        (int)sqlDataReader["OrderItemQuantity"]                        
                        );

                    orderItems.Add(orderItem);
                }

                connection.Close();
                return orderItems;
            }
        }

		public static Order GetOrderByOrderNumber(int orderNumber)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				Order order = new Order();
				connection.Open();

				string sqlQuery = string.Format($"SELECT * FROM [Order] WHERE OrderNumber = {orderNumber}");

				SqlCommand getOrderByOrderNumber = new SqlCommand(sqlQuery, connection);

				SqlDataReader sqlDataReader = getOrderByOrderNumber.ExecuteReader();

				while (sqlDataReader.Read())
				{
					order = new Order(
						(int)sqlDataReader["OrderNumber"],
						(DateTime)sqlDataReader["OrderDate"],
						(int)sqlDataReader["OrderPlacedByStaffId"],
						(string)sqlDataReader["OrderStatus"]
						);
				}

				connection.Close();
				return order;
			}
		}

		public static List<Order> GetAllOrdersWithDeliveryDetails()
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				List<Order> orders = new List<Order>();
				connection.Open();

				string sqlQuery = "SELECT * FROM [OrdersView] ORDER BY OrderNumber DESC";

				SqlCommand getAllOrdersCommand = new SqlCommand(sqlQuery, connection);

				SqlDataReader sqlDataReader = getAllOrdersCommand.ExecuteReader();

				while (sqlDataReader.Read())
				{
					Order order = new Order(

						(int)sqlDataReader["OrderNumber"],
						(DateTime)sqlDataReader["OrderDate"],
						(int)sqlDataReader["OrderPlacedByStaffId"],
						(string)sqlDataReader["OrderStatus"],
						GetSqlString(sqlDataReader, "OrderPlacedByStaffName"),
						GetSqlDate(sqlDataReader, "MinDeliveryDueDate"),
						GetSqlDate(sqlDataReader, "MaxDeliveryDueDate"),
						GetSqlDate(sqlDataReader, "LastDeliveryDate")
					);
					orders.Add(order);
				}

				connection.Close();
				return orders;
			}
		}

		public static DateTime? GetSqlDate(SqlDataReader sqlDataReader, string columnName)
		{
			var dbDateTime = sqlDataReader[columnName];
			DateTime? dateTime = null;
			if (dbDateTime != DBNull.Value)
				dateTime = Convert.ToDateTime(dbDateTime);
			return dateTime;
		}

		public static string GetSqlString(SqlDataReader sqlDataReader, string columnName)
		{
			var dbString = sqlDataReader[columnName];
			string returnString = "";
			if (dbString != DBNull.Value)
				returnString = (string)dbString;
			return returnString;
		}

		public static OrderItem GetOrderItemByOrderNumberAndStockId(int orderNumber, int stockId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                OrderItem orderItem = new OrderItem();
                connection.Open();

                string sqlQuery = $"SELECT * FROM OrderItem WHERE OrderNumber = {orderNumber} AND StockId = {stockId}";

                SqlCommand getOrderItemByOrderNumberAndStockIdCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getOrderItemByOrderNumberAndStockIdCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                     orderItem = new OrderItem(

                        (int)sqlDataReader["OrderNumber"],
                        (int)sqlDataReader["StockId"],
                        (int)sqlDataReader["OrderItemQuantity"]
                        );
                }

                connection.Close();
                return orderItem;
            }
        }

		public static List<OrderItemsDeliveredView> GetOrderItemDiscrepancies()
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				List<OrderItemsDeliveredView> orderItemsDelivered = new List<OrderItemsDeliveredView>();

				connection.Open();

				string sqlQuery = "SELECT * " +
					"FROM OrderItemsDeliveredView " +
					"WHERE (QuantityDelivered - QuantityFaulty) < OrderItemQuantity " +
					"ORDER BY OrderNumber DESC";

				SqlCommand getAllOrderItemsDeliveredCommand = new SqlCommand(sqlQuery, connection);

				SqlDataReader sqlDataReader = getAllOrderItemsDeliveredCommand.ExecuteReader();

				while (sqlDataReader.Read())
				{
					OrderItemsDeliveredView orderItemDelivered = new OrderItemsDeliveredView(
						(int)sqlDataReader["OrderNumber"],
						(int)sqlDataReader["StockId"],
						(string)sqlDataReader["StockName"],
						(int)sqlDataReader["OrderItemQuantity"],
						(DateTime)sqlDataReader["DeliveryDate"],
						(int)sqlDataReader["QuantityDelivered"],
						(int)sqlDataReader["QuantityFaulty"]
						);

					orderItemsDelivered.Add(orderItemDelivered);
				}

				connection.Close();
				return orderItemsDelivered;
			}
		}
	}
}
