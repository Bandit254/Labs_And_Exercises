using System;
using System.Collections.Generic;
using System.Text;

namespace RouletteWheel
{
    interface IBet
    {
        string[] AssignBetArray(string[] inputArray);

        void DisplayBetChoices();

        void PrintArray(string[] inputArray);

        void DisplayChosenBet();

        bool EvaluateBet(string spinResult);

        int EvaluateBetResult(bool winniningBet, int betMultiplier, int wagerAmount);



    }
}
