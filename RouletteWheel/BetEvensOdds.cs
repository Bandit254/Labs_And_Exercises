using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetEvensOdds : IBet 
    {
        //The odds for this category of bet:
        public const int betMultiplier = 2;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[18];

        //Construct an object containing the player's chosen bet:
        public BetEvensOdds(int choice)
        {
            switch (choice)
            {
                case 1:
                    string[] betArray = AssignBetArray(odds);
                    break;
                case 2:
                    betArray = AssignBetArray(evens);
                    break;
                default:
                    betArray = new string[] { "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0" };
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
            PrintArray(odds);
            Console.Write("Option 2: ");
            PrintArray(evens);
        }
        //Display the bet array that the player has chosen by referencing the Bet object:
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
        //All possible even/odd bets:
        string[] odds = new string[] { "1", "3", "5", "7", "9", "11", "13", "15", "17", "19", "21", "23", "25", "27", "29", "31", "33", "35" };
        string[] evens = new string[] { "2", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36" };

    }
}
