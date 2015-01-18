using System;

//Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

namespace ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            double b = Double.Parse(Console.ReadLine());
            double c = 0;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
            }

            Console.WriteLine(a + " " + b);
        }
    }
}
