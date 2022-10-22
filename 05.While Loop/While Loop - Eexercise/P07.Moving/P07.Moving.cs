using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            int roomSize = width * lenght * hight;
            int result = 0;
            string inputBox = "";

            while (inputBox != "Done" && roomSize >= 0)
            {
                inputBox = Console.ReadLine();

                if (inputBox == "Done")
                {
                    Console.WriteLine($"{roomSize} Cubic meters left.");
                    break;
                }

                int convBox = int.Parse(inputBox);
                result += convBox;
                roomSize -= convBox;
                
                if (roomSize < 0)
                {
                    int neededSpace = roomSize;
                    Console.WriteLine($"No more free space! You need {Math.Abs(neededSpace)} Cubic meters more.");
                    break;
                }
            }
        }
    }
}
