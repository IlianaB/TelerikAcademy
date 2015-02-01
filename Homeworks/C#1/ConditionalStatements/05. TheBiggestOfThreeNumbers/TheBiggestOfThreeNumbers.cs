using System;
using System.Threading;

//Write a program that finds the biggest of three numbers.

namespace TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Console.Write("Write a number: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double c = Double.Parse(Console.ReadLine());
            double biggestNumber = 0;

            biggestNumber = a >= b ? a : b;
            biggestNumber = biggestNumber >= c ? biggestNumber : c;

            Console.WriteLine("The biggest number is: " + biggestNumber);
        }
    }
}
