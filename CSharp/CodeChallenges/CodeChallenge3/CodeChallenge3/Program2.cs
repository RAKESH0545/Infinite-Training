
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge3
{
    /* 
    2. Write a class Box that has Length and breadth as its members. Write a function that 
    adds 2 box objects and stores in the 3rd. Display the 3rd object details. Create a
    Test class to execute the above.
    */


    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box AddBoxes(Box box1, Box box2)
        {
            double newLength = box1.Length + box2.Length;
            double newBreadth = box1.Breadth + box2.Breadth;
            return new Box(newLength, newBreadth);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
        }
    }

    class Program2 //class name written program2 instead of class Test for better understandings in files.
    {
        static void Main()
        {
            Console.Write("Enter the length of Box 1: ");
            double length1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of Box 1: ");
            double breadth1 = double.Parse(Console.ReadLine());

            Box box1 = new Box(length1, breadth1);

            Console.Write("Enter the length of Box 2: ");
            double length2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth of Box 2: ");
            double breadth2 = double.Parse(Console.ReadLine());

            Box box2 = new Box(length2, breadth2);

            Box box3 = Box.AddBoxes(box1, box2);

            Console.WriteLine("Box 3 details (sum of Box 1 and Box 2):");
            box3.Display();

            // Keep the console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
