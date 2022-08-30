using System;

namespace GodzillavsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double moviebudget = double.Parse(Console.ReadLine());
            int numbofst = int.Parse(Console.ReadLine());
            double dressingprice = double.Parse(Console.ReadLine());
            double totaldisc, totalsum;

            double filmsetcosts = moviebudget * 0.1;
            double stcost = numbofst * dressingprice;

            if (numbofst > 150)
            {
                double disc = stcost * 0.1;
                totaldisc = stcost - disc;
                totalsum = (filmsetcosts + totaldisc);
            }
            
            else 
            {
                totalsum = filmsetcosts + stcost;
            }

            if (totalsum >  moviebudget)
            {
                double neededmoney = totalsum - moviebudget;
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {neededmoney:F2} leva more.");
            }

            else if (totalsum <= moviebudget)
            {
                double extramoney = moviebudget - totalsum;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {extramoney:F2} leva left.");
            } 
        }
    }
}