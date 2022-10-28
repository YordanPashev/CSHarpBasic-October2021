using System;

namespace PrimePairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPairStartNum = int.Parse(Console.ReadLine());
            int secondPairStartNum = int.Parse(Console.ReadLine());
            int firstPairInterval = int.Parse(Console.ReadLine());
            int secondPairInterval = int.Parse(Console.ReadLine());
            int endfirstPairnum = firstPairStartNum + firstPairInterval;
            int endsecondPairnum = secondPairStartNum + secondPairInterval;
            int sum = 25 % 3;

            for (int i = firstPairStartNum; i <= endfirstPairnum; i++)
            {
                for (int j = secondPairStartNum; j <= endsecondPairnum; j++)
                {
                    if (i % 2 != 0 && j % 2 != 0 && i % 3 != 0 && j % 3 != 0 && 
                        i % 5 != 0 && j % 5 != 0 && i % 7 != 0 && j % 7 != 0)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }
    }
}