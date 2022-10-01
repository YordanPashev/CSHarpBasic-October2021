using System;

namespace TruckDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double run = double.Parse(Console.ReadLine());
            double paycheck = 0;

            if (run <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        paycheck = (0.75 * run) * 4;
                        paycheck *= 0.9;
                        break;

                    case "Summer":
                        paycheck = (0.9 * run) * 4;
                        paycheck *= 0.9;
                        break;

                    case "Winter":
                        paycheck = (1.05 * run) * 4;
                        paycheck *= 0.9;
                        break;
                }
            }

            if (run > 5000 && run <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        paycheck = (0.95 * run) * 4;
                        paycheck *= 0.9;
                        break;

                    case "Summer":
                        paycheck = (1.1 * run) * 4;
                        paycheck *= 0.9;
                        break;

                    case "Winter":
                        paycheck = (1.25 * run) * 4;
                        paycheck *= 0.9;
                        break;
                }
            }

            if (run > 10000 && run <= 20000)
            {
                paycheck = (1.45 * run) * 4;
                paycheck *= 0.9;
            }

            Console.WriteLine($"{paycheck:F2}");
        }
    }
}
