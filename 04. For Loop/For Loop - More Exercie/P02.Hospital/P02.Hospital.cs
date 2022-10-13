using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int totalTreatedPacients = 0, totalUntreatedPacients = 0, doctors = 7, treatedPacients = 0, untreatedPacients = 0;
            int untreatedPacientsForTwodays = 0, treatedPacientsFortwoDays = 0;

            for (int i = 1; i <= days; i++)
            {
                if (untreatedPacientsForTwodays > treatedPacientsFortwoDays && i % 3 == 0)
                {
                    doctors++;
                }

                int pacients = int.Parse(Console.ReadLine());

                if (pacients >= doctors)
                {
                    treatedPacients = doctors;
                    untreatedPacients = pacients - doctors;
                    untreatedPacientsForTwodays += untreatedPacients;
                    treatedPacientsFortwoDays += treatedPacients;
                    totalTreatedPacients += treatedPacients;
                    totalUntreatedPacients += untreatedPacients;
                }

                else
                { 
                    totalTreatedPacients += pacients;
                }
            }

            Console.WriteLine($"Treated patients: {totalTreatedPacients}.");
            Console.WriteLine($"Untreated patients: {totalUntreatedPacients}.");
        }
    }
}
