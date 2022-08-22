using System;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            string forecast = Console.ReadLine();

            if (forecast == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }

            else
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
