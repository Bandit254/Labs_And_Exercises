using System;

namespace ISTA421___20200411___ZSilvis___EX_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Math Games.\n");
            MathGame();
        }
        public static void MathGame()
        {
            Console.WriteLine("Welcome to, 'So you think you're smarter than a 5th grader?!?' To prove it, you will be tested with a number of math problems.\n");
            Console.WriteLine("You can choose between addition, subtraction, multiplication, and division problems. \n");
            Console.WriteLine("Enter the number corresponding to the type of problems you want to solve:\n");
            Console.WriteLine("\n#\tProblem Type");
            Console.WriteLine("--------------------");
            Console.WriteLine($"1)\tAddition");
            Console.WriteLine($"2)\tSubtraction");
            Console.WriteLine($"3)\tMultiplication");
            Console.WriteLine($"4)\tDivision");
            Console.WriteLine("--------------------\n");
            Console.Write("Enter your choice: ");
            int probTypeChoice = Convert.ToInt32(Console.ReadLine());
            string problemType;
            switch (probTypeChoice)
            {
                case 1:
                    problemType = "Addition";
                    break;
                case 2:
                    problemType = "Subtraction";
                    break;
                case 3:
                    problemType = "Multiplication";
                    break;
                case 4:
                    problemType = "Division";
                    break;
                default:
                    problemType = "Error";
                    Console.WriteLine("Error - enter a number 1 - 4 as your selection");
                    break;
            }
            if (String.Equals(problemType,"Error"))
            {
                Console.Write("Enter your choice again: ");
                probTypeChoice = Convert.ToInt32(Console.ReadLine());
                switch (probTypeChoice)
                {
                    case 1:
                        problemType = "Addition";
                        break;
                    case 2:
                        problemType = "Subtraction";
                        break;
                    case 3:
                        problemType = "Multiplication";
                        break;
                    case 4:
                        problemType = "Division";
                        break;
                    default:
                        problemType = "Error";
                        Console.WriteLine("Error - enter a number 1 - 4 as your selection");
                        break;
                }
            }
            Console.WriteLine("\nNow enter the number of problems you want to solve:\n");
            Console.Write("Enter your choice: ");
            double probNumChoice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"You have chosen to perform {probNumChoice} {problemType} problems. Are you ready?\n");
            Console.Write("Press any key to begin playing...");
            Console.ReadKey();
            Console.WriteLine("\n");
            double numCorrect = 0;
            for (int i = 0; i < probNumChoice; i++)
            {
                Random num1R = new Random();
                int num1 = num1R.Next(1, 13);
                Random num2R = new Random();
                int num2 = num2R.Next(1, 13);
                if (probTypeChoice==1)
                {
                    int trueAnswer= Addition(num1, num2);
                    Console.WriteLine($"What is {num1} + {num2}?\n");
                    Console.Write("Enter your answer: ");
                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (trueAnswer == userAnswer)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you answered wrong; the correct answer was {trueAnswer}.\n");
                    }
                    
                }
                else if (probTypeChoice == 2)
                {
                    int trueAnswer = Subtraction(num1, num2);
                    Console.WriteLine($"What is {num1} - {num2}?\n");
                    Console.Write("Enter your answer (include the negative sign if the answer is less than 0): ");
                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (trueAnswer == userAnswer)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you answered wrong; the correct answer was {trueAnswer}.\n");
                    }
                }
                else if (probTypeChoice==3)
                {
                    int trueAnswer = Multiplication(num1, num2);
                    Console.WriteLine($"What is {num1} * {num2}?\n");
                    Console.Write("Enter your answer: ");
                    int userAnswer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (trueAnswer == userAnswer)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you answered wrong; the correct answer was {trueAnswer}.\n");
                    }
                }
                else if (probTypeChoice==4)
                {
                    Random dub1R = new Random();
                    double dub1 = dub1R.Next(1, 13);
                    Random dub2R = new Random();
                    double dub2 = dub2R.Next(1, 13);
                    double trueAnswer = Division(dub1, dub2);
                    double roundedAnswer = Math.Round(trueAnswer, 2);
                    Console.WriteLine($"What is {dub1} / {dub2}?\n");
                    Console.Write("Enter your answer (rounded to two decimal places): ");
                    double userAnswer = Convert.ToDouble(Console.ReadLine());
                    if (roundedAnswer == userAnswer)
                    {
                        Console.WriteLine("Correct!");
                        numCorrect++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you answered wrong; the correct answer was {roundedAnswer}.\n");
                    }
                }
            }

            double finalScore = numCorrect / probNumChoice;
            finalScore = 100*(Math.Round(finalScore, 2));
            Console.WriteLine($"\n\nThanks for playing! You answered {numCorrect} out of {probNumChoice} questions correctly, for a final score of {finalScore}%.\n");
            if (finalScore>90)
            {
                Console.WriteLine("With that impressive performance, you have demonstrated that you are, in fact, smarter than a 5th grader!");
            }
            else
            {
                Console.WriteLine("We will see you in school next week because you are most definitely not smarter than a 5th grader!");
            }
        }

        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static double Division(double dub1, double dub2)
        {
            double quotient = dub1 / dub2;            
            return quotient;
        }



    }
}
