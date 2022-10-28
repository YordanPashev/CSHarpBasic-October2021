using System;

namespace ChallengeTheWedding
{
    class Program
    {
        private static double present;

        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tablesNum = int.Parse(Console.ReadLine());
            int tableCounter = 0;

            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    tableCounter++;
                    
                    if (tableCounter == tablesNum)
                    {
                        i = 101;
                        break;
                    }
                }
            }

        }
    }
}
