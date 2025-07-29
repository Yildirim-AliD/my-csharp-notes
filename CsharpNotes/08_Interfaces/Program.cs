using System;

namespace _08_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();ü,
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[] 
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
                customerDal.Delete();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager(new SqlServerCustomerDal());
            CustomerManager oraclecustomerManager = new CustomerManager(new OracleCustomerDal());
            customerManager.Add();
            customerManager.Update();
            customerManager.Delete();
            oraclecustomerManager.Add();
            oraclecustomerManager.Update();
            oraclecustomerManager.Delete();
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Name = "Ali", Age = 23, Address = "İzmir" });
            Student student = new Student { Name = "Yıldırım", Age = 23, department = "Computer Science" };
            personManager.Add(student);
        }
    }

    interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        void Speak();
    }

    class Customer : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public void Speak()
        {
            Console.WriteLine("Hello, I am a customer.");
        }
    }

    class Student : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string department { get; set; }
        public void Speak()
        {
            Console.WriteLine("Hello, I am a student.");
        }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine($"Adding person: {person.Name}, Age: {person.Age}");
        }
    }
}
