using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetStreets : IBet
    {
        //The odds for this category of bet:
        public const int betMultiplier = 11;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[3];
        //Construct an object containing the player's chosen bet:
        public BetStreets(int choice)
        {
            switch (choice)
            {
                case 1:
                    string[] betArray = AssignBetArray(firstStreet);
                    break;
                case 2:
                    betArray = AssignBetArray(secondStreet);
                    break;
                case 3:
                    betArray = AssignBetArray(thirdStreet);
                    break;
                case 4:
                    betArray = AssignBetArray(fourthStreet);
                    break;
                case 5:
                    betArray = AssignBetArray(fifthStreet);
                    break;
                case 6:
                    betArray = AssignBetArray(sixthStreet);
                    break;
                case 7:
                    betArray = AssignBetArray(seventhStreet);
                    break;
                case 8:
                    betArray = AssignBetArray(eightStreet);
                    break;
                case 9:
                    betArray = AssignBetArray(ninthStreet);
                    break;
                case 10:
                    betArray = AssignBetArray(tenthStreet);
                    break;
                case 11:
                    betArray = AssignBetArray(eleventhStreet);
                    break;
                case 12:
                    betArray = AssignBetArray(twelfthStreet);
                    break;
                default:
                    betArray = new string[] { "0", "0", "0"};
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
            PrintArray(firstStreet);
            Console.Write("Option 2: ");
            PrintArray(secondStreet);
            Console.Write("Option 3: ");
            PrintArray(thirdStreet);
            Console.Write("Option 4: ");
            PrintArray(fourthStreet);
            Console.Write("Option 5: ");
            PrintArray(fifthStreet);
            Console.Write("Option 6: ");
            PrintArray(sixthStreet);
            Console.Write("Option 7: ");
            PrintArray(seventhStreet);
            Console.Write("Option 8: ");
            PrintArray(eightStreet);
            Console.Write("Option 9: ");
            PrintArray(ninthStreet);
            Console.Write("Option 10: ");
            PrintArray(tenthStreet);
            Console.Write("Option 11: ");
            PrintArray(eleventhStreet);
            Console.Write("Option 12: ");
            PrintArray(twelfthStreet);
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
        //All possible Street bets:
        string[] firstStreet = new string[] { "1", "2", "3" };
        string[] secondStreet = new string[] { "4", "5", "6" };
        string[] thirdStreet = new string[] { "7", "8", "9" };
        string[] fourthStreet = new string[] { "10", "11", "12" };
        string[] fifthStreet = new string[] { "13", "14", "15" };
        string[] sixthStreet = new string[] { "16", "17", "18" };
        string[] seventhStreet = new string[] { "19", "20", "21" };
        string[] eightStreet = new string[] { "22", "23", "24" };
        string[] ninthStreet = new string[] { "25", "26", "27" };
        string[] tenthStreet = new string[] { "28", "29", "30" };
        string[] eleventhStreet = new string[] { "31", "32", "33" };
        string[] twelfthStreet = new string[] { "34", "35", "36" };


    }
}
