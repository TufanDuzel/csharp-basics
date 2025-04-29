using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Istanbul";

            foreach(var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Roma";

            /*String cities = city + city2;
            Console.WriteLine(cities);*/

            Console.WriteLine(string.Format("{0} {1}", city, city2));



            string sentence = "I love coding.";

            var characters = sentence.Length;
            Console.WriteLine(characters);
            
            var sentence2 = sentence.Clone();
            Console.WriteLine(sentence2);

            bool end = sentence.EndsWith(".");
            Console.WriteLine(end);

            bool start = sentence.StartsWith("I");
            Console.WriteLine(start);

            var index = sentence.IndexOf("coding");
            Console.WriteLine(index);
            // if the index can't be fined, the result will be "-1".

            var indexBeginning = sentence.IndexOf(" ");
            Console.WriteLine(indexBeginning);
            // Starts searching the index from beginning.

            var indexEnd = sentence.LastIndexOf(" ");
            Console.WriteLine(indexEnd);
            // Starts searching the index from end.

            var adding = sentence.Insert(0, "Hi ");
            Console.WriteLine(adding);

            var cutting = sentence.Substring(7, 6);
            Console.WriteLine(cutting);

            var lower = sentence.ToLower();
            Console.WriteLine(lower);

            var upper = sentence.ToUpper();
            Console.WriteLine(upper);

            var replacing = sentence.Replace(" ", "- ");
            Console.WriteLine(replacing);

            var removing = sentence.Remove(6);
            Console.WriteLine(removing);

            Console.ReadLine();
        }
    }
}
