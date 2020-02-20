using System;

namespace ISTA220___20200201___ZSilvis___LAB_3C
{
    class Program
    {

        //Write a program that calculates tuition over a five year period. Tuition starts at $6000 and each year it increases by 2%. 
        //You will display to the screen the following: For year n your tuition will be x

        public static double TuitionCalculator(int baseTuition, int numYears, double annualIncrease)
        {
            double totalTuition = 0.0;
            for (int i = 0; i < numYears; i++)
            {
            
                totalTuition += baseTuition + baseTuition * annualIncrease;
            }
            return totalTuition;
        }

        //Write a program that asks the user for the number of feet to be converted into inches. Calculate the number of inches. 
        //Display to the user: n feet is x inches

        public static int NumberOfInches(int numFeet)
        {
            int numInches = numFeet * 12;
            return numInches;
        }

        //Write a program that finds the greater of two number entered by the user. Display to the screen: n greater than x
        public static string NumberComparison(int firstNum, int secondNum)
        {
            string outputMessage = "The numbers are indetermined";
            if (firstNum > secondNum)
            {
                outputMessage = ($"\n\tThe value of {firstNum} is greater than {secondNum}.");
                return outputMessage;
            }
            else if (firstNum < secondNum)
            {
                outputMessage = ($"\n\tThe value of {secondNum} is greater than {firstNum}.");
                return outputMessage;
            }
            else if (firstNum == secondNum)
            {
                outputMessage = ($"\n\tThe values of the two numbers are the same");
                return outputMessage;
            }
            return outputMessage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ISTA220 - 20200201 - ZSilvis - LAB 3C\n");

            
            //Tuition Calculator
            Console.Write("Enter the base tuition rate: ");
            int baseTuition = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of years of study: ");
            int numYears = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the annual rate of increase of the tuition (use decimal form, not percentage): ");
            double annualIncrease = Convert.ToDouble(Console.ReadLine());
            double totalTuition = TuitionCalculator(baseTuition, numYears, annualIncrease);
            Console.WriteLine($"\n\tThe total tuition over {numYears} years will be ${totalTuition}. Would you like to apply for financial aid?");
            
            /*
            
            //Inches Calculator
            Console.Write("Enter the number of feet: ");
            int numFeet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\tThe number of inches in {numFeet} feet is {NumberOfInches(numFeet)}.");
            

            //Number Comparison
            Console.Write("Enter the first number to compare: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number to compare: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            string outputMessage = NumberComparison(firstNum, secondNum);
            Console.WriteLine($"\n\t{outputMessage}");

            */
        }
    }
}
