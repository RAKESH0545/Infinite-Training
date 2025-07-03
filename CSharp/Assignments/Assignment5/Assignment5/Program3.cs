
using System;

namespace Assignment5
{
    /*
    3. Create a class called Books with BookName and AuthorName as members.
    Instantiate the class through constructor and also write a method Display()
    to display the details.

    Create an Indexer of Books Object to store 5 books in a class called 
    BookShelf. Using the indexer method assign values to the books and display the same.

    Hint (use Aggregation/composition)
    */

    class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        public Books(string bookname, string authorname)
        {
            BookName = bookname;
            AuthorName = authorname;
        }

        public void Display()
        {
            Console.WriteLine($"Book Name = {BookName}, Author Name = {AuthorName}");
        }
    }

    class BookShelf
    {
        Books[] bookArray = new Books[5];

        public Books this[int index]
        {
            get { return bookArray[index]; }
            set { bookArray[index] = value; }
        }
    }

    class Program3
    {
        static void Main()
        {
            BookShelf bookshelf = new BookShelf();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Book Name {i + 1}: ");
                string bookname = Console.ReadLine();

                Console.Write($"Enter Author Name {i + 1}: ");
                string authorname = Console.ReadLine();

                bookshelf[i] = new Books(bookname, authorname);
            }

            Console.WriteLine("\n======== Books inside BookShelf =========");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}. ");
                bookshelf[i].Display();
            }

            Console.ReadKey();
        }
    }
}
