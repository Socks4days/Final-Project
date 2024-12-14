using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Models;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public class DeliveryDal
    {
        private static string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string projectDirectoryPath = Directory.GetParent(workingDirectoryPath).Parent.Parent.Parent.FullName;
        private static string _connectionstring = string.Format(ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ConnectionString, projectDirectoryPath);

        public static List<DeliveryItem> GetAllDeliveryItems(int deliveryNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<DeliveryItem> deliveryItems = new List<DeliveryItem>();
                connection.Open();

                string sqlQuery = $"SELECT * FROM DeliveryItem WHERE deliveryNumber = {deliveryNumber}";

                SqlCommand getAllDeliveryItemsCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllDeliveryItemsCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DeliveryItem deliveryItem = new DeliveryItem(

                        (int)sqlDataReader["DeliveryNumber"],
                        (int)sqlDataReader["StockId"],
                        (int)sqlDataReader["QuantityDelivered"],
                        (int)sqlDataReader["QuantityFaulty"]
                        );

                    deliveryItems.Add(deliveryItem);
                }
                return deliveryItems;
            }
        }

        public static int AddDeliveryItem(DeliveryItem newDeliveryItem)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand insertDeliveryItemCommand = new SqlCommand();
                insertDeliveryItemCommand.Connection = connection;

                insertDeliveryItemCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertDeliveryItemCommand.CommandText = "AddDeliveryItem";

                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@DeliveryNumber", newDeliveryItem.deliveryNumber));
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@StockId", newDeliveryItem.stockId));
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@QuantityDelivered", newDeliveryItem.quantityDelivered));
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@QuantityFaulty", newDeliveryItem.quantityFaulty));

                int rowsAffected = insertDeliveryItemCommand.ExecuteNonQuery();

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

        public static Delivery GetDeliveryByDeliveryNumber(int deliveryNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                Delivery delivery = new Delivery();
                connection.Open();

                string sqlQuery = string.Format($"SELECT * FROM [Delivery] WHERE DeliveryNumber = {deliveryNumber}");

                SqlCommand getDeliveryByDeliveryNumber = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getDeliveryByDeliveryNumber.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    delivery = new Delivery(
                        (int)sqlDataReader["DeliveryNumber"],
                        (int)sqlDataReader["OrderNumber"],
                        (DateTime)sqlDataReader["DeliveryDate"],
                        (int)sqlDataReader["DeliveryCheckedByStaffId"]
                        );
                }
                return delivery;
            }
        }
    }
}
