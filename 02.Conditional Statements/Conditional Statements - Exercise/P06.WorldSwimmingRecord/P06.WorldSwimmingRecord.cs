using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distances = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double slowDown = Math.Floor(distances / 15);
            double totalSlownDown = (slowDown * 12.5);
            double time = (timeForOneMeter * distances) + totalSlownDown;

            if (time < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time:F2} seconds.");
            }

            else
            {
                double result = worldRecord - time;
                Console.WriteLine($"No, he failed! He was {Math.Abs(result):F2} seconds slower.");
            }
        }
    }
}
