﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLServer sqlServer = new SQLServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

        }
    }

    class Database
    {
        public virtual void Add()
        { 
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        { 
            Console.WriteLine("Deleted by default");
        }
    }


    class SQLServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql Code");
            //base.Add();
        }
    }

    class MySql : Database
    {
       
    }
}
