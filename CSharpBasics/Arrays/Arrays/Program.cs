using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] students = new string[] {"Tufan", "Sahin", "Duzel"};

            foreach(var student in students)
            {
                Console.WriteLine(student);
            }*/

            string[,] continents = new string[4, 3]
            {
                {"Germany", "France", "Italy"}, 
                {"United States", "Mexico", "Canada"}, 
                {"Japan", "South Korea", "China"}, 
                {"Brazil", "Argentina", "Cuba"}
            };

            for(int i = 0; i <= continents.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= continents.GetUpperBound(1); j++)
                {
                    Console.WriteLine(continents[i, j]);
                }

                Console.WriteLine("-----");
            }

            Console.ReadLine();
        }
    }
}
