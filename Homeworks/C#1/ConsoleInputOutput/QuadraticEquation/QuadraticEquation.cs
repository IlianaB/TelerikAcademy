using System;

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Write a real number: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Write a real number: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Write a real number: ");
            double c = Double.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a *c;


            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }

            if (discriminant == 0)
            {
                Console.WriteLine("x1=x2={0}", (-b / (2 * a)));
            }

            if (discriminant > 0)
            {
                Console.WriteLine("x1={0}; x2={1}", ((-b - Math.Sqrt(discriminant)) / (2 * a)), ((-b + Math.Sqrt(discriminant)) / (2 * a)));
            }
        }
    }
}
