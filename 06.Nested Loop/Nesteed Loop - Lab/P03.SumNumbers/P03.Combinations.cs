using System;

namespace Combinations 
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            int count = 0;

            for (int x1 = 0; x1 <= input; x1++)
            {
                for (int x2 = 0; x2 <= input; x2++)
                {
                    for (int x3 = 0; x3 <= input; x3++)
                    {
                        result= x1 + x2 + x3;

                        if (result == input)
                        {
                            count++;
                        }
                        
                    }
                }
            }
            
            Console.WriteLine(count);
        }
    }
}
