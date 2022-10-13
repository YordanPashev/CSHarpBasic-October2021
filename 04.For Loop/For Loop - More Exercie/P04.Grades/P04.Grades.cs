using System;

namespace GameOfIntervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber = int.Parse(Console.ReadLine());
            double topStudentsCounter = 0, students4to5 = 0, student3to4 = 0, failedStudents = 0;
            double totalGradeSum = 0;

            for (int i = 1; i <= studentsNumber; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                totalGradeSum += grade;

                if (grade >= 2.00 && grade < 3.00)
                {
                    failedStudents++;
                }

                else if (grade >= 3.00 && grade < 4.00)
                {
                    student3to4++;
                }

                else if (grade >= 4.00 && grade < 5.00)
                {
                    students4to5++;
                }

                else if (grade >= 5.00)
                {
                    topStudentsCounter++;
                }
            }

            Console.WriteLine($"Top students: {((topStudentsCounter / studentsNumber) * 100):F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {((students4to5 / studentsNumber) * 100):F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {((student3to4 / studentsNumber) * 100):F2}%");
            Console.WriteLine($"Fail: {((failedStudents / studentsNumber) * 100):F2}%");
            Console.WriteLine($"Average: {(totalGradeSum / studentsNumber):F2}");
        }
    }
}
