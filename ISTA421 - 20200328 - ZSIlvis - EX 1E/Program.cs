using System;
using System.Collections.Generic;
using System.Linq;

namespace ISTA421___20200328___ZSIlvis___EX_1E
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Base Number Conversion: Binary, Octal, and Decimal.\n");
            Console.WriteLine("Please enter the number to convert (note: binary numbers must have 8 bits, no more and no less):\n");
            string inputNumber = Console.ReadLine();
            Console.WriteLine( "Please enter the base of the number you entered: [ 2 | 8 | 10 ].\n");
            string inputBase = Console.ReadLine();
            int baseNumber = int.Parse(inputBase);
            Console.WriteLine($"\nNumber: {inputNumber}, base: {baseNumber}.\n");
            if(baseNumber == 10 )
            {
                Console.WriteLine($"Decimal to binary conversion is: {DecimalToBinary(inputNumber)}.");
                Console.WriteLine($"Decimal to octal conversion is: {DecimalToOctal(inputNumber)}.");
            }
            else if(baseNumber == 2)
            {
                Console.WriteLine($"Binary to octal conversion is {BinaryToOctal(inputNumber)}");
                Console.WriteLine($"Binary to decimal conversion is {BinaryToDecimal(inputNumber)}");
            }
            else if (baseNumber == 8)
            {
                Console.WriteLine($"Octal to binary conversion is:\n");
                OctalToBinary(inputNumber);
                Console.WriteLine($"\n\nOctal to decimal conversion is: {OctalToDecimal(inputNumber)}");
            }
            else
                Console.WriteLine("Error in base to convert from");
        }
        public static string BinaryToOctal(string inputNumber)
        {
            string binToOct = "";
            List<int> binDigits = new List<int>(); 
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] == '1')
                {
                    binDigits.Add(1);
                }
                else if (inputNumber[i] == '0')
                {
                    binDigits.Add(0);
                }
            }
            string firstOct = Convert.ToString(binDigits[0] * 2 + binDigits[1] * 1);
            string secondOct = Convert.ToString(binDigits[2] * 4 + binDigits[3] * 2 + binDigits[4] * 1);
            string thirdOct = Convert.ToString(binDigits[5] * 4 + binDigits[6] * 2 + binDigits[7] * 1);
            binToOct += firstOct;
            binToOct += secondOct;
            binToOct += thirdOct;
            return binToOct;
        }
        public static int BinaryToDecimal(string inputNumber)
        {
            int binToDec = 0;
            List<int> binDigits = new List<int>();
            List<int> powerList = new List<int>() { 128, 64, 32, 16, 8, 4, 2, 1};
            for (int i = 0; i < inputNumber.Length; i++)
            {
                if (inputNumber[i] == '1')
                {
                    binDigits.Add(1);
                }
                else if (inputNumber[i] == '0')
                {
                    binDigits.Add(0);
                }
            }
            for (int i = 0; i < binDigits.Count; i++)
            {
                binToDec += binDigits[i] * powerList[i];
            }
            return binToDec;
        }
        public static void OctalToBinary(string inputNumber)
        {
            string[] octToBin = new string[inputNumber.Length];
            char[] octalArray = inputNumber.ToCharArray();
            for (int i = 0; i < octalArray.Length; i++)
            {
                string binaryEquivalent="";
                switch (octalArray[i])
                {
                    case '0':
                        binaryEquivalent = "000";
                        break;
                    case '1':
                        binaryEquivalent = "001";
                        break;
                    case '2':
                        binaryEquivalent = "010";
                        break;
                    case '3':
                        binaryEquivalent = "011";
                        break;
                    case '4':
                        binaryEquivalent = "100";
                        break;
                    case '5':
                        binaryEquivalent = "101";
                        break;
                    case '6':
                        binaryEquivalent = "110";
                        break;
                    case '7':
                        binaryEquivalent = "111";
                        break;
                    default:
                        Console.WriteLine("Error - highest allowable octal digit is 7.");
                        break;
                }
                octToBin[i] = binaryEquivalent;
            }
            foreach (string str in octToBin)
            {
                Console.Write($"{str}");
            }
        }
        public static double OctalToDecimal(string inputNumber)
        {
            int number = Convert.ToInt32(inputNumber);
            double octToDec = 0;
            int[] octalIntArray = new int[inputNumber.Length];
            for (int i = 0; i < inputNumber.Length; i++)
            {
                octalIntArray[inputNumber.Length - 1 - i] = number % 10;
                number /= 10;
            }           
            for (int i = 0; i < octalIntArray.Length; i++)
            {
                octToDec += (Math.Pow(8, (octalIntArray.Length - 1 - i)) * octalIntArray[i]);
            }
            return octToDec;
        }
        public static string DecimalToBinary(string inputNumber)
        {
            int number = int.Parse(inputNumber);
            string binToDec ="";
            List<int> binDigits = new List<int>();
            do
            {
                int lastDigit = number % 2;
                number /= 2;
                binDigits.Add(lastDigit);
            } while (number>0);
            for (int i = (binDigits.Count-1); i >= 0; i--)
            {
                binToDec += binDigits[i];
            }
            return binToDec;
        }
        public static string DecimalToOctal(string inputNumber)
        {
            int number = int.Parse(inputNumber);
            string decToOct = "";
            List<int> octalDigits = new List<int>();
            do
            {
                int lastDigit = number % 8;
                number /= 8;
                octalDigits.Add(lastDigit);
            } while (number>0);
            for (int i = (octalDigits.Count)-1; i >= 0; i--)
            {
                decToOct += octalDigits[i];
            }
            return decToOct;
        }
    }
}
