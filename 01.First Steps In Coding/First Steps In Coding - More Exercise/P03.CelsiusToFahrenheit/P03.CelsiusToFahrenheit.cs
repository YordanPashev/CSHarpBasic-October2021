using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double cel = double.Parse(Console.ReadLine());
            double fahr = cel * 1.8 + 32;
            Console.WriteLine($"{fahr:F2}");
        }
    }
}
