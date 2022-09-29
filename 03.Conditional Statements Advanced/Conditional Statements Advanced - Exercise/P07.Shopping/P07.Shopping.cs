using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double petersBudget = double.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double priceForCPU = cpu * 250;
            double priceForProcessor = (priceForCPU * 0.35) * processor;
            double priceForRam = (priceForCPU * 0.1) * ram;

            double result = priceForCPU + priceForProcessor + priceForRam;
            
            
            if (cpu > processor)
            {
                string disc = "15%";
                result *= 0.85;
            }

            if (petersBudget >= result)
            {
                double moneyLeft = petersBudget - result;
                Console.WriteLine($"You have {moneyLeft:F2} leva left!");
            }

            else
            {
                double neededMoney = result - petersBudget;
                Console.WriteLine($"Not enough money! You need {neededMoney:F2} leva more!");
            }
        }
    }
}
