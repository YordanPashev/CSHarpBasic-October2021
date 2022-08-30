using System;

namespace 
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (number <= 100)
            {
                double bonus1 = 5;

                if (number % 2 == 0)
                {
                    double totalBonus = bonus1 + 1;
                    double sum = totalBonus + number;
                    Console.WriteLine(totalBonus);
                    Console.WriteLine(sum);
                }

                else if (number % 10 == 5)
                {
                    double totalBonus = bonus1 + 2;
                    double sum = totalBonus + number;
                    Console.WriteLine(totalBonus);
                    Console.WriteLine(sum);
                }

                else
                {
                    double sum = bonus1 + number;
                    Console.WriteLine(bonus1);
                    Console.WriteLine(sum);
                }
            }

            else if (number > 100 && number < 1000)
            {
                double bonus1 = number * 0.2;

                if (number % 2 == 0)
                {
                    double totalBonus = bonus1 + 1;
                    double sum = totalBonus + number;
                    Console.WriteLine(totalBonus);
                    Console.WriteLine(sum);
                }

                else if (number % 10 == 5)
                {
                    double totalBonus = bonus1 + 2;
                    double sum = totalBonus + number;
                    Console.WriteLine(totalBonus);
                    Console.WriteLine(sum);
                }


                else
                {
                    double sum = bonus1 + number;
                    Console.WriteLine(bonus1);
                    Console.WriteLine(sum);
                }
            }

            else
            {
                double bonus1 = number * 0.1;
             

                if (number % 2 == 0)
                {
                    double totalBonus = bonus1 + 1;
                    double sum = totalBonus + number;
                    Console.WriteLine(totalBonus);
                    Console.WriteLine(sum);
                }

                else if (number % 10 == 5)
                {
                    double totalBonus = bonus1 + 2;
                    double sum = totalBonus + number;
                    Console.WriteLine(totalBonus);
                    Console.WriteLine(sum);
                }

                else
                {
                    double sum = bonus1 + number;
                    Console.WriteLine(bonus1);
                    Console.WriteLine(sum);
                }
            }
        }
    }
}