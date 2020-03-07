using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class BetSplit : IBet
    {
        //The odds for this category of bet:
        public const int betMultiplier = 17;
        //Empty Bet Array that will be assigned to the player's choice
        private string[] betArray = new string[2];

        //Construct an object containing the player's chosen bet:
        public BetSplit(int choice)
        {
            switch (choice)
            { 
        
                case 1:
                    string[] betArray = AssignBetArray(split1);
                    break;
                case 2:
                    betArray = AssignBetArray(split2);
                    break;
                case 3:
                    betArray = AssignBetArray(split3);
                    break;
                case 4:
                    betArray = AssignBetArray(split4);
                    break;
                case 5:
                    betArray = AssignBetArray(split5);
                    break;
                case 6:
                    betArray = AssignBetArray(split6);
                    break;
                case 7:
                    betArray = AssignBetArray(split7);
                    break;
                case 8:
                    betArray = AssignBetArray(split8);
                    break;
                case 9:
                    betArray = AssignBetArray(split9);
                    break;
                case 10:
                    betArray = AssignBetArray(split10);
                    break;
                case 11:
                    betArray = AssignBetArray(split11);
                    break;
                case 12:
                    betArray = AssignBetArray(split12);
                    break;
                case 13:
                    betArray = AssignBetArray(split13);
                    break;
                case 14:
                    betArray = AssignBetArray(split14);
                    break;
                case 15:
                    betArray = AssignBetArray(split15);
                    break;
                case 16:
                    betArray = AssignBetArray(split16);
                    break;
                case 17:
                    betArray = AssignBetArray(split17);
                    break;
                case 18:
                    betArray = AssignBetArray(split18);
                    break;
                case 19:
                    betArray = AssignBetArray(split19);
                    break;
                case 20:
                    betArray = AssignBetArray(split20);
                    break;
                case 21:
                    betArray = AssignBetArray(split21);
                    break;
                case 22:
                    betArray = AssignBetArray(split22);
                    break;
                case 23:
                    betArray = AssignBetArray(split23);
                    break;
                case 24:
                    betArray = AssignBetArray(split24);
                    break;
                case 25:
                    betArray = AssignBetArray(split25);
                    break;
                case 26:
                    betArray = AssignBetArray(split26);
                    break;
                case 27:
                    betArray = AssignBetArray(split27);
                    break;
                case 28:
                    betArray = AssignBetArray(split28);
                    break;
                case 29:
                    betArray = AssignBetArray(split29);
                    break;
                case 30:
                    betArray = AssignBetArray(split30);
                    break;
                case 31:
                    betArray = AssignBetArray(split31);
                    break;
                case 32:
                    betArray = AssignBetArray(split32);
                    break;
                case 33:
                    betArray = AssignBetArray(split33);
                    break;
                case 34:
                    betArray = AssignBetArray(split34);
                    break;
                case 35:
                    betArray = AssignBetArray(split35);
                    break;
                case 36:
                    betArray = AssignBetArray(split36);
                    break;
                case 37:
                    betArray = AssignBetArray(split37);
                    break;
                case 38:
                    betArray = AssignBetArray(split38);
                    break;
                case 39:
                    betArray = AssignBetArray(split39);
                    break;
                case 40:
                    betArray = AssignBetArray(split40);
                    break;
                case 41:
                    betArray = AssignBetArray(split41);
                    break;
                case 42:
                    betArray = AssignBetArray(split42);
                    break;
                case 43:
                    betArray = AssignBetArray(split43);
                    break;
                case 44:
                    betArray = AssignBetArray(split44);
                    break;
                case 45:
                    betArray = AssignBetArray(split45);
                    break;
                case 46:
                    betArray = AssignBetArray(split46);
                    break;
                case 47:
                    betArray = AssignBetArray(split47);
                    break;
                case 48:
                    betArray = AssignBetArray(split48);
                    break;
                case 49:
                    betArray = AssignBetArray(split49);
                    break;
                case 50:
                    betArray = AssignBetArray(split50);
                    break;
                case 51:
                    betArray = AssignBetArray(split51);
                    break;
                case 52:
                    betArray = AssignBetArray(split52);
                    break;
                case 53:
                    betArray = AssignBetArray(split53);
                    break;
                case 54:
                    betArray = AssignBetArray(split54);
                    break;
                case 55:
                    betArray = AssignBetArray(split55);
                    break;
                case 56:
                    betArray = AssignBetArray(split56);
                    break;
                case 57:
                    betArray = AssignBetArray(split57);
                    break;
                case 58:
                    betArray = AssignBetArray(split58);
                    break;
                default: 
                    betArray = new string[] { "0", "0" };
                    break;
               
            }
        }
        public string[] AssignBetArray(string[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                betArray[i] = inputArray[i];
            }
            return betArray;
        }

        public void DisplayBetChoices()
        {
            Console.Write("Option 1: ");
            PrintArray(split1);
            Console.Write("Option 2: ");
            PrintArray(split2);
            Console.Write("Option 3: ");
            PrintArray(split3);
            Console.Write("Option 4: ");
            PrintArray(split4);
            Console.Write("Option 5: ");
            PrintArray(split5);
            Console.Write("Option 6: ");
            PrintArray(split6);
            Console.Write("Option 7: ");
            PrintArray(split7);
            Console.Write("Option 8: ");
            PrintArray(split8);
            Console.Write("Option 9: ");
            PrintArray(split9);
            Console.Write("Option 10: ");
            PrintArray(split10);
            Console.Write("Option 11: ");
            PrintArray(split11);
            Console.Write("Option 12: ");
            PrintArray(split12);
            Console.Write("Option 13: ");
            PrintArray(split13);
            Console.Write("Option 14: ");
            PrintArray(split14);
            Console.Write("Option 15: ");
            PrintArray(split15);
            Console.Write("Option 16: ");
            PrintArray(split16);
            Console.Write("Option 17: ");
            PrintArray(split17);
            Console.Write("Option 18: ");
            PrintArray(split18);
            Console.Write("Option 19: ");
            PrintArray(split19);
            Console.Write("Option 20: ");
            PrintArray(split20);
            Console.Write("Option 21: ");
            PrintArray(split21);
            Console.Write("Option 22: ");
            PrintArray(split22);
            Console.Write("Option 23: ");
            PrintArray(split23);  
            Console.Write("Option 24: ");
            PrintArray(split24);  
            Console.Write("Option 25: ");
            PrintArray(split25);  
            Console.Write("Option 26: ");
            PrintArray(split26);  
            Console.Write("Option 27: ");
            PrintArray(split27);  
            Console.Write("Option 28: ");
            PrintArray(split28);  
            Console.Write("Option 29: ");
            PrintArray(split29);  
            Console.Write("Option 30: ");
            PrintArray(split30);  
            Console.Write("Option 31: ");
            PrintArray(split31);
            Console.Write("Option 32: ");
            PrintArray(split32);
            Console.Write("Option 33: ");
            PrintArray(split33);
            Console.Write("Option 34: ");
            PrintArray(split34);
            Console.Write("Option 35: ");
            PrintArray(split35);
            Console.Write("Option 36: ");
            PrintArray(split36);
            Console.Write("Option 37: ");
            PrintArray(split37);
            Console.Write("Option 38: ");
            PrintArray(split38);
            Console.Write("Option 39: ");
            PrintArray(split39);
            Console.Write("Option 40: ");
            PrintArray(split40);
            Console.Write("Option 41: ");
            PrintArray(split42);
            Console.Write("Option 42: ");
            PrintArray(split20);
            Console.Write("Option 43: ");
            PrintArray(split43);
            Console.Write("Option 44: ");
            PrintArray(split44);
            Console.Write("Option 45: ");
            PrintArray(split45);
            Console.Write("Option 46: ");
            PrintArray(split46);
            Console.Write("Option 47: ");
            PrintArray(split47);
            Console.Write("Option 48: ");
            PrintArray(split48);
            Console.Write("Option 49: ");
            PrintArray(split49);
            Console.Write("Option 50: ");
            PrintArray(split50);
            Console.Write("Option 51: ");
            PrintArray(split51);
            Console.Write("Option 52: ");
            PrintArray(split52);
            Console.Write("Option 53: ");
            PrintArray(split53);
            Console.Write("Option 54: ");
            PrintArray(split54);
            Console.Write("Option 55: ");
            PrintArray(split55);
            Console.Write("Option 56: ");
            PrintArray(split56);
            Console.Write("Option 57: ");
            PrintArray(split57);
            Console.Write("Option 58: ");
            PrintArray(split58);
        }

        public void DisplayChosenBet()
        {
            foreach (string s in betArray)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }

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

        public void PrintArray(string[] inputArray)
        {
            foreach (string s in inputArray)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }

        //All possible split bets:
        string[] split1 = new string[] { "1", "2" };
        string[] split2 = new string[] { "1", "4" };
        string[] split3 = new string[] { "2", "3" };
        string[] split4 = new string[] { "2", "5" };
        string[] split5 = new string[] { "3", "6" };
        string[] split6 = new string[] { "6", "9" };
        string[] split7 = new string[] { "6", "5" };
        string[] split8 = new string[] { "5", "8" };
        string[] split9 = new string[] { "5", "4" };
        string[] split10 = new string[] { "4", "7" };
        string[] split11 = new string[] { "7", "8" };
        string[] split12 = new string[] { "7", "10" };
        string[] split13 = new string[] { "8", "11" };
        string[] split14 = new string[] { "8", "9" };
        string[] split15 = new string[] { "9", "2" };
        string[] split16 = new string[] { "9", "12" };
        string[] split17 = new string[] { "12", "11" };
        string[] split18 = new string[] { "11", "14" };
        string[] split19 = new string[] { "10", "11" };
        string[] split20 = new string[] { "10", "13" };
        string[] split21 = new string[] { "13", "14" };
        string[] split22 = new string[] { "13", "16" };
        string[] split23 = new string[] { "14", "15" };
        string[] split24 = new string[] { "14", "17" };
        string[] split25 = new string[] { "15", "12" };
        string[] split26 = new string[] { "15", "18" };
        string[] split27 = new string[] { "18", "21" };
        string[] split28 = new string[] { "18", "17" };
        string[] split29 = new string[] { "17", "20" };
        string[] split30 = new string[] { "17", "16" };
        string[] split31 = new string[] { "16", "19" };
        string[] split32 = new string[] { "19", "22" };
        string[] split33 = new string[] { "19", "20" };
        string[] split34 = new string[] { "20", "23" };
        string[] split35 = new string[] { "20", "21" };
        string[] split36 = new string[] { "21", "24" };
        string[] split37 = new string[] { "24", "27" };
        string[] split38 = new string[] { "24", "23" };
        string[] split39 = new string[] { "23", "22" };
        string[] split40 = new string[] { "23", "26" };
        string[] split41 = new string[] { "22", "25" };
        string[] split42 = new string[] { "25", "26" };
        string[] split43 = new string[] { "25", "28" };
        string[] split44 = new string[] { "26", "27" };
        string[] split45 = new string[] { "26", "29" };
        string[] split46 = new string[] { "27", "30" };
        string[] split47 = new string[] { "30", "33" };
        string[] split48 = new string[] { "30", "29" };
        string[] split49 = new string[] { "29", "28" };
        string[] split50 = new string[] { "28", "31" };
        string[] split51 = new string[] { "31", "34" };
        string[] split52 = new string[] { "31", "32" };
        string[] split53 = new string[] { "32", "29" };
        string[] split54 = new string[] { "32", "33" };
        string[] split55 = new string[] { "32", "35" };
        string[] split56 = new string[] { "33", "36" };
        string[] split57 = new string[] { "36", "35" };
        string[] split58 = new string[] { "35", "34" };
    }


    
}
