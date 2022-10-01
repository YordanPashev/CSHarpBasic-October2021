using System;

namespace Flower
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsQuantity = int.Parse(Console.ReadLine());
            int rosesQuantity = int.Parse(Console.ReadLine());
            int tulipQuantity = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holliday = Console.ReadLine();
            double chrysanthemumsPrice = 0, rosesPrice = 0, tulipPrice = 0, result = 0;

            switch (season)
            {

                case "Spring":
                case "Summer":
                    chrysanthemumsPrice = 2 * chrysanthemumsQuantity;
                    rosesPrice = 4.1 * rosesQuantity;
                    tulipPrice = 2.5 * tulipQuantity;
                    result = chrysanthemumsPrice + rosesPrice + tulipPrice;
                    break;

                case "Autumn":
                case "Winter":
                    chrysanthemumsPrice = 3.75 * chrysanthemumsQuantity;
                    rosesPrice = 4.5 * rosesQuantity;
                    tulipPrice = 4.15 * tulipQuantity;
                    result = chrysanthemumsPrice + rosesPrice + tulipPrice;
                    break;
            }

            if (holliday == "Y")
            {
                result *= 1.15;
            }

            if (season == "Spring" && tulipQuantity > 7)
            {
                result *= 0.95;
            }

            if (season == "Winter" && rosesQuantity >= 10)
            {
                result *= 0.90;
            }

            if (chrysanthemumsQuantity + rosesQuantity + tulipQuantity > 20)
            {
                result *= 0.8;
            }

            Console.WriteLine($"{(result + 2):F2}");
        }
    }
}
