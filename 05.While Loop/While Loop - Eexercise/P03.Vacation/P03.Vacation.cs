using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            double cash = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int dayCounter = 0;

            while (spendCounter < 5 && cash < excursionPrice)
            {
                string operation = Console.ReadLine();
                double sum = double.Parse(Console.ReadLine());
                dayCounter++;
                
                if (operation == "save")
                {
                    spendCounter = 0;
                    cash += sum;
                }

                else if (operation == "spend")
                {
                    spendCounter++;
                    cash -= sum;
                    if (cash < 0)
                    {
                        cash = 0;
                    }
                }
            }


            if (cash >= excursionPrice)
            {
                Console.WriteLine($"You saved the money for {dayCounter} days.");
            }

            if (cash < excursionPrice)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{dayCounter}");

            }

        }
    }
}
