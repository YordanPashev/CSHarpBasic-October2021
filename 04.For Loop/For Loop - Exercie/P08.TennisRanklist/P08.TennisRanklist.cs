using System;

namespace TennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamets = int.Parse(Console.ReadLine());
            int staringpoints = int.Parse(Console.ReadLine());
            int points = 0; double wintour = 0;

            for (int i = 0; i < tournamets; i++)
            {
                string qualification = Console.ReadLine();

                switch (qualification)
                {
                    case "W":
                        points += 2000;
                        wintour++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                }
            }

            int totalpoints = points + staringpoints;
            double averragepoints = (double)points / tournamets;
            double winrate = (wintour / tournamets) * 100;

            Console.WriteLine($"Final points: {totalpoints}");
            Console.WriteLine($"Average points: {Math.Floor(averragepoints)}");
            Console.WriteLine($"{winrate:F2}%");
        }
    }
}
