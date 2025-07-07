using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment6
{
    /*
        3. Write a program in C# Sharp to count the number of lines in a file.
    */
    class Program3
    {
        static void Main()
        {
            string filePath = "output.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                int lineCount = lines.Length;

                Console.WriteLine($"The file {filePath} contains {lineCount} lines.");
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
