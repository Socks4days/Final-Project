using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class User
    {
        // properties of the user class are created
        public string forename { get; set; }
        public string surname { get; set; }
        public string password { get; set; }
        public string username { get; set; }

        // Default constructor
        public User()
        {
        }

        // creates the user objects with the relevant information
        public User(string forename, string surname, string username, string password)
        {
            this.forename = forename;
            this.surname = surname;
            this.username = username;
            this.password = password;            
        }
    }
}
