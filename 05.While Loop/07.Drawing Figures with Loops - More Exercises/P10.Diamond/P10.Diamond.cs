using System;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashNum = (n - 1) / 2;

            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', dashNum));
                Console.Write("*");
                int mid = n - 2 * dashNum - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.WriteLine(new string('-', dashNum));
                dashNum--;
            }

            for (int i = n / 2; i < n; i++)
            {
                Console.Write(new string('-', dashNum));
                Console.Write("*");
                int mid = n - 2 * dashNum - 2;

                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }

                Console.WriteLine(new string('-', dashNum));
                dashNum++;
            }
        }
    }
}

