using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    /*
        2. Write a program in C# Sharp to create a file and write an array of strings to the file.
    */
    class Program2
    {
        static void Main()
        {
            string[] lines = { "First line", "Second line", "Third line", "Fourth line", "Fifth line" };

            string filePath = "output.txt";

            try
            {
                File.WriteAllLines(filePath, lines);

                Console.WriteLine($"Data written to {filePath}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }

}
