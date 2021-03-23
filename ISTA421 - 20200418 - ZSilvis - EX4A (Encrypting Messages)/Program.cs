using System;
using System.Collections.Generic;

namespace ISTA421___20200418___ZSilvis___EX4A__Encrypting_Messages_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Write a program that cleans and encrypts a given string using three different types of encryption keys.\n");
            //Console.Write("Enter a plain text message: ");
            //string input = Console.ReadLine();
            //string cleanedInput = CleanMessage(input);
            //Console.Write("Enter a simple encryption key (a single alphabetical character): ");
            //string simpleKey = Console.ReadLine();
            //Console.Write("Enter a multi-key (more than one alphabetical character, but less than the characters in the plain text message): ");
            //string multiKey = Console.ReadLine();
            //Console.WriteLine($"\n\nThe message you entered was '{input}'");
            //Console.WriteLine($"The simple encryption key you entered was '{simpleKey}'");
            //Console.WriteLine($"The multi-key you entered was '{multiKey}'\n");
            //string encryptedStringSimple = SimpleKeyEncryption(cleanedInput, simpleKey);
            //string encryptedMultiKey = MultiKeyEncryption(cleanedInput, multiKey);
            //string continuousKey = GenerateContinuousKey(cleanedInput, multiKey);
            //string continuousKeyMessage = ContinuousKeyEncryption(cleanedInput, continuousKey);
            //Console.WriteLine($"\nThe encrypted message using the simple key is '{encryptedStringSimple}'");
            //Console.WriteLine($"The encrypted message using the multi-key is: '{encryptedMultiKey}'");
            //Console.WriteLine($"The encrypted message using the continuous key is: '{continuousKeyMessage}.'\n");
            //string decryptedSimple = DecryptSimpleKey(encryptedStringSimple, simpleKey);
            //string decryptedMultiKey = DecryptedMultiKey(encryptedMultiKey, multiKey);
            //string decryptContinuousKey = DecryptContinuousKey(continuousKeyMessage, continuousKey);
            //Console.WriteLine($"\nThe decrypted message using the simple key is '{decryptedSimple}'");
            //Console.WriteLine($"The decrypted message using the multi-key is '{decryptedMultiKey}'");
            //Console.WriteLine($"The decrypted message using the continuous key is '{decryptContinuousKey}'");

            Console.Write("Enter the encrypted message: ");
            string encryptedInput = Console.ReadLine();
            string cleanedEncryptedInput = CleanMessageV2(encryptedInput);
            Console.WriteLine($" The cleaned messages is: '{cleanedEncryptedInput}'");
            string tryAgain = "y";
            while (String.Equals(tryAgain,"y"))
            {
                Console.Write("Enter the letter from the encrypted message that you want to make a guess about: ");
                string letterFromMessage = Console.ReadLine();
                Console.Write("Enter your guess for what the letter from the encrypted message actually represents: ");
                string guessedLetter = Console.ReadLine();
                string decryptionGuess = DecryptionGuessSimpleKey(cleanedEncryptedInput, letterFromMessage, guessedLetter);
                Console.WriteLine($"Based on your guess that '{letterFromMessage}' in the encrypted message is actually '{guessedLetter}', the decrypted message is: {decryptionGuess}\n");
                Console.WriteLine("Does the decrypted message make sense? If you want to try again, enter 'y'. If you guess the message correctly, then enter 'n': ");
                tryAgain = Console.ReadLine();
                tryAgain = tryAgain.ToLower();
            }
            //Console.Write("Enter the letter from the encrypted message that you want to make a guess about: ");
            //string letterFromMessage = Console.ReadLine();
            //Console.Write("Enter your guess for what the letter from the encrypted message actually represents: ");
            //string guessedLetter = Console.ReadLine();
            //string decryptionGuess = DecryptionGuessSimpleKey(cleanedEncryptedInput, letterFromMessage, guessedLetter);
            //Console.WriteLine($"Based on your guess that '{letterFromMessage}' in the encrypted message is actually '{guessedLetter}', the decrypted message is: {decryptionGuess}");
            //string decryptedMessage = DecryptSimpleKey(cleanedEncryptedInput, susSimpleKey);
            //Console.WriteLine($"\nThe decrypted message using the simple key is '{decryptedMessage}'");
        }
        public static string CleanMessage(string input)
        {
            string cleanedPTMessage = "";
            input = input.ToUpper();
            char[] inputCharArray = input.ToCharArray();
            List<char> cleanedCharList = new List<char>();
            for (int i = 0; i < inputCharArray.Length; i++)
            {
                if (inputCharArray[i]<=90 && inputCharArray[i]>=65)
                {
                    cleanedCharList.Add(inputCharArray[i]);
                }
            }
            for (int i = 0; i < cleanedCharList.Count; i++)
            {
                cleanedPTMessage += cleanedCharList[i];
            }
            return cleanedPTMessage;
        }

        public static string CleanMessageV2(string input)
        {
            input = input.ToUpper();
            return input;
        }
        public static string SimpleKeyEncryption(string input, string simpleKey)
        {
            string encryptedStringSimple = "";
            simpleKey = simpleKey.ToUpper();
            int numSpaces = Convert.ToChar(simpleKey) - 64;
            char[] inputCharArray = input.ToCharArray();
            for (int i = 0; i < inputCharArray.Length; i++)
            {
                char nextChar = Convert.ToChar(inputCharArray[i] + numSpaces);
                if (nextChar>90)
                {
                    nextChar = Convert.ToChar(nextChar - 26);
                }
                encryptedStringSimple += nextChar;
            }
            return encryptedStringSimple;
        }
        public static string DecryptSimpleKey(string encryptedMessage, string simpleKey)
        {
            string decryptedSimple = "";
            simpleKey = simpleKey.ToUpper();
            int numSpaces = Convert.ToChar(simpleKey) - 64;
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                char nextChar = Convert.ToChar(encryptedMessage[i] - numSpaces);
                if (nextChar < 65)
                {
                    nextChar = Convert.ToChar(nextChar + 26);
                }
                decryptedSimple += nextChar;
            }
            return decryptedSimple;
        }
        public static string DecryptionGuessSimpleKey(string encryptedMessage, string letterFromMessage, string guessedLetter)
        {
            string decryptedGuess = "";
            letterFromMessage = letterFromMessage.ToUpper();
            guessedLetter = guessedLetter.ToUpper();
            int numSpaces = (Convert.ToChar(guessedLetter) - Convert.ToChar(letterFromMessage));
            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if (encryptedMessage[i] <= 90 & encryptedMessage[i] >= 65)
                {
                    char nextChar = Convert.ToChar(encryptedMessage[i] + numSpaces);
                    if (nextChar < 65)
                    {
                        nextChar = Convert.ToChar(nextChar + 26);
                    }
                    else if (nextChar > 90)
                    {
                        nextChar = Convert.ToChar(nextChar - 26);
                    }
                    decryptedGuess += nextChar;
                }
                else
                {
                    decryptedGuess += encryptedMessage[i];
                }
            }
            return decryptedGuess;
        }
        public static string MultiKeyEncryption(string input, string multiKey)
        {
            string encryptedMultiKeyString = "";
            multiKey = multiKey.ToUpper();
            if (multiKey.Length>=input.Length)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int numSpaces = Convert.ToChar(multiKey[i]) - 64;
                    char nextChar = Convert.ToChar(input[i] + numSpaces);
                    if (nextChar > 90)
                    {
                        nextChar = Convert.ToChar(nextChar - 26);
                    }
                    encryptedMultiKeyString += nextChar;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                int numSpaces = Convert.ToChar(multiKey[i - ((i / multiKey.Length) * multiKey.Length)]) - 64;
                char nextChar = Convert.ToChar(input[i] + numSpaces);
                if (nextChar > 90)
                {
                    nextChar = Convert.ToChar(nextChar - 26);
                }
                encryptedMultiKeyString += nextChar;
            }
            return encryptedMultiKeyString;
        }
        public static string DecryptedMultiKey(string encryptedMultiKeyMessage, string multiKey)
        {
            string decryptedMultiKeyMessage = "";
            multiKey = multiKey.ToUpper();
            if (multiKey.Length >= encryptedMultiKeyMessage.Length)
            {
                for (int i = 0; i < encryptedMultiKeyMessage.Length; i++)
                {
                    int numSpaces = Convert.ToChar(multiKey[i]) - 64;
                    char nextChar = Convert.ToChar(encryptedMultiKeyMessage[i] - numSpaces);
                    if (nextChar < 65)
                    {
                        nextChar = Convert.ToChar(nextChar + 26);
                    }
                    decryptedMultiKeyMessage += nextChar;
                }
            }
            for (int i = 0; i < encryptedMultiKeyMessage.Length; i++)
            {
                int numSpaces = Convert.ToChar(multiKey[i - ((i / multiKey.Length) * multiKey.Length)]) - 64;
                char nextChar = Convert.ToChar(encryptedMultiKeyMessage[i] - numSpaces);
                if (nextChar < 65)
                {
                    nextChar = Convert.ToChar(nextChar + 26);
                }
                decryptedMultiKeyMessage += nextChar;
            }
            return decryptedMultiKeyMessage;
        }
        public static string GenerateContinuousKey(string input, string multiKey)
        {
            string continuousKey = "";
            if (multiKey.Length > input.Length)
            {
                Console.WriteLine($"Error: Key length must be shorter than the message length. You must provide a key with a length less than {input.Length} characters long.\n");
                Console.Write("Enter a new key: ");
                multiKey = Console.ReadLine();
            }
            multiKey = multiKey.ToUpper();
            for (int i = 0; i < multiKey.Length; i++)
            {
                continuousKey += multiKey[i];
            }
            for (int i = 0; i < (input.Length - multiKey.Length); i++)
            {
                continuousKey += input[i];
            }

            return continuousKey;
        }
        public static string ContinuousKeyEncryption(string input, string continuousKey)
        {
            if (continuousKey.Length != input.Length)
            {
                return "Error - key and message length do not match";
            }
            string encryptedContinuousMessage = "";
            for (int i = 0; i < input.Length; i++)
            {
                int numSpaces = Convert.ToChar(continuousKey[i]) - 64;
                char nextChar = Convert.ToChar(input[i] + numSpaces);
                if (nextChar > 90)
                {
                    nextChar = Convert.ToChar(nextChar - 26);
                }
                encryptedContinuousMessage += nextChar;
            }
            return encryptedContinuousMessage;
        }
        public static string DecryptContinuousKey(string encryptedContinuousMessage, string continuousKey)
        {
            string decryptedContinuousMessage = "";
            for (int i = 0; i < encryptedContinuousMessage.Length; i++)
            {
                int numSpaces = Convert.ToChar(continuousKey[i]) - 64;
                char nextChar = Convert.ToChar(encryptedContinuousMessage[i] - numSpaces);
                if (nextChar < 65)
                {
                    nextChar = Convert.ToChar(nextChar + 26);
                }
                decryptedContinuousMessage += nextChar;
            }
            return decryptedContinuousMessage;
        }
    }
}
