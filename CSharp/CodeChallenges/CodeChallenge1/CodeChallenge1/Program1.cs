using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    /*1. Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.
 
    Sample Input:
    "Python", 1
    "Python", 0
    "Python", 4
    Expected Output:
    Pthon
    ython
    Pythn*/

    class Program1
    {
        static string RemoveChar(string str, int pos)
        {
            return str.Remove(pos, 1);

        }

        static void Main()
        {
            Console.WriteLine(RemoveChar("Python", 1));
            Console.WriteLine(RemoveChar("Python", 0));
            Console.WriteLine(RemoveChar("Python", 4));
            Console.ReadLine();
        }
    }
}
