
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program3
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());
                CheckPositive(number);
                Console.WriteLine("The number is positive.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }

        static void CheckPositive(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The number cannot be negative.");
            }
        }
    }
}
