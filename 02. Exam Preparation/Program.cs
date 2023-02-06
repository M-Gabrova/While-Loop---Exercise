using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());
            int evaluationSum = 0;
            int evaluationCount = 0;
            int failedCount = 0;
            string lastExercise = string.Empty;
            string input = Console.ReadLine();
            int evaluation;

            while (input != "Enough")
            {
                lastExercise= input;
                evaluation = int.Parse(Console.ReadLine());
                evaluationSum+= evaluation;
                evaluationCount++;

                if (evaluation <= 4)
                {
                    failedCount++;
                    if (failedCount == failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedCount} poor grades.");
                        break;
                    }
                }

                input = Console.ReadLine();
            }
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {(double)evaluationSum/evaluationCount:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");

            }
        }
    }
}
