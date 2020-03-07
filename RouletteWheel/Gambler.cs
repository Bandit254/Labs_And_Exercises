using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    class Gambler
    {
        private string playerName;
        private int playerCredits;
        private bool outOfCredits = false;

        public Gambler(string playerName, int playerCredits)
        {
            this.playerName = playerName;
            this.playerCredits = playerCredits;
        }

        public int AdjustCredits(int betResult)
        {
            playerCredits += betResult;
            return playerCredits;
        }

        public void DisplayCurrentCredits()
        {
            Console.WriteLine($"Remaining credits = ${playerCredits}.");
        }

        public bool GoBust()
        {
            if (playerCredits<=0)
            {
                outOfCredits = true;
            }
            return outOfCredits;
        }

        public int PlaceWager()
        {
            Console.Write("Enter the amount you will wager on this bet: ");
            int wagerAmount = Convert.ToInt32(Console.ReadLine());
            if (wagerAmount>playerCredits)
            {
                Console.WriteLine("You don't have enough credits to wager that amount.");
                Console.Write("Choose a wager amount less than your current credit amount:");
                wagerAmount = Convert.ToInt32(Console.ReadLine());
            }
            return wagerAmount;
        }





    }
}
