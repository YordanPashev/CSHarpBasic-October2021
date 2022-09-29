using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if ((hour >= 10 && hour < 18) && (day == "Monday" || day == "Tuesday" || day == "Wednesday" || 
                 day == "Thursday" || day == "Friday" || day == "Saturday"))
            {
                Console.WriteLine("open");
            }

            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
