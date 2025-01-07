using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Final_Project
{
	public class AuditDal
	{
		private static string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
		private static string projectDirectoryPath = Directory.GetParent(workingDirectoryPath).Parent.Parent.Parent.FullName;
		private static string _connectionstring = string.Format(ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ConnectionString, projectDirectoryPath);

		public static Audit AddAudit(Audit newAudit)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand insertAuditCommand = new SqlCommand();
				insertAuditCommand.Connection = connection;

				insertAuditCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertAuditCommand.CommandText = "AddAudit";

				SqlParameter dbAuditId = new SqlParameter("@AuditId", 0);
				dbAuditId.Direction = System.Data.ParameterDirection.Output;

				insertAuditCommand.Parameters.Add(dbAuditId);
				insertAuditCommand.Parameters.Add(new SqlParameter("@AuditDate", newAudit.auditDate));
				insertAuditCommand.Parameters.Add(new SqlParameter("@AuditedByStaffId", newAudit.auditedByStaffId));

				int rowsAffected = insertAuditCommand.ExecuteNonQuery();

				newAudit.auditId = Convert.ToInt32(dbAuditId.Value);

				connection.Close();

				return newAudit;
			}
		}

		public static int AddAuditItem(AuditItem newAuditItem)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand insertAuditItemCommand = new SqlCommand();
				insertAuditItemCommand.Connection = connection;

				insertAuditItemCommand.CommandType = System.Data.CommandType.StoredProcedure;
				insertAuditItemCommand.CommandText = "AddAuditItem";

				insertAuditItemCommand.Parameters.Add(new SqlParameter("@AuditId", newAuditItem.auditId));
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@StockId", newAuditItem.stockId));
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@PredictedAmount", newAuditItem.predictedAmount));
				insertAuditItemCommand.Parameters.Add(new SqlParameter("@ActualAmount", newAuditItem.actualAmount));

				int rowsAffected = insertAuditItemCommand.ExecuteNonQuery();

				connection.Close();

				return rowsAffected;
			}
		}
	}
}
