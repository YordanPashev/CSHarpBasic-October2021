using System;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle = double.Parse(Console.ReadLine());
            double c = angle * 180 / Math.PI;
            Console.WriteLine(c);
        }
    }
}
