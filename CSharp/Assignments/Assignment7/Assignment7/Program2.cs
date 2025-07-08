using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
/*
    2.)
    Write a query that returns words starting with letter 'a' and ending with letter 'm'.
    Expected input and output
    "mum", "amsterdam", "bloom" → "amsterdam"

*/
    class Program2
    {
        static void Main()
        {
            List<string> words = new List<string> { "mum", "amsterdam", "bloom" };

            var result = words
     .Where(word => word.StartsWith("a") && word.EndsWith("m"));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }

}
