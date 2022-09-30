using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int stay = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studio = 50;
                    apartment = 65;
                    break;
                case "June":
                case "September":
                    studio = 75.20;
                    apartment = 68.70;
                    break;
                case "July":
                case "August":
                    studio = 76;
                    apartment = 77;
                    break;
            }

            if ((stay > 7 && stay <= 14) && (month == "May" || month == "October"))
            {
                studio *= 0.95;
            }

            else if (stay > 14 && (month == "May" || month == "October"))
            {
                studio *= 0.7;
                apartment *= 0.9;
            }

            else if (stay > 14 && (month == "June" || month == "September"))
            {
                studio *= 0.8;
                apartment *= 0.9;
            }

            else if (stay > 14)
            {
                apartment *= 0.9;
            }

            studio *= stay;
            apartment *= stay;

            Console.WriteLine($"Apartment: {apartment:F2} lv.");
            Console.WriteLine($"Studio: {studio:F2} lv.");
        }
    }
}
