using System;
using System.Threading;

//Write a program that reads 3 real numbers from the console and prints their sum.

namespace SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Write a real number: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Write a real number: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Write a real number: ");
            double c = Double.Parse(Console.ReadLine());

            Console.WriteLine("The sum of the numbers is: " + (a + b + c));
        }
    }
}
