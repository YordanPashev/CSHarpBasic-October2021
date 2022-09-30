using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreesC = int.Parse(Console.ReadLine());
            string timeoftheday = Console.ReadLine();
            string clothes, shoes;

            if (timeoftheday == "Morning")
            {
                if (10 <= degreesC && degreesC <= 18)
                {
                    clothes = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }

                else if (18 <= degreesC && degreesC <= 24)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }

                else
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }
            }

            if (timeoftheday == "Afternoon")
            {
                if (10 <= degreesC && degreesC <= 18)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }

                else if (18 <= degreesC && degreesC <= 24)
                {
                    clothes = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }

                else
                {
                    clothes = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }
            }

            if (timeoftheday == "Evening")
            {
                if (10 <= degreesC && degreesC <= 18)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }

                else if (18 <= degreesC && degreesC <= 24)
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }

                else
                {
                    clothes = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degreesC} degrees, get your {clothes} and {shoes}.");
                }
            }
        }
    }
}
