using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Final_Project.Data_Access;

namespace Final_Project
{
	// Manage access to the Stock table
	public class StockDal
	{
		// Get connection string using DalHelper class
		private static string _connectionstring = DalHelper._connectionstring;

		// Create a new stock item
		public static int AddNewStock(Stock newStock)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Call the AddStock stored procedure with the details from the Stock object provided
				connection.Open();
				SqlCommand addStockCommand = new SqlCommand();
				addStockCommand.Connection = connection;
				addStockCommand.CommandType = System.Data.CommandType.StoredProcedure;
				addStockCommand.CommandText = "AddStock";
				addStockCommand.Parameters.Add(new SqlParameter("@StockName", newStock.stockName));
				addStockCommand.Parameters.Add(new SqlParameter("@StockDescription", newStock.stockDescription));
				addStockCommand.Parameters.Add(new SqlParameter("@Price", newStock.price));
				addStockCommand.Parameters.Add(new SqlParameter("@DeliveryTimeDays", newStock.deliveryTimeDays));
				addStockCommand.Parameters.Add(new SqlParameter("@MaximumLevel", newStock.maximumLevel));
				addStockCommand.Parameters.Add(new SqlParameter("@MinimumLevel", newStock.minimumLevel));
				addStockCommand.Parameters.Add(new SqlParameter("@OrderQuantity", newStock.orderQuantity));
				addStockCommand.Parameters.Add(new SqlParameter("@StockCheckFrequency", newStock.stockCheckFrequency));
				addStockCommand.Parameters.Add(new SqlParameter("@StockLevel", newStock.stockLevel));
				addStockCommand.Parameters.Add(new SqlParameter("@LastUpdatedByStaffId", newStock.lastUpdatedByStaffId));

				// Get the number of rows created
				int rowsAffected = addStockCommand.ExecuteNonQuery();
				connection.Close();

