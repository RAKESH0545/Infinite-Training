
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge3
{
    /* 
    1. Write a program to find the Sum and the Average points scored by the teams in the IPL. Create 
       a Class called CricketTeam that has a function called Pointscalculation(int no_of_matches)
       that takes no.of matches as input and accepts that many scores from the user. The function should
       then return the Count of Matches, Average and Sum of the scores.
    */

    class CricketTeam
    {
        private List<int> scores = new List<int>();

        public (int, int, double) Pointscalculation(int no_of_matches)
        {
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.Write($"Enter score for match {i + 1}: ");
                int score = int.Parse(Console.ReadLine());
                scores.Add(score);
            }

            int totalScore = scores.Sum();
            double averageScore = (double)totalScore / no_of_matches;

            return (no_of_matches, totalScore, averageScore);
        }
    }

    class Program1
    {
        static void Main()
        {
            CricketTeam team = new CricketTeam();

            Console.Write("Enter the number of matches: ");
            int no_of_matches = int.Parse(Console.ReadLine());

            var (count, total, average) = team.Pointscalculation(no_of_matches);

            Console.WriteLine("\nResults:");
            Console.WriteLine($"Count of Matches: {count}");
            Console.WriteLine($"Sum of Scores: {total}");
            Console.WriteLine($"Average Score: {average:F2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
