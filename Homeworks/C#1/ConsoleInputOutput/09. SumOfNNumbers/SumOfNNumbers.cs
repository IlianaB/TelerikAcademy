using System;

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Write a positive integer: ");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Write a number: ");
                int a = Int32.Parse(Console.ReadLine());
                sum += a;
            }

            Console.WriteLine(sum);
        }
    }
}
