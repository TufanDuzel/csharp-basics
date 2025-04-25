using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLServer sqlserver = new SQLServer();
            MySQL mysql = new MySQL();

            sqlserver.Add();
            mysql.Add();

            Console.ReadLine();
        }

        class Database
        {
            public virtual void Add()
            {
                Console.WriteLine("Added by default.");
            }
        }

        class SQLServer : Database
        {
            public override void Add()
            {
                Console.WriteLine("Added by SQL Server code.");
                //base.Add();
            }
        }

        class MySQL : Database
        {
            
        }
    }
}
