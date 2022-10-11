using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int webnums = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double facebook = 150;
            double insta = 100;
            double reddit = 50;
            double penalty = 0;

            for (int i = 0; i < webnums; i++)
            {
                string web = Console.ReadLine();
                switch (web)
                {
                    case "Facebook":
                        penalty += facebook;
                        break;
                    case "Instagram":
                        penalty += insta;
                        break;
                    case "Reddit":
                        penalty += reddit;
                        break;
                }

                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            
            if (penalty < salary)
            {
                double moneyleft = salary - penalty;
                Console.WriteLine($"{moneyleft:F0}");

            }    
        }
    }
}
