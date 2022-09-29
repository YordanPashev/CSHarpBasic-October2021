using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.6;
            double spdoll = 3;
            double teddybear = 4.1;
            double minion = 8.2;
            double truck = 2;
            double totalsum2, totalsumminusrental, rental;

            double excursion = double.Parse(Console.ReadLine());
            double puzzlenum = double.Parse(Console.ReadLine());
            double spdollnum = double.Parse(Console.ReadLine());
            double teddybearnum = double.Parse(Console.ReadLine());
            double minionnum = double.Parse(Console.ReadLine());
            double trucknum = double.Parse(Console.ReadLine());

            double prtoynum = puzzlenum + spdollnum + teddybearnum + minionnum + trucknum;
            double totalsum = (puzzle * puzzlenum) + (spdoll * spdollnum) + (teddybear * teddybearnum) + (minion * minionnum) + (truck * trucknum);

            if (prtoynum >= 50)
            {
                double disc = totalsum * 0.25;
                double totalwdisc = totalsum - disc;
                rental = totalwdisc * 0.1;
                totalsumminusrental = totalwdisc - rental;
            }

            else
            {
                rental = totalsum * 0.1;
                totalsumminusrental = totalsum - rental;
            }

            if (totalsumminusrental >= excursion)
            {
                double moneyleft = totalsumminusrental - excursion;
                Console.WriteLine($"Yes! {moneyleft:F2} lv left.");
            }

            else
            {
                double moneyneeded = excursion - totalsumminusrental;
                Console.WriteLine($"Not enough money! {moneyneeded:F2} lv needed.");
            } 
        }
    }
}