using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chichek");
            double ac = double.Parse(Console.ReadLine());
            double c = ac * 10.35;
            Console.WriteLine("Fish");
            double af = double.Parse(Console.ReadLine());
            double f = af * 12.40;
            Console.WriteLine("Vegetarian");
            double av = double.Parse(Console.ReadLine());
            double v = av * 8.15;
            double allf = (c + f + v);
            double d = (allf * 20) / 100;
            double del = 2.5;
            Console.WriteLine($"Your delivery will cost: {allf + d + del} lv.");
        }
    }
}
