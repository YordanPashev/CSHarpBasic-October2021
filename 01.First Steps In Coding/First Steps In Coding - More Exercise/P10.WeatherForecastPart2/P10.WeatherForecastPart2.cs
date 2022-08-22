using System;

namespace WeatherForecastPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dc = double.Parse(Console.ReadLine());

            if (dc >= 5 && dc <= 11.9)
            { 
                Console.WriteLine("Cold");
            }

            else if (dc >= 12 && dc <= 14.9)
            {
                Console.WriteLine("Cool");
            }

            else if (dc >= 15 && dc <= 20)
            {
                Console.WriteLine("Mild");
            }

            else if (dc >= 20.1 && dc <= 25.9)
            {
                Console.WriteLine("Warm");
            }

            else if (dc >= 26 && dc <= 35)
            {
                Console.WriteLine("Hot");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
