
using System;

namespace Assignment5
{
    /*
    2. Exception Handling
    Create a class called Scholarship which has a function Public void Merit() that takes marks and fees as an input.
    If the given mark is >= 70 and <=80, then calculate scholarship amount as 20% of the fees
    If the given mark is > 80 and <=90, then calculate scholarship amount as 30% of the fees
    If the given mark is >90, then calculate scholarship amount as 50% of the fees.
    In all the cases return the Scholarship amount, else throw an user exception
    */

    public class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message) { }
    }

    public class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            if (marks >= 70 && marks <= 80)
            {
                return fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                return fees * 0.30;
            }
            else if (marks > 90)
            {
                return fees * 0.50;
            }
            else
            {
                throw new InvalidMarksException("Marks do not qualify for a scholarship.");
            }
        }
    }

    class Program2
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter marks: ");
                int marks = int.Parse(Console.ReadLine());

                Console.Write("Enter fees: ");
                double fees = double.Parse(Console.ReadLine());

                Scholarship scholarship = new Scholarship();
                double amount = scholarship.Merit(marks, fees);

                Console.WriteLine($"Scholarship Amount: ₹{amount}");
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }

            Console.ReadKey();
        }
    }
}
