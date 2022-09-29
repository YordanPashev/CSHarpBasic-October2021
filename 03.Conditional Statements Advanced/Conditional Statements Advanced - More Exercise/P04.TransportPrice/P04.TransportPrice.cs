using System;

namespace ConsoleApp3
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxiPrice = 0.70;
            double dayTaxi = 0.79;
            double nightTaxi = 0.90;
            double bus = 0.09;
            double train = 0.06;
            double sum = 0;

            if (distance < 20)
            {
                switch (time)
                {
                    case "day":
                        sum = taxiPrice + (dayTaxi * distance);
                        break;
                    case "night":
                        sum = taxiPrice + (nightTaxi * distance);
                        break;
                }
            }

            else if (distance >= 20 && distance < 100)
            {
                sum = bus * distance; 
            }

            else if (distance >= 100)
            {
                sum = train * distance;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
