using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while (input != "Stop")
            {
                int convert = int.Parse(input);

                if (max < convert)
                {
                    max = convert;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
