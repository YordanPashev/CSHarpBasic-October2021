using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalTimeHour = int.Parse(Console.ReadLine());
            int arrivalTimeMinutes = int.Parse(Console.ReadLine());

            int resultExamMinutes = (examHour * 60) + examMinutes;
            int resultArrivalMinutes = (arrivalTimeHour * 60) + arrivalTimeMinutes;
            int final = Math.Abs(resultExamMinutes - resultArrivalMinutes);

            if (resultArrivalMinutes == resultExamMinutes)
            {
                Console.WriteLine("On time");
            }

            else if (resultExamMinutes > resultArrivalMinutes  && (resultExamMinutes - resultArrivalMinutes) <= 30)
            {

                Console.WriteLine("On time");
                Console.WriteLine($"{resultExamMinutes - resultArrivalMinutes} minutes before the start");
            }

            else if (resultExamMinutes > resultArrivalMinutes)  
            {
                int h = final / 60;
                double m = final % 60;
                if (resultExamMinutes - resultArrivalMinutes > 30 && resultExamMinutes - resultArrivalMinutes < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{resultExamMinutes - resultArrivalMinutes} minutes before the start");
                }
                else if (resultExamMinutes - resultArrivalMinutes >= 60)
                {
                    if (m < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{h}:0{m} hours before the start");
                    }

                    else if (m >= 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{h}:{m} hours before the start");
                    }
                }
            }

            else if (resultArrivalMinutes > resultExamMinutes)
            {
                if (resultArrivalMinutes - resultExamMinutes >= 60)
                {
                    int h = final / 60;
                    double m = final % 60;
                    if (m < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{h}:0{m} hours after the start");
                    }

                    else if (m >= 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{h}:{m} hours after the start");
                    }
                }

                else if (resultArrivalMinutes - resultExamMinutes < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{resultArrivalMinutes - resultExamMinutes} minutes after the start");
                }
            }

        }
    }
}
