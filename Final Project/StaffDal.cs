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

                string sqlQuery = "SELECT * FROM Staff";

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
            using (SqlConnection connection = new SqlConnection(_connectionstring))
            {
                Staff staff = new Staff();
                connection.Open();

                string sqlQuery = string.Format("SELECT * FROM Staff WHERE StaffId = {0}", staffId);

                SqlCommand getStaffByStaffId = new SqlCommand(sqlQuery, connection);

                SqlDataReader sqlDataReader = getStaffByStaffId.ExecuteReader();

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
                return staff;
            }
        }
    }
}
