using System;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double people = int.Parse(Console.ReadLine());
            double ticketPrice = 0, result = 0;

            switch (type)
            {
                case "VIP":
                    ticketPrice = people * 499.99;
                    break;
                case "Normal":
                    ticketPrice = people * 249.99;
                    break;
            }

            if (people <= 4)
            {
                result = budget * 0.25;
            }

            else if(people >= 5 && people <= 9)
            {
                result = budget * 0.4;
            }
            else if (people >= 10 && people <= 24)
            {
                result = budget * 0.5;
            }

            else if (people >= 25 && people <= 49)
            {
                result = budget * 0.6;
            }
            else if (people >= 50)
            {
                result = budget * 0.75;
            }

            if (result >= ticketPrice)
            {
                double moneyLeft = result - ticketPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else if (ticketPrice > result)
            {
                double neededMoney = ticketPrice - result;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva.");
            }
        }
    }
}
