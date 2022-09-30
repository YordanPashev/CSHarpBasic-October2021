using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine()) - 1;
            string accommodation = Console.ReadLine();
            string feedback = Console.ReadLine();

            double result = 0;
            double roomForOnePerson = 18;
            double apartment = 25;
            double presidentApartment = 35;
            double finalprice = 0;

            switch (accommodation)
            {
                case "room for one person":
                    result = nights * roomForOnePerson;
                    break;

                case "apartment":
                    result = nights * apartment;
                    if (nights < 10)
                    {
                        result *= 0.7;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        result *= 0.65;
                    }
                    else
                    {
                        result *= 0.5;
                    }
                    break;
                case "president apartment":
                    result = presidentApartment * nights;
                    if (nights < 10)
                    {
                        result *= 0.9;
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        result *= 0.85;
                    }
                    else
                    {
                        result *= 0.80;
                    }
                    break;
            }

            if (feedback == "positive")
            {
                result *= 1.25;
                Console.WriteLine($"{result:F2}");
            }

            else if (feedback == "negative")
            {
                result *= 0.9;
                Console.WriteLine($"{result:F2}");
            }         
        }
    }
}