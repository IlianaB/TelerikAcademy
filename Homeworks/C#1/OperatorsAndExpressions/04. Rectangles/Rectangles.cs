using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.Write("Write the width of the rectangle: ");
            double width = Double.Parse(Console.ReadLine());
            Console.Write("Write the height of the rectangle: ");
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter of the rectangle is: " + (2 * (width + height)));
            Console.WriteLine("The area of the rectangle is: " + (width * height));
        }
    }
}
