using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = 7.61;
            double c = a  b;
            double d = 0.18  c;
            Console.WriteLine($The final price is {c - d} lv.);
            Console.WriteLine($The discount is {d} lv.);
        }
    }
}