using System;

namespace Class1_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            //double area;
            //double circumference;
            //double diameter;
            double test;
            double milesPerGallon;
            double gallons;
            string input;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);

            //area = Math.PI * radius * radius;

            //Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.AreaOfCircle(radius));

            //circumference = 2 * Math.PI * radius;
            Console.WriteLine("The cicumference of a circle of radius " + radius + " is: " + Circle.Circumfernce(radius));

            //diameter = 2 * radius;
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + Circle.Diameter(radius));

            Console.WriteLine("Enter your Miles per Gallon: ");
            input = Console.ReadLine();
            milesPerGallon = double.Parse(input);

            gallons = Circle.Circumfernce(radius) / milesPerGallon;
            Console.WriteLine("It will take " + gallons + " gallons of fuel to go around the circle.");

        }
    }
}
