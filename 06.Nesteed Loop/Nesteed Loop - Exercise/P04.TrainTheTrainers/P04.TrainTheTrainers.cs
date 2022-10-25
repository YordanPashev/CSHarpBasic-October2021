using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            bool isFinished = false;
            double gradeSum = 0;
            double projectAverageGrade = 0;
            int projectCounter = 0;
            double averageGradeSum = 0;
            double finalAssessment = 0;

            while (isFinished == false)
            {
                string project = Console.ReadLine();

                if (project == "Finish")
                {
                    isFinished = true;
                    break;
                }

                gradeSum = 0;
                projectAverageGrade = 0;

                for (int i = 0; i < n; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    gradeSum += grade;
                    projectAverageGrade = gradeSum / n;
                }
                
                Console.WriteLine($"{project} - {projectAverageGrade:F2}.");
                projectCounter++;
                averageGradeSum += projectAverageGrade;
            }

            finalAssessment = averageGradeSum / projectCounter;
            Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
        }
    }
}
