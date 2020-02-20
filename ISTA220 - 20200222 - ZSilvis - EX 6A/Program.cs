using System;

namespace ISTA220___20200222___ZSilvis___EX_6A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISTA220 - 20200222 - ZSilvis - EX 6A\n");
            int[] arrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            
            //Part 1 - Calculating the Averages
            Console.WriteLine($"The average value of Array A is {AverageOfArray(arrayA)}\n");
            Console.WriteLine($"The average value of Array B is {AverageOfArray(arrayB)}\n");
            Console.WriteLine($"The average value of Array C is {AverageOfArray(arrayC)}\n");

            //Part 2 - Reversing an Array
            Console.WriteLine("\nArray A:");
            PrintArray(arrayA);
            Console.WriteLine("\nThe reverse of Array A: ");
            PrintArray(ReverseArray(arrayA));
            Console.WriteLine("\nArray B:");
            PrintArray(arrayB);
            Console.WriteLine("\nThe reverse of Array B: ");
            PrintArray(ReverseArray(arrayB));
            Console.WriteLine("\nArray C:");
            PrintArray(arrayC);
            Console.WriteLine("\nThe reverse of Array C: ");
            PrintArray(ReverseArray(arrayC));
            
            //Part 3 - Rotating Arrays
            Console.WriteLine("\n\nArray A shifted to the left by 2 spaces: ");
            PrintArray(RotateArray(arrayA, 2, "left"));
            Console.WriteLine("\n\nArray B shifted to the right by 2 spaces: ");
            PrintArray(RotateArray(arrayB, 2, "right"));
            Console.WriteLine("\n\nArray C shifted to the left by 4 spaces: ");
            PrintArray(RotateArray(arrayC, 4, "left"));
            //Part 4 - Sorting Arrays
            Console.WriteLine("\n\nThe Array C sorted: ");
            PrintArray(SortArray(arrayC));
            Console.WriteLine("\n");

        }
        public static double AverageOfArray(int[] inputArray)
        {
            double sumOfArray = 0.0;
            double numItems = inputArray.Length;
            foreach (int value in inputArray)
            {
                sumOfArray += value;
            }
            double avgOfArray = sumOfArray / numItems;
            return avgOfArray;
        }
        public static void PrintArray(int[] inputArray)
        {
            foreach(int value in inputArray)
            {
                Console.Write($"{value} ");
            }
        }
        public static int[] ReverseArray(int[] inputArray)
        {
            int numItems = inputArray.Length;
            int[] reverseArray = new int[numItems];
            for (int i = 0; i < numItems; i++)
            {
                reverseArray[i] = inputArray[numItems - 1 - i];
            }
            return reverseArray;
        }
        public static int[] RotateArray(int[] inputArray, int numPlaces, string direction)
        {
            int numItems = inputArray.Length;
            int[] rotatedArray = new int[numItems];

            if(direction=="right")
            {
                for (int i = 0; i < numItems; i++)
                {
                    if (i+numPlaces <= numItems-1)
                    {
                        rotatedArray[i + numPlaces] = inputArray[i];
                    }
                    else if (i+numPlaces > numItems-1)
                    {
                        rotatedArray[(i + numPlaces) - numItems] = inputArray[i];
                    }
                }
            }
            else if (direction == "left")
            {
                for (int j = 0; j < numItems; j++)
                {
                    if (j-numPlaces < 0)
                    {
                        rotatedArray[j - numPlaces + numItems] = inputArray[j];
                    }
                    else if (j - numPlaces >= 0)
                    {
                        rotatedArray[j - numPlaces] = inputArray[j];
                    }
                }
            }
            return rotatedArray;
        }
        public static int[] SortArray(int[] inputArray)
        {
            int placeHolder;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if (inputArray[i] < inputArray[j])
                    {
                        placeHolder = inputArray[i];
                        inputArray[i] = inputArray[j];
                        inputArray[j] = placeHolder;
                    }
                }
            }
            return inputArray;
        }

    }
}
