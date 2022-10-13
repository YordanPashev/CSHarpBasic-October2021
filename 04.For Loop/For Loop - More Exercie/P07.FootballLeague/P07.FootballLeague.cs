using System;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            int seatingCapacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            double sectorA = 0, sectorB = 0, sectorV = 0, sectorG = 0;

            for (int i = 1; i <= fans; i++)
            {
                char sector = char.Parse(Console.ReadLine());

                switch (sector)
                {
                    case 'A':
                        sectorA++;
                        break;
                    case 'B':
                        sectorB++;
                        break;
                    case 'V':
                        sectorV++;
                        break;
                    case 'G':
                        sectorG++;
                        break;
                }
            }

            Console.WriteLine($"{((sectorA / fans) * 100):F2}%");
            Console.WriteLine($"{((sectorB / fans) * 100):F2}%");
            Console.WriteLine($"{((sectorV / fans) * 100):F2}%");
            Console.WriteLine($"{((sectorG / fans) * 100):F2}%");
            Console.WriteLine($"{(double)fans / seatingCapacity * 100:F2}%");
        }
    }
}
