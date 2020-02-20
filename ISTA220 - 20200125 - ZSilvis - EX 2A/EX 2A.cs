using System;

namespace ISTA220___20200125___ZSilvis___EX_2A
{
    class Program
    {

        public static double SumOfTests(int numberOfTests = 10)
        {
            double sumOfTests = 0.0;
            for (int i = 0; i < numberOfTests; i++)
            {
                Console.Write($"Enter test score #{i+1}: ");
                double testScore = Convert.ToDouble(Console.ReadLine());
                sumOfTests += testScore;               
            }
            return sumOfTests;
        }

        public static double AverageTestScore(int numberOfTests = 10)
        {
            double sumOfTests = 0.0;
            double avgScore = 0.0;

            for (int i = 0; i < numberOfTests; i++)
            {
                Console.Write($"Enter test score #{i + 1}: ");
                double testScore = Convert.ToDouble(Console.ReadLine());
                sumOfTests += testScore;
            }
            return avgScore = sumOfTests / numberOfTests;
        }

        
        public static string AverageTestGrade(double avgTestScore = 0.0)
        {
            string avgTestGrade = "Unknown";

                if (avgTestScore < 60)
                {
                avgTestGrade = "F";
                }
                else if (avgTestScore >= 60 && avgTestScore < 70)
                {
                avgTestGrade = "D";
                }
                else if (avgTestScore >= 70 && avgTestScore < 80)
                {
                avgTestGrade = "C";
                }
                else if (avgTestScore >= 80 && avgTestScore < 90)
                {
                avgTestGrade = "B";
                }
                else if (avgTestScore >= 90 && avgTestScore <= 100)
                {
                avgTestGrade = "A";
                }
                else
                {
                avgTestGrade = "Unknown";
                }
                return avgTestGrade;
        }

            static void Main(string[] args)
        {
            Console.WriteLine("ISTA220 - 20200125 - ZSilvis - EX 2A (Calculating Averages)\n");

            Console.Write("How many tests do you need to grade? ");
            int numberOfTests = Convert.ToInt32(Console.ReadLine());

            //Remove comments on the line immediately below in order to calculate the sum of 10 test grades:
            //Console.WriteLine($"\n\tThe sum of {numberOfTests} tests is {SumOfTests(numberOfTests)}");

            //Remove comments on the line immediately below in order to calculate the average test score and average letter grade 10 numbers:
            double avgTestScore = AverageTestScore(numberOfTests);
            string avgTestGrade = AverageTestGrade(avgTestScore);
            Console.WriteLine($"\n\tThe average score of the {numberOfTests} tests is {avgTestScore}, which means the class' average grade is {avgTestGrade}.");

        }
    }
}
