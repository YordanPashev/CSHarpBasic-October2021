using System;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxDiff = int.MinValue;
            int sum = 0, lastSum = 0;
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                sum = input1 + input2;

                if (i > 1)
                {
                    int sumMinusPreviousSum = Math.Abs(sum - lastSum);
                    if (sumMinusPreviousSum > maxDiff)
                    {
                        maxDiff = sumMinusPreviousSum;
                    }
                }

                if (sum <= min)
                {
                    min = sum;
                }

                if (sum >= max)
                {
                    max = sum;
                }
    
                lastSum = sum;
            }

            if (sum == max && sum == min)
            {
                Console.WriteLine($"Yes, value={sum}");
            }

            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }           
        }
    }
}
