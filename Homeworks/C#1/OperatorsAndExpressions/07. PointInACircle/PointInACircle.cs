using System;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double radius = 2;
            Console.Write("x of the circle is: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y of the circle is: ");
            double y = Double.Parse(Console.ReadLine());
            bool givenPoint = (x * x + y * y) <= radius * radius;

            Console.WriteLine(givenPoint);
        }
    }
}
