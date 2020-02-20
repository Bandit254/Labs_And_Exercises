using System;

namespace ISTA220___20200125___ZSilvis___LAB_2C__Monte_Carlo_Method_
{
    class Program
    {
        public static double NumGenerator()
        {
            var randy = new Random();
            double randomNumber = randy.NextDouble();
            return randomNumber;
        }

        public static double Hypotenuse(double sideOne, double sideTwo)
        {
            double hypotenuse = Math.Sqrt((Math.Pow(sideOne, 2) + Math.Pow(sideTwo, 2)));
            return hypotenuse;
        }

        public static int CircleArea(int iterations)
        {
            int overlapCounter=0;
            for (int i = 0; i < iterations; i++)
            {
                {
                    double sideOne = NumGenerator();
                    double sideTwo = NumGenerator();
                    double hypotenuse = Hypotenuse(sideOne, sideTwo);
                    if (hypotenuse <= 1)
                    {
                        overlapCounter++;
                    }
                }
            }
            return overlapCounter;
        }

        public static double PiEstimator(int iterations)
        { 
            double piEstimate = (CircleArea(iterations) / iterations) * 4;
            return piEstimate;
        }
         
        public static double PiDiff(double piEstimate)
        {
            double piDiff = piEstimate - Math.PI;
            return piDiff;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ISTA220 - 20200125 - ZSilvis - LAB 2C (Monte Carlo Method)");
            Console.WriteLine("\nEnter the number of iterations you want to run the program:\n");
            int iterations = Convert.ToInt32(Console.ReadLine());
            int overlapCounter = CircleArea(iterations);
            //double piEstimate = PiEstimator(iterations);
            double piDiff = ((overlapCounter/iterations)*4) - Math.PI;
            Console.WriteLine($"\nThe estimate of PI after {iterations} iterations is {(overlapCounter / iterations) * 4}, while the difference between the estimate and real PI is {piDiff}.");




//1.  Why do we multiply the value from step 5 above by 4 ? Answer - because we're initially only looky an one-quarter of a circle
//2. What do you observe in the output when running your program with parameters of increasing size? - Accuracy Improves, performance takes longer
//3. If you run the program multiple times with the same parameter, does the output remain the same? Why or why not? - No because the code specifies a new random seed each time
//4. Find a parameter that requires multiple seconds of run time. What is that parameter ?
//5. How accurate is the estimated value of pi?
//6. Research one other use of Monte - Carlo methods.Record it in your exercise submission and be prepared to discuss it in class. - Financial simulations of future stock prices


        }
    }
}
