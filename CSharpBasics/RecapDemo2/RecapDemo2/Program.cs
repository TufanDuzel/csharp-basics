using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new DatabaseLogger();
            customerManager.Add();

            Console.ReadLine();
        }

        class CustomerManager
        {
            public ILogger logger { get; set; }
            public void Add()
            {
                logger.Log();
                Console.WriteLine("Customer added successfully.");
            }
        }

        interface ILogger
        {
            void Log();
        }

        class DatabaseLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to database.");
            }
        }

        class EmailLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged to email.");
            }
        }

        class SMSLogger : ILogger
        {
            public void Log()
            {
                Console.WriteLine("Logged via sms.");
            }
        }
    }
}
