using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1

{

    //Scenario:
/*    You're developing a banking system where users can withdraw money from their account. If the withdrawal amount exceeds the daily limit (e.g., ₹50,000), the system must throw a custom exception called DailyLimitExceededException.
    Question:
    Create a custom exception class DailyLimitExceededException that includes a message and the attempted withdrawal amount.Then, implement a method Withdraw(decimal amount) in a BankAccount class that throws this exception if the withdrawal exceeds the limit.
    Demonstrate how you would catch this custom exception and display an appropriate message to the user.*/

    
    public class DailyLimitExceededException : Exception
    {
        public decimal AttemptedAmount { get;  }

        public DailyLimitExceededException(string message, decimal amount) : base(message)

        {
            AttemptedAmount = amount;

        }

        public class BankAccount
        {
            private const decimal DailyLimit = 50000;
            public void Withdraw(decimal amount)
            {
                if (amount > DailyLimit)
                {
                    throw new DailyLimitExceededException("Withdrawal exceeds daily limit.", amount);

                }
                Console.WriteLine($"₹{amount} withdrawn successfully.");


            }
        }
        class Program1
        {
            public static void Main()
            {
                BankAccount account = new BankAccount();

                try
                {
                    account.Withdraw(60000);

                }
                catch(DailyLimitExceededException ex)
                {
                    Console.WriteLine($"Error: {ex.Message} Attempted: ₹ {ex.AttemptedAmount}");


                }
            }
        }
    }

        /*Scenario:
    You are developing a C# application to calculate students' final grades. The application takes user input for marks in three subjects. The input should be integers between 0 and 100. You need to ensure that:
    The input is a valid integer.
    The marks are within the valid range.
    The average is calculated and displayed.
    Question:
    Design a try-catch block that:
    Handles non-integer inputs using FormatException.
    Handles invalid range(e.g., negative numbers or >100) using ArgumentOutOfRangeException.
    Always displays a "Grade calculation complete" message using finally.
    Explain how exception handling improves robustness in this scenario and optionally suggest how custom exceptions could be used to further improve it.*/


    class Program2
    {
        public static void Main()
        {
            int[] marks = new int[3];
            int total = 0;

            try
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter marks for subject {i + 1}:");
                    string input = Console.ReadLine();
                    int mark = int.Parse(input);

                    if (mark < 0 || mark > 100)
                    {
                        throw new ArgumentOutOfRangeException("Marks must be between 0 and 100.");

                    }
                    marks[i] = mark;
                    total += mark;

                }

            }
        }
    }
}

