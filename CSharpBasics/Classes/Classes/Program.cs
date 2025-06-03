using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Delete();

            Customer customer1 = new Customer();
            customer1.ID = 1;
            customer1.FirstName = "Tufan";
            customer1.LastName = "Duzel";
            customer1.City = "Istanbul";

            Customer customer2 = new Customer
            {
                ID = 2, FirstName = "John", LastName = "Trump", City = "Boston"
            };

            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
