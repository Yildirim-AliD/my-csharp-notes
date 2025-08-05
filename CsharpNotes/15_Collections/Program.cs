using System;
using System.Collections;
using System.Collections.Generic;

namespace _15_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            //ArrayList();
            //ListDemo();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("TR", "Türkiye");
            dictionary.Add("EN", "England");
            dictionary.Add("FR", "France");

            //Console.WriteLine(dictionary["TR"]);
            //Console.WriteLine(dictionary["Computer"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                //Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
            }
            var key = dictionary.ContainsKey("TR"); // Check if the key "TR" exists in the dictionary
            var value = dictionary.ContainsValue("Türkiye"); // Check if the value "Türkiye" exists in the dictionary
            Console.WriteLine("Contains Key 'TR': " + key); // Output: True
            Console.WriteLine("Contains Value 'Türkiye': " + value); // Output: True

        }

        private static void Intro()
        {
            string[] cities = new string[] { "Ankara", "Istanbul" };
            Console.WriteLine(cities[0]);
            cities = new string[3]; // Reinitialize the array to a new size
            Console.WriteLine("new cities:" + cities[0]);
        }

        private static void ListDemo()
        {
            List<string> cityList = new List<string>();
            cityList.Add("Ankara");
            cityList.Add("Istanbul");
            cityList.Add("Izmir");
            //cityList.Add(1); // This will cause a compile-time error because List<string> can only hold strings
            Console.WriteLine("List Count: " + cityList.Count);

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Ali" });
            //customers.Add(new Customer { Id = 2, FirstName = "Yıldırım" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Ali" },
                new Customer { Id = 2, FirstName = "Yıldırım" }
            };


            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
                Console.WriteLine(customer.Id);
            }

            var count = customers.Count;
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Yıldırım"
            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2] {
                new Customer { Id = 4,FirstName = "Ali" },
                new Customer { Id = 5,FirstName = "Yıldırım"}
            });


            var index = customers.IndexOf(customer2);
            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("LastIndexOf: {0}", index);
            Console.WriteLine("IndexOf : {0}",index);


            customers.Insert(0, new Customer { Id = 6, FirstName = "Mehmet" });
            Console.WriteLine(customers.IndexOf(new Customer { Id = 6, FirstName = "Mehmet" })); // Output: -1

            var customerToFind = customers[0];
            Console.WriteLine(customers.IndexOf(customerToFind)); // Output: 0, because we just added it at index 0

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
            }
            customers.Remove(customer2);
            //customers.Clear();
            //Console.WriteLine("List Count after clear: " + customers.Count);// Output = 0

            Console.WriteLine("List Count after remove: " + customers.Count); // Output = 4, because customer2 was removed
            customers.RemoveAll(c =>c.FirstName == "Yıldırım");
            Console.WriteLine("List Count after removing all Yıldırım: " + customers.Count); // Output = 2, because all customers with FirstName "Yıldırım" were removed

            Console.WriteLine(customers.Contains(customer2)); // Output = false, because customer2 was removed
            Console.WriteLine(customers.Contains(new Customer { Id = 3, FirstName = "Yıldırım" })); // Output = false, because this is a different instance


        }

        private static void ArrayList()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Ankara");
            arrayList.Add("Istanbul");
            arrayList.Add(10); // ArrayList can hold different types of objects
            arrayList.Add(true); // Adding a boolean value
            arrayList.Add(3.14); // Adding a double value
            Console.WriteLine("ArrayList Count: " + arrayList.Count);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Add("İzmir");
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
