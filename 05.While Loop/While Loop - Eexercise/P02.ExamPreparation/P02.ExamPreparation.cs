using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string passwor = Console.ReadLine();

            string pass2 = Console.ReadLine();

            if (passwor == pass2)
            {
                Console.WriteLine($"Welcome {username}!");
            }

            while (passwor != pass2)
            {
                pass2 = Console.ReadLine();

                if (passwor == pass2)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }
            }
        }
    }
}
