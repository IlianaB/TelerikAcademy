//Problem 1. Shapes
//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface
//of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept 
//equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes 
//Square, Rectangle, Triangle) stored in an array.

namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;

    class ShapesTest
    {
        static void Main()
        {
            Shape[] shapesArray = {
                                      new Triangle(5, 6),
                                      new Rectangle(7, 10),
                                      new Square(4, 4)
                                  };

            foreach (var shape in shapesArray)
            {
                Console.Write("{0} area: ", shape.GetType().Name);
                Console.WriteLine("{0} cm.", shape.CalculateSurface());
            }
        }
    }
}
