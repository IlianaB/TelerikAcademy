using System;
using System.Threading;

//Write a program that finds the biggest of five numbers by using only five if statements.

namespace TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
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
            Console.Write("Write a number: ");
            double d = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double e = Double.Parse(Console.ReadLine());
            double biggestNumber = a;

            if (biggestNumber <= b)
            {
                biggestNumber = b;
            }
            if (biggestNumber <= c)
            {
                biggestNumber = c;
            }
            if (biggestNumber <= d)
            {
                biggestNumber = d; 
            }
            if (biggestNumber <= e)
            {
                biggestNumber = e;
            }

            Console.WriteLine("The biggest number is: " + biggestNumber);
        }
    }
}
