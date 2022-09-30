using System;

namespace Jorney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination;
            string accommodation = "l";
            double expenses = 0.0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        expenses = budget * 0.3;
                        accommodation = "Camp";
                        break;
                    case "winter":
                        expenses = budget * 0.7;
                        accommodation = "Hotel";
                        break;
                }
            }

            else if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        expenses = budget * 0.4;
                        accommodation = "Camp";
                        break;
                    case "winter":
                        expenses = budget * 0.8;
                        accommodation = "Hotel";
                        break;
                }
            }

            else
            {
                destination = "Europe";
                expenses = budget * 0.9;
                accommodation = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{accommodation} - {expenses:F2}");
        }
    }
}
