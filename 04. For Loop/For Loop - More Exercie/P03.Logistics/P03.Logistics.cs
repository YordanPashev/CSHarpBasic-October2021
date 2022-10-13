using System;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            double minibusTones = 0, truckTones = 0, trainTones = 0, totalCount = 0;
            double averagePricePercentage = 0, expenses = 0, totalPrice = 0;
            double minibusExpenses = 0, truckExpenses = 0, trainExpenses = 0;

            for (int i = 1; i <= quantity; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    expenses = weight * 200;
                    minibusExpenses += expenses;
                    minibusTones += weight;
                }

                else if (weight > 3 && weight <= 11)
                {
                    expenses = weight * 175;
                    truckExpenses += expenses;
                    truckTones += weight;
                }

                else
                {
                    expenses = weight * 120;
                    trainExpenses += expenses;
                    trainTones += weight;
                }
                
                totalPrice += expenses;
            }

            totalCount = minibusTones + truckTones + trainTones;
            averagePricePercentage = totalPrice / totalCount;
            double minibusPercentage = (minibusTones / totalCount) * 100;
            double truckPercentage = (truckTones / totalCount) * 100;
            double trainPercentage = (trainTones / totalCount) * 100;

            Console.WriteLine($"{averagePricePercentage:F2}");
            Console.WriteLine($"{minibusPercentage:F2}%");
            Console.WriteLine($"{truckPercentage:F2}%");
            Console.WriteLine($"{ trainPercentage:F2}%");
        }
    }
}
