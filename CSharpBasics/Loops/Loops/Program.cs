using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();

            Console.ReadLine();
        }

        private static void ForLoop()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine("Odd number: {0}", i);
            }
        }

        private static void WhileLoop()
        {
            int number = 100;
            
            while(number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void ForEachLoop()
        {
            string[] students = new string[] { "Tufan", "Sahin", "Duzel" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
