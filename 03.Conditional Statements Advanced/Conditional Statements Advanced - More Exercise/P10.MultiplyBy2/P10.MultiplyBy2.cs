using System;

namespace MultiplyBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = 0;
            bool isPositive = true;

            while (isPositive == true)
            {
                input = double.Parse(Console.ReadLine());
                if (input < 0 )
                {
                    isPositive = false;
                    Console.WriteLine("Negative number!");
                    break;
                }
                double result = input * 2;
                Console.WriteLine($"Result: {result:F2}");
                result = 0;
            }
        }
    }
}
