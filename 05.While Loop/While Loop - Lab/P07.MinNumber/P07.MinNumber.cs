using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;
            
            while (input != "Stop")
            {
               int convert = int.Parse(input);

                if (min > convert)
                {
                    min = convert;
                }
                input = Console.ReadLine();
            }
            
            Console.WriteLine(min);
        }
    }
}
