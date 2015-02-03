using System;
using System.Numerics;

//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

namespace _18.TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());
            BigInteger sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum *= i;             
            }

            string sumToString = sum.ToString();
            int count = 0;

            for (int i = sumToString.Length - 1; i >= 0; i--)
            {
                if (sumToString[i] == '0')
                {
                    count++;                   
                }
                if (count != 0 && sumToString[i] != '0')
                {
                    break;                    
                }
            }

            Console.WriteLine(count);
        }
    }
}
