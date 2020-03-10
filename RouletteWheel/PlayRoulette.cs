using System;

namespace RouletteWheel
{
    class PlayRoulette
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Modeling a Roulette Wheel.\n");

            Console.WriteLine("Welcome to The Mos Eisley Casino! We have the best roulette game in the galaxy!\n");
            Console.WriteLine("Tell us about yourself since you seem to be new to this spaceport.");
            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.Write($"Well, {playerName}, how many credits are you starting with today?: ");
            int playerCredits = Convert.ToInt32(Console.ReadLine());
            Gambler player = new Gambler(playerName, playerCredits);
            RouletteGame.PlayRoulette(player);           

        }

       






        

    }
}
