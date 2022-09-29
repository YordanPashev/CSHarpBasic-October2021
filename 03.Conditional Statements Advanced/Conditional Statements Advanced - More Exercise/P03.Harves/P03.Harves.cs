using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int numberofworkers = int.Parse(Console.ReadLine());

            double winearea = x * y;
            double wineweight = winearea * 0.4;
            double wineliters = wineweight / 2.5;

            if (z > wineliters)
            {
                double litersneeded = z - wineliters;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersneeded)} liters wine needed.");
            }

            else
            {
                double wineleft = wineliters - z;
                double literperworker = wineleft / numberofworkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineliters)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineleft)} liters left -> {Math.Ceiling(literperworker)} liters per person.");            
            }      
        }
    }
}