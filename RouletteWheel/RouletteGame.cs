using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class RouletteGame
    {
        static string[] rouletteNumbers = new string[]{ "0", "2", "14", "35", "23", "4", "16", "33", "21", "6", "18",
                                      "31", "19", "8", "12", "29", "25", "10", "27", "00", "1", "13",
                                        "36", "24", "3", "15", "34", "22", "5", "17", "32", "20",
                                            "7", "11", "30", "26", "9", "28" };

        static string[] rouletteColors = new string[] {"green", "black", "red", "black", "red", "black", "red",
                                                    "black", "red","black", "red","black", "red","black", "red",
                                                    "black", "red","black", "red","green", "red", "black", "red","black", "red","black", "red","black", "red",
                                                            "black", "red","black", "red","black", "red","black", "red","black"};





        
        

        
        /*
        
        //Commonly used code put into a method
        public static void Continue()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }// End Continue()

        public static void CheckTime()
        {
            if (timer - gameTime < 0)
            {
                Farewell();
            }
        }//End CheckTime()

*/

        public static int GetRouletteNumber()
        {
            Random r = new Random();
            int rouletteNumber = r.Next(38);

            return rouletteNumber;
        }
        public static (string, string) SpinResult(int rouletteNumber)
        {
            string spinResult = rouletteNumbers[rouletteNumber];
            string spinResultColor = rouletteColors[rouletteNumber];
            return (spinResult, spinResultColor);
        }

        public static void PlayRoulette(Gambler player)
        {
            Console.WriteLine("Let's play roulette! Let's first check your credit levels:");
            player.DisplayCurrentCredits();
            Console.WriteLine("Next, select a betting category:");
            Console.WriteLine("\n#\tBet Type\tBet Payout");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"1)\tSingle Number\t\t35:1");
            Console.WriteLine($"2)\tRed or Black\t\t1:1");
            Console.WriteLine($"3)\tEvens or Odds\t\t2:1");
            Console.WriteLine($"4)\tHigh or Low\t\t2:1");
            Console.WriteLine($"5)\tStreet\t\t\t11:1");
            Console.WriteLine($"6)\tSplit\t\t\t17:1");
            Console.WriteLine($"7)\tDozens\t\t\t2:1");
            Console.WriteLine($"8)\tDouble Rows\t\t8:1");
            Console.WriteLine($"9)\tCorner\t\t\t8:1");
            Console.WriteLine($"10)\tColumns\t\t\t2:1");
            Console.Write("\n\nPlease enter the number of your desired betting category: ");
            int playerChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int choice = PickBettingOption(playerChoice);
            Console.WriteLine("\n");
            IBet genericBet = new BetNumbers(0);
            IBet playerBet = GenerateBet(playerChoice, choice, genericBet);
            int wagerAmount = player.PlaceWager();
            Console.Write("Let's review the details of the bet you have selected before spinning the roulette wheel. You have selected the following set of winning numbers/colors: \n\n");
            playerBet.DisplayChosenBet();
            Console.WriteLine("\n");
            Console.WriteLine($"And you will be wagering {wagerAmount} on this bet.");
            Console.WriteLine("\n");
            Continue();
            int rouletteNumber = GetRouletteNumber();
            (string spinResult, string spinResultColor) = SpinResult(rouletteNumber);
            Console.WriteLine($"\nThe winning number came out to be {spinResult}, which is a {spinResultColor} number.\n");
            bool winningBet;
            if (playerChoice==2)
            {
                winningBet = playerBet.EvaluateBet(spinResultColor);
            }
            else
            {
                winningBet = playerBet.EvaluateBet(spinResult);
                
            }
            int betMultiplier = GenerateBetMultiplier(playerChoice);
            int betResult = playerBet.EvaluateBetResult(winningBet,betMultiplier,wagerAmount);
            player.AdjustCredits(betResult);
            bool outOfCredits = player.GoBust();
            Console.WriteLine("\n");
            if (outOfCredits == true)
            {
                Console.WriteLine("You went completely bust on that bet! You'll be shipped out to Jaba's Palace to be fed to the Rancor!");
            }
            else
            {
                KeepPlaying(player);
            }
        }


        public static IBet GenerateBet(int playerChoice, int choice, IBet playerBet)
        {
            
            if (playerChoice == 1)
            {
                playerBet = new BetNumbers(choice);
                return playerBet;
            }
            else if (playerChoice == 2)
            {
                playerBet = new BetRedBlack(choice);
                return playerBet;

            }
            else if (playerChoice == 3)
            {
                playerBet = new BetEvensOdds(choice);
                return playerBet;

            }
            else if (playerChoice == 4)
            {
                playerBet = new BetHighLow(choice);
                return playerBet;

            }
            else if (playerChoice == 5)
            {
                playerBet = new BetStreets(choice);
                return playerBet;

            }
            else if (playerChoice == 6)
            {
                playerBet = new BetSplit(choice);
                return playerBet;

            }
            else if (playerChoice == 7)
            {
                playerBet = new BetDozens(choice);
                return playerBet;

            }
            else if (playerChoice == 8)
            {
                playerBet = new BetDoubleRows(choice);
                return playerBet;

            }
            else if (playerChoice == 9)
            {
                playerBet = new BetCorner(choice);
                return playerBet;

            }
            else if (playerChoice == 10)
            {
                playerBet = new BetColumns(choice);
                return playerBet;
            }
            return playerBet;
        }

        public static int GenerateBetMultiplier(int playerChoice)
        {
            int betMultiplier = 1;
            if (playerChoice == 1)
            {
                betMultiplier = BetNumbers.betMultiplier;
                
            }
            else if (playerChoice == 2)
            {
                betMultiplier = BetRedBlack.betMultiplier;
            

            }
            else if (playerChoice == 3)
            {
                betMultiplier =  BetEvensOdds.betMultiplier;
              

            }
            else if (playerChoice == 4)
            {
                betMultiplier = BetHighLow.betMultiplier;
                

            }
            else if (playerChoice == 5)
            {
                betMultiplier =  BetStreets.betMultiplier;
               

            }
            else if (playerChoice == 6)
            {
                betMultiplier =  BetSplit.betMultiplier;
                

            }
            else if (playerChoice == 7)
            {
                betMultiplier =  BetDozens.betMultiplier;
                

            }
            else if (playerChoice == 8)
            {
                betMultiplier = BetDoubleRows.betMultiplier;
                

            }
            else if (playerChoice == 9)
            {
                betMultiplier = BetCorner.betMultiplier;
                

            }
            else if (playerChoice == 10)
            {
                betMultiplier =  BetColumns.betMultiplier;
                
            }
            return betMultiplier;
        }

        public static int PickBettingOption(int playerChoice)
        {
            int choice=0; 
            if (playerChoice==1)
            {
                BetNumbers genericBet = new BetNumbers(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 2)
            {
                BetRedBlack genericBet = new BetRedBlack(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice==3)
            {
                BetEvensOdds genericBet = new BetEvensOdds(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 4)
            {
                BetHighLow genericBet = new BetHighLow(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 5)
            {
                BetStreets genericBet = new BetStreets(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 6)
            {
                BetSplit genericBet = new BetSplit(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 7)
            {
                BetDozens genericBet = new BetDozens(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 8)
            {
                BetDoubleRows genericBet = new BetDoubleRows(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 9)
            {
                BetCorner genericBet = new BetCorner(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            else if (playerChoice == 10)
            {
                BetColumns genericBet = new BetColumns(0);
                genericBet.DisplayBetChoices();
                Console.Write("Enter the number of the specific bet you want: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            return choice;
        }

        public static void Continue()
        {
            Console.WriteLine("\nReady to spin the wheel? Press any key to see if you've won!\n");
            Console.ReadKey();
        }

        public static void KeepPlaying(Gambler player)
        {
            Console.WriteLine("You've still got some credits left, would you like to play again?\n");
            Console.Write("Enter 1 to keep playing, of 0 to head back out into the galaxy: ");
            int playAgain = Convert.ToInt32(Console.ReadLine());
            if (playAgain==0)
            {
                Console.WriteLine($"Alright, don't get burned by the twin suns on your way out!");
                
            }
            else if (playAgain==1)
            {
                Console.WriteLine("Alright, another round coming right up!\n\n\n");
                PlayRoulette(player);
            }
        }

    }



    //https://www.quora.com/How-many-unique-bets-are-there-in-a-roulette
}
