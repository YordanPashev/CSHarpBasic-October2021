using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < input; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }

            int sumwithmax = sum - max;

            if (max == sumwithmax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }

            else if (max != sumwithmax)
            {
                int diff = Math.Abs(sumwithmax- max);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
