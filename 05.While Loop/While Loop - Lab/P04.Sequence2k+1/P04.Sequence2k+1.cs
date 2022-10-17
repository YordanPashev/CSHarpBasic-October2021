using System;

namespace P04.Sequence2k+1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 1;
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                i = i * 2; 
            }
        }
    }
}
