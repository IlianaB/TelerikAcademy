using System;
using System.Threading;

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

namespace MultiplicationSign
{
    class MultiplicationSign
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
            sbyte count = 0;
            string sign = "";

            if (a < 0)
            {
                count++;
            }

            if (b < 0)
            {
                count++;
            }

            if (c < 0)
            {
                count++;
            }

            if (count % 2 != 0)
            {
                sign = "-";
            }
            else
            {
                sign = "+";
            }

            if (a == 0 || b == 0 || c == 0)
            {
                sign = "0";
            }

            Console.WriteLine(sign);
        }
    }
}