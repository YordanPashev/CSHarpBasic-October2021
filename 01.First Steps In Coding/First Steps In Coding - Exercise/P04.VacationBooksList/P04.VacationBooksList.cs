using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a / b;
            int totalsum = sum / c;
            
            Console.WriteLine(totalsum);
        }
    }
}
