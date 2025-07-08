
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    /* 
        4.    Create a class library with a function CalculateConcession()  that takes age as an input and calculates concession for travel as below:
        If age <= 5 then “Little Champs - Free Ticket” should be displayed
        If age > 60 then calculate 30% concession on the totalfare(Which is a constant Eg:500/-) and Display “ Senior Citizen” + Calculated Fare
        Else “Print Ticket Booked” + Fare.
        Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.Accept Name, Age from the user and call the CalculateConcession() function to test the Classlibrary functionality
    */

    public class ConcessionCalculator
    {
        private const int TotalFare = 500;

        public string CalculateConcession(int age)
        {
            if (age <= 5)
            {
                return "Little Champs - Free Ticket";
            }
            else if (age > 60)
            {
                double concessionFare = TotalFare * 0.7; // 30% concession
                return $"Senior Citizen - Fare: {concessionFare}";
            }
            else
            {
                return $"Ticket Booked - Fare: {TotalFare}";
            }
        }
    }

    class Program4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            ConcessionCalculator calculator = new ConcessionCalculator();
            string result = calculator.CalculateConcession(age);

            Console.WriteLine("=======================");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine(result);
       
            Console.WriteLine("----Press Enter to Exit..-----");
            Console.ReadLine();
        }
    }
   

}
