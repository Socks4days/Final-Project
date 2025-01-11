using Microsoft.Data.SqlClient;
using System.Configuration;

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

                connection.Close();
                return deliveryItems;
            }
        }

        public static List<OrderItemsDeliveredView> GetOrderItemsDeliveredView(int orderNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<OrderItemsDeliveredView> deliveryItems = new List<OrderItemsDeliveredView>();
                connection.Open();

                string sqlQuery = $"SELECT * FROM OrderItemsDeliveredView WHERE OrderNumber = {orderNumber} ORDER BY StockName";

                SqlCommand getAllDeliveryItemsCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllDeliveryItemsCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int? deliveryNumber = null;                   
                    DateTime? deliveryDate = null;
                    int? quantityDelivered = null;
                    int? quantityFaulty = null;

                    var dbDeliveryDateTime = sqlDataReader["DeliveryDate"];
                    if (dbDeliveryDateTime != DBNull.Value)
                        deliveryDate = Convert.ToDateTime(dbDeliveryDateTime);

                    var dbQuantityDelivered = sqlDataReader["QuantityDelivered"];
                    if (dbQuantityDelivered != DBNull.Value)
                        quantityDelivered = Convert.ToInt32(dbQuantityDelivered);

                    var dbQuantityFaulty = sqlDataReader["QuantityFaulty"];
                    if (dbQuantityFaulty != DBNull.Value)
                        quantityFaulty = Convert.ToInt32(dbQuantityFaulty);

                    OrderItemsDeliveredView deliveryItem = new OrderItemsDeliveredView(
                        (int)sqlDataReader["OrderNumber"],
                        (int)sqlDataReader["StockId"],
                        (string)sqlDataReader["StockName"],
                        (int)sqlDataReader["OrderItemQuantity"],
                        deliveryDate,
                        quantityDelivered,
                        quantityFaulty
                        );

                    deliveryItems.Add(deliveryItem);
                }

                connection.Close();
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

        public static List<Delivery> GetAllDeliveries()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<Delivery> deliveries = new List<Delivery>();
                connection.Open();

                string sqlQuery = "SELECT * FROM Delivery";

                SqlCommand getAllDeliveriesCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllDeliveriesCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Delivery delivery = new Delivery(

                        (int)sqlDataReader["DeliveryNumber"],
                        (int)sqlDataReader["OrderNumber"],
                        (DateTime)sqlDataReader["DeliveryDate"],
                        (int)sqlDataReader["DeliveryCheckedByStaffId"]
                        );
                    deliveries.Add(delivery);
                }

                connection.Close();
                return deliveries;
            }
        }

        public static Delivery AddDelivery(Delivery newDelivery)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand insertDeliveryCommand = new SqlCommand();
                insertDeliveryCommand.Connection = connection;

                insertDeliveryCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertDeliveryCommand.CommandText = "AddDelivery";

                SqlParameter dbDeliveryNumber = new SqlParameter("@DeliveryNumber", 0);
                dbDeliveryNumber.Direction = System.Data.ParameterDirection.Output;

                insertDeliveryCommand.Parameters.Add(dbDeliveryNumber);
                insertDeliveryCommand.Parameters.Add(new SqlParameter("@OrderNumber", newDelivery.orderNumber));
                insertDeliveryCommand.Parameters.Add(new SqlParameter("@DeliveryDate", newDelivery.deliveryDate));
                insertDeliveryCommand.Parameters.Add(new SqlParameter("@DeliveryCheckedByStaffId", newDelivery.deliveryCheckedByStaffId));

                int rowsAffected = insertDeliveryCommand.ExecuteNonQuery();

                newDelivery.deliveryNumber = Convert.ToInt32(dbDeliveryNumber.Value);

                connection.Close();

                return newDelivery;
            }
        }

        public static Delivery GetDeliveryByDeliveryNumber(int deliveryNumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                Delivery delivery = new Delivery();
                connection.Open();

                string sqlQuery = string.Format($"SELECT * FROM Delivery WHERE DeliveryNumber = {deliveryNumber}");

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

                connection.Close();
                return delivery;
            }
        }

        public static List<DeliveryItemsView> GetDeliveryItemsView(int deliveryNumberToLookup)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<DeliveryItemsView> deliveryItems = new List<DeliveryItemsView>();

                connection.Open();

                string sqlQuery = $"SELECT * FROM DeliveryItemsView WHERE DeliveryNumber = {deliveryNumberToLookup} ORDER BY StockName";

                SqlCommand getAllDeliveryItemsCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllDeliveryItemsCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int? deliveryNumber = null;
                    DateTime? deliveryDate = null;
                    int? quantityDelivered = null;
                    int? quantityFaulty = null;

                    var dbDeliveryDateTime = sqlDataReader["DeliveryDate"];
                    if (dbDeliveryDateTime != DBNull.Value)
                        deliveryDate = Convert.ToDateTime(dbDeliveryDateTime);

                    var dbQuantityDelivered = sqlDataReader["QuantityDelivered"];
                    if (dbQuantityDelivered != DBNull.Value)
                        quantityDelivered = Convert.ToInt32(dbQuantityDelivered);

                    var dbQuantityFaulty = sqlDataReader["QuantityFaulty"];
                    if (dbQuantityFaulty != DBNull.Value)
                        quantityFaulty = Convert.ToInt32(dbQuantityFaulty);

                    DeliveryItemsView deliveryItem = new DeliveryItemsView(
                        (int)sqlDataReader["OrderNumber"],
                        (int)sqlDataReader["StockId"],
                        deliveryDate,
                        (int)sqlDataReader["StockId"],
                        (string)sqlDataReader["StockName"],                        
                        quantityDelivered,
                        quantityFaulty
                        );

                    deliveryItems.Add(deliveryItem);
                }

                connection.Close();
                return deliveryItems;
            }
        }
    }
}
