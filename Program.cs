using System;

namespace ISTA220___20200208___ZSilvis___EX_4A__Creating_a_Farm_
{
    class Program
    {
        static void Main(string[] args)
        {
            try //TODO: Test for an exception
            {
                Console.WriteLine("ISTA220 - 20200208 - ZSilvis - EX 4A (Creating a Farm)\n");
                PokemonJourney();
            }
            catch
            {
                //TODO: Add an exception message
            }
            //TODO: Write Unit Tests
            
        }

        public static void PokemonJourney()
        {
            //Object Instantiation

            Pikachu wildPikachu = new Pikachu();
            Charmander wildCharmander = new Charmander();
            Bulbasaur wildBulbasaur = new Bulbasaur();
            Squirtle wildSquirtle = new Squirtle();
            Trainer ash = new Trainer("Ash", "Pallet Town", 0);
            Trainer blaine = new Trainer("Blaine", "Cinabar Island", 7);
            Trainer erika = new Trainer("Erika", "Celadon City", 4);
            Trainer misty = new Trainer("Misty", "Cerulean City", 3);
            Squirtle mrBubbles = new Squirtle("Mr. Bubbles", "Hydro Pump", "Sitrus Berry", "Water");
            Pikachu sparky = new Pikachu("Sparky", "Thunderbolt", "Oran Berry", "Electric");
            Charmander toasty = new Charmander("Toasty", "Flamethrower", "Cherri Berry", "Fire");
            Bulbasaur leafy = new Bulbasaur("Leafy", "Solar Beam", "Chesto Berry", "Grass", "Poison");

            //Story Introduction
            Console.WriteLine("Hello there! My name is Professor Oak, welcome to the Kanto Region! Today we will follow the stories of four Pokemon trainers as they catch their Pokemon partners and battle to determine who is the strongest!\n\n");

            //Ash catches his wild Pokemon
            ash.Speak();
            wildPikachu.WildPokemonAppears();
            wildPikachu.Attack();
            ash.CatchPokemon("Poke Ball", "Pikachu");
            wildPikachu.HasType();
            Console.WriteLine("Alright! I caught a Pikachu! I'm going to call you Sparky!");
            sparky.Speak();
            Console.WriteLine("Sparky joined Ash's team!\n");
            //Blaine catches his wild Pokemon
            blaine.Speak();
            wildCharmander.WildPokemonAppears();
            wildCharmander.Attack();
            blaine.CatchPokemon("Great Ball", "Charmander");
            wildCharmander.HasType();
            Console.WriteLine("Alright! I caught a Charmander! I'm going to call you Toasty!");
            toasty.Speak();
            Console.WriteLine("Toasty joined Blaine's team!\n");
            //Erika catches her wild Pokemon
            erika.Speak();
            wildBulbasaur.WildPokemonAppears();
            wildBulbasaur.Attack();
            erika.CatchPokemon("Ultra Ball", "Bulbasaur");
            wildBulbasaur.HasType();
            Console.WriteLine("Alright! I caught a Bulbasaur! I'm going to call you Leafy!");
            leafy.Speak();
            Console.WriteLine("Leafy joined Erika's team!\n");
            //Misty catches her wild Pokemon
            misty.Speak();
            wildSquirtle.WildPokemonAppears();
            wildSquirtle.Attack();
            misty.CatchPokemon("Net Ball", "Squirtle");
            wildSquirtle.HasType();
            Console.WriteLine("Alright! I caught a Squirtle! I'm going to call you Mr. Bubbles!");
            mrBubbles.Speak();
            Console.WriteLine("Leafy joined Misty's team!\n");

            //Beginning of the tournament
            Console.WriteLine("Hello there! Professor Oak here again! Now that our four trainers have caught their Pokemon partners they will now begin the tournament to determine who will be the Pokemon Champion!\n");

            //Pokemon Tournament, Round 1 (Ash vs Misty)
            Console.WriteLine("\tRound 1: Ash vs. Misty");
            ash.ChallengeTrainer("Misty");
            misty.AcceptChallenge("Ash");
            ash.ChoosePokemon("Sparky");
            misty.ChoosePokemon("Mr. Bubbles");
            mrBubbles.Attack();
            sparky.Eats();
            sparky.Recovers();
            sparky.Attack();
            mrBubbles.Faints();
            Console.WriteLine("Ash is victorious over Misty!\n");

            //Pokemon Tournament, Round 2 (Blaine vs Erika)
            Console.WriteLine("\tRound 2: Blaine vs. Erika");
            blaine.ChallengeTrainer("Erika");
            erika.AcceptChallenge("Blaine");
            blaine.ChoosePokemon("Toasty");
            erika.ChoosePokemon("Leafy");
            leafy.Attack();
            toasty.Eats();
            toasty.Recovers();
            toasty.Attack();
            leafy.Faints();
            Console.WriteLine("Blaine is victorious over Erika!\n");

            //Pokemon Tournament, Round 3 (Blaine vs Ash)
            Console.WriteLine("\tRound 3: Blaine vs Ash for the Championship");
            blaine.ChallengeTrainer("Ash");
            ash.AcceptChallenge("Blaine");
            blaine.ChoosePokemon("Toasty");
            ash.ChoosePokemon("Sparky");
            toasty.Attack();
            sparky.Eats();
            sparky.Recovers();
            sparky.Attack();
            toasty.Faints();
            Console.WriteLine("\n\tAsh is victorious over Blaine! He is the new Pokemon Champion!\n");



        }


    }


