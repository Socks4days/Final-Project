using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Final_Project.Data_Access
{
	internal static class DalHelper
	{
		// Set up connection string to database using relative path based on working directory for application
		// Get working directory which ends in bin/Debug/net8.0-windows
		private static string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
		// Go back 3 levels to get project directory 
		private static string projectDirectoryPath = Directory.GetParent(workingDirectoryPath)!.Parent!.Parent!.Parent!.FullName;
		// Replace {0} in connection string with project directory
		public static string _connectionstring = string.Format(ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ConnectionString, projectDirectoryPath);

		// Helper method to check for null values in a SQL datetime column
		public static DateTime? GetSqlDate(SqlDataReader sqlDataReader, string columnName)
		{
			var dbDateTime = sqlDataReader[columnName];
			DateTime? dateTime = null;
			if (dbDateTime != DBNull.Value)
				dateTime = Convert.ToDateTime(dbDateTime);
			return dateTime;
		}

		// Helper method to check for null values in a SQL nverchar column
		public static string GetSqlString(SqlDataReader sqlDataReader, string columnName)
		{
			var dbString = sqlDataReader[columnName];
			string returnString = "";
			if (dbString != DBNull.Value)
				returnString = (string)dbString;
			return returnString;
		}

		// Helper method to check for null values in a SQL int column
		public static int? GetSqlInt(SqlDataReader sqlDataReader, string columnName)
		{
			var dbInt = sqlDataReader[columnName];
			int? returnInt = null;
			if (dbInt != DBNull.Value)
				returnInt = (int)dbInt;
			return returnInt;
		}
	}
}
