using System;
using System.Net.NetworkInformation;

namespace Class1_Studio
{
    public class Circle
    {
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public static double Circumfernce(double radius)
        {
            double circumfernnce = 2 * Math.PI * radius;
            return circumfernnce;
        }

        public static double Diameter(double radius)
        {
            double diameter = 2 * radius;
            return diameter;
        }
    }
}
