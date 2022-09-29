using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int total = first + second + third;

            int min = total / 60;
            int sec = total % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }

            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
