using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            int result = 0;
            int finalsteps = 0;
            int steps = 0;

            while (result < 10000)
            {
                input = (Console.ReadLine());
                if (input == "Going home")
                {
                    finalsteps = int.Parse(Console.ReadLine());
                    result += finalsteps;
                    break;
                }

                else
                {
                    steps = Convert.ToInt32(input);
                    result += steps;
                }
            }

            if (result >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{result - 10000} steps over the goal!");
            }

            else
            {
                Console.WriteLine($"{10000 - result} more steps to reach goal.");
            }

        }
    }
}
