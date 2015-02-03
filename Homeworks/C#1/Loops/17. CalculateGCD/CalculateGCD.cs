using System;

//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = Int32.Parse(Console.ReadLine());
            int biggerNum = 0;

            biggerNum = Math.Max(a, b);

            for (int i = biggerNum; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }                
            }
        }
    }
}
