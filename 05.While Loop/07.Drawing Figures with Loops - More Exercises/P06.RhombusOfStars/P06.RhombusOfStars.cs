using System;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write("*");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n - row; col++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine(" ");

                for (int col = 1; col < row; col++)
                {
                    Console.Write(" ");
                }

                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}
