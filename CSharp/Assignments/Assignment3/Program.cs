using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    //1. Create a class called Accounts which has data members/fields like Account no, Customer name, Account type, Transaction type (d/w), amount, balance
    //D->Deposit
    //W->Withdrawal

    //-write a function that updates the balance depending upon the transaction type

    //-If transaction type is deposit call the function credit by passing the amount to be deposited and update the balance

    //function Credit(int amount)

    //-If transaction type is withdraw call the function debit by passing the amount to be withdrawn and update the balance

    //Debit(int amt) function 

    //-Pass the other information like Account no, customer name, acc type through constructor

    //-write and call the show data method to display the values.


    class Accounts
    {
        public int AccountNo;
        public string CustomerName;
        public string AccountType;
        public int Balance;

        public Accounts(int accNo, string name, string accType, int initialBalance)
        {
            AccountNo = accNo;
            CustomerName = name;
            AccountType = accType;
            Balance = initialBalance;
        }

        public void Credit(int amount)
        {
            Balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }

        public void Debit(int amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Not enough balance to withdraw.");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
        }

        public void ShowData()
        {
            Console.WriteLine("\nAccount Info:");
            Console.WriteLine("Account No: " + AccountNo);
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Account Type: " + AccountType);
            Console.WriteLine("Balance: " + Balance);
        }

        static void Main()
        {
            Accounts acc = new Accounts(05450, "Rakesh", "Savings", 18900);

            acc.Credit(5000);   
            acc.Debit(3000);    
            acc.ShowData();     
        }
    }



    //2. Create a class called student which has data members like rollno, name, class, Semester, branch, int [] marks=new int marks [5](marks of 5 subjects )

    //-Pass the details of student like rollno, name, class, SEM, branch in constructor

    //-For marks write a method called GetMarks() and give marks for all 5 subjects

    //-Write a method called displayresult, which should calculate the average marks

    //-If marks of any one subject is less than 35 print result as failed
    //-If marks of all subject is >35,but average is < 50 then also print result as failed
    //-If avg > 50 then print result as passed.

    //-Write a DisplayData() method to display all object members values.


    class Student
    {
        public int RollNo;
        public string Name;
        public string ClassName;
        public int Semester;
        public string Branch;
        public int[] Marks = new int[5];

        public Student(int rollNo, string name, string className, int semester, string branch)
        {
            RollNo = rollNo;
            Name = name;
            ClassName = className;
            Semester = semester;
            Branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayResult()
        {
            int total = 0;
            bool failed = false;

            for (int i = 0; i < 5; i++)
            {
                total += Marks[i];
                if (Marks[i] < 35)
                {
                    failed = true;
                }
            }

            double average = total / 5.0;

            if (failed || average < 50)
            {
                Console.WriteLine("Result: Failed");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll No: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Class: " + ClassName);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("Branch: " + Branch);
            Console.WriteLine("Marks: " + string.Join(", ", Marks));
        }

        static void Main()
        {
            Student s1 = new Student(101, "Anjali", "10th", 2, "Science");
            s1.GetMarks();
            s1.DisplayData();
            s1.DisplayResult();
        }
    }



    //3. Create a class called Saledetails which has data members like Salesno,  Productno,  Price, dateofsale, Qty, TotalAmount
    //- Create a method called Sales() that takes qty, Price details of the object and updates the TotalAmount as  Qty* Price
    //- Pass the other information like SalesNo, Productno, Price, Qty and Dateof sale through constructor
    //- call the show data method to display the values without an object.


    class Saledetails
    {
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public string DateOfSale;
        public int Qty;
        public double TotalAmount;

        public Saledetails(int salesNo, int productNo, double price, int qty, string dateOfSale)
        {
            SalesNo = salesNo;
            ProductNo = productNo;
            Price = price;
            Qty = qty;
            DateOfSale = dateOfSale;
            Sales(); 
        }

        public void Sales()
        {
            TotalAmount = Qty * Price;
        }

        public void ShowData()
        {
            Console.WriteLine("\nSales Details:");
            Console.WriteLine("Sales No: " + SalesNo);
            Console.WriteLine("Product No: " + ProductNo);
            Console.WriteLine("Price: ₹" + Price);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Date of Sale: " + DateOfSale);
            Console.WriteLine("Total Amount: ₹" + TotalAmount);
        }

        static void Main()
        {
            Saledetails sale = new Saledetails(1, 101, 250.50, 4, "24-06-2025");
            sale.ShowData();
        }
    }




}
