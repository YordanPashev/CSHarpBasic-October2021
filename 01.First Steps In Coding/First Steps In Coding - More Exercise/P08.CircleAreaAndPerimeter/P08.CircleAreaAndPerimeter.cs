using System;

namespace CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double circlearea = (r * r) * Math.PI;
            double circleperimeter = (r * 2) * Math.PI;
            Console.WriteLine($"{circlearea:F2}");
            Console.WriteLine($"{circleperimeter:F2}");
        }
    }
}