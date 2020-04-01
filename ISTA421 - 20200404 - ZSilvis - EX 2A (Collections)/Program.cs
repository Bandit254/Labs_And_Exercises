using System;
using System.Collections;
using System.Collections.Generic;

namespace ISTA421___20200404___ZSilvis___EX_2A__Collections_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with generic collections.\n");
            ListGeneration();
            LinkedListGeneration();
            QueueGeneration();
            StackGeneration();
            DictionaryGeneration();
            SortedListGeneration();
            HashSetGeneration();
        }

        public static void ListGeneration()
        {
            Console.WriteLine("Printing from a List of strings:");
            List<string> stringList = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                stringList.Add($"Hello x{i}");
            }
            foreach (string s in stringList)
            {
                Console.WriteLine($"{s}");
            }
            Console.WriteLine("\n");
        }
        public static void LinkedListGeneration()
        {
            Console.WriteLine("Printing from a Linked List of Integers");
            LinkedList<int> numLinkList = new LinkedList<int>();
            foreach (int x in new int[]{ 1,3,5,7,9})
            {
                numLinkList.AddFirst(x);
            }
            int counter = 1;
            for (LinkedListNode<int> node=numLinkList.First; node!=null;node=node.Next)
            {
                int x = node.Value;
                Console.WriteLine($"LinkedList Item {counter}: {x}");
                counter++;
            }
            Console.WriteLine("\n");
        }
        public static void QueueGeneration()
        {
            Console.WriteLine("Printing from a queue of strings.");
            Queue<string> stringQ = new Queue<string>();
            foreach (string s in new string[] { "Jim", "Bob", "Lil' Marry Bo Peep", "Ash Ketchum", "Darth Vader" })
            {
                stringQ.Enqueue(s);
                Console.WriteLine($"{s} has joined the party!");
            }
            Console.WriteLine("\n");
            while (stringQ.Count>0)
            {
                string s = stringQ.Dequeue();
                Console.WriteLine($"{s} has left the party!");
            }
            Console.WriteLine("\n");
        }
        public static void StackGeneration()
        {
            Console.WriteLine("Printing from a stack of doubles.");
            Stack<double> doubleStack = new Stack<double>();
            foreach (double d in new double[] { 3.14, 0.27, 54.54, 10000.1, 5.22 })
            {
                doubleStack.Push(d);
                Console.WriteLine($"{d} has been put on the stack.");
            }
            Console.WriteLine("\n");
            while (doubleStack.Count>0)
            {
                double d = doubleStack.Pop();
                Console.WriteLine($"{d} has been taken off the stack.");
            }
            Console.WriteLine("\n");
        }
        public static void DictionaryGeneration()
        {
            Console.WriteLine("Printing from a dictionary of places I have lived and their zip codes.");
            Dictionary<string, string> placesAndZips = new Dictionary<string, string>();
            placesAndZips.Add("San Diego, CA", "92123");
            placesAndZips.Add("Vilseck, Germany APO", "09112");
            placesAndZips.Add("Grafenwoehr, Germany APO", "09114");
            placesAndZips["Amberg, Germany"] = "92224";
            placesAndZips.Add("Erie, PA", "16508");
            foreach (KeyValuePair<string, string> element in placesAndZips)
            {
                string place = element.Key;
                string zip = element.Value;
                Console.WriteLine($"When I lived in {place} my zip code was {zip}");
            }
            Console.WriteLine("\n");
        }
        public static void SortedListGeneration()
        {
            Console.WriteLine("Printing from a sorted list of my school year and the pet that my family received that year.");
            SortedList<int, string> schoolPets = new SortedList<int, string>();
            schoolPets.Add(2, "Nigel (Black Lab)");
            schoolPets.Add(10, "Shiloh (Terrier Mix)");
            schoolPets.Add(11, "Rocky (White Boxer)");
            schoolPets.Add(0, "Rachel (Rat)");
            schoolPets.Add(6, "Two unremarkable hamsters");
            foreach (KeyValuePair<int, string> element in schoolPets)
            {
                int schoolYear = element.Key;
                string pet = element.Value;
                Console.WriteLine($"When I was in grade {schoolYear}, my family received {pet} as a new pet.");
            }
            Console.WriteLine("\n");
        }
        public static void HashSetGeneration()
        {
            Console.WriteLine("Printing from a hash set of all starter Pokemon from each generation of games.");
            HashSet<string> starterPokemon = new HashSet<string>(new string[] { "Bulbasaur", "Squirtle", "Charmander", "Chikorita", "Totodile", "Cyndaquil", "Treeko", "Mudkip", "Torchick", "Turtwig", "Piplup", "Chimchar", "Snivy", "Oshawott", "Tepig", "Chespin", "Froakie", "Fennekin", "Rowlett", "Poplio", "Litten", "Grookey", "Sobble", "Scorbunny" });
            foreach (string pokemon in starterPokemon)
            {
                Console.WriteLine($"{pokemon}");
            }
            Console.WriteLine("\n");
        }
    }
}
