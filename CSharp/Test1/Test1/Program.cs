using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    // Scenario:
    //A company is developing a billing system.A developer is asked to calculate the total cost of 5 items, each priced at ₹200, and then apply a 10% discount.
    //Question:
    //Write a simple C# code snippet using arithmetic operators to:
    //Calculate the total price
    //Apply the 10% discount
    //Print the final amount to be paid

    class BillingSystem
    {
        public static void Main()
        {
            int itemPrice = 200;
            int itemCount = 5;
            int totalPrice = itemPrice * itemCount;
            double discountRate = 0.10;
            double discountAmount = totalPrice - discountRate;
            double finalAmount = totalPrice - discountAmount;

            Console.WriteLine("Final amount to be paid: ₹" + finalAmount);


        }
    }


    //2. Operator Overloading
    //Scenario:
    //You are creating a Box class that has a Length property.The team wants to be able to "add" two boxes by summing their lengths.
    //Question:
    //Create a simple Box class and overload the + operator so that adding two boxes returns a new box with the combined length.


    class Box
    {
        public int Length { get; set; }
        public Box(int length)
        {
            Length = length;

        }
        public static Box operator +(Box b1, Box b2)
        {
            return new Box(b1.Length = b2.Length);

        }
        public override string ToString()
        {
            return $"Box with Length: {Length}";

        }
    }


    class Program2
    {
        public static void Main()
        {
            Box box1 = new Box(10);
            Box box2 = new Box(20);


            Box combinedBox = box1 + box2;
            Console.WriteLine(combinedBox);
        }
    }


    //3.Scenario:
    //You are building a leaderboard and want to compare player scores.
    //Question:
    //Write a class Player with a Score property and implement a method that:
    //Compares two Player objects using ==
    //Uses.Equals()
    //Uses.CompareTo() for sorting logic
    //Explain what each comparison is checking.


    class Player : IComparable<Player>
    {

        public int Score { get; set; }


        public Player(int score)
        {
            Score = score;
        }


        public static bool operator ==(Player p1, Player p2)
        {
            return p1.Score == p2.Score;
        }


        public static bool operator !=(Player p1, Player p2)
        {
            return !(p1 == p2);
        }


        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Player))
                return false;

            Player other = (Player)obj;
            return this.Score == other.Score;
        }


        public override int GetHashCode()
        {
            return Score.GetHashCode();
        }


        public int CompareTo(Player other)
        {
            if (other == null) return 1;
            return this.Score.CompareTo(other.Score);
        }


        public override string ToString()
        {
            return $"Player with Score: {Score}";
        }
    }

    class Program3
    {
        public static void Main()
        {

            Player player1 = new Player(100);
            Player player2 = new Player(200);


            Console.WriteLine(player1 == player2);

            Console.WriteLine(player1.Equals(player2));

            Console.WriteLine(player1.CompareTo(player2));
        }
    }


}


