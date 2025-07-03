
using System;

namespace Assignment5
{
    /*
    1. Exception Handling
    • You have a class which has methods for transaction for a banking system. (created earlier)
    • Define your own methods for deposit money, withdraw money and balance in the account.
    • Write your own new application Exception class called InsuffientBalanceException.
    • This new Exception will be thrown in case of withdrawal of money from the account where customer doesn’t have sufficient balance.
    • Identify and categorize all possible checked and unchecked exception.
    */

    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    public class Bank
    {
        private double balance;

        public Bank(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited: " + amount);
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Insufficient balance to withdraw.");
            }
            balance -= amount;
            Console.WriteLine("Amount Withdrawn: " + amount);
        }

        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }

    class Program1
    {
        static void Main()
        {
            try
            {
                Bank bank = new Bank(1000);  
                bank.Deposit(500);
                bank.Withdraw(200);
                bank.ShowBalance();
                bank.Withdraw(2000);  
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Custom Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General Exception: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
