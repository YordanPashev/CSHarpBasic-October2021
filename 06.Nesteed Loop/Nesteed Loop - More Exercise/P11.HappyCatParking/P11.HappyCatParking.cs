using System;

namespace HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double dailyFee = 0, totalAmount = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        dailyFee += 2.5;
                    }

                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        dailyFee += 1.25;
                    }

                    else
                    {
                        dailyFee += 1;
                    }
                }

                Console.WriteLine($"Day: {i} - {dailyFee:F2} leva");
                totalAmount += dailyFee;
                dailyFee = 0;
            }
            
            Console.WriteLine($"Total: {totalAmount:F2} leva");
        }
    }
}