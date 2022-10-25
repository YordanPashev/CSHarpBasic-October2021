using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            string letter = " abcdefggijklmnopqrstufvxyz";
            char endLetter = letter[l];

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (char k = 'a'; k <= endLetter; k++)
                    {
                        for (char m = 'a'; m <= endLetter; m++)
                        {
                            for (int a = 2; a <= n; a++)
                            {
                                if (a > i && a > j)
                                {
                                    Console.Write($"{i}{j}{k}{m}{a} ");
                                } 
                            }
                        }
                    }
                }
            }
        }
    }
}