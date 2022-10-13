using System;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double oddNumbersSum = 0, oddNumberMin = int.MaxValue, oddNumberMax = int.MinValue;
            double evenNumbersSum = 0, evenNumberMin = int.MaxValue, evenNumberMax = int.MinValue;
            bool noEvenNumbers = true, noOddNumbers = true;
            
            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    noEvenNumbers = false;
                    evenNumbersSum += input;
                    if (input < evenNumberMin)
                    {
                        evenNumberMin = input;
                    }

                    if (input > evenNumberMax)
                    {
                        evenNumberMax = input;
                    }
                }

                else
                {
                    noOddNumbers = false;
                    oddNumbersSum += input;
                    if (input < oddNumberMin)
                    {
                        oddNumberMin = input;
                    }
                    
                    if (input > oddNumberMax)
                    {
                        oddNumberMax = input;
                    }
                }
            }

            if (noEvenNumbers == true && noOddNumbers == true)
            {
                Console.WriteLine($"OddSum={oddNumbersSum:F2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenNumbersSum:F2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }

            else if (noEvenNumbers == true)
            {
                Console.WriteLine($"OddSum={oddNumbersSum:F2},");
                Console.WriteLine($"OddMin={oddNumberMin:F2},");
                Console.WriteLine($"OddMax={oddNumberMax:F2},");
                Console.WriteLine($"EvenSum={evenNumbersSum:F2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }

            else if (noEvenNumbers == true)
            {
                Console.WriteLine($"OddSum={oddNumbersSum:F2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenNumbersSum:F2},");
                Console.WriteLine($"EvenMin={evenNumberMin:F2},");
                Console.WriteLine($"EvenMax={evenNumberMax:F2}");
            }

            else
            {
                Console.WriteLine($"OddSum={oddNumbersSum:F2},");
                Console.WriteLine($"OddMin={oddNumberMin:F2},");
                Console.WriteLine($"OddMax={oddNumberMax:F2},");
                Console.WriteLine($"EvenSum={evenNumbersSum:F2},");
                Console.WriteLine($"EvenMin={evenNumberMin:F2},");
                Console.WriteLine($"EvenMax={evenNumberMax:F2}");
            }
        }
    }
}
