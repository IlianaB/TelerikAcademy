using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("The radius of the circle is: ");
            double r = Double.Parse(Console.ReadLine());
            double diameter = 2 * r;

            Console.WriteLine("The perimeter of the circle is {0:0.00}", Math.PI * diameter);
            Console.WriteLine("The area of the circle is {0:0.00}", Math.PI * Math.Pow(r, 2));
        }
    }
}
