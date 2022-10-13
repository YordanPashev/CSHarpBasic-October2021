using System;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int moths = int.Parse(Console.ReadLine());
            double electricity = 0, water = 0, internet = 0, others = 0;
            double totalElectricity = 0, totalWater = 0, totalInternet = 0, totalOthers = 0;

            for (int i = 1; i = moths; i++)
            {
                electricity = double.Parse(Console.ReadLine());
                totalElectricity += electricity;
                water = 20;
                totalWater += water;
                internet = 15;
                totalInternet += internet;
                others = (electricity + water + internet)  1.2;
                totalOthers += others;
            }

            double averageUtilitiesPerMoth = (totalElectricity + totalWater + totalInternet + totalOthers)  moths;

            Console.WriteLine($Electricity {totalElectricityF2} lv);
            Console.WriteLine($Water {totalWaterF2} lv);
            Console.WriteLine($Internet {totalInternetF2} lv);
            Console.WriteLine($Other {totalOthersF2} lv);
            Console.WriteLine($Average {averageUtilitiesPerMothF2} lv);
        }
    }
}
