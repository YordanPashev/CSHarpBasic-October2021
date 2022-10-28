using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0, firstNum = 0, secondNum = 0;
            bool isMagicNumberEven = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;

                    if (i + j == magicNumber)
                    {
                        isMagicNumberEven = true;
                        firstNum = i;
                        secondNum = j;
                        break;
                    }            
                }

                if (isMagicNumberEven == true)
                {
                    break;
                }
            }

            if (isMagicNumberEven == true)
            {
                Console.WriteLine($"Combination N:{counter} ({firstNum} + {secondNum} = {magicNumber})");
            }
            
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}


