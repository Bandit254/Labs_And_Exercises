using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ISTA421___20200509___ZSilvis___EX7A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading and Parsing Comma-Separated Values (CSV):\n");
            List<string> myList = new List<string>();
            string input1 = "\"a,b\",c";
            string input2 = "\"Obama, Barack\",\"August 4, 1961\",\"Washington, D.C.\"";
            string input3 = "\"Ft. Benning, Georgia\",32.3632N,84.9493W," + "\"Ft. Stewart, Georgia\",31.8691N,81.6090W," + "\"Ft. Gordon, Georgia\",33.4302N,82.1267W";
            myList.Add(input1);
            myList.Add(input2);
            myList.Add(input3);
            foreach (string input in myList)
            {
                Console.WriteLine($"Current input is {input}");
                List<string> output = GetCSV(input);
                int numFields = output.Count;
                Console.WriteLine($"This line has {numFields} fields. They are:\n");
                foreach (string s in output)
                {
                    Console.WriteLine($"{s}\n");
                };
            }
        }
        public static List<string> GetCSV(string input)
        {
            string pattern = "[\"-\"]";
            string[] result = Regex.Split(input, pattern, RegexOptions.IgnoreCase);
            List<string> output = new List<string>();
            for (int i = 0; i < result.Length; i++)
            {
                string currentString = result[i];
                if (String.IsNullOrEmpty(currentString))
                {
                    continue;
                }
                if (Char.Equals(currentString[0], ',') || Char.Equals(currentString[currentString.Length - 1], ','))
                {
                    string[] intResults = currentString.Split(',');
                    foreach (string s in intResults)
                    {
                        if (!String.IsNullOrEmpty(s))
                        {
                            output.Add(s);
                        }
                    }
                }
                else
                {
                    output.Add(currentString);
                }
            }
            return output;
        }
    }
}
