using System;

namespace OperationsBetween
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0.0;
            string evenorodd;

            if (operation == "+" || operation == "-" || operation == "*")
            {
                switch (operation)
                {
                    case "+":
                        result = N1 + N2;
                        break;

                    case "-":
                        result = N1 - N2;
                        break;
                    case "*":
                        result = N1 * N2;
                        break;
                }
                if (result % 2 == 0)
                {
                    evenorodd = "even";
                }
                else
                {
                    evenorodd = "odd";
                }
                Console.WriteLine($"{N1} {operation} {N2} = {result} - {evenorodd}");
            }

            if ((operation == "/" || operation == "%") && N2 == 0)
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }

            else if (operation == "/")
            {

                result = (double)N1 / N2;
                Console.WriteLine($"{N1} {operation} {N2} = {result:F2}");
            }

            else if (operation == "%")
            {
                result = N1 % N2;
                Console.WriteLine($"{N1} {operation} {N2} = {result}");
            }
        }
    }
}
