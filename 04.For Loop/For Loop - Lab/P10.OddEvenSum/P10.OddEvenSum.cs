using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenNumSum = 0;
            int oddNumSum = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int number = int.Parse(Console.ReadLine());

                    evenNumSum += number;
                }
                
                else
                {
                    int number = int.Parse(Console.ReadLine());

                    oddNumSum += number;
                }
            }   

            if (evenNumSum == oddNumSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenNumSum}");
            }

            else
            {
                int diff = Math.Abs(evenNumSum - oddNumSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");

            }
        }
    }
}
