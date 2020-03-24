using System;

namespace ISTA322___20200314___ZSilvis___EX_9A__Bisection_Algorithm_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Binary Search and Creating a 'Guess my Number' game.\n");

            //Basic demonstration of binary search:
            /*
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int targetNumber = 7;
            Console.WriteLine($"We're going to see how many guesses it takes for the computer to find our target number from an array of numbers.");
            Console.WriteLine($"Here is the array of numbers we will be searching:\n");
            PrintArray(inputArray);
            Console.WriteLine($"\n");
            Console.WriteLine($"\nAnd the number we want the computer to find is: {targetNumber}. Let's see how long it takes...\n");
            BinarySearch(targetNumber, inputArray, 0);
            */

            //Human Player:
            /*
            int[] inputArray = MakeArray(1000);
            int targetNumber = GenerateTargetNumber(1, 1001);
            Console.WriteLine("Now let's see how well a human does implementing the binary search method.");
            Console.WriteLine("The computer has selected a random number between 1 and 1000. Try to figure out what that number is in the fewest number of guesses!\n");
            BinarySearchHumanPlayer(targetNumber, inputArray, 0);
            */
            
            //Computer Player:
            int[] inputArray = MakeArray(100);
            Console.WriteLine("Now it's the computer's turn to play with a larger array.\n");
            Console.WriteLine("Enter a number between 1 and 100 and the computer will try to guess it: ");
            int targetNumber = Convert.ToInt32(Console.ReadLine());
            BinarySearchComputerPlayer(targetNumber, inputArray, 0);
        }

        public static void BinarySearch(int targetNumber, int[] inputArray, int counter)
        {
            int guessNumber = (inputArray[inputArray.Length-1] + inputArray[0])/2;
            Console.WriteLine($"For this round of guessing, I, the omniscient computer, will guess: {guessNumber}.\n");
            if (guessNumber==targetNumber)
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which matches the target number of {targetNumber}.");
                Console.WriteLine($"I found your number in only {counter} attempts. Give me a harder challenge next time, silly human!");
            }
            else if (guessNumber>targetNumber)
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which was too high. Let's try again.");
                int adjustedArrayLength = (Array.FindIndex(inputArray, item => item == guessNumber))+1;
                int[] adjustedArray = new int[adjustedArrayLength];
                for (int i = 0; i < adjustedArrayLength; i++)
                {
                    adjustedArray[i] = inputArray[i];
                }
                Console.WriteLine($"Alright, since the last guess was too high, I'll now be looking at the following set of numbers:\n");
                PrintArray(adjustedArray);
                Console.WriteLine($"\n");
                BinarySearch(targetNumber, adjustedArray, counter);
            }
            else if (guessNumber<targetNumber)
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which was too low. Let's try again.");
                int guessNumberIndex = Array.FindIndex(inputArray, item => item == guessNumber);
                int adjustedArrayLength = inputArray.Length-((Array.FindIndex(inputArray, item => item == guessNumber)) + 1);
                int[] adjustedArray = new int[adjustedArrayLength];
                for (int i = 0; i < adjustedArrayLength; i++)
                {
                    adjustedArray[i] = inputArray[guessNumberIndex + i+1];
                }
                Console.WriteLine($"Alright, since the last guess was too low, I'll now be looking at the following set of numbers:\n");
                PrintArray(adjustedArray);
                Console.WriteLine($"\n");
                BinarySearch(targetNumber, adjustedArray, counter);
            }
        }

        public static void BinarySearchHumanPlayer(int targetNumber, int[] inputArray, int counter)
        {
            Console.Write("Human, tell me what number you will guess this round: ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\nSo you have guessed {guessNumber}, eh? Let's see if you're correct....\n");
            if (guessNumber == targetNumber)
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which matches the target number of {targetNumber}.");
                Console.WriteLine($"You found the correct number in {counter} attempts. I though humans were smarter than that!");
            }
            else if (guessNumber > targetNumber)
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which was too high. I will have pity on you human, and I will let you try again.\n");
                int adjustedArrayLength = (Array.FindIndex(inputArray, item => item == guessNumber)) + 1;
                int[] adjustedArray = new int[adjustedArrayLength];
                for (int i = 0; i < adjustedArrayLength; i++)
                {
                    adjustedArray[i] = inputArray[i];
                }
                Console.WriteLine($"I will even show you the new set of numbers that contains the target number, just to make it easier on you:\n");
                PrintArray(adjustedArray);
                Console.WriteLine($"\n");
                BinarySearchHumanPlayer(targetNumber, adjustedArray, counter);
            }
            else if (guessNumber < targetNumber)
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which was too low. I will have pity on you human, and I will let you try again.\n");
                int guessNumberIndex = Array.FindIndex(inputArray, item => item == guessNumber);
                int adjustedArrayLength = inputArray.Length - ((Array.FindIndex(inputArray, item => item == guessNumber)) + 1);
                int[] adjustedArray = new int[adjustedArrayLength];
                for (int i = 0; i < adjustedArrayLength; i++)
                {
                    adjustedArray[i] = inputArray[guessNumberIndex + i + 1];
                }
                Console.WriteLine($"I will even show you the new set of numbers that contains the target number, just to make it easier on you:\n");
                PrintArray(adjustedArray);
                Console.WriteLine($"\n");
                BinarySearchHumanPlayer(targetNumber, adjustedArray, counter);
            }
        }

        public static void BinarySearchComputerPlayer(int targetNumber, int[] inputArray, int counter)
        {
            int guessNumber = (inputArray[inputArray.Length - 1] + inputArray[0]) / 2;
            Console.WriteLine($"For this round of guessing, I, the omniscient computer, will guess: {guessNumber}.\n");
            Console.WriteLine("Tell me human, did I get it right?");
            Console.Write("If I got it right, enter 'yes'. If my guess was too high, enter 'high'. If my guess was too low, enter 'low'. ");
            string humanResponse = Console.ReadLine();

            if (String.Equals(humanResponse,"yes"))
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which matches the target number of {targetNumber}.");
                Console.WriteLine($"I found your number in only {counter} attempts. Give me a harder challenge next time, silly human!");
            }
            else if (String.Equals(humanResponse, "high"))
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which was too high. Let me try again.");
                int adjustedArrayLength = (Array.FindIndex(inputArray, item => item == guessNumber)) + 1;
                int[] adjustedArray = new int[adjustedArrayLength];
                for (int i = 0; i < adjustedArrayLength; i++)
                {
                    adjustedArray[i] = inputArray[i];
                }
                Console.WriteLine($"Alright, since the last guess was too high, I'll now be looking at the following set of numbers:\n");
                PrintArray(adjustedArray);
                Console.WriteLine($"\n");
                BinarySearchComputerPlayer(targetNumber, adjustedArray, counter);
            }
            else if (String.Equals(humanResponse, "low"))
            {
                counter++;
                Console.WriteLine($"The guessed number was {guessNumber}, which was too low. Let me try again.");
                int guessNumberIndex = Array.FindIndex(inputArray, item => item == guessNumber);
                int adjustedArrayLength = inputArray.Length - ((Array.FindIndex(inputArray, item => item == guessNumber)) + 1);
                int[] adjustedArray = new int[adjustedArrayLength];
                for (int i = 0; i < adjustedArrayLength; i++)
                {
                    adjustedArray[i] = inputArray[guessNumberIndex + i + 1];
                }
                Console.WriteLine($"Alright, since the last guess was too low, I'll now be looking at the following set of numbers:\n");
                PrintArray(adjustedArray);
                Console.WriteLine($"\n");
                BinarySearchComputerPlayer(targetNumber, adjustedArray, counter);
            }
        }

        public static int[] MakeArray(int desiredLength)
        {
            int[] outputArray = new int[desiredLength];
            for (int i = 0; i < desiredLength; i++)
            {
                outputArray[i] = i + 1;
            }
            return outputArray;
        }

        public static int GenerateTargetNumber(int lowerBound, int upperBound)
        {
            Random r = new Random();
            int targetNumber = r.Next(lowerBound, upperBound);
            return targetNumber;
        }

        public static void PrintArray(int[] inputArray)
        {
            foreach (int x in inputArray)
            {
                Console.Write($"{x} ");
            }
        }
    }
}
