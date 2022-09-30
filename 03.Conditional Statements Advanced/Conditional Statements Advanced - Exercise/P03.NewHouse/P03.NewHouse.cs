using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeofFlower = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double finalprice = 0.0;

            double roses = 5;
            double dahlias = 3.80;
            double tulips = 2.80;
            double narcissus = 3;
            double glardiolus = 2.5;

            if (typeofFlower == "Roses" && quantity > 80)
            {
                finalprice = quantity * roses * 0.9;
            }

            else if (typeofFlower == "Roses")
            {
                finalprice = quantity * roses;
            }

            if (typeofFlower == "Dahlias" && quantity > 90)
            {
                finalprice = quantity * dahlias * 0.85;

            }

            else if (typeofFlower == "Dahlias" && quantity <=90)
            {
                finalprice = quantity * dahlias;
            }

            if (typeofFlower == "Tulips" && quantity > 80)
            {
                finalprice = quantity * tulips * 0.85;

            }

            else if (typeofFlower == "Tulips" && quantity <= 80)
            {
                finalprice = quantity * tulips;
            }

            if (typeofFlower == "Narcissus" && quantity < 120)
            {
                finalprice = quantity * narcissus * 1.15;

            }

            else if (typeofFlower == "Narcissus" && quantity >= 120)
            {
                finalprice = quantity * narcissus;
            }

            if (typeofFlower == "Gladiolus" && quantity < 80)
            {
                finalprice = quantity * glardiolus * 1.20;

            }

            else if (typeofFlower == "Gladiolus" && quantity >= 80)
            {
                finalprice = quantity * glardiolus;
            }


            if (budget >= finalprice)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {typeofFlower} and {budget - finalprice:F2} leva left.");
            }

            else
            {
                Console.WriteLine($"Not enough money, you need {finalprice - budget:F2} leva more.");
            }
        }
    }
}
