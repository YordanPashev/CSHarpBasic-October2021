using System;

namespace GuestThePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string ThePass = "s3cr3t!P@ssw0rd";
            string Inpt = Console.ReadLine();
            

            if(ThePass == Inpt)
            { 
                Console.WriteLine("Welcome"); 
            }

            else
            {
                Console.WriteLine("Wrong password!");
            }                 
        }
    }
}
