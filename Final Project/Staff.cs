using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Staff : User
    {
        public int staffId { get; set; }
        public string staffPosition { get; set; }
        public int active { get; set; }

        public Staff() { }

        public Staff(string forename, string surname, string username, string password, string staffPosition, int active) :base(forename, surname, username, password)
        {
            this.staffPosition = staffPosition;
            this.active = active;
        }
    }
}
