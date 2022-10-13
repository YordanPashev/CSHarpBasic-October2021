using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double invalidNumbersCounter = 0, from0to9Counter = 0, from10to19Counter = 0, from20to29Counter = 0, from30to39Counter = 0, from40to50Counter = 0;
            double points = 0;

            for (int i = 1; i <= moves; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    invalidNumbersCounter++;
                    points /= 2;
                }

                else if (number >= 0 && number <= 9)
                {
                    from0to9Counter++;
                    points += (number * 0.2);
                }

                else if (number >= 10 && number <= 19)
                {
                    from10to19Counter++;
                    points += (number * 0.3);
                }

                else if (number >= 20 && number <= 29)
                {
                    from20to29Counter++;
                    points += (number * 0.4);
                }

                else if (number >= 30 && number <= 39)
                {
                    from30to39Counter++;
                    points += 50;
                }

                else if (number >= 40 && number <= 50)
                {
                    from40to50Counter++;
                    points += 100;
                }
            }

            Console.WriteLine($"{points:F2}");
            Console.WriteLine($"From 0 to 9: {((from0to9Counter / moves) * 100):F2}%");
            Console.WriteLine($"From 10 to 19: {((from10to19Counter / moves) * 100):F2}%");
            Console.WriteLine($"From 20 to 29: {((from20to29Counter / moves) * 100):F2}%");
            Console.WriteLine($"From 30 to 39: {((from30to39Counter / moves) * 100):F2}%");
            Console.WriteLine($"From 40 to 50: {((from40to50Counter / moves) * 100):F2}%");
            Console.WriteLine($"Invalid numbers: {((invalidNumbersCounter / moves) * 100):F2}%");
        }
    }
}
