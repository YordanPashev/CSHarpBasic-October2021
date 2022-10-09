using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int n2 = n* 2;
            int half = n2 / 2;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= half; i++)
            {
                int lfn = int.Parse(Console.ReadLine());
                leftSum += lfn;
            }

            for (int i = 0; i < half; i++)
            {
                int rn = int.Parse(Console.ReadLine());
                rightSum += rn;
            }

            if (leftSum == rightSum)
            {
               Console.WriteLine($"Yes, sum = {leftSum}");
            }

            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }         
        }
    }
}
