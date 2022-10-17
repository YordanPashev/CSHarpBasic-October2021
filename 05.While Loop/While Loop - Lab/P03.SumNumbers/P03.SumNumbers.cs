using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            
            while (sum > num)
            {
                num += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(num);
        }
    }
}
