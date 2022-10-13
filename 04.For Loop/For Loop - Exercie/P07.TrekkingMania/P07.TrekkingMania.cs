using System;

namespace TrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleMus = 0, peopleMon = 0, peopleKil = 0, peopleK2 = 0, peopleEv = 0;
            int groupnum = int.Parse(Console.ReadLine());
            int totalpeoplenum = 0;
            for (int i = 0; i < groupnum; i++)
            {
                int peoplenum = int.Parse(Console.ReadLine());
                totalpeoplenum += peoplenum;
                if (peoplenum <= 5)
                {
                    peopleMus += peoplenum;
                }
                else if (peoplenum <= 12)
                {
                    peopleMon += peoplenum;
                }
                else if (peoplenum <= 25)
                {
                    peopleKil += peoplenum;
                }
                else if (peoplenum <= 40)
                {
                    peopleK2 += peoplenum;
                }
                else
                {
                    peopleEv += peoplenum;
                }
            }

            double MusPer = 0, MonPer = 0, KilPer = 0, K2Per = 0, EvPer = 0;

            MusPer = (double)peopleMus / totalpeoplenum * 100;
            MonPer = (double)peopleMon / totalpeoplenum * 100;
            KilPer = (double)peopleKil / totalpeoplenum * 100;
            K2Per = (double)peopleK2 / totalpeoplenum * 100;
            EvPer = (double)peopleEv /totalpeoplenum * 100;

            Console.WriteLine($"{MusPer:F2}%");
            Console.WriteLine($"{MonPer:F2}%");
            Console.WriteLine($"{KilPer:F2}%");
            Console.WriteLine($"{K2Per:F2}%");
            Console.WriteLine($"{EvPer:F2}%");
        }
    }
}
