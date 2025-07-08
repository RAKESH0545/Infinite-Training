using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /*
        1.) 
        Write a query that returns list of numbers and their squares only if square is greater than 20 

        Example input[7, 2, 30]
        Expected output
        → 7 - 49, 30 - 900
    */

    class Program1
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by commas (e.g., 7,2,30):");
            string input = Console.ReadLine();

            List<int> numbers = input.Split(',').Select(int.Parse).ToList();

            var result = numbers
             .Select(n => new { Number = n, Square = n * n })
             .Where(x => x.Square > 20);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }

}
