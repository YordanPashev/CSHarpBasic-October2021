using System;

namespace CinemaTickets 
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isntFinished = true;
            double studentCounter = 0;
            double standardCounter = 0;
            double kidCounter = 0;;
            double movieticketCounter = 0;

            while (isntFinished == true)
            {
                string movie = Console.ReadLine();

                if (movie == "Finish")
                {
                    isntFinished = false;
                    break;
                }

                int seatingCapacity = int.Parse(Console.ReadLine());
                double full = 0;

                for (int i = seatingCapacity; i > 0; i--)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    switch (ticketType)
                    {
                        case "student":
                            movieticketCounter++;
                            studentCounter++;
                            break;
                        case "standard":
                            movieticketCounter++;
                            standardCounter++;
                            break;
                        case "kid":
                            movieticketCounter++;
                            kidCounter++;
                            break;
                    }
                }

                full = (movieticketCounter / seatingCapacity) * 100;
                Console.WriteLine($"{movie} - {full:F2}% full.");
                movieticketCounter = 0;
            }

            double totaltickets = studentCounter + standardCounter + kidCounter;
            Console.WriteLine($"Total tickets: {totaltickets}");
            Console.WriteLine($"{((studentCounter / totaltickets) * 100):F2}% student tickets.");
            Console.WriteLine($"{((standardCounter / totaltickets) * 100):F2}% standard tickets.");
            Console.WriteLine($"{((kidCounter / totaltickets) * 100):F2}% kids tickets.");
        }
    }
}
