using System;

namespace UsdToBgn
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = 1.79549;
            double LV = double.Parse(Console.ReadLine());
            double final = LV * USD;
            Console.WriteLine(final);
        }
    }
}
