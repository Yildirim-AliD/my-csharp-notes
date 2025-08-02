using System;
using System.Net.Http.Headers;
namespace _13_Constructors
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            // CustomerManager customerManager = new CustomerManager(); // Default constructor
            customerManager.Add();
            customerManager.List();

            Product product = new Product { Id = 1, Name = "Laptop" };
            Product product2 = new Product(2, "Phone");


            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            //Teacher teacher = new Teacher(); // Static class, no instance can be created

            Teacher.Number = 10; // Static class can be accessed without instantiation 

            Utilitles.Validate(); // Static method can be called without instantiation

            Manager.DoSomething(); // Static method can be called without instantiation
            Manager manager = new Manager();
            manager.DoSomething2(); // Instance method can be called after instantiation

        }
    }

    class CustomerManager
    {
        private int _count = 15;
        // Constructor(ctor)
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items",_count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    class Product
        {
        public Product()
        {
            
        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
        {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }

    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }

    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Employee added");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;   
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity):base(entity) 
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added!");
            Message();
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }

    }
    static class Utilitles
    {
        static Utilitles()
        {
            Console.WriteLine("Utilities class initialized");
        }
        public static void Validate()
        {
            Console.WriteLine("Validated");
        }
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");
        }
    }
}
