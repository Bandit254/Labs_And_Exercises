using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetColumns : IBet
    {
        //The odds for this category of bet:
        public const int betMultiplier = 2;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[12];

        //Construct an object containing the player's chosen bet:
        public BetColumns(int choice)
        {
            switch (choice)
            {
                case 1:
                    string[] betArray = AssignBetArray(firstColumn);
                    break;
                case 2:
                    betArray = AssignBetArray(secondColumn);
                    break;
                case 3:
                    betArray = AssignBetArray(thirdColumn);
                    break;
                default:
                    betArray = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
                    break;
            }
        }
        //Assign the bet array to the desired combination:
        public string[] AssignBetArray(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                betArray[i] = inputArray[i];
            }
            return betArray;
        }
        //Display all possible choices of the bet category:
        public void DisplayBetChoices()
        {
            Console.Write("Option 1: ");
            PrintArray(firstColumn);
            Console.Write("Option 2: ");
            PrintArray(secondColumn);
            Console.Write("Option 3: ");
            PrintArray(thirdColumn);
        }
        //Check to see if the player's bet won or not:
        public void DisplayChosenBet()
        {
            foreach (string s in betArray)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
        //Check to see if the player's bet won or not:
        public bool EvaluateBet(string spinResult)
        {
            bool winningBet = false;
            for (int i = 0; i < betArray.Length; i++)
            {
                
                if (betArray[i] == spinResult)
                {
                    winningBet = true;
                }
            }
            if (winningBet == true)
            {
                Console.WriteLine("Congratulations! You won the bet!");
            }
            else
            {
                Console.WriteLine("Oh no! You lost the bet :(");
            }
            return winningBet;
        }
        //Check to what the amount the player won/lost:
        public int EvaluateBetResult(bool winniningBet, int betMultiplier, int wagerAmount)
        {
            int betResult;
            if (winniningBet == true)
            {
                betResult = wagerAmount * betMultiplier;
                Console.WriteLine($"You won {betResult} credits!");
            }
            else
            {
                betResult = -wagerAmount;
                Console.WriteLine($"You lost {betResult} credits...");
            }
            return betResult;
        }
        //Print the bet array to the console:
        public void PrintArray(string[] inputArray)
        {
            foreach (string s in inputArray)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
        //All possible corner bets:
        string[] firstColumn = new string[] { "1", "4", "7", "10", "13", "16", "19", "22", "25", "28", "31", "34" };
        string[] secondColumn = new string[] { "2", "5", "8", "11", "14", "17", "20", "23", "26", "29", "32", "35" };
        string[] thirdColumn = new string[] { "3", "6", "9", "12", "15", "18", "21", "24", "27", "30", "33", "36" };

    }
}
