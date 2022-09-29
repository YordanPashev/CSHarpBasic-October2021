using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            dogFoodPerDay *= days;
            catFoodPerDay *= days;
            turtleFoodPerDay = (turtleFoodPerDay * days) /1000;

            double neededFood = turtleFoodPerDay + catFoodPerDay + dogFoodPerDay;

            if (food >= neededFood)
            {
                double restFood = food - neededFood;
                Console.WriteLine($"{Math.Floor(restFood)} kilos of food left.");
            }

            else if (food < neededFood)
            {
                double nf = neededFood - food;
                Console.WriteLine($"{Math.Ceiling(nf)} more kilos of food are needed.");
            }
        }
    }
}
