using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double commission = 0.0;

            if ((city == "Sofia" || city == "Varna" || city == "Plovdiv") && sells >= 0)
            {
                if (sells >= 0 && sells <= 500)
                {
                    switch (city)
                    {
                        case "Sofia":
                            commission = 5;
                            break;
                        case "Varna":
                            commission = 4.5;
                            break;
                        case "Plovdiv":
                            commission = 5.5;
                            break;
                        default:
                            break;
                    }
                }

                else if (sells > 500 && sells <= 1000)
                {
                    switch (city)
                    {
                        case "Sofia":
                            commission = 7;
                            break;
                        case "Varna":
                            commission = 7.5;
                            break;
                        case "Plovdiv":
                            commission = 8.0;
                            break;
                    }
                }

                else if (sells > 1000 && sells <= 10000)
                {
                    switch (city)
                    {
                        case "Sofia":
                            commission = 8;
                            break;
                        case "Varna":
                            commission = 10;
                            break;
                        case "Plovdiv":
                            commission = 12;
                            break;
                    }
                }

                else if (sells > 10000)
                {
                    switch (city)
                    {
                        case "Sofia":
                            commission = 12;
                            break;
                        case "Varna":
                            commission = 13;
                            break;
                        case "Plovdiv":
                            commission = 14.5;
                            break;
                    }
                }

                double finalcommisssion = (sells * commission) / 100;
                Console.WriteLine($"{finalcommisssion:F2}");
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
