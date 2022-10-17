using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalsum = 0;

            while (input != "NoMoreMoney")
            {
                double convinput = double.Parse(input);

                if (convinput < 0)
                {
                    Console.WriteLine($"Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {convinput:F2}");
                totalsum += convinput;
                input = Console.ReadLine();               
            }

            Console.WriteLine($"Total: {totalsum:F2}");
        }
    }
}
