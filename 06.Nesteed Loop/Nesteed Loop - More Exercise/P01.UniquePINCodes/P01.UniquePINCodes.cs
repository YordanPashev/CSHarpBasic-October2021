using System;

namespace UniquePINCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1ceiling = int.Parse(Console.ReadLine());
            int n2ceiling = int.Parse(Console.ReadLine());
            int n3ceiling = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1ceiling; i++)
            {

                if (i % 2 == 0)
                {
                    for (int j = 2; j <= n2ceiling; j++)
                    {
                        if (j == 2 || j == 3 || j == 5 || j == 7)
                        {
                            for (int k = 1; k <= n3ceiling; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
