using System;

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.

namespace CalculateNXN
{
    class CalculateNXN
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write an integer: ");
            int x = Int32.Parse(Console.ReadLine());
            double sum = 1;
            int factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                sum += factorial / Math.Pow(x, i);
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
