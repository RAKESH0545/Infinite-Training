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
        }
    }

    /*2. Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
 
    Sample Input:
    "abcd"
    "a"
    "xy"
    Expected Output:
 
    dbca
    a
    yx*/

    class Program2
    {
        static string SwapFirstLast(string str)
        {
            if (str.Length <= 1)
                return str;

            char first = str[0];
            char last = str[str.Length - 1];
            string middle = str.Substring(1, str.Length - 2);


            return last + middle + first;
        }

        static void Main()
        {
            Console.WriteLine(SwapFirstLast("abcd"));
            Console.WriteLine(SwapFirstLast("a"));
            Console.WriteLine(SwapFirstLast("xy"));
        }
    }

    /*3. Write a C# Sharp program to check the largest number among three given integers.
 
    Sample Input:
    1,2,3
    1,3,2
    1,1,1
    1,2,2
    Expected Output:
    3
    3
    1
    2*/

    class Program3
    {
        static int FindLargest(int a, int b, int c)
        {
            int max = a;

            if (b > max)
                max = b;

            if (c > max)
                max = c;

            return max;
        }

        static void Main()
        {
            Console.WriteLine(FindLargest(1, 2, 3));
            Console.WriteLine(FindLargest(1, 3, 2));
            Console.WriteLine(FindLargest(1, 1, 1));
            Console.WriteLine(FindLargest(1, 2, 2));
        }
    }



}
