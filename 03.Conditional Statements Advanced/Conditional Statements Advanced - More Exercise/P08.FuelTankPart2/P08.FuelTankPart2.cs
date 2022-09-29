using System;

namespace FuelTankPart2
{
    class Program
    {
        private static double present;

        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();
            double result = 0;

            switch (fuel)
            {
                case "Gasoline":
                    result = quantity * 2.22;
                    if (discountCard == "Yes")
                    {
                        result = quantity * (2.22 - 0.18);
                    }
                    if (quantity >= 20 && quantity <= 25)
                    {
                        result *= 0.92;
                    }
                    else if (quantity > 25)
                    {
                        result *= 0.90;
                    }

                    break;

                case "Diesel":
                    result = quantity * 2.33;
                    if (discountCard == "Yes")
                    {
                        result = quantity * (2.33 - 0.12);
                    }
                    if (quantity >= 20 && quantity <= 25)
                    {
                        result *= 0.92;
                    }
                    else if (quantity > 25)
                    {
                        result *= 0.90;
                    }

                    break;

                case "Gas":
                    result = quantity * 0.93;
                    if (discountCard == "Yes")
                    {
                        result = quantity * (0.93 - 0.08);
                    }
                    if (quantity >= 20 && quantity <= 25)
                    {
                        result *= 0.92;
                    }
                    else if (quantity > 25)
                    {
                        result *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"{result:F2} lv.");
        }
    }
}