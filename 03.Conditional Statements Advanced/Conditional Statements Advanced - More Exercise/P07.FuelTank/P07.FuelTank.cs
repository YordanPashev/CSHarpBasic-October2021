using System;

namespace FuelTank
{
    class Program
    {
        private static double present;

        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litters = double.Parse(Console.ReadLine());

            switch (fuel)
            {
                case "Diesel":
                    if (litters >= 25)
                    {
                        Console.WriteLine($"You have enough diesel.");
                    }
                    else if (litters < 25)
                    {
                        Console.WriteLine($"Fill your tank with diesel!");
                    }
                    break;
                case "Gasoline":
                    if (litters >= 25)
                    {
                        Console.WriteLine($"You have enough gasoline.");
                    }
                    else if (litters < 25)
                    {
                        Console.WriteLine($"Fill your tank with gasoline!");
                    }
                    break;
                case "Gas":
                    if (litters >= 25)
                    {
                        Console.WriteLine($"You have enough gas.");
                    }
                    else if (litters < 25)
                    {
                        Console.WriteLine($"Fill your tank with gas!");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid fuel!");
                    break;
            }
        }
    }
}