using System;

namespace SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int groupNumber = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            string sport = "";
            double cost = 0;

            switch (season)
            {
                case "Winter":
                    switch (groupType)
                    {
                        case "girls":
                            sport = "Gymnastics";
                            cost = 9.6 * days * groupNumber;
                            break;

                        case "boys":
                            sport = "Judo";
                            cost = 9.6 * days * groupNumber;
                            break;

                        case "mixed":
                            sport = "Ski";
                            cost = 10 * days * groupNumber;
                            break;
                    }
                    break;

                case "Spring":
                    switch (groupType)
                    {
                        case "girls":
                            sport = "Athletics";
                            cost = 7.2 * days * groupNumber;
                            break;

                        case "boys":
                            sport = "Tennis";
                            cost = 7.2 * days * groupNumber;
                            break;

                        case "mixed":
                            sport = "Cycling";
                            cost = 9.5 * days * groupNumber;
                            break;
                    }
                    break;

                case "Summer":
                    switch (groupType)
                    {
                        case "girls":
                            sport = "Volleyball";
                            cost = 15 * days * groupNumber;
                            break;

                        case "boys":
                            sport = "Football";
                            cost = 15 * days * groupNumber;
                            break;

                        case "mixed":
                            sport = "Swimming";
                            cost = 20 * days * groupNumber;
                            break;
                    }
                    break;
            }

            if (groupNumber >= 50)
            {
                cost *= 0.5;
            }

            else if (groupNumber >= 20 && groupNumber < 50)
            {
                cost *= 0.85;
            }

            else if (groupNumber >= 10 && groupNumber < 20)
            {
                cost *= 0.95;
            }

            Console.WriteLine($"{sport} {cost:F2} lv.");
        }
    }
}
