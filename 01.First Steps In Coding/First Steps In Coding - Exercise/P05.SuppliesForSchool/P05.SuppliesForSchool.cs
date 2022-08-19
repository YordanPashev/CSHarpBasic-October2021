using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine()) * 5.8;
            double hl = double.Parse(Console.ReadLine()) * 7.2;
            double liters = double.Parse(Console.ReadLine()) * 1.2;
            double discount = double.Parse(Console.ReadLine()) / 100;
            double totalsum = (pens + hl + liters);
            double totalsumd = totalsum - (totalsum * discount);
            Console.WriteLine(totalsumd);
        }
    }
}