using System;

namespace ConsoleApp112
{
    class EqualSumsEvenOddPosition 
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
           

            for (int i = firstNum; i <= secondNum; i++)
            {
                int currentNum = i;
                int oddNumSum = 0;
                int evenNumSum = 0;
                int counter = 0;
                while (currentNum > 0)
                {
                    int digit = currentNum % 10;
                    if (counter % 2 == 0)
                    {
                        evenNumSum += digit;
                    }

                    else
                    {
                        oddNumSum += digit;
                    }
                    currentNum /= 10;
                    counter++;
                }

                if (oddNumSum == evenNumSum)
                {
                    Console.Write(i + " ");
                }             
            }
        }
    }
}
