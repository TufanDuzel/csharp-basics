using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Customer customer = new Customer
            {
                ID = 1, FirstName = "Tufan", LastName = "Duzel", Address = "Skopje"
            };

            Student student = new Student
            {
                ID = 1,
                FirstName = "Cinar",
                LastName = "Duzel",
                Departmant = "Computer Sciences"
            };

            PersonManager manager = new PersonManager();
            manager.Add(customer);
            manager.Add(student);
            */

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());

            Console.ReadLine();
        }

        interface IPerson
        {
            int ID { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
