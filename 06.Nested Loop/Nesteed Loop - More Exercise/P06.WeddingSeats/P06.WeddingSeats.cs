using System;

namespace WeddingSeats
{
    class Program
    {
        static void Main(string[] args)
        {
            char endSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int seatingsOddrow = int.Parse(Console.ReadLine());
            string letter = " abcdefggijklmnopqrstufvxyz";
            char end = letter[seatingsOddrow];
            int counter = 0;


            for (char i = 'A'; i <= endSector; i++)
            {
                for (int j = 1; j <= rowsFirstSector; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (char k = 'a'; k <= end + 2; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }

                    else
                    {
                        for (char k = 'a'; k <= end; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }
                }
                
                rowsFirstSector++;
            }

            Console.WriteLine(counter);
        }
    }
}
