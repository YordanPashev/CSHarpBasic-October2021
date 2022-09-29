using System;

namespace Time15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalm, totalm2, totalh;

            if (minutes < 45)
            {
                totalm = minutes + 15;
                if (totalm < 10)
                {
                    Console.WriteLine($"{hours}:0{totalm}");
                }

                else
                {
                    Console.WriteLine($"{hours}:{totalm}");
                }
            }

                else
                {
                    totalm2 = (minutes + 15) - 60;
                    totalh = hours + 1;


                    if (totalh == 24 && totalm2 < 10)
                {
                    Console.WriteLine($"0:0{totalm2}");
                    }

                    else if (totalh == 24)
                    {
                    Console.WriteLine($"0:{totalm2}");
                    }

                    else if (totalm2 < 10)
                    {
                    Console.WriteLine($"{totalh}:0{totalm2}");
                    }

                    else
                    {
                        Console.WriteLine($"{totalh}:{totalm2}");
                    }
                }
            }
        }
    }