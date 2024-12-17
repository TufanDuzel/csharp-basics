using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;

            if(number == 10)
            {
                Console.WriteLine("The number is 10.");
            }
            else if(number == 20)
            {
                Console.WriteLine("The number is 20.");
            }
            else
            {
                Console.WriteLine("The number is not 10 or 20.");
            }

            number = 20;

            switch(number) 
            {
                case 10:
                    Console.WriteLine("The number is 10.");
                    break;
                case 20:
                    Console.WriteLine("The number is 20.");
                    break;
                default:
                    Console.WriteLine("The number is not 10 or 20.");
                    break;
            }

            number = 200;

            if(number >= 0 && number <= 100)
            {
                Console.WriteLine("The number is between 0 - 100.");
            }
            else if(number > 100 && number <= 200)
            {
                Console.WriteLine("The number is between 101 - 200.");
            }
            else if(number > 200)
            {
                Console.WriteLine("The number is more than 201.");
            }
            else
            {
                Console.WriteLine("The number is less than 0.");
            }
                Console.ReadLine();
        }
    }
}
