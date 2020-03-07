using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetNumbers : IBet
    {
        //The odds for this category of bet:
        public const int betMultiplier = 35;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[1];

        //Construct an object containing the player's chosen bet:
        public BetNumbers(int choice)
        {
            string choiceString = choice.ToString();
            string[] betArray = new string[] { choiceString };
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
            Console.Write("Pick a number from the roulette wheel: ");
            PrintArray(rouletteNumbers);
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

        string[] rouletteNumbers = new string[]{ "0", "2", "14", "35", "23", "4", "16", "33", "21", "6", "18",
                                      "31", "19", "8", "12", "29", "25", "10", "27", "00", "1", "13",
                                        "36", "24", "3", "15", "34", "22", "5", "17", "32", "20",
                                            "7", "11", "30", "26", "9", "28" };

    }
}
