using System;

namespace NumbersNToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 1)
            {
                for (int i = n; i >= 1 ; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
