using System;

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

namespace MinMaxSumAndAverage
{
    class MinMaxSumAndAverage
    {
        static void Main(string[] args)
        {
            Console.Write("Write a positive integer: ");
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int temp = Int32.Parse(Console.ReadLine());
                sum += temp;

                if (temp < min)
                {
                    min = temp;
                }
                if (temp > max)
                {
                    max = temp;
                } 
            }

            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Sum: {0}", sum);
            Console.WriteLine("Average: {0:F2}", (decimal)sum / n);
        }
    }
}
