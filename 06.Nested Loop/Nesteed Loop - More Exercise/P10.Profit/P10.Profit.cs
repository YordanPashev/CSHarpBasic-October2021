using System;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int lv1 = int.Parse(Console.ReadLine());
            int lv2 = int.Parse(Console.ReadLine());
            int lv5 = int.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            int counter1 = 0, counter2 = -1, counter5 = 0;
            int totalMoney = (lv1 * 1) + (lv2 * 2) + (lv5 * 5);

            for (int i = 0; i <= lv1 * 1; i += 1)
            {
                for (int j = 0; j <= lv2 * 2; j += 2)
                {
                    for (int k = 0; k <= lv5 * 5; k += 5)
                    {
                        counter1 = i / 1;
                        counter2 = j / 2;
                        counter5 = k / 5;
                        int sum = i + j + k;
                        
                        if (sum == amount)
                        {
                            Console.WriteLine($"{counter1} * 1 lv. + {counter2} * 2 lv. + {counter5} * 5 lv. = {amount} lv.");
                        }
                    }
                }
            }
        }
    }
}


