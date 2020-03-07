using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetRedBlack : IBet
    {
        //The odds for this category of bet:
        public const int betMultiplier = 1;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[1];

        //Construct an object containing the player's chosen bet:
        public BetRedBlack(int choice)
        {
            switch (choice)
            {
                case 1:
                    string[] betArray = new string[] { "red" };
                    break;
                case 2:
                    betArray = new string[] { "black" };
                    break;
                default:
                    betArray = new string[] { "green" };
                    break;
            }
        }
        //Assign the bet array to the desired combination:
        public string[] AssignBetArray(string[] inputArray)
        {
            //Not needed for this bet;
            return inputArray;
        }
        //Display all possible choices of the bet category:
        public void DisplayBetChoices()
        {
            Console.Write(" Option 1: red, ");
            Console.Write(" Option 2: black. ");
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
        public bool EvaluateBet(string spinResultColor)
        {
            bool winningBet = false;
            string[] resultArray = new string[] { spinResultColor };
            if (Equals(betArray[0],resultArray[0]))
            {
                winningBet = true;
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

        string[] rouletteColors = new string[] {"green", "black", "red", "black", "red", "black", "red",
                                                    "black", "red","black", "red","black", "red","black", "red",
                                                    "black", "red","black", "red","green", "red", "black", "red","black", "red","black", "red","black", "red",
                                                            "black", "red","black", "red","black", "red","black", "red","black"};
    }
}
