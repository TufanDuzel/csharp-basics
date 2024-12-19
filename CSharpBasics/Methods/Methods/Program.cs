using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Addition(10);
            Console.WriteLine(result);

            //

            int a = 100;
            int b = 50;

            int result2 = Subtraction(ref a, b);
            Console.WriteLine(result2);

            //

            int number1;
            int number2 = 2;

            int result3 = Divition(out number1, number2);
            Console.WriteLine(result3);

            //

            Console.WriteLine(Multiplication(100, 200, 300, 400, 500));

            Console.ReadLine();
        }

        static int Addition(int x, int y = 0)
        {
            return x + y;
        }

        static int Subtraction(ref int a, int b)
        {
            a = 200;
            return a - b;
        }

        static int Divition(out int number1, int number2)
        {
            number1 = 10;
            return number1 / number2;
        }

        static int Multiplication(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
