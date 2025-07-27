using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    internal class Customer
    {
        // Properties of the Customer class
        public int Id { get; set; }
        private string _firstName; // Backing field for FirstName
        public string FirstName { get
            {
                return "Mr." + _firstName;
            }
            set { _firstName = value; } }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
