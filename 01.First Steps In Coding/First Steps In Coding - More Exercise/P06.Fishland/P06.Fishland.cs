using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double cenaskumria = double.Parse(Console.ReadLine());
            double cenacaca = double.Parse(Console.ReadLine());
            double klpal = double.Parse(Console.ReadLine());
            double klsaf = double.Parse(Console.ReadLine());
            double klmidi = double.Parse(Console.ReadLine());
            
            double cenamidi = 7.50;
            double cenapalamud = (cenaskumria * 0.6) + cenaskumria;
            double cenasafrid = (cenacaca * 0.8) + cenacaca;

            double fm = (cenamidi * klmidi) + (cenasafrid * klsaf) + (cenapalamud * klpal);

            Console.WriteLine($"{fm:F2}");
        }
    }
}
