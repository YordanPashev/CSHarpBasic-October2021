using System;

namespace CarToGo
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double carPrice = 0;
            string carType = "";
            string car = "";

            if (budget <= 100)
            {
                carType = "Economy class";
                switch (season)
                {
                    case "Summer":
                        carPrice = budget * 0.35;
                        car = "Cabrio";
                        break;

                    case "Winter":
                        carPrice = budget * 0.65;
                        car = "Jeep";
                        break;
                }
            }

            else if (budget > 100 && budget <= 500)
            {
                carType = "Compact class";
                switch (season)
                {
                    case "Summer":
                        carPrice = budget * 0.45;
                        car = "Cabrio";
                        break;

                    case "Winter":
                        carPrice = budget * 0.8;
                        car = "Jeep";
                        break;
                }
            }

            else if(budget > 500)
            {
                carType = "Luxury class";
                car = "Jeep";
                carPrice = budget * 0.9;
            }

            Console.WriteLine(carType);
            Console.WriteLine($"{car} - {carPrice:F2}");
        }
    }
}
