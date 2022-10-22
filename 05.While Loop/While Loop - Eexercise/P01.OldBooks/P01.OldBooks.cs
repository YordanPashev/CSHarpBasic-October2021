using System;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            int bookCount = 0;
            string input = Console.ReadLine();

            while (input != "No More Books")
            {

                if (input == favouriteBook)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    break;
                }

                bookCount++;
                input = Console.ReadLine();

            }

            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}
