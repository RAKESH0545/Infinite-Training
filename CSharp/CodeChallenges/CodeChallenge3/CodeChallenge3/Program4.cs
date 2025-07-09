using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge3
{
    /*
    4. Write a console program that uses delegate object as an argument to call Calculator
       Functionalities like 1. Addition, 2. Subtraction and 3. Multiplication by taking 2
       integers and returning the output to the user. You should display all the return 
       values accordingly.
*/


        public delegate int CalculatorDelegate(int x, int y);

        class Program4
        {
            static void Main()
            {
                Console.Write("Enter the first number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number: ");
                int num2 = int.Parse(Console.ReadLine());


                CalculatorDelegate add = new CalculatorDelegate(Add);
                CalculatorDelegate subtract = new CalculatorDelegate(Subtract);

                Console.WriteLine($"Addition: {add(num1, num2)}");
                Console.WriteLine($"Subtraction: {subtract(num1, num2)}");
                Console.WriteLine($"Multiplication: {Multiply(num1, num2)}");

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }

            //addition
            public static int Add(int x, int y)
            {
                return x + y;
            }

            // subtraction
            public static int Subtract(int x, int y)
            {
                return x - y;
            }

            // multiplication
            public static int Multiply(int x, int y)
            {
                return x * y;
            }
        }
    


}

