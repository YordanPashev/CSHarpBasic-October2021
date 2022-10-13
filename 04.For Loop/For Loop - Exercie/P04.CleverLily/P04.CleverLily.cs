using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double wm = double.Parse(Console.ReadLine());
            double toysquantity = 0;
            double toyPrice = double.Parse(Console.ReadLine());
            double money = 0, totalToySum = 0, m = 1, totalmoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money = 10 * m++;
                    totalmoney += money;
                }

                else
                {
                    toysquantity++;
                }
            }

            totalToySum = toyPrice * toysquantity;
            double totalSum = totalmoney + totalToySum;
            double stealing = (age / 2) * 1;
            totalSum -= stealing;
            
            if (totalSum >= wm)
            {
                double moneyleft = totalSum - wm;
                Console.WriteLine($"Yes! {moneyleft:F2}");
            }

            else
            {
                double moneyneeded = wm - totalSum;
                Console.WriteLine($"No! {moneyneeded:F2}");
            }

        }
    }
}
