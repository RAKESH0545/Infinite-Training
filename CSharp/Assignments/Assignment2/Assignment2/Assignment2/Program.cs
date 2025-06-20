using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    //1. Write a C# Sharp program to swap two numbers.
    class Program1
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"\nBefore swapping: num1 = {num1}, num2 = {num2}");


            int temp = num1;
            num1 = num2;
            num2 = temp;


            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }

    //2. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.

    // Test Data:
    //Enter a digit: 25

    //Expected Output:
    //25 25 25 25
    //25252525
    //25 25 25 25
    //25252525

    class Program2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a digit: ");
            string input = Console.ReadLine();


            Console.WriteLine("{0} {0} {0} {0}", input);


            Console.WriteLine("{0}{0}{0}{0}", input);


            Console.WriteLine("{0} {0} {0} {0}", input);
            Console.WriteLine("{0}{0}{0}{0}", input);
        }
    }

    //3. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.
    //Test Data / input: 2
    //Expected Output :Tuesday

    class Program3
    {
        public static void Main()
        {
            Console.Write("Enter a day number (1-7): ");
            int dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.  Enter a number between 1 and 7.");
                    break;
            }
        }
    }

    //ARRAYS

    //1.    Write a  Program to assign integer values to an array  and then print the following
    //a.Average value of Array elements
    //b.Minimum and Maximum value in an array

    class Array1
    {
        public static void Main()
        {

            int[] numbers = { 10, 25, 30, 5, 40, 15 };


            double sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = sum / numbers.Length;


            int min = numbers[0];
            int max = numbers[0];

            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }


            Console.WriteLine("Array Elements: " + string.Join(", ", numbers));
            Console.WriteLine("Average Value: " + average);
            Console.WriteLine("Minimum Value: " + min);
            Console.WriteLine("Maximum Value: " + max);
        }
    }


    //2.	Write a program in C# to accept ten marks and display the following
    // a.Total
    //b.Average

    //c.Minimum marks

    //d.Maximum marks

    //e.Display marks in ascending order

    //f.Display marks in descending order


    class Array2
    {
        public static void Main()
        {
            int[] marks = new int[10];


            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }


            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            double average = total / (double)marks.Length;


            int min = marks[0];
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min) min = mark;
                if (mark > max) max = mark;
            }


            Array.Sort(marks);
            int[] descending = (int[])marks.Clone();
            Array.Reverse(descending);


            Console.WriteLine($"\nTotal Marks: {total}");
            Console.WriteLine($"Average Marks: {average}");
            Console.WriteLine($"Minimum Marks: {min}");
            Console.WriteLine($"Maximum Marks: {max}");

            Console.WriteLine("\nMarks in Ascending Order:");
            Console.WriteLine(string.Join(", ", marks));

            Console.WriteLine("Marks in Descending Order:");
            Console.WriteLine(string.Join(", ", descending));
        }
    }

    //3.  Write a C# Sharp program to copy the elements of one array into another array.(do not use any inbuilt functions)

    class Array3
    {
        public static void Main()
        {

            int[] originalArray = { 10, 20, 30, 40, 50 };


            int[] copiedArray = new int[originalArray.Length];


            for (int i = 0; i < originalArray.Length; i++)
            {
                copiedArray[i] = originalArray[i];
            }


            Console.WriteLine("Original Array: " + string.Join(", ", originalArray));
            Console.WriteLine("Copied Array: " + string.Join(", ", copiedArray));
        }
    }

    //STRINGS

    //1.	Write a program in C# to accept a word from the user and display the length of it.

    class String1
    {
        public static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            int length = word.Length;

            Console.WriteLine($"The length of the word \"{word}\" is: {length}");
        }
    }

    //2.	Write a program in C# to accept a word from the user and display the reverse of it. 

    class String2
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reversed = "";


            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }

            Console.WriteLine($"The reverse of \"{word}\" is: {reversed}");
        }
    }

    //3.	Write a program in C# to accept two words from user and find out if they are same. 

    //Hint: Use functions of the string class

    class String3
    {
        public static void Main()
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            
            if (word1.Equals(word2))
            {
                Console.WriteLine("The words are the same.");
            }
            else
            {
                Console.WriteLine("The words are different.");
            }
        }
    }


}