    class Pikachu
    {
        private string givenName;
        private string attackName;
        private string foodType;
        private string typeOne;
        
        public void Speak()
        {
            Console.WriteLine($"My name is {givenName} the Pikachu!");
        }
        public void Attack()
        {
            Console.WriteLine($"{givenName} used {attackName}!");
        }

        public void Eats()
        {
            Console.WriteLine($"{givenName} ate an {foodType}!");
        }

        public void HasType()
        {
            Console.WriteLine($"{givenName}'s type is {typeOne}!");
        }        

        public void Recovers()
        {
            Console.WriteLine($"{givenName} recovered strength after eating the {foodType}");
        }

        public void Faints()
        {
            Console.WriteLine($"{givenName} fainted! Better take {givenName} to a Pokemon center as soon as the battle ends!");
        }

        public void WildPokemonAppears()
        {
            Console.WriteLine($"A {givenName} appeared! The startled Pokemon attacked!");
        }

        public Pikachu() //Default Constructor
        {
            givenName = "Wild Pikachu";
            attackName = "Thundershock";
            foodType = "Oran Berry";
            typeOne = "Electric";
        }
        
        public Pikachu(string givenName, string attackName, string foodType, string typeOne) //1st Constructor
        {
            this.givenName = givenName;
            this.attackName = attackName;
            this.foodType = foodType;
            this.typeOne = typeOne;
        }

    }

    class Charmander
    {
        private string givenName;
        private string attackName;
        private string foodType;
        private string typeOne;

        public void Speak()
        {
            Console.WriteLine($"My name is {givenName} the Charmander!");
        }
        public void Attack()
        {
            Console.WriteLine($"{givenName} used {attackName}!");
        }

        public void Eats()
        {
            Console.WriteLine($"{givenName} ate an {foodType}!");
        }

        public void HasType()
        {
            Console.WriteLine($"{givenName}'s type is {typeOne}!");
        }

        public void Recovers()
        {
            Console.WriteLine($"{givenName} recovered strength after eating the {foodType}");
        }

        public void Faints()
        {
            Console.WriteLine($"{givenName} fainted! Better take {givenName} to a Pokemon center as soon as the battle ends!");
        }

        public void WildPokemonAppears()
        {
            Console.WriteLine($"A {givenName} appeared! The startled Pokemon attacked!");
        }

        public Charmander() //Default Constructor
        {
            givenName = "Wild Charmander";
            attackName = "Ember";
            foodType = "Cherri Berry";
            typeOne = "Fire";
        }

        public Charmander(string givenName, string attackName, string foodType, string typeOne) //1st Constructor
        {
            this.givenName = givenName;
            this.attackName = attackName;
            this.foodType = foodType;
            this.typeOne = typeOne;
        }

    }

    class Bulbasaur
    {
        private string givenName;
        private string attackName;
        private string foodType;
        private string typeOne;
        private string typeTwo;

