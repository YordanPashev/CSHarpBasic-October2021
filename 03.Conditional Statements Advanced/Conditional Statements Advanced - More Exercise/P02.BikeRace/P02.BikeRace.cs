using System;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorsNum = int.Parse(Console.ReadLine());
            int seniorNum = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double juniorFee = 0, seniorFee = 0;

            switch (track)
            {
                case "trail":
                    juniorFee = juniorsNum * 5.5;
                    seniorFee = seniorNum * 7;
                    break;

                case "cross-country":
                    juniorFee = juniorsNum * 8;
                    seniorFee = seniorNum * 9.5;
                    break;

                case "downhill":
                    juniorFee = juniorsNum * 12.25;
                    seniorFee = seniorNum * 13.75;
                    break;

                case "road":
                    juniorFee = juniorsNum * 20;
                    seniorFee = seniorNum * 21.50;
                    break;
            }

            if (track == "cross-country" && seniorNum + juniorsNum >= 50)
            {
                juniorFee *= 0.75;
                seniorFee *= 0.75;
            }

            double result = (juniorFee + seniorFee) * 0.95;
            Console.WriteLine($"{result:F2}");
        }
    }
}
