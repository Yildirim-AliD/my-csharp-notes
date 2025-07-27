using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomManager customManager = new CustomManager();
            customManager.Add();
            customManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ali";
            customer.LastName = "Yıldırım";
            customer.City = "Diyarbakır";

            Console.WriteLine("Customer 1: " + customer.FirstName + " " + customer.LastName + ", City: " + customer.City);
        }
    }
}
