﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    class SQLServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Data added to the SQL Server.");
        }

        public void Delete()
        {
            Console.WriteLine("Data deleted from the SQL Server.");
        }

        public void Update()
        {
            Console.WriteLine("Data updated in the SQL Server.");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Data added to the Oracle.");
        }

        public void Delete()
        {
            Console.WriteLine("Data deleted from the Oracle.");
        }

        public void Update()
        {
            Console.WriteLine("Data updated in the Oracle.");
        }
    }

    class MySQLCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Data added to the MySQL.");
        }

        public void Delete()
        {
            Console.WriteLine("Data deleted from the MySQL.");
        }

        public void Update()
        {
            Console.WriteLine("Data updated in the MySQL.");
        }
    }
}
