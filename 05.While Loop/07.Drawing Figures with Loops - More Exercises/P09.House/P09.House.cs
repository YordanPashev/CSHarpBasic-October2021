using System;

namespace House 
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                for (int col = 1; col <= n - row - (n / 2); col++)
                {
                    Console.Write("-");
                }

                if (n % 2 == 0)
                {
                    Console.Write("**");
                }

                else
                {
                    Console.Write("*");
                }

                for (int col = 1; col < row; col++)
                {
                    Console.Write("**");
                }

                for (int col = 1; col <= n - row - (n / 2); col++)
                { 
                    if (col > n / 2)
                    {
                        continue;
                    }
                    Console.Write("-");
                }

                Console.WriteLine();
            }

            for (int row = 1; row <= n / 2; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (col == 1 || col == n)
                    {
                        Console.Write("|");
                    }

                    else
                    {
                        Console.Write("*");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}
