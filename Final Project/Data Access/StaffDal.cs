using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Final_Project.Models;
using Final_Project.Data_Access;

namespace Final_Project
{
	// Manage access to the Staff table
	public class StaffDal
    {
		// Get connection string using DalHelper class
		private static string _connectionstring = DalHelper._connectionstring;

        // Get a list of all staff members ordered by username
		public static List<Staff> GetAllStaff()
        {
			List<Staff> staffMembers = new List<Staff>();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
            { 
                // Build and run SQL query to get all staff
                string sqlQuery = "SELECT * FROM Staff ORDER BY [Username] ASC";
                connection.Open();
				SqlCommand getAllStaffCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader sqlDataReader = getAllStaffCommand.ExecuteReader();

				// Create a Staff object for each row returned
				while (sqlDataReader.Read()) 
                {
                    Staff staff = new Staff(
						(int)sqlDataReader["StaffId"],
						(string)sqlDataReader["Forename"],
                        (string)sqlDataReader["Surname"],
                        (string)sqlDataReader["Username"],
                        (string)sqlDataReader["Password"],                        
                        (string)sqlDataReader["StaffPosition"],                      
                        (int)sqlDataReader["Active"]
                        );
                    staffMembers.Add(staff);
                }
                connection.Close();
            }

			// Return list of Staff objects
			return staffMembers;
		}

		// Create a new staff member
		public static int AddStaffMember(Staff newStaff)
        {
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
				// Call AddStaffMember stored procedure
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

				// Get number of rows created
                int rowsAffected =  insertProjectCommand.ExecuteNonQuery();
                connection.Close();

                // Return number of rows created (1 for success, 0 for failure)
                return rowsAffected;
            }
        }

        // Get a specific staff member by id
        public static Staff GetStaffByStaffId(int staffId)
        {
			// Build SQL query to get by id and then call helper method to return the staff object
			string sqlQuery = string.Format("SELECT * FROM Staff WHERE StaffId = {0}", staffId);
            return GetStaffSql(sqlQuery);
        }

		// Get a specific staff member by username
		public static Staff GetStaffByStaffUsername(string staffUsername)
        {
			// Build SQL query to get by username and then call helper method to return the staff object
			string sqlQuery = string.Format($"SELECT * FROM Staff WHERE Username = '{staffUsername}'");
			return GetStaffSql(sqlQuery);
        }

        // Internal shared method to get a staff member using the SQL query provided
		private static Staff GetStaffSql(string sqlQuery)
		{
			Staff staff = new Staff();

			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
                // Build and run SQL query
				connection.Open();
				SqlCommand getStaffSql = new SqlCommand(sqlQuery, connection);
				SqlDataReader sqlDataReader = getStaffSql.ExecuteReader();

				// Create a Staff object
				while (sqlDataReader.Read())
				{
					staff = new Staff(
						(int)sqlDataReader["StaffId"],
						(string)sqlDataReader["Forename"],
						(string)sqlDataReader["Surname"],
						(string)sqlDataReader["Username"],
						(string)sqlDataReader["Password"],
						(string)sqlDataReader["StaffPosition"],
						(int)sqlDataReader["Active"]
						);
				}
				connection.Close();
			}

			// Return Staff object
			return staff;
		}

		// Update details of an existing staff member
        public static void UpdateStaffInformation(Staff staff)
        {
            using(SqlConnection connection = new SqlConnection(_connectionstring))
            {
				// Call UpdateStaffMember stored procedure passing in new values from Staff object properties
				connection.Open();
				SqlCommand updateStaffCommand = new SqlCommand();
				updateStaffCommand.Connection = connection;
				updateStaffCommand.CommandType = System.Data.CommandType.StoredProcedure;
				updateStaffCommand.CommandText = "UpdateStaffMember";
				updateStaffCommand.Parameters.Add(new SqlParameter("@StaffId", staff.staffId));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Forename", staff.forename));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Surname", staff.surname));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Username", staff.username));
				updateStaffCommand.Parameters.Add(new SqlParameter("@Password", staff.password));
				updateStaffCommand.ExecuteNonQuery();
				connection.Close();
			}
        }

		// Update the position of a staff member
        public static void UpdateStaffPosition(Staff staff)
        {
            using(SqlConnection connection = new SqlConnection(_connectionstring))
            {
				// Call UpdateStaffPosition stored procedure passing in the staff id and their new position 
                connection.Open();
                SqlCommand updateStaffPositionCommand = new SqlCommand();
                updateStaffPositionCommand.Connection = connection;
				updateStaffPositionCommand.CommandType = System.Data.CommandType.StoredProcedure;
				updateStaffPositionCommand.CommandText = "UpdateStaffPosition";
				updateStaffPositionCommand.Parameters.Add(new SqlParameter("@StaffId", staff.staffId));
				updateStaffPositionCommand.Parameters.Add(new SqlParameter("@StaffPosition", staff.staffPosition));
                updateStaffPositionCommand.ExecuteReader();
                connection.Close();
			}
        }

		// Update the status of a staff member (set to active or inactive)
		public static void UpdateStaffStatus(Staff staff)
		{
			using (SqlConnection connection = new SqlConnection(_connectionstring))
			{
				// Call UpdateStaffStatus stored procedure passing in the staff id and their new status (active or inactive) 
				connection.Open();
				SqlCommand updateStaffStatusCommand = new SqlCommand();
				updateStaffStatusCommand.Connection = connection;
				updateStaffStatusCommand.CommandType = System.Data.CommandType.StoredProcedure;
				updateStaffStatusCommand.CommandText = "UpdateStaffStatus";
				updateStaffStatusCommand.Parameters.Add(new SqlParameter("@StaffId", staff.staffId));
				updateStaffStatusCommand.Parameters.Add(new SqlParameter("@Active", staff.active));
				updateStaffStatusCommand.ExecuteReader();
				connection.Close();
			}
		}
	}
}
