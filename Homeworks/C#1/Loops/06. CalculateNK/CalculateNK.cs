using System;
using System.Numerics;

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

namespace CalculateNK
{
    class CalculateNK
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer between 1 and 100: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write a smaller integer than the previous one: ");
            int k = Int32.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = n; i > k; i--)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