        public void Speak()
        {
            Console.WriteLine($"My name is {givenName} the Bulbasaur!");
        }
        public void Attack()
        {
            Console.WriteLine($"{givenName} used {attackName}!");
        }

        public void Eats()
        {
            Console.WriteLine($"{givenName} ate an {foodType}!");
        }

        public void HasType()
        {
            Console.WriteLine($"{givenName}'s types are {typeOne} and {typeTwo}!");
        }

        public void Recovers()
        {
            Console.WriteLine($"{givenName} recovered strength after eating the {foodType}");
        }

        public void Faints()
        {
            Console.WriteLine($"{givenName} fainted! Better take {givenName} to a Pokemon center as soon as the battle ends!");
        }

        public void WildPokemonAppears()
        {
            Console.WriteLine($"A {givenName} appeared! The startled Pokemon attacked!");
        }

        public Bulbasaur() //Default Constructor
        {
            givenName = "Wild Bulbasaur";
            attackName = "Razor Leaf";
            foodType = "Chesto Berry";
            typeOne = "Grass";
            typeTwo = "Poison";
        }

        public Bulbasaur(string givenName, string attackName, string foodType, string typeOne, string typeTwo) //1st Constructor
        {
            this.givenName = givenName;
            this.attackName = attackName;
            this.foodType = foodType;
            this.typeOne = typeOne;
            this.typeTwo = typeOne;
        }

    }

    class Squirtle
    {
        private string givenName;
        private string attackName;
        private string foodType;
        private string typeOne;

        public void Speak()
        {
            Console.WriteLine($"My name is {givenName} the Squirtle!");
        }
        public void Attack()
        {
            Console.WriteLine($"{givenName} used {attackName}!");
        }

        public void Eats()
        {
            Console.WriteLine($"{givenName} ate an {foodType}!");
        }

        public void HasType()
        {
            Console.WriteLine($"{givenName}'s type is {typeOne}!");
        }

        public void Recovers()
        {
            Console.WriteLine($"{givenName} recovered strength after eating the {foodType}");
        }

        public void Faints()
        {
            Console.WriteLine($"{givenName} fainted! Better take {givenName} to a Pokemon center as soon as the battle ends!");
        }

        public void WildPokemonAppears()
        {
            Console.WriteLine($"A {givenName} appeared! The startled Pokemon attacked!");
        }

        public Squirtle() //Default Constructor
        {
            givenName = "Wild Squirtle";
            attackName = "Water Gun";
            foodType = "Sitrus Berry";
            typeOne = "Water";
        }

        public Squirtle(string givenName, string attackName, string foodType, string typeOne) //1st Constructor
        {
            this.givenName = givenName;
            this.attackName = attackName;
            this.foodType = foodType;
            this.typeOne = typeOne;
        }

    }

    class Trainer
    {
        private string trainerName;
        private string trainerHomeTown;
        private int numberOfGymBadges;

        public void Speak()
        {
            Console.WriteLine($"My name is {trainerName} from {trainerHomeTown}! I have {numberOfGymBadges} Gym Badges but I wanna be the very best, like no one ever was!");
        }

        public void CatchPokemon(string pokeballType, string pokemonType)
        {
            Console.WriteLine($"{trainerName} threw a {pokeballType} and caught a {pokemonType}!");
        }

        public void ChoosePokemon(string pokemonName)
        {
            Console.WriteLine($"{pokemonName}, I choose you!");
        }

        public void ChallengeTrainer(string opponentName)
        {
            Console.WriteLine($"{opponentName}, I challenge you to a battle!");
        }

        public void AcceptChallenge(string opponentName)
        {
            Console.WriteLine($"You really think you can beat me, {opponentName}? You're on!");
        }

        public Trainer() //Default Constructor
        {
            trainerName = "Bird Keeper Toby";
            trainerHomeTown = "Ekruteak City";
            numberOfGymBadges = 3;
        }

        public Trainer(string trainerName, string trainerHomeTown, int numberOfGymBadges) //1st Constructor
        {
            this.trainerName = trainerName;
            this.trainerHomeTown = trainerHomeTown;
            this.numberOfGymBadges = numberOfGymBadges;
        }
    }


}
