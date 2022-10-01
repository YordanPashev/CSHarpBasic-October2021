using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodation = "", location = "";
            double expenses = 0;

            if (budget <= 1000)
            {
                accomodation = "Camp";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        expenses = budget * 0.65;
                        break;

                    case "Winter":
                        location = "Morocco";
                        expenses = budget * 0.45;
                        break;
                }
            }

            if (budget > 1000 && budget <= 3000)
            {
                accomodation = "Hut";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        expenses = budget * 0.8;
                        break;

                    case "Winter":
                        location = "Morocco";
                        expenses = budget * 0.60;
                        break;
                }
            }

            if (budget > 3000)
            {
                accomodation = "Hotel";
                switch (season)
                {
                    case "Summer":
                        location = "Alaska";
                        expenses = budget * 0.9;
                        break;

                    case "Winter":
                        location = "Morocco";
                        expenses = budget * 0.9;
                        break;
                }
            }

            Console.WriteLine($"{location} - {accomodation} - {expenses:F2}");
        }
    }
}
