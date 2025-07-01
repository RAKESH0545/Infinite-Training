using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
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
            Console.ReadLine();
        }
    }



}
