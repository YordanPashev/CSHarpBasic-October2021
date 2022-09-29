using System;

namespace FlowerShop
{
    class Program
    {
        private static double present;

        static void Main(string[] args)
        {
            double magnolias = double.Parse(Console.ReadLine()) * 3.25;
            double hyacinthus = double.Parse(Console.ReadLine()) * 4;
            double roses = double.Parse(Console.ReadLine()) * 3.5;
            double cactuses = double.Parse(Console.ReadLine()) * 8;
            double presentPrice = double.Parse(Console.ReadLine());

            double result = (magnolias + hyacinthus + roses + cactuses) * 0.95;

            if (result >= presentPrice)
            {
                result -= presentPrice;
                Console.WriteLine($"She is left with {Math.Floor(result)} leva.");
            }

            else if (result < presentPrice)
            {
                double neededMoney = presentPrice - result;
                Console.WriteLine($"She will have to borrow {Math.Ceiling(neededMoney)} leva." );
            }
        }
    }
}