				// Return the number of rows created (1 = success, 0 = failure)
				return rowsAffected;
			}
		}

		// Update the stock level for an existing stock item
		public static void UpdateStockLevel(Stock stock)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Call the UpdateStockLevel stored procedure with the new stock level from the Stock object provided
				connection.Open();
				SqlCommand updateStockLevelCommand = new SqlCommand();
				updateStockLevelCommand.Connection = connection;
				updateStockLevelCommand.CommandType = System.Data.CommandType.StoredProcedure;
				updateStockLevelCommand.CommandText = "UpdateStockLevel";
				updateStockLevelCommand.Parameters.Add(new SqlParameter("@StockId", stock.stockId));
				updateStockLevelCommand.Parameters.Add(new SqlParameter("@StockLevel", stock.stockLevel));
				updateStockLevelCommand.ExecuteNonQuery();
				connection.Close();
			}
		}

		// Update the details of an existing stock item
		public static void UpdateStockInformation(Stock stock)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Convert boolean value of active to 0 or 1 for stored procedure
				int sqlActive = 0;
				if (stock.active == true)
					sqlActive = 1;

				// Call UpdateSotckInformation stored procedure with the details from the Stock object provided
				connection.Open();
				SqlCommand updateStockInformationCommand = new SqlCommand();
				updateStockInformationCommand.Connection = connection;
				updateStockInformationCommand.CommandType = System.Data.CommandType.StoredProcedure;
				updateStockInformationCommand.CommandText = "UpdateStockInformation";
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@StockId", stock.stockId));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@StockName", stock.stockName));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@StockDescription", stock.stockDescription));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@Price", stock.price));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@DeliveryTimeDays", stock.deliveryTimeDays));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@MaximumLevel", stock.maximumLevel));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@MinimumLevel", stock.minimumLevel));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@OrderQuantity", stock.orderQuantity));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@StockCheckFrequency", stock.stockCheckFrequency));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@LastUpdatedByStaffId", stock.lastUpdatedByStaffId));
				updateStockInformationCommand.Parameters.Add(new SqlParameter("@Active", sqlActive));
				updateStockInformationCommand.ExecuteNonQuery();
				connection.Close();
			}
		}

		// Internal helper method to create a Stock object from a row returned from the Stock table 
		private static Stock GetStockFromSqlDataReader(SqlDataReader sqlDataReader)
		{
			// Convert 0/1 from table to boolean value for Stock object
			bool active = false;
			int sqlActive = (int)sqlDataReader["Active"];
			if (sqlActive == 1)
			{
				active = true;
			}

			decimal price = sqlDataReader.GetDecimal(3);
			


			// Create and return Stock object
			Stock stock = new Stock(
				(int)sqlDataReader["StockId"],
				(string)sqlDataReader["StockName"],
				(string)sqlDataReader["StockDescription"],
				price,//(decimal)sqlDataReader["Price"], //issue
				(int)sqlDataReader["DeliveryTimeDays"],
				(int)sqlDataReader["MaximumLevel"],
				(int)sqlDataReader["MinimumLevel"],
				(int)sqlDataReader["OrderQuantity"],
				(int)sqlDataReader["StockCheckFrequency"],
				(int)sqlDataReader["StockLevel"],
				(int)sqlDataReader["LastUpdatedByStaffId"],
				active
				);
			return stock;
		}

		// Internal helper method to run different SQL queries on the Stock table and returning a Stock object
		private static Stock GetStockSql(string sqlQuery)
		{
			Stock stock = new Stock();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Run the SQL query provided and use the internal helper method to get a Stock object from the result
				connection.Open();
				SqlCommand getStock = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = getStock.ExecuteReader();
				while (sqlDataReader.Read())
				{
					stock = GetStockFromSqlDataReader(sqlDataReader);
				}
				connection.Close();
			}

			// Return a Stock object
			return stock;
		}

		// Get a stock item by id
		public static Stock GetStockByStockId(int stockId)
		{
			// Build SQL query to get by id and then call helper method to return the Stock object
			string sqlQuery = string.Format("SELECT * FROM Stock WHERE StockId = {0}", stockId);
			return GetStockSql(sqlQuery);
		}

		// Get a stock item by name
		public static Stock GetStockByStockName(string stockName)
		{
			// Build SQL query to get by name and then call helper method to return the Stock object
			string sqlQuery = string.Format("SELECT * FROM Stock WHERE StockName = '{0}'", stockName);
			return GetStockSql(sqlQuery);
		}

		// Get all active stock (without extra information about number on order)
		public static List<Stock> GetAllActiveStock()
		{
			return GetAllActiveStock(false);
		}

		// Get all active stock (parameter indicates if this should be with or without extra information about number on order)
		public static List<Stock> GetAllActiveStock(bool includeNumberOnOrder)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				List<Stock> stockItems = new List<Stock>();

				// Use different select statements depending on whether or not extra information is needed
				connection.Open();
				string sqlQuery = "";
				if (includeNumberOnOrder)
				{
					// Get stock details including number on order
					// Uses join to StockOnOrderView to get the extra information
					sqlQuery =
						"SELECT Stock.*, ISNULL(StockOnOrderView.NumberOnOrder, 0) AS NumberOnOrder " +
						"FROM Stock " +
						"LEFT OUTER JOIN StockOnOrderView ON StockOnOrderView.StockId = Stock.StockId " +
						"WHERE Active = 1 " +
						"ORDER BY StockName ASC";
				}
				else
				{
					// Get stock details only
					// Uses Stock table only
					sqlQuery = "SELECT * FROM Stock WHERE Active = 1 ORDER BY StockName ASC";
				}

				// Execute the SQL command and create a list of Stock items
				SqlCommand getAllStockCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = getAllStockCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					Stock stock = GetStockFromSqlDataReader(sqlDataReader);
					// if extra information was requested, set the numberOnOrder property
					if (includeNumberOnOrder)
						stock.numberOnOrder = (int)sqlDataReader["NumberOnOrder"];
					stockItems.Add(stock);
				}
				connection.Close();

				// Return the list of Stock objects
				return stockItems;
			}
		}

		// Get details of the stock levels for each active stock item
		// Including details of the last audit and when the next audit is due
		// Parameter allows the list to be sorted by: StockName, AuditDate or NextAuditDueDate
		public static List<StockLevelAuditView> GetStockLevelAuditView(string orderBy)
		{
			List<StockLevelAuditView> stockLevelItems = new List<StockLevelAuditView>();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Build and run SQL query checking parameter value to determine correct order by
				// Note it doesn't use the parameter directly to avoid SQL injection risks
				connection.Open();
				string sqlQuery = "SELECT * FROM StockLevelAuditView";
				if (orderBy == "StockName")
				{
					sqlQuery += " ORDER BY [StockName] ASC";
				}
				else if (orderBy == "AuditDate")
				{
					sqlQuery += " ORDER BY [AuditDate] ASC";
				}
				else if (orderBy == "NextAuditDueDate")
				{
					sqlQuery += " ORDER BY [NextAuditDueDate] ASC";
				}
				SqlCommand getAllStockCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = getAllStockCommand.ExecuteReader();

				// Create list of StockLevelsView objects based on results
				while (sqlDataReader.Read())
				{
					StockLevelAuditView stockLevel = new StockLevelAuditView(
						(int)sqlDataReader["StockId"],
						(string)sqlDataReader["StockName"],
						(int)sqlDataReader["StockLevel"],
						DalHelper.GetSqlDate(sqlDataReader,"AuditDate"),
						DalHelper.GetSqlInt(sqlDataReader, "AuditedByStaffId"),
						(string)sqlDataReader["AuditedByStaffFullName"],
						DalHelper.GetSqlDate(sqlDataReader, "NextAuditDueDate"),
						(int)sqlDataReader["DaysToNextAudit"]
						);
					stockLevelItems.Add(stockLevel);
				}
				connection.Close();
			}

			// Return list of StockLevelsView items
			return stockLevelItems;
		}

		// Get count of stock items that are below the minimum stock level
		// Used for KPI on dashboard
		public static int GetNumberOfLowStockItems()
		{
			int numberOfLowStockItems = 0;

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Run SQL query to count of active stock items with stock level less that minimum level
				connection.Open();
				string sqlQuery =
					"SELECT COUNT(StockId) AS NumberOfLowStockItems " +
					"FROM Stock " +
					"WHERE StockLevel < MinimumLevel AND Active = 1";
				SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

				// If a result was returned, get the count
				while (sqlDataReader.Read())
				{
					numberOfLowStockItems = (int)sqlDataReader["NumberOfLowStockItems"];
				}
				connection.Close();
			}

			// Return the count of low stock items
			return numberOfLowStockItems;
		}
	}
}