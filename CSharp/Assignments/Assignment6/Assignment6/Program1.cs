using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{

    /*1. Create a class called Books with BookName and AuthorName as members.
       Instantiate the class through constructor and also write a method Display()
       to display the details.
       Create an Indexer of Books Object to store 5 books in a class called BookShelf.
        Using the indexer method assign values to the books and display the same.

    Hint(use Aggregation/composition)
    */


    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        public void Display()
        {
            Console.WriteLine($"Book: {BookName}, Author: {AuthorName}");
        }
    }

    public class BookShelf
    {
        private Books[] books = new Books[5];

        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }
    }

    class Program1
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();

            shelf[0] = new Books("Rakesh", "Naresh");
            shelf[1] = new Books("Kill", "Bill ");
            shelf[2] = new Books("Python", "C#");
            shelf[3] = new Books("White", "Black");
            shelf[4] = new Books("Mark", "Antony");

            for (int i = 0; i < 5; i++)
            {
                shelf[i].Display();
            }

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }

}
