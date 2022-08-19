using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("On year membership:");
            int oneyearmembership = int.Parse(Console.ReadLine());
            double sn = (oneyearmembership * 40) / 100;
            double tapos = oneyearmembership - sn;
            double c = (tapos * 20) / 100;
            double tapoc = tapos - c;
            double b = tapoc / 4;
            double acc = b / 5;
            double tfp = oneyearmembership + tapos + tapoc + b + acc;
            Console.WriteLine($"All expensives will be: {tfp} lv.");
        }
    }
}
