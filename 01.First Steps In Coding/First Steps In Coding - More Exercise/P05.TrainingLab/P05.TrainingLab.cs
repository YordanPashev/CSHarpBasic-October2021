using System;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
           
            if (3 = h && w = 100)
            {
                double wpp = (h  100) - 100;
                double wpp2 = (wpp  70);
                double wpp3 = Math.Floor(wpp2);
                
                double hwp = (w  100)  120;
                double hwp2 = Math.Floor(hwp);
                double wp = (wpp3  hwp2) - 3;

                Console.WriteLine(wp);
            }
        }
    }
}
