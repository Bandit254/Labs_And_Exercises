using System;

namespace ISTA220___20200125___ZSilvis___EX_2C
{
    class Program
    {
    
        public static double GetSum(int end)
        {
            int start;
            double sum = 0.0;
            for (start=0; start < end; start++)
            {
                Console.Write($"Enter value #{start + 1}: ");
                double inputValue = Convert.ToDouble(Console.ReadLine());
                sum += inputValue;
            }
            return sum;
        }

        public static double AverageTestScoreDefinedNumber(int end)
        {
            double sum = 0.0;
            int start;
            double avgTestScore = 0.0;

            for (start = 0; start < end; start++)
            {
                Console.Write($"Enter test score #{start + 1}: ");
                double inputValue = Convert.ToDouble(Console.ReadLine());
                sum += inputValue;
            }
            return avgTestScore = sum / end;
        }

        public static (double, int) AverageTestScoreNonSpecificNumber(double inputValue, int count = 0)
        {
            double sum = 0.0;
            double avgTestScore = 0.0;
          
            while (inputValue >= 0.0)
            {
                Console.Write($"Enter test score #{count + 1}: ");
                inputValue = Convert.ToDouble(Console.ReadLine());
                sum += inputValue;
                count++;
            }
            return (avgTestScore = (sum / count), count);
        }


        public static string TestGrade(double testScore = 0.0)
        {
            string testGrade = "Unknown";

            if (testScore < 60)
            {
                testGrade = "F";
            }
            else if (testScore >= 60 && testScore < 70)
            {
                testGrade = "D";
            }
            else if (testScore >= 70 && testScore < 80)
            {
                testGrade = "C";
            }
            else if (testScore >= 80 && testScore < 90)
            {
                testGrade = "B";
            }
            else if (testScore >= 90 && testScore <= 100)
            {
                testGrade = "A";
            }
            else
            {
                testGrade = "Unknown";
            }
            return testGrade;
        }

        //Bad Fibonacci Sequence:
        public static long Fibonacci(int fibNumber)
        {
            
            long fib1stPrev = 1;
            long fib2ndPrev = 1;
            long fibCurrent = 0;
            fibCurrent += (fib1stPrev+fib2ndPrev);
            long fibRatio = 0;
            int count = 1;

            if (count <= fibNumber)
                    {
                
                    fibCurrent = fib1stPrev+fib2ndPrev;
                    Console.WriteLine($"Fibonacci #{count}: {fibCurrent}");
                    fib2ndPrev = fib1stPrev;
                    fib1stPrev = fibCurrent;
                    ++count; 
                    }
            
            fibRatio = fibCurrent / fib1stPrev;
           
            return fibRatio;
        }
        //Original Fibonacci Sequence:
        public static long FibonacciTwo(int fibNumber)
        {
            if (fibNumber == 0 || fibNumber == 1)
                return fibNumber;

            return FibonacciTwo(fibNumber - 1) + FibonacciTwo(fibNumber - 2);
        }
        //More-correcter Fibonacci Sequence (updated 27APR2020):
        public static int Flubbernacci(int flubNumber)
        {
            if (flubNumber==1)
            {
                return 0;
            }
            if (flubNumber==2)
            {
                return 1;
            }

            return Flubbernacci(flubNumber - 1) + Flubbernacci(flubNumber - 2);
        }

        public static double FibonacciRatio(int fibNumber)
        {
            double fibCurrent = Convert.ToDouble(Flubbernacci(fibNumber));
            double fibPrev = Convert.ToDouble(Flubbernacci(fibNumber - 1));
            double fibRatio = fibCurrent / fibPrev; ;
            return fibRatio;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ISTA220 - 20200125 - ZSilvis - EX_2C (Recursive Methods)");
            /*
            int start = 0;
            int end = 0;
            double sum = 0.0;
            string testGrade = "unknown";
            double testScore = 0.0;
            int numTests = 0;
            */
            /*
            sum = GetSum(end);
            Console.WriteLine($"\nThe sum of the {end} values is {sum}.");
            */

            /*
            //Use the following two lines when calculating the average of a defined set of numbers
            Console.Write("\nSpecify how many numbers you want to sum: \n");
            end = Convert.ToInt32(Console.ReadLine());
            */

            /*
            //Average a specific number of scores
            testScore = AverageTestScoreDefinedNumber(end);
            testGrade = TestGrade(testScore);
            Console.WriteLine($"\n\tThe average score of {end} tests is {testScore}, with an average letter grad of {testGrade}.");
            */

            /*
            //Average a non-number of scores
            Console.WriteLine("Below, enter each student's test score until all scores have been entered. When complete, enter a negative one (-1):\n");
            double inputValue = 0.0;
            int count = 0;
            (testScore, numTests) = AverageTestScoreNonSpecificNumber(inputValue, count);
            testGrade = TestGrade(testScore);
            Console.WriteLine($"\n\tThe average score of {numTests-1} tests is {testScore}, with an average letter grade of {testGrade}.");
            */

            //Calculating the Fibonacci Series
            Console.WriteLine("Enter which Fibonacci number you want to calculate:\n");
            int flubNumber = Convert.ToInt32(Console.ReadLine());
            int flubberNacci = Flubbernacci(flubNumber);
            double fibRatio = Convert.ToDouble(Flubbernacci(flubNumber)) / Convert.ToDouble(Flubbernacci(flubNumber - 1));
            Console.WriteLine($"\n\tThe value of the value of Fibonacci #{flubNumber} is {flubberNacci} (Updated Method)");
            Console.WriteLine($"\n\tThe Ratio between Fibonacci #{flubNumber} and #{flubNumber - 1} is {fibRatio}.");



        }
    }
}
