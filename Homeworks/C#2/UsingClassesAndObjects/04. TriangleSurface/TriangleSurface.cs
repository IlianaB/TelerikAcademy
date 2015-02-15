using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static void Main()
        {
            Console.Write("side1 = ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("side2 = ");
            double side2 = double.Parse(Console.ReadLine());
            Console.Write("side3 = ");
            double side3 = double.Parse(Console.ReadLine());
            Console.Write("altitude = ");
            double altitude = double.Parse(Console.ReadLine());
            Console.Write("angle = ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine("The surface of a triangle with side1 = {0} and altitude = {1} is {2}.", side1, altitude, CalculateSurface(side1, altitude));
            Console.WriteLine("The surface of a triangle with side1 = {0}, side2 = {1} and side3 = {2} is {3}.", side1, side2, side3, CalculateSurface(side1, side2, side3));
            Console.WriteLine("The surface of a triangle with side1 = {0}, side2 = {1} and angle between them = {2} is {3}.", side1, side2, angle, CalculateSurface2(side1, side2, angle));
        }

        private static double CalculateSurface2(double side1, double side2, double angle)
        {
            double surface = 0;
            surface = 0.5 * side1 * side2 * Math.Sin(Math.PI * angle / 180);

            return surface;
        }

        private static double CalculateSurface(double side1, double side2, double side3)
        {
            double perimeter = 0;
            double surface = 0;

            perimeter = 0.5 * (side1 + side2 + side3);
            surface = Math.Sqrt((perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3)));

            return surface;
        }

        private static double CalculateSurface(double side1, double altitude)
        {
            double surface = 0;
            surface = side1 * 0.5 * altitude;

            return surface;
        }
    }
}
