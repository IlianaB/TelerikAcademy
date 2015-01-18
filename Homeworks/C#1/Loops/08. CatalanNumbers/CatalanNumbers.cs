using System;

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer between 1 and 100: ");
            decimal n = Decimal.Parse(Console.ReadLine());
            decimal catalan = 1;

            for (int i = 2; i <= n; i++)
            {
                catalan *= (n + i) / i;
            }

            Console.WriteLine(Decimal.Round(catalan, 0));
        }
    }
}
