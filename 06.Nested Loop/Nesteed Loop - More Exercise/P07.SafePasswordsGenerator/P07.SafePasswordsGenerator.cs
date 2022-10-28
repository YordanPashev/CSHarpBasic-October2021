using System;

namespace afePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxNumPass = int.Parse(Console.ReadLine());
            char firstSymb = Convert.ToChar(35);
            char secondSymb = Convert.ToChar(64);
            int counter = 1;

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    Console.Write($"{firstSymb}{secondSymb}{i}{j}{secondSymb}{firstSymb}|");
                    firstSymb++;
                    secondSymb++;
                    counter++;

                    if (firstSymb > 55)
                    {
                        firstSymb = Convert.ToChar(35);
                    }

                    if (secondSymb > 96)
                    {
                        secondSymb = Convert.ToChar(64);
                    }
                    
                    if (counter > maxNumPass)
                    {
                        return;
                    }
                }
            }
        }
    }
}
