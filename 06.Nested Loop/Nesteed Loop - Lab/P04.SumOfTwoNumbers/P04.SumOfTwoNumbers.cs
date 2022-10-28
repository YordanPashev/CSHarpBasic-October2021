using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicDigit = int.Parse(Console.ReadLine());
            int counter = 0;
            int result = 0;
            bool isEqual = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    result = j + i;
                    counter++;
                    if (result == magicDigit)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicDigit})");
                        isEqual = true;
                        break;
                    }
                }
                
                if (isEqual)
                {
                    break;
                }
            }

            if (isEqual == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicDigit}");
            }
        }
    }
}
