using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberofpeople = int.Parse(Console.ReadLine());
            double shiprent = 0.0;
            double discount = 0.0;
            double extrediscount = 0.0;

            switch (season)
            {
                case "Spring":
                    shiprent = 3000;
                    break;

                case "Summer":
                case "Autumn":
                    shiprent = 4200;
                    break;

                case "Winter":
                    shiprent = 2600;
                    break;
            }

            if (numberofpeople <= 6)
            {
                discount = 0.9;
            }

            else if (numberofpeople >= 7 && numberofpeople <= 11)
            {
                discount = 0.85;
            }

            else
            {
                discount = 0.75;
            }

            double totalPrice = shiprent * discount;

            if ((numberofpeople % 2 == 0) && (season == "Spring" || season == "Summer" || season == "Winter"))
            {
                extrediscount = 0.95;
                totalPrice *= extrediscount;
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }

            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
        }
    }
}
