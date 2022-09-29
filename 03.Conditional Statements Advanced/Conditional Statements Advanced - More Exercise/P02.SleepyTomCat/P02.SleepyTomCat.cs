using System;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysoff = int.Parse(Console.ReadLine());
            int neededhoursforsleep = 30000;
            int workingdaystimetoplay = 63;
            int daysofftimetoplay = 127;

            int totalworkingdays = 365 - daysoff;

            int playinghoursforyear = (daysoff * daysofftimetoplay) + (totalworkingdays * workingdaystimetoplay);

            if (playinghoursforyear <= 30000)
            {
                double timeleftforplay = 30000 - playinghoursforyear;
                double hours = timeleftforplay / 60;
                double minutes = timeleftforplay % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes less for play");
            }

            else
            {
                double neededtime = playinghoursforyear - 30000;
                double hours = neededtime / 60;
                double minutes = neededtime % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor(hours)} hours and {minutes} minutes more for play");
            }
        }
    }
}