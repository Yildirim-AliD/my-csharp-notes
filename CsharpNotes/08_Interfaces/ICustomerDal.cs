using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Server: Customer added.");
        }
        public void Update()
        {
            Console.WriteLine("SQL Server: Customer updated.");
        }
        public void Delete()
        {
            Console.WriteLine("SQL Server: Customer deleted.");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle: Customer added.");
        }
        public void Update()
        {
            Console.WriteLine("Oracle: Customer updated.");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle: Customer deleted.");
        }
    }


    class CustomerManager
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add()
        {
            _customerDal.Add();
        }

        public void Update()
        {
            _customerDal.Update();
        }

        public void Delete()
        {
            _customerDal.Delete();
        }
    }

}
