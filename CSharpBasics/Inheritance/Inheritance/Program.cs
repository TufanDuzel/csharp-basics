using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[3]
            {
                new Person {FirstName = "Tufan"},
                new Customer {FirstName = "Sahin"},
                new Student {FirstName = "Cinar"}
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }

        interface IPerson
        {
            int ID { get; set; }
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        
        class Customer : Person
        {

        }

        class Student : Person, IPerson
        {
            public int ID { get; set; }
        }
    }
}
