using System;

public class NumberPyramid
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int num = 1;
        bool isBigger = false;

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write(num + " ");
                num++;

                if (num > n)
                {
                    Console.WriteLine();
                    isBigger = true;
                    break;

                }
            }
            
            if (isBigger == true)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}