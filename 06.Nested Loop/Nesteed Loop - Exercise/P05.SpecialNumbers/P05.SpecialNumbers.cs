using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int num = i;
                for (int j = 0; j < 4; j++)
               
                {
                    int num1 = num % 10;
                
                    if (num1 != 0 && n % num1 == 0)
                    {
                        num /= 10;
                    }
                    
                    else
                    {
                        break;
                    }
                }

                if (num == 0)
                {
                    Console.Write(i + " ");
                }            
            }
        }
    }
}
