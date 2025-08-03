using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_ReferenceAndVaklueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;   
            int number2 = 20;
            number1 = number2; // Value type, number1 gets a copy of number2's value
            number2 = 100; // Changing number2 does not affect number1
            Console.WriteLine("Number1: " + number1); // Output: 20

            string[] cities1 = new string[] { "Ankara", "Istanbul", "Izmir" };
            string[] cities2 = new string[] { "Bursa", "Antalya", "Adana" };
            cities1 = cities2; // Reference type, cities1 now references the same array as cities2
            cities2[0] = "Mersin"; // Changing cities2 affects cities1 since they reference the same array
            Console.WriteLine("Cities1[0]: " + cities1[0]); // Output: Mersin

            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2; // Reference type, dataTable now references the same DataTable as dataTable2
            dataTable2.Columns.Add("Column1"); // Adding a column to dataTable2 also affects dataTable
            Console.WriteLine("DataTable Columns Count: " + dataTable.Columns.Count); // Output: 1

        }
    }
}
