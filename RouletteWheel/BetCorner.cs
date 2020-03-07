using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetCorner : IBet
    {
        //The odds for this category of bet:
        public const int betMultiplier = 8;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[4];

        //Construct an object containing the player's chosen bet:
        public BetCorner(int choice)
        {
            switch (choice)
            {
                case 1:
                    string[] betArray = AssignBetArray(corner1);
                    break;
                case 2:
                    betArray = AssignBetArray(corner2);
                    break;
                case 3:
                    betArray = AssignBetArray(corner3);
                    break;
                case 4:
                    betArray = AssignBetArray(corner4);
                    break;
                case 5:
                    betArray = AssignBetArray(corner5);
                    break;
                case 6:
                    betArray = AssignBetArray(corner6);
                    break;
                case 7:
                    betArray = AssignBetArray(corner7);
                    break;
                case 8:
                    betArray = AssignBetArray(corner8);
                    break;
                case 9:
                    betArray = AssignBetArray(corner9);
                    break;
                case 10:
                    betArray = AssignBetArray(corner10);
                    break;
                case 11:
                    betArray = AssignBetArray(corner11);
                    break;
                case 12:
                    betArray = AssignBetArray(corner12);
                    break;
                case 13:
                    betArray = AssignBetArray(corner13);
                    break;
                case 14:
                    betArray = AssignBetArray(corner14);
                    break;
                case 15:
                    betArray = AssignBetArray(corner15);
                    break;
                case 16:
                    betArray = AssignBetArray(corner16);
                    break;
                case 17:
                    betArray = AssignBetArray(corner17);
                    break;
                case 18:
                    betArray = AssignBetArray(corner18);
                    break;
                case 19:
                    betArray = AssignBetArray(corner19);
                    break;
                case 20:
                    betArray = AssignBetArray(corner20);
                    break;
                case 21:
                    betArray = AssignBetArray(corner21);
                    break;
                case 22:
                    betArray = AssignBetArray(corner22);
                    break;
                default: 
                    betArray = new string[] { "0", "0", "0", "0"};
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
            PrintArray(corner1);
            Console.Write("Option 2: ");
            PrintArray(corner2);
            Console.Write("Option 3: ");
            PrintArray(corner3);
            Console.Write("Option 4: ");
            PrintArray(corner4);
            Console.Write("Option 5: ");
            PrintArray(corner5);
            Console.Write("Option 6: ");
            PrintArray(corner6);
            Console.Write("Option 7: ");
            PrintArray(corner7);
            Console.Write("Option 8: ");
            PrintArray(corner8);
            Console.Write("Option 9: ");
            PrintArray(corner9);
            Console.Write("Option 10: ");
            PrintArray(corner10);
            Console.Write("Option 11: ");
            PrintArray(corner11);
            Console.Write("Option 12: ");
            PrintArray(corner12);
            Console.Write("Option 13: ");
            PrintArray(corner13);
            Console.Write("Option 14: ");
            PrintArray(corner14);
            Console.Write("Option 15: ");
            PrintArray(corner15);
            Console.Write("Option 16: ");
            PrintArray(corner16);
            Console.Write("Option 17: ");
            PrintArray(corner17);
            Console.Write("Option 18: ");
            PrintArray(corner18);
            Console.Write("Option 19: ");
            PrintArray(corner19);
            Console.Write("Option 20: ");
            PrintArray(corner20);
            Console.Write("Option 21: ");
            PrintArray(corner21);
            Console.Write("Option 22: ");
            PrintArray(corner22);
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
        {//TODO: Change spinResult to a string 
            bool winningBet = false;
            for (int i = 0; i < betArray.Length; i++)
            {
                
                if (betArray[i]== spinResult)
                {
                    winningBet = true;
                }
            }
            if (winningBet==true)
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
            if (winniningBet==true)
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
        static string[] corner1 = new string[] { "35", "34", "31", "32" };
        static string[] corner2 = new string[] { "35", "33", "36", "32" };
        static string[] corner3 = new string[] { "29", "30", "33", "32" };
        static string[] corner4 = new string[] { "28", "31", "29", "32" };
        static string[] corner5 = new string[] { "29", "28", "25", "26" };
        static string[] corner6 = new string[] { "29", "26", "27", "30" };
        static string[] corner7 = new string[] { "23", "26", "27", "24" };
        static string[] corner8 = new string[] { "25", "26", "23", "22" };
        static string[] corner9 = new string[] { "20", "23", "19", "22" };
        static string[] corner10 = new string[] { "20", "23", "24", "21" };
        static string[] corner11 = new string[] { "21", "20", "18", "17" };
        static string[] corner12 = new string[] { "16", "19", "20", "17" };
        static string[] corner13 = new string[] { "16", "13", "14", "17" };
        static string[] corner14 = new string[] { "17", "18", "15", "14" };
        static string[] corner15 = new string[] { "11", "12", "15", "14" };
        static string[] corner16 = new string[] { "13", "14", "10", "11" };
        static string[] corner17 = new string[] { "7", "8", "10", "11" };
        static string[] corner18 = new string[] { "11", "12", "8", "9" };
        static string[] corner19 = new string[] { "5", "6", "8", "9" };
        static string[] corner20 = new string[] { "7", "8", "5", "4" };
        static string[] corner21 = new string[] { "5", "6", "2", "3" };
        static string[] corner22 = new string[] { "4", "5", "1", "2" };
    }
}
