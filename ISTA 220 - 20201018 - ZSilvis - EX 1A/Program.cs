using System;

namespace ISTA_220___20201018___ZSilvis___EX_1A
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello World! This is my math homework!");

            //Calculating the circumference of a circle (assuming positive values for the radius)

            Console.WriteLine("Please input a positive value for the radius, then press any key to calculate the circumference, area, and volume:");
            double radius = Convert.ToDouble(Console.ReadLine());

            double circumference = 2 * Math.PI * radius;

            Console.WriteLine($"The circumference is {circumference}");

            //Calculating the area of a circle (assuming positive values for the radius)

            double powerA = 2.0;
            double area = Math.PI * (Math.Pow(radius, powerA));

            Console.WriteLine($"The area is {area}");

            //Calculating the volume of a sphere
            double powerV = 3.0;
            double volume = ((4 /3 ) * Math.PI * (Math.Pow(radius, powerV)) / 2);

            Console.WriteLine($"The volume is {volume}");

            //Calculating the area of a triangle

            Console.WriteLine("Now please enter a positive integer value for the first leg of a trianle:");
            int firstLeg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("And now enter a positive integer value for the second leg of the trianle:");
            int secondLeg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finally please enter a positive integer value for the last leg of a trianle:");
            int thirdLeg = Convert.ToInt32(Console.ReadLine());

            double p = ((firstLeg + secondLeg + thirdLeg) / 2);

            Console.WriteLine($"The value of P is {p}");

            double areaTriangle = Math.Sqrt(p * ((p - firstLeg) * (p - secondLeg) * (p - thirdLeg)));

            Console.WriteLine($"The area of the triangle is {areaTriangle}");

            Console.WriteLine("If the area of the triangle is evaluated to be either 0 or negative, aka NaN, that means the values you entered for the legs of the triangle would not connect in real life.");

            //Solving a quadratic equation

            Console.WriteLine("\n Now we will solve a quadratic equation. Start by entering a positive value for the first constant, a. Note that putting zero for a will result in division by zero, which is equivalent to infinity");

            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Enter a positive value for the second constant, b. For the sake of getting real numbers as solutions, try to make the value of b significantly larger than the other two constants or make c zero:");

            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Finally, enter a positive value for the third and final constant, c. For another way to ensure real numbers as solutions,  make c zero:");

            double c = Convert.ToDouble(Console.ReadLine());

            double x1 = ((-1 * b) + Math.Sqrt((Math.Pow(b, powerA)) - (4 * a * c))) / (2 * a);

            double x2 = ((-1 * b) - Math.Sqrt((Math.Pow(b, powerA)) - (4 * a * c))) / (2 * a);

            Console.WriteLine($"\n The value of the first intercept is {x1}");

            Console.WriteLine($"\n The value of the second intercept is {x2}");

            Console.WriteLine("\n Note that is either of the solutions is NaN then that means the function tried to take the square root of a negative number, which is not possible in this context. More specifically, if the value of b-squared is smaller than 4*a*c the solution will result in NaN.");

        }
    }
}
