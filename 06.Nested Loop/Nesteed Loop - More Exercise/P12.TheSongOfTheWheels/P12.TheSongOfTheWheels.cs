using System;

namespace TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int counter = 0;
            int firstNum = 0, secondNum = 0, third = 0, fourth = 0;

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if ((i * j) + (k * l) == m && i < j && k > l)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                counter++;

                                if (counter == 4)
                                {
                                    firstNum = i;
                                    secondNum = j;
                                    third = k;
                                    fourth = l;
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
            if (counter >= 4)
            {        
                Console.WriteLine($"Password: {firstNum}{secondNum}{third}{fourth}");
            }

            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}