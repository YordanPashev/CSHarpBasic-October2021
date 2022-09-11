using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            double V = int.Parse(Console.ReadLine());
            double P1 = int.Parse(Console.ReadLine());
            double P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double P1d = H * P1;
            double P2d = H * P2;
            double totallinpool = (P1 * H) + (P2 * H);
            
            if (V >= totallinpool)
            {
                double percleftp1 = Math.Round(P1d / V * 100, 2);
                double percleftp2 = Math.Round(P2d / V * 100, 2);
                double totalperc = percleftp1 + percleftp2;
                double resultp1 = Math.Round(P1d / totallinpool * 100, 2);
                double resultp2= Math.Round(P2d / totallinpool * 100, 2);
                Console.WriteLine($"The pool is {Math.Abs(totalperc):F2}% full. Pipe 1: {resultp1:F2}%. Pipe 2: {resultp2:F2}%.");
            }

            else
            {
                double overflowliters = totallinpool - V;
                Console.WriteLine($"For {H:F2} hours the pool overflows with {overflowliters:F2} liters.");
            }
        }  
    }
}
