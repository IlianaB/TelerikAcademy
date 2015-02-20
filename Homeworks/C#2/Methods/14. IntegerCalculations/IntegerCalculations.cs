using System;
using System.Linq;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

namespace _14.IntegerCalculations
{
    class IntegerCalculations
    {
        static int minimum = 0;
        static int maximum = 0;
        static decimal average = 0;
        static long sum = 0;
        static long product = 1;

        static void Main()
        {
            Console.Write("How many numbers do you want to use for the calculations: ");
            int numbers = int.Parse(Console.ReadLine());
            int[] numsArray = new int[numbers];

            Console.WriteLine("Write the numbers, each on a separate line: ");
            for (int i = 0; i < numbers; i++)
            {
                numsArray[i] = int.Parse(Console.ReadLine());
            }

            minimum = CalculateMinimum(numsArray);
            maximum = CalculateMaximum(numsArray);
            average = CalculateAverage(numsArray);
            sum = CalculateSum(numsArray);
            product = CalculateProduct(numsArray);

            Console.WriteLine("Minimum element = {0}", minimum);
            Console.WriteLine("Maximum element = {0}", maximum);
            Console.WriteLine("Average = {0}", average);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Product = {0}", product);

        }

        private static long CalculateProduct(int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                product *= numsArray[i];
            }
            return product;
        }

        private static long CalculateSum(int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                sum += numsArray[i];
            }
            return sum;
        }

        private static decimal CalculateAverage(params int[] numsArray)
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                average += numsArray[i];
            }
            average /= numsArray.Length;

            return average;
        }

        private static int CalculateMaximum(params int[] numsArray)
        {
            int max = numsArray.Max();
            return max;
        }

        private static int CalculateMinimum(params int[] numsArray)
        {
            int min = numsArray.Min();
            return min;
        }
    }
}
