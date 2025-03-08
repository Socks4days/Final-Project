using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Final_Project.Models;

namespace Final_Project
{
	public class StaffDal
    {
        private static string workingDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
        private static string projectDirectoryPath = Directory.GetParent(workingDirectoryPath).Parent.Parent.Parent.FullName;
        private static string _connectionstring = string.Format(ConfigurationManager.ConnectionStrings["StockManagementConnectionString"].ConnectionString, projectDirectoryPath);


        public static List<Staff> GetAllStaff()
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            { 
                List<Staff> staffMembers = new List<Staff>();
                connection.Open();

                string sqlQuery = "SELECT * FROM Staff ORDER BY [Forename] ASC";

                SqlCommand getAllStaffCommand = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getAllStaffCommand.ExecuteReader();

                while (sqlDataReader.Read()) 
                {
                    Staff staff = new Staff(
                        
                        (string)sqlDataReader["Forename"],
                        (string)sqlDataReader["Surname"],
                        (string)sqlDataReader["Username"],
                        (string)sqlDataReader["Password"],                        
                        (string)sqlDataReader["StaffPosition"],                      
                        (int)sqlDataReader["Active"]
                        );

                    staff.staffId = (int)sqlDataReader["StaffId"];
                    staffMembers.Add(staff);

                }

                connection.Close();
                return staffMembers;
            }
        }

        public static int AddStaffMember(Staff newStaff)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand insertProjectCommand = new SqlCommand();
                insertProjectCommand.Connection = connection;

                insertProjectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                insertProjectCommand.CommandText = "AddStaffMember";

                insertProjectCommand.Parameters.Add(new SqlParameter("@Username", newStaff.username));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Password", newStaff.password));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Forename", newStaff.forename));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Surname", newStaff.surname));
                insertProjectCommand.Parameters.Add(new SqlParameter("@StaffPosition", newStaff.staffPosition));
                insertProjectCommand.Parameters.Add(new SqlParameter("@Active", newStaff.active));

                int rowsAffected =  insertProjectCommand.ExecuteNonQuery();

                connection.Close();

                return rowsAffected;
            }
        }

        public static Staff GetStaffByStaffId(int staffId)
        {          
            string sqlQuery = string.Format("SELECT * FROM Staff WHERE StaffId = {0}", staffId);
            return GetStaffSql(sqlQuery);
        }

        public static Staff GetStaffByStaffFullName(string staffForename, string staffSurname)
        {
            string sqlQuery = string.Format($"SELECT * FROM Staff WHERE Forename = '{staffForename}' AND Surname = '{staffSurname}'");
            return GetStaffSql(sqlQuery);
        }

		public static Staff GetStaffSql(string sqlQuery)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				Staff staff = new Staff();
				connection.Open();

				SqlCommand getStaffSql = new SqlCommand(sqlQuery, connection);

				SqlDataReader sqlDataReader = getStaffSql.ExecuteReader();

				while (sqlDataReader.Read())
				{
					staff = new Staff(
						(string)sqlDataReader["Forename"],
						(string)sqlDataReader["Surname"],
						(string)sqlDataReader["Username"],
						(string)sqlDataReader["Password"],
						(string)sqlDataReader["StaffPosition"],
						(int)sqlDataReader["Active"]
						);

					staff.staffId = (int)sqlDataReader["StaffId"];
				}

				connection.Close();
				return staff;
			}
		}

        public static void UpdateStaffInformation(Staff staff)
        {
            using(SqlConnection connection = new SqlConnection(_connectionstring))
            {
				connection.Open();

				SqlCommand updateStaffCommand = new SqlCommand();
				updateStaffCommand.Connection = connection;
				// specifies its a stored procedure
				updateStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
				// name of stored procedure to execute
				updateStaffCommand.CommandText = "UpdateStaffMember";
				// now add parameters that are passed to the stored procedure
				updateStaffCommand.Parameters.Add(new SqlParameter("@StaffId", staff.staffId));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Forename", staff.forename));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Surname", staff.surname));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Username", staff.username));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Password", staff.password));

				updateStaffCommand.ExecuteNonQuery();

				connection.Close();
			}
        }

        public static void UpdateStaffPosition(Staff staff)
        {
            using(SqlConnection connection = new SqlConnection(_connectionstring))
            {
                connection.Open();

                SqlCommand updateStaffPositionCommand = new SqlCommand();
                updateStaffPositionCommand.Connection = connection;

				// specifies its a stored procedure
				updateStaffPositionCommand.CommandType = System.Data.CommandType.StoredProcedure;
				// name of stored procedure to execute
				updateStaffPositionCommand.CommandText = "UpdateStaffPosition";
				// now add parameters that are passed to the stored procedure
				updateStaffPositionCommand.Parameters.Add(new SqlParameter("@StaffId", staff.staffId));
				updateStaffPositionCommand.Parameters.Add(new SqlParameter("@StaffPosition", staff.staffPosition));

                updateStaffPositionCommand.ExecuteReader();

                connection.Close();
			}
        }

		public static void UpdateStaffStatus(Staff staff)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				connection.Open();

				SqlCommand updateStaffStatusCommand = new SqlCommand();
				updateStaffStatusCommand.Connection = connection;

				// specifies its a stored procedure
				updateStaffStatusCommand.CommandType = System.Data.CommandType.StoredProcedure;
				// name of stored procedure to execute
				updateStaffStatusCommand.CommandText = "UpdateStaffStatus";
				// now add parameters that are passed to the stored procedure
				updateStaffStatusCommand.Parameters.Add(new SqlParameter("@StaffId", staff.staffId));
				updateStaffStatusCommand.Parameters.Add(new SqlParameter("@Active", staff.active));

				updateStaffStatusCommand.ExecuteReader();

				connection.Close();
			}
		}
	}
}
