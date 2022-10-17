using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double inputrate = 0;
            double sumrate = 0;
            double minrate = 4.00;
            double exp = 0;
            int grade = 1;

            for (int i = 1; i <= 12; i++)
            {
                inputrate = double.Parse(Console.ReadLine());
               
                if (minrate > inputrate)
                {
                    exp += 1;

                    if (exp == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        break;
                    }

                    continue;
                }

                sumrate += inputrate;

                grade++;
            }

            if (exp < 2)
            {
                double averagerate = sumrate / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averagerate:F2}");
            }
        }
    }
}
