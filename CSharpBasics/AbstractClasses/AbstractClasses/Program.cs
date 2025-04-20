using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database sqlserver = new SQLServer();
            Database mysql = new MySQL();

            sqlserver.Add();
            sqlserver.Delete();

            mysql.Add();
            mysql.Delete();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default.");
        }

        public abstract void Delete();
    }

    class SQLServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by SQL Server code.");
        }
    }

    class MySQL : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by MySQL code.");
        }
    }
}

