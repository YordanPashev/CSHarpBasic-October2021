using System;

namespace SumPrimeNonPrime 
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeNumbersSum = 0;
            int nonprimeNumbersSum = 0;

            while (input != "stop")
            {
                int digit = Convert.ToInt32(input);

                if (digit < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                if (digit == 2 || digit == 3 || digit == 0)
                {
                    primeNumbersSum += digit;
                    input = Console.ReadLine();
                    continue;
                }

                else if (digit == 1 || digit % 3 == 0 || digit % 2 == 0)
                {
                    nonprimeNumbersSum += digit;
                    input = Console.ReadLine();
                    continue;
                }
                
                else
                {
                    primeNumbersSum += digit;
                    input = Console.ReadLine();
                    continue;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeNumbersSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprimeNumbersSum}");
        }
    }
}
