using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int cake = width * lenght;
            string input = string.Empty;
            int result = 0;

            while (input != "STOP")
            {
                input = Console.ReadLine();

                if (input == "STOP")
                {
                    Console.WriteLine($"{cake} pieces are left.");
                    break;
                }

                int pieces = Convert.ToInt32(input);
                result = cake - (1 * pieces);
                cake = result;

                if (result < 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(result)} pieces more.");
                    break;
                }
            }        
        }
    }
}
