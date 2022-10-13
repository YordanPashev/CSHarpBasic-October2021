using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorname = Console.ReadLine();
            double staringpoint = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double totalpointsofjudge = staringpoint;

            for (int i = 0; i < n; i++)
            {
                string judgename = Console.ReadLine();
                double judgepoints = double.Parse(Console.ReadLine());
                totalpointsofjudge += ((double)judgename.Length * judgepoints) / 2;

                if (totalpointsofjudge > 1250.5)
                {
                    i = 21;
                    Console.WriteLine($"Congratulations, {actorname} got a nominee for leading role with {totalpointsofjudge:F1}!");
                }
            }

            double result = totalpointsofjudge;

            if (result <= 1250.5)
            {
                double neededPoints = 1250.5 - result;
                Console.WriteLine($"Sorry, {actorname} you need {neededPoints:F1} more!");
            }
        }
    }
}