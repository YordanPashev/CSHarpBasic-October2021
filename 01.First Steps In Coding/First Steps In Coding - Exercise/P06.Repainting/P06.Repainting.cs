using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of the nylon.");
            double nylon = double.Parse(Console.ReadLine()) + 2;
            double nylon2 = nylon * 1.5;
            Console.WriteLine("Please enter the amount of paint /in liters/");
            double paint = double.Parse(Console.ReadLine()) * 14.5;
            double addpaint = (paint * 10) / 100;
            double allpaint = paint + addpaint;
            Console.WriteLine("Please enter the amount of paint thinner.");
            double pt = double.Parse(Console.ReadLine()) * 5;
            Console.WriteLine("How many hours the painters will work? ");
            double hours = double.Parse(Console.ReadLine());
            double torbi = 0.4;
            double gp = (nylon2 + allpaint + pt + torbi);
            double gpe = gp * 30;
            double gp2 = gpe / 100;
            double guys = hours * gp2;
            Console.WriteLine($"The final price will be: {gp + guys}.");
        }
    }
}
