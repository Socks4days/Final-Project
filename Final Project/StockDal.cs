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

namespace Final_Project
{
    public class StockDal
    {
        // Get current directory ending in bin/Debug/net8.0-windows
        private static string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
        // Go back 3 levels to get project directory 
        private static string projectDirectoryPath = Directory.GetParent(workingDirectoryPath).Parent.Parent.Parent.FullName;
        // Replace {0} in connection string with project directory
        private static string _connectionstring = string.Format(ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ConnectionString, projectDirectoryPath);

        public static Stock GetStockByStockId(int stockId)
        {
			string sqlQuery = string.Format("SELECT * FROM Stock WHERE StockId = {0}", stockId);
			return GetStockSql(sqlQuery);
		}

		public static Stock GetStockByStockName(string stockName)
        {
			string sqlQuery = string.Format("SELECT * FROM Stock WHERE StockName = '{0}'", stockName);

			return GetStockSql(sqlQuery);
        }

        private static Stock GetStockSql(string sqlQuery)
        {
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				Stock stock = new Stock();
				connection.Open();


				SqlCommand getStock = new SqlCommand(sqlQuery, connection);

				SqlDataReader sqlDataReader = getStock.ExecuteReader();

				while (sqlDataReader.Read())
				{
					bool active = false;
					int sqlActive = (int)sqlDataReader["Active"];

					if (sqlActive == 1)
					{
						active = true;
					}

					stock = new Stock(
						(string)sqlDataReader["StockName"],
						(string)sqlDataReader["StockDescription"],
						(decimal)sqlDataReader["Price"],
						(int)sqlDataReader["DeliveryTimeDays"],
						(int)sqlDataReader["MaximumLevel"],
						(int)sqlDataReader["MinimumLevel"],
						(int)sqlDataReader["OrderQuantity"],
						(int)sqlDataReader["StockCheckFrequency"],
						(int)sqlDataReader["StockLevel"],
						(int)sqlDataReader["LastUpdatedByStaffId"],
						active
						);

					stock.stockId = (int)sqlDataReader["StockId"];
				}
				connection.Close();
				return stock;
			}
		}

        public static void UpdateStockInformation(Stock stock)
        {
            int sqlActive = 0;
            if(stock.active == true)
            {
                sqlActive = 1;
            }

            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

				SqlCommand updateStockInformationCommand = new SqlCommand();
				updateStockInformationCommand.Connection = connection;
				// specifies its a stored procedure
				updateStockInformationCommand.CommandType = System.Data.CommandType.StoredProcedure;
				// name of stored procedure to execute
				updateStockInformationCommand.CommandText = "UpdateStockInformation";
				// now add parameters that are passed to the stored procedure
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

        public static int AddNewStock(Stock newStock)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {

                connection.Open();

                SqlCommand addStockCommand = new SqlCommand();
                addStockCommand.Connection = connection;
                // specifies its a stored procedure
                addStockCommand.CommandType = System.Data.CommandType.StoredProcedure;
                // name of stored procedure to execute
                addStockCommand.CommandText = "AddStock";
                // now add parameters that are passed to the stored procedure
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

                int rowsAffected = addStockCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static List<Stock> GetAllStock()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<Stock> stockItems = new List<Stock>();
                connection.Open();

                string sqlQuery = "SELECT * FROM Stock ORDER BY StockName ASC";

                SqlCommand getAllStockCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllStockCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Stock stock = new Stock(
                        (string)sqlDataReader["StockName"],
                        (string)sqlDataReader["StockDescription"],
                        (decimal)sqlDataReader["Price"],
                        (int)sqlDataReader["DeliveryTimeDays"],
                        (int)sqlDataReader["MaximumLevel"],
                        (int)sqlDataReader["MinimumLevel"],
                        (int)sqlDataReader["OrderQuantity"],
                        (int)sqlDataReader["StockCheckFrequency"],
                        (int)sqlDataReader["StockLevel"],
                        (int)sqlDataReader["LastUpdatedByStaffId"]
                        );

                    stock.stockId = (int)sqlDataReader["StockId"];
                    stockItems.Add(stock);
                }

                connection.Close();
                return stockItems;
            }
        }

        public static List<StockLevelsView> GetStockLevelsView(string orderBy)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                List<StockLevelsView> stockLevelItems = new List<StockLevelsView>();
                connection.Open();

                string sqlQuery = "SELECT * FROM StockLevelsView";
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

                while (sqlDataReader.Read())
                {
                    DateTime? auditDate = null;
                    var dbAuditDateTime = sqlDataReader["AuditDate"];
                    if (dbAuditDateTime != DBNull.Value)
                        auditDate = Convert.ToDateTime(dbAuditDateTime);

                    int auditedByStaffId = 0;
                    var dbAuditedByStaffId = sqlDataReader["AuditedByStaffId"];
                    if (dbAuditedByStaffId != DBNull.Value)
                        auditedByStaffId = Convert.ToInt32(dbAuditedByStaffId);

					DateTime? nextAuditDueDate = null;
					var dbNextAuditDueDateTime = sqlDataReader["NextAuditDueDate"];
					if (dbNextAuditDueDateTime != DBNull.Value)
						nextAuditDueDate = Convert.ToDateTime(dbNextAuditDueDateTime);

					StockLevelsView stockLevel = new StockLevelsView(
                        (int)sqlDataReader["StockId"],
                        (string)sqlDataReader["StockName"],                        
                        (int)sqlDataReader["StockLevel"],
                        auditDate,
                        auditedByStaffId,
                        (string)sqlDataReader["AuditedByStaffFullName"],
                        nextAuditDueDate,
						(int)sqlDataReader["DaysToNextAudit"]
						);

                    
                    stockLevelItems.Add(stockLevel);
                }
                connection.Close();
                return stockLevelItems;
            }
        }
    }
}
