using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double ticketPrice = 0.0;

            switch (type)
            {
                case "Premiere":
                    ticketPrice = 12.00;
                    break;
                case "Normal":
                    ticketPrice = 7.50;
                    break;
                case "Discount":
                    ticketPrice = 5.00;
                    break;
            }

            double income = (r * c) * ticketPrice;
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
