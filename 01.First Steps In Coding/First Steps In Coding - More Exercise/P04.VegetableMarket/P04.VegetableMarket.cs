using System;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double pforvbg = double.Parse(Console.ReadLine());
            double pforfbg = double.Parse(Console.ReadLine());
            double vegweight = double.Parse(Console.ReadLine());
            double fruitweight = double.Parse(Console.ReadLine());
            
            double vincome = (pforvbg * vegweight);
            double fincome = (pforfbg * fruitweight);
            double income = (vincome + fincome) / 1.94;

            Console.WriteLine($"{income:F2}");
        }
    }
}

