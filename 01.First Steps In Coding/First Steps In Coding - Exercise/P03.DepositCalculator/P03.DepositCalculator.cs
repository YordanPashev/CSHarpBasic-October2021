using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int  b = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine()) / 100;
            double area = a + b * ((a* c) / 12);
            Console.WriteLine(area);
        }
    }
}
