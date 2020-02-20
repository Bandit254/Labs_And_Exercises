using System;

namespace ISTA220___20200201___ZSilvis___EX_3D
{
    class Program
    {

        public static void CircumferenceOfCirlce()
        {
            try
            {
                Console.Write("Please input a value for the radius, then press any key to calculate the circumference of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.Write("Please input a positive, non-zero value for the radius ");
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                double circumference = 2 * Math.PI * radius;
                Console.WriteLine($"\nThe circumference is {circumference}");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"Incorrect input parameters (radius must be a positive number, and cannot contain ltters/symbols:\n {fEx}");
            }
        }

        public static void AreaOfCircle()
        {
            try
            {
                Console.Write("Please input a value for the radius, then press any key to calculate the area of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.Write("Please input a positive, non-zero value for the radius ");
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                double area = Math.PI * (Math.Pow(radius, 2));
                Console.WriteLine($"\nThe area is {area}");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"Incorrect input parameters (radius must be a positive number, and cannot contain ltters/symbols:\n {fEx}");
            }

        }

        public static void VolumeOfSphere()
        {
            try
            {
                Console.Write("Please input a value for the radius, then press any key to calculate the volume of the sphere: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                if (radius <= 0)
                {
                    Console.Write("Please input a positive, non-zero value for the radius ");
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                double volume = ((4 / 3) * Math.PI * (Math.Pow(radius, 3)) / 2);
                Console.WriteLine($"\nThe volume is {volume}");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"Incorrect input parameters (radius must be a positive number, and cannot contain ltters/symbols:\n {fEx}");
            }

        }

        public static void AreaOfTriangle()
        {
            try
            {
                Console.WriteLine("\nNow please enter an integer value for the first leg of a triangle:");
                int firstLeg = Convert.ToInt32(Console.ReadLine());
                if (firstLeg <= 0)
                {
                    Console.Write("Please input a positive, non-zero value for the leg ");
                    firstLeg = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nAnd now enter an integer value for the second leg of the triangle:");
                int secondLeg = Convert.ToInt32(Console.ReadLine());
                if (secondLeg <= 0)
                {
                    Console.Write("Please input a positive, non-zero value for the leg ");
                    secondLeg = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nFinally please enter an integer value for the last leg of a triangle:");
                int thirdLeg = Convert.ToInt32(Console.ReadLine());
                if (thirdLeg <= 0)
                {
                    Console.Write("Please input a positive, non-zero value for the leg ");
                    thirdLeg = Convert.ToInt32(Console.ReadLine());
                }
                double p = ((firstLeg + secondLeg + thirdLeg) / 2);
                Console.WriteLine($"\nThe value of P is {p}");
                double areaTriangle = Math.Sqrt(p * ((p - firstLeg) * (p - secondLeg) * (p - thirdLeg)));
                Console.WriteLine($"\nThe area of the triangle is {areaTriangle}");
                Console.WriteLine("\nIf the area of the triangle is evaluated to be either 0 or negative, aka NaN, that means the values you entered for the legs of the triangle would not connect in real life.");
            }
            catch (FormatException fEx)
            {
                Console.WriteLine($"Incorrect input parameters (radius must be a positive number, and cannot contain ltters/symbols:\n {fEx}");
            }
        }

        public static void QuadraticEquation()
        {
            try
            {
                Console.WriteLine("\n Now we will solve a quadratic equation. Start by entering a value for the first constant, a.");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n Enter a positive value for the second constant, b. For the sake of getting real numbers as solutions, try to make the value of b significantly larger than the other two constants or make c zero:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\n Finally, enter a positive value for the third and final constant, c.");
                double c = Convert.ToDouble(Console.ReadLine());
                double x1 = ((-1 * b) + Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);
                double x2 = ((-1 * b) - Math.Sqrt((Math.Pow(b, 2)) - (4 * a * c))) / (2 * a);
                Console.WriteLine($"\n The value of the first intercept is {x1}");
                Console.WriteLine($"\n The value of the second intercept is {x2}");
                Console.WriteLine("\n Note that is either of the solutions is NaN then that means the function tried to take the square root of a negative number, which is not possible in this context. More specifically, if the value of b-squared is smaller than 4*a*c the solution will result in NaN.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of the numerator by zero. The constant 'a' must be non-zero.");
            }
            finally
            {
                if (1 == 1)
                {
                    Console.WriteLine("\n\n\tYou are at the end of this exercise");
                }
            }
        }


            static void Main(string[] args)
            {
                Console.WriteLine("ISTA220 - 20200201 - ZSilvis - EX 3D (Exception Handling and Mathematical Formulas)");

                CircumferenceOfCirlce();
                AreaOfCircle();
                VolumeOfSphere();
                AreaOfTriangle();
                QuadraticEquation();



            }
        
    }
}
