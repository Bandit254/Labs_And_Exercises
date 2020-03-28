using System;

namespace ISTA421___20200328___ZSilvis___EX_1A__Using_Properties_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Re-factor an earlier exercise to use properties instead of public fields.\n");
            PokemonJourney();
        }

        public static void PokemonJourney()
        {
            //Object Instantiation
            Pikachu pikachu = new Pikachu();
            Trainer ash = new Trainer("Ash", "Pallet Town", 0);
            Trainer defaultTrainer = new Trainer();
        
            //Story
            ash.Speak();
            Console.WriteLine("\n");
            pikachu.WildPokemonAppears();
            pikachu.Attack();
            ash.CatchPokemon("Poke Ball", "Pikachu");
            pikachu.HasType();
            Console.WriteLine("Alright! I caught a Pikachu! I'm going to call you Sparky!");
            pikachu.GivenName = "Sparky";
            Console.WriteLine("\n");
            Console.WriteLine($"Let's see what your Pokemon ID number is...oh, it's {pikachu.IdNumber}, got it!");
            Console.WriteLine($"{pikachu.GivenName} joined Ash's team!\n");
            Console.WriteLine("\n");
            Console.WriteLine($"{pikachu.GivenName}, I'm going to give you some food to recover from our battle.");
            pikachu.Eats();
            Console.WriteLine("Oh no! That was my last Oran Berry, but you're clearly still hungry. How about a Sitrus Berry?");
            pikachu.FoodType = "Sitrus Berry";
            pikachu.Eats();
            Console.WriteLine("\n");
            Console.WriteLine("Good! I'm glad you liked those Sitrus Berries! Now, let's teach you a stronger attack! Instead of Thunder Shock, you can now use Thunder Bolt!");
            pikachu.AttackName = "Thunder Bolt";
            pikachu.Attack();
            Console.WriteLine("Now you've gotten the hang of it! Let's challenge a gym leader now!");
            Console.WriteLine("\n");
            defaultTrainer.Speak();
            ash.ChallengeTrainer(defaultTrainer.TrainerName);
            Console.WriteLine($"Just wait a number there, {ash.TrainerName}. Firs I need to know what your trainer ID is to make sure it's valid. It must be between 2,000 and 20,000.");
            Console.WriteLine($"My trainer ID is {ash.TrainerID}. Happy now???");
            Console.WriteLine("Yes, we can battle now! ");
            Console.WriteLine("\n");
            defaultTrainer.AcceptChallenge(ash.TrainerName);
            Console.WriteLine("You'll never beat me and my bird Pokemon! Go. Pidgeotto!");
            ash.ChoosePokemon(pikachu.GivenName);
            Console.WriteLine($"{pikachu.GivenName}, use that new move I showed you!");
            pikachu.Attack();
            Console.WriteLine($"Great hit, {pikachu.GivenName}! That super-effective move made {defaultTrainer.TrainerName}'s Pidgeotto faint! We won!");
            Console.WriteLine($"Congratulations, {ash.TrainerName}. Let me give you a gym badge.");
            ash.NumberOfGymBadges = 1;
            Console.WriteLine($"Alright! Thanks for the great battle, {defaultTrainer.TrainerName}! I may only have {ash.NumberOfGymBadges} gym badge, but I will someday defeat the Elite Four with my best friend {pikachu.GivenName}!");
        }
      
        class Pikachu
        {
            private string _givenName;
            private string _attackName;
            private string _foodType;
            private string _typeOne;
            private int _idNumber;
            //Read-only ID Number Property:
            public int IdNumber
            {
                get { return this._idNumber; }
            }
            public string GivenName
            {
                get { return this._givenName; }
                set { this._givenName = value; }
            }
            public string FoodType
            {
                get { return this._foodType; }
                set { this._foodType = value; }
            }
            public string AttackName
            {
                get { return this._attackName; }
                set { this._attackName = value; }
            }
            public string TypeOne
            {
                get { return this._typeOne; }
                set { this._typeOne = value; }
            }
            public void Speak()
            {
                Console.WriteLine($"My name is {GivenName} the Pikachu!");
            }
            public void Attack()
            {
                Console.WriteLine($"{GivenName} used {AttackName}!");
            }
            public void Eats()
            {
                Console.WriteLine($"{GivenName} ate an {FoodType}!");
            }
            public void HasType()
            {
                Console.WriteLine($"{GivenName}'s type is {TypeOne}!");
            }
            public void Recovers()
            {
                Console.WriteLine($"{GivenName} recovered strength after eating the {FoodType}");
            }
            public void Faints()
            {
                Console.WriteLine($"{GivenName} fainted! Better take {GivenName} to a Pokemon center as soon as the battle ends!");
            }
            public void WildPokemonAppears()
            {
                Console.WriteLine($"A {GivenName} appeared! The startled Pokemon attacked!");
            }
            public Pikachu() //Default Constructor
            {
                _givenName = "Wild Pikachu";
                _attackName = "Thundershock";
                _foodType = "Oran Berry";
                _typeOne = "Electric";
                Random r = new Random();
                _idNumber = r.Next(1000, 100001);
            }
            public Pikachu(string GivenName, string AttackName, string FoodType, string TypeOne) //1st Constructor
            {
                this._givenName = GivenName;
                this._attackName = AttackName;
                this._foodType = FoodType;
                this._typeOne = TypeOne;
                Random r = new Random();
                _idNumber = r.Next(1000, 100001);
            }
        }
 
        class Trainer
        {
            private string _trainerName;
            private string _trainerHomeTown;
            private int _numberOfGymBadges;
            private int _trainerIDNumber;
            //Read-only Trainer ID Property:
            public int TrainerID
            {
                get { return this._trainerIDNumber; }
            }
            public string TrainerName
            {
                get => this._trainerName;
                set => this._trainerName= value;
            }
            public string TrainerHomeTown
            {
                get => this._trainerHomeTown;
                set => this._trainerHomeTown = value;
            }
            public int NumberOfGymBadges
            {
                get => this._numberOfGymBadges;
                set => this._numberOfGymBadges = value;
            }

            public void Speak()
            {
                Console.WriteLine($"My name is {TrainerName} from {TrainerHomeTown}! I have {NumberOfGymBadges} Gym Badges but I wanna be the very best, like no one ever was!");
            }
        
            public void CatchPokemon(string pokeballType, string pokemonType)
            {
                Console.WriteLine($"{TrainerName} threw a {pokeballType} and caught a {pokemonType}!");
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
                _trainerName = "Bird Keeper Toby";
                _trainerHomeTown = "Ekruteak City";
                _numberOfGymBadges = 3;
                Random r = new Random();
                _trainerIDNumber = r.Next(2000, 20001);
            }
        
            public Trainer(string TrainerName, string TrainerHomeTown, int NumberOfGymBadges) //1st Constructor
            {
                this._trainerName = TrainerName;
                this._trainerHomeTown = TrainerHomeTown;
                this._numberOfGymBadges = NumberOfGymBadges;
                Random r = new Random();
                _trainerIDNumber = r.Next(2000, 20001);
            }
        }


    }
}
