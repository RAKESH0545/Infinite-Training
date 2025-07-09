using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeChallenge3
{
    /*
        3. Write a program in C# Sharp to append some text to an existing file. If file is not available, then create one in the same workspace.
    */

    class Program3
    {
        static void Main()
        {
            Console.Write("Enter the file name: ");
            string fileName = Console.ReadLine();

            Console.Write("Enter the text to append: ");
            string textToAppend = Console.ReadLine();

            if (File.Exists(fileName))
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(textToAppend);
                }
                Console.WriteLine("Text appended to the existing file.");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    sw.WriteLine(textToAppend);
                }
                Console.WriteLine("File created and text written to it.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }


}
