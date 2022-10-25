using System;

namespace SecretDoorsLock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n1; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }

                for (int j = 1; j <= n2; j++)
                {                   
                        for (int k = 1; k <= n3; k++)
                        {
                            if (k % 2 == 0)
                            {
                                if ((j != 2 && j != 3) && (j == 1 || j % 2 == 0 || j % 3 == 0))
                                {
                                    continue;
                                }

                                Console.WriteLine($"{i} {j} {k}");
                            }
                        }
                    }
                }
            }
        }
    }


