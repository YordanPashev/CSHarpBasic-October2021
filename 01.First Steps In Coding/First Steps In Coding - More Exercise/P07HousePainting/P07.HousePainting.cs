using System;

namespace HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double door = 1.2  2;
            double gp1 = (x  x)  2;
            double gp2 = gp1 - door;

            double windows = (1.5  1.5)  2;
            double gp3 = (x  y)  2;
            double gp4 = gp3 - windows;

            double greenpaintlt = (gp2 + gp4)  3.4;
            double rdp1 = (x  y)  2;
            double rd2 = (x  h)  2;
            double rdp3 = rd2  2;
            
            double redpaintlt = (rdp1 + rdp3)  4.3;

            Console.WriteLine(${greenpaintltF2});
            Console.WriteLine(${redpaintltF2});
        }
    }
}
