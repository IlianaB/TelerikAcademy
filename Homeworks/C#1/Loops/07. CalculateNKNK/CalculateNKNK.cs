using System;
using System.Numerics;

//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) 
//for given n and k (1 < k < n < 100). Try to use only two loops.

namespace CalculateNKNK
{
    class CalculateNKNK
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer between 1 and 100: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write a smaller integer than the previous one: ");
            int k = Int32.Parse(Console.ReadLine());
            BigInteger numerator = 1;
            BigInteger denominator = 1;

            for (int i = n; i > k; i--)
            {
                numerator *= i;  
            }

            for (int i = n - k; i >= 1; i--)
            {
                denominator *= i;
            }

            Console.WriteLine(numerator / denominator);
        }
    }
}
