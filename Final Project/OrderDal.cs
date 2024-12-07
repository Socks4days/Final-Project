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

        public static List<OrderItem> GetAllOrderItems(int orderNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<OrderItem> orderItems = new List<OrderItem>();
                connection.Open();

                string sqlQuery = $"SELECT * FROM OrderItem WHERE orderNumber = {orderNumber}";

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
                return orderItems;
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

        public static List<Order> GetAllOrders()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<Order> orders = new List<Order>();
                connection.Open();

                string sqlQuery = "SELECT * FROM [Order]";

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
                return orders;
            }
        }

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
                return order;
            }
        }

        public static void UpdateOrderStatus(Order order)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                string sqlQuery = string.Format($"UPDATE [Order] SET OrderStatus = '{order.orderStatus}' WHERE OrderNumber = {order.orderNumber}");

                SqlCommand updateOrderStatusByOrderNumber = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = updateOrderStatusByOrderNumber.ExecuteReader();
            }
        }
    }
}
