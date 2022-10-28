using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bridge = n / 2;
            bridge = n - bridge; 
            
            for (int row1 = 1; row1 <= n; row1++)
            {
                for (int col1 = 1; col1 <= n * 5; col1++)
                {
                    if (col1 >= (n * 2) + 1 && col1 <= (n * 2) + n)
                    {
                        if (row1 == bridge)
                        {
                            Console.Write("|");
                        }

                        else
                        {
                            Console.Write(" ");
                        }
                        
                    }

                    else if (row1 == 1 || row1 == n || col1 == 1 || col1 == n * 2 || col1 == (n * 2) + n + 1 || col1 == n * 5)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write("/");
                    }
                }

                Console.WriteLine();
            }             
        }
    }
}
