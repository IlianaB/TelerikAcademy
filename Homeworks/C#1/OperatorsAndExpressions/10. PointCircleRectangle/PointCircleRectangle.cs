using System;
using System.Threading;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            double radius = 1.5d;
            Console.Write("x of the circle is: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("y of the circle is: ");
            double y = Double.Parse(Console.ReadLine());

            bool InsideCircle = ((x - 1)*(x - 1) + (y - 1)*(y - 1)) <= radius * radius;
            bool InsideRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            if ((InsideCircle && InsideRectangle) || (!InsideCircle && !InsideRectangle) || (!InsideCircle && InsideRectangle))
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}
