using System;

namespace LunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            int tvShowDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double lunch = breakDuration / 8.0;
            double rest = breakDuration / 4.0;
            double timeForTvShow = breakDuration - (lunch + rest);
     
            if (timeForTvShow >= tvShowDuration)
            {
                double timeLeft = timeForTvShow - tvShowDuration;
               Console.WriteLine($"You have enough time to watch {title} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }

            else
            {
                double neededTime = tvShowDuration - timeForTvShow;
                Console.WriteLine($"You don't have enough time to watch {title}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
