using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isSaving = true;

            while (isSaving == true)
            {
                string destination = Console.ReadLine();

                if (destination == "End")
                {
                    isSaving = false;
                    break;
                }
                
                double minimalBudget = double.Parse(Console.ReadLine());
                double result = 0;

                while (minimalBudget > result)
                {
                    double sum = double.Parse(Console.ReadLine());
                    minimalBudget -= sum;
                }
                
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
