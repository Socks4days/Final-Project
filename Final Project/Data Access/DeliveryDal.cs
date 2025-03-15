using Microsoft.Data.SqlClient;
using System.Configuration;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using System.Collections.Generic;
using Final_Project.Models;
using Final_Project.Data_Access;

namespace Final_Project
{
    // Manage access to the Delivery and DeliveryItem tables
	public class DeliveryDal
    {
        // Get connection string using DalHelper class
        private static string _connectionstring = DalHelper._connectionstring;

        // Get a list of items for an order (with number delivered/remaining)
        public static List<OrderItemsDeliveredView> GetOrderItemsDeliveredView(int orderNumber)
        {
			List<OrderItemsDeliveredView> deliveryItems = new List<OrderItemsDeliveredView>();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                // Build run run SQL query to get list of order items using view
                connection.Open();
                string sqlQuery = $"SELECT * FROM OrderItemsDeliveredView WHERE OrderNumber = {orderNumber} ORDER BY StockName";
                SqlCommand getAllDeliveryItemsCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getAllDeliveryItemsCommand.ExecuteReader();

				// Create an OrderItemsDeliveredView object for each row returned
				while (sqlDataReader.Read())
                {
					OrderItemsDeliveredView deliveryItem = new OrderItemsDeliveredView(
                        (int)sqlDataReader["OrderNumber"],
                        (int)sqlDataReader["StockId"],
                        (string)sqlDataReader["StockName"],
                        (int)sqlDataReader["OrderItemQuantity"],
				        DalHelper.GetSqlDate(sqlDataReader, "DeliveryDate"),
					    DalHelper.GetSqlInt(sqlDataReader, "QuantityDelivered"),
					    DalHelper.GetSqlInt(sqlDataReader, "QuantityFaulty")
                        );
                    deliveryItems.Add(deliveryItem);
                }
                connection.Close();

				// Return a list of OrderItemsDeliveredView objects
				return deliveryItems;
            }
        }

        // Create a new delivery item for a delivery
        public static int AddDeliveryItem(DeliveryItem newDeliveryItem)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                // Call AddDeliveryItem stored procedure with details from DeliveryItem object provided
                connection.Open();
                SqlCommand insertDeliveryItemCommand = new SqlCommand();
                insertDeliveryItemCommand.Connection = connection;
                insertDeliveryItemCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertDeliveryItemCommand.CommandText = "AddDeliveryItem";
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@DeliveryNumber", newDeliveryItem.deliveryNumber));
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@StockId", newDeliveryItem.stockId));
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@QuantityDelivered", newDeliveryItem.quantityDelivered));
                insertDeliveryItemCommand.Parameters.Add(new SqlParameter("@QuantityFaulty", newDeliveryItem.quantityFaulty));

                // Get and return the number of rows created (1 = success, 0 = failure)
                int rowsAffected = insertDeliveryItemCommand.ExecuteNonQuery();
                connection.Close();
                return rowsAffected;
            }
        }

        // Create a new delivery
        public static Delivery AddDelivery(Delivery newDelivery)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                // Call AddDelivery stored procedure with details from the Delivery object provided
                connection.Open();
                SqlCommand insertDeliveryCommand = new SqlCommand();
                insertDeliveryCommand.Connection = connection;
                insertDeliveryCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertDeliveryCommand.CommandText = "AddDelivery";
                // Set DeliveryNumber as an output parameter
                SqlParameter dbDeliveryNumber = new SqlParameter("@DeliveryNumber", newDelivery.deliveryNumber);
                dbDeliveryNumber.Direction = System.Data.ParameterDirection.Output;
                insertDeliveryCommand.Parameters.Add(dbDeliveryNumber);
                insertDeliveryCommand.Parameters.Add(new SqlParameter("@OrderNumber", newDelivery.orderNumber));
                insertDeliveryCommand.Parameters.Add(new SqlParameter("@DeliveryDate", newDelivery.deliveryDate));
                insertDeliveryCommand.Parameters.Add(new SqlParameter("@DeliveryCheckedByStaffId", newDelivery.deliveryCheckedByStaffId));
				int rowsAffected = insertDeliveryCommand.ExecuteNonQuery();

				// Update the Delivery object with the id of the row created and return the updated Delivery object 
				newDelivery.deliveryNumber = Convert.ToInt32(dbDeliveryNumber.Value);
                connection.Close();
                return newDelivery;
            }
        }

        // Get all delivery items for a delivery
        public static List<DeliveryItemsView> GetDeliveryItemsView(int deliveryNumberToLookup)
        {
			List<DeliveryItemsView> deliveryItems = new List<DeliveryItemsView>();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                // Build and run SQL query to get delivery items using the DeliveryItemsView which includes the total number delivered and number of faulty items
                connection.Open();
                string sqlQuery = $"SELECT * FROM DeliveryItemsView WHERE DeliveryNumber = {deliveryNumberToLookup} ORDER BY StockName";
                SqlCommand getAllDeliveryItemsCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getAllDeliveryItemsCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    // Create a DeliveryItemsView object for each row returned
                    DeliveryItemsView deliveryItem = new DeliveryItemsView(
                        (int)sqlDataReader["OrderNumber"],
                        (int)sqlDataReader["DeliveryNumber"],
                        DalHelper.GetSqlDate(sqlDataReader, "DeliveryDate"),
                        (int)sqlDataReader["StockId"],
                        (string)sqlDataReader["StockName"],                        
                        DalHelper.GetSqlInt(sqlDataReader, "QuantityDelivered"),
                        DalHelper.GetSqlInt(sqlDataReader, "QuantityFaulty")
                        );
                    deliveryItems.Add(deliveryItem);
                }
                connection.Close();

                // Return a list of DeliveryItemsView objects
                return deliveryItems;
            }
        }

        // Record the name of the person who checked a delivery against the original order
		public static void SetDeliveryCheckedBy(Delivery newDelivery)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
                // Call the SetDeliveryCheckedBy stored procedure
				connection.Open();
				SqlCommand insertDeliveryCheckedByCommand = new SqlCommand();
				insertDeliveryCheckedByCommand.Connection = connection;
				insertDeliveryCheckedByCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertDeliveryCheckedByCommand.CommandText = "SetDeliveryCheckedBy";
				insertDeliveryCheckedByCommand.Parameters.Add(new SqlParameter("@DeliveryNumber", newDelivery.deliveryNumber));
				insertDeliveryCheckedByCommand.Parameters.Add(new SqlParameter("@DeliveryCheckedByStaffId", newDelivery.deliveryCheckedByStaffId));
				insertDeliveryCheckedByCommand.ExecuteNonQuery();
				connection.Close();
			}
		}

        // Get a count of delivery discrepancies (i.e. number of order items that have discrepancies)
        // See corresponding method to get full list in OrderDal
        public static int GetNumberOfDeliveryDiscrepancies()
        {
			int numberOfDeliveryDiscrepancies = 0;

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Get count of order items delivered where the number received minus the number faulty is less than the number ordered
				string sqlQuery =
					"SELECT COUNT(OrderNumber) AS NumberOfDeliveryDiscrepancies " +
					"FROM OrderItemsDeliveredView " +
					"WHERE(QuantityDelivered - QuantityFaulty) < OrderItemQuantity";
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					numberOfDeliveryDiscrepancies = (int)sqlDataReader["NumberOfDeliveryDiscrepancies"];
				}
				connection.Close();
			}

            // Return a count of orders that have discrepancies
			return numberOfDeliveryDiscrepancies;
		}
	}
}
