using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.Write("The lenght of side a is: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("The lenght of side b is: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("The hight of the trapezoid is: ");
            double h = Double.Parse(Console.ReadLine());

            Console.WriteLine("The are of the trapezoid is " + ((a + b) / 2) * h);
        }
    }
}
