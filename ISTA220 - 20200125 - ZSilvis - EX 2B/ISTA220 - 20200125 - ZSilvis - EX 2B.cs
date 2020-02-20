using System;

namespace ISTA220___20200125___ZSilvis___EX_2B
{
    class Program
    {
        /*
        "Stntactic Sugar" to me is a method of accounting for all of the possible ways (or at least as many as we can think of) that a user might either mess up the input of a method or of the different ways that they might need to use the method.
        Instead of writing separate methods for each possible way a user might need to implement a method, we can use overload techniques to account for those possible use cases (or misuse) all at once.
        Overload methods also help keep naming conventions standardized and understandable.
        */


        //The following method takes up to four optional side lengths as arguments and returns the circumference of the sides and the type of shape that the sides make.
        public static (int, string) CircumferenceOfShapes(int sideOne = 0, int sideTwo = 0, int sideThree = 0, int sideFour = 0)
        {
            int circumference = sideOne + sideTwo + sideThree + sideFour;
            string shape = "Undefined";

            if (sideOne !=0 && sideTwo == 0 && sideThree == 0 && sideFour == 0)
            {
                shape = "Line";
            }
            else if (sideOne != 0 && sideTwo != 0 && sideThree == 0 && sideFour == 0)
            {
                shape = "Angle";
            }
            else if (sideOne != 0 && sideTwo != 0 && sideThree != 0 && sideFour == 0)
            {
                shape = "Triangle";
            }
            else if (sideOne != 0 && sideTwo != 0 && sideThree != 0 && sideFour != 0)
            {
                shape = "Rectangle";
            }
            else
            {
                shape = "non-existant shape";
            }

            return (circumference, shape);
        }
        //The following method recives three side lengths as required values and returns the circumference of the shape
        public static (int, string) CircumferenceOfShapes(int sideOne, int sideTwo, int sideThree)
        {
            sideOne = 0;
            sideTwo = 0;
            sideThree = 0;
            int circumference = sideOne + sideTwo + sideThree;
            string shape = "Undefined";

            if (sideOne != 0 && sideTwo == 0 && sideThree == 0)
            {
                shape = "Line";
            }
            else if (sideOne != 0 && sideTwo != 0 && sideThree == 0)
            {
                shape = "Angle";
            }
            else if (sideOne != 0 && sideTwo != 0 && sideThree != 0)
            {
                shape = "Triangle";
            }
            else
            {
                shape = "non-existant shape";
            }

            return (circumference, shape);
        }
        //The following method recives two side lengths as required values and returns the circumference of the shape
        public static (int, string) CircumferenceOfShapes(int sideOne, int sideTwo)
        {
            sideOne = 0;
            sideTwo = 0;
            int circumference = sideOne + sideTwo;
            string shape = "Undefined";

            if (sideOne != 0 && sideTwo == 0)
            {
                shape = "Line";
            }
            else if (sideOne != 0 && sideTwo != 0)
            {
                shape = "Angle";
            }
            else
            {
                shape = "non-existant shape";
            }

            return (circumference, shape);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("ISTA220 - 20200125 - ZSilvis - EX 2B");
            Console.WriteLine("Input the lengths of the sides of a shape (1-4 sides) to calculate the circumference/length of that shape. If your shape has less than 4 sides, enter zero for the sides that don't exist");
            int sideOne = Convert.ToInt32((Console.ReadLine()));
            int sideTwo = Convert.ToInt32(Console.ReadLine());
            int sideThree = Convert.ToInt32(Console.ReadLine());
            int sideFour = Convert.ToInt32(Console.ReadLine());
            int circumference = 0;
            string shape = "Undefined";
            (circumference, shape) = CircumferenceOfShapes(sideOne, sideTwo, sideThree, sideFour);

            Console.WriteLine($"\n\tThe circumference of your {shape} is {circumference}");
        }

    }
}
