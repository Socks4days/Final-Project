using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.NetworkInformation;
using Final_Project.Models;
using Final_Project.Data_Access;

namespace Final_Project
{
	// Manage access to the Audit and AuditItem tables
	public class AuditDal
	{
		// Get connection string using DalHelper class
		private static string _connectionstring = DalHelper._connectionstring;

		// Create a new audit
		public static Audit AddAudit(Audit newAudit)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Call AddAudit stored procedure
				connection.Open();
				SqlCommand insertAuditCommand = new SqlCommand();
				insertAuditCommand.Connection = connection;
				insertAuditCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertAuditCommand.CommandText = "AddAudit";
				// Set output parameter for AuditId of new entry
				SqlParameter dbAuditId = new SqlParameter("@AuditId", 0);
				dbAuditId.Direction = System.Data.ParameterDirection.Output;
				insertAuditCommand.Parameters.Add(dbAuditId);
				insertAuditCommand.Parameters.Add(new SqlParameter("@AuditDate", newAudit.auditDate));
				insertAuditCommand.Parameters.Add(new SqlParameter("@AuditedByStaffId", newAudit.auditedByStaffId));

				// Check number of rows affected
				int rowsAffected = insertAuditCommand.ExecuteNonQuery();
				if (rowsAffected > 0)
				{
					// If a row was inserted successfully, set id of row in audit object
					newAudit.auditId = Convert.ToInt32(dbAuditId.Value);
				}
				else 
				{
					// Otherwise, set id to 0 to indicate an error
					newAudit.auditId = 0;
				}
				connection.Close();

				// Return updated audit object
				return newAudit;
			}
		}

		// Add a stock item to an audit
		public static int AddAuditItem(AuditItem newAuditItem)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Call AddAuditItem stored procedure
				connection.Open();
				SqlCommand insertAuditItemCommand = new SqlCommand();
				insertAuditItemCommand.Connection = connection;
				insertAuditItemCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertAuditItemCommand.CommandText = "AddAuditItem";
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@AuditId", newAuditItem.auditId));
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@StockId", newAuditItem.stockId));
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@PredictedAmount", newAuditItem.predictedAmount));
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@ActualAmount", newAuditItem.actualAmount));

				// Get number of rows affected
				int rowsAffected = insertAuditItemCommand.ExecuteNonQuery();
				connection.Close();

				// Return number of rows affected
				return rowsAffected;
			}
		}

		// Get a list of all audits that have been recorded
		public static List<Audit> GetAllAudits()
		{
			List<Audit> audits = new List<Audit>();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Build and run SQL query to get list of audits (most recent first)
				connection.Open();
				string sqlQuery = $"SELECT * FROM Audit ORDER BY AuditId DESC";
				SqlCommand getAllAuditsCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = getAllAuditsCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					// Create an Audit object for each row returned
					Audit audit = new Audit(

						(int)sqlDataReader["AuditId"],
						(DateTime)sqlDataReader["AuditDate"],
						(int)sqlDataReader["AuditedByStaffId"]
						);
					audits.Add(audit);
				}
				connection.Close();
			}

			// Return list of Audit objects
			return audits;
		}

		// Get a list of all audit tems for a specific audit
		public static List<AuditItem> GetAllAuditItems(int auditId)
		{
			List<AuditItem> auditItems = new List<AuditItem>();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Build and run SQL query to get list of audit items
				connection.Open();
				string sqlQuery = $"SELECT * FROM AuditItem WHERE auditId = {auditId}";
				SqlCommand getAllAuditItemsCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = getAllAuditItemsCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					// Create an AuditItem object for each row returned
					AuditItem auditItem = new AuditItem(

						(int)sqlDataReader["AuditId"],
						(int)sqlDataReader["StockId"],
						(int)sqlDataReader["PredictedAmount"],
						(int)sqlDataReader["ActualAmount"]
						);
					auditItems.Add(auditItem);
				}
				connection.Close();

				// Return list of AuditItem objects
				return auditItems;
			}
		}
		
		// Get number of overdue audits
		public static int GetNumberOfOverdueAudits()
		{
			int numberOfOverdueAudits = 0;

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Build and run SQL query to get count of audits where the DaysToNextAudit < 0
				// Uses StockLevelsView which calculates the number of days to the next audit
				string sqlQuery =
					"SELECT COUNT(StockId) AS NumberOfOverdueAudits " +
					"FROM StockLevelsView " +
					"WHERE DaysToNextAudit < 0";
				connection.Open();
				SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					// Read the count returned by the SQL query
					numberOfOverdueAudits = (int)sqlDataReader["NumberOfOverdueAudits"];
				}
				connection.Close();
			}

			// Return the count
			return numberOfOverdueAudits;
		}
	}
}
