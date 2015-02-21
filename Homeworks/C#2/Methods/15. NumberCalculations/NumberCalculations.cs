using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
//Use generic method (read in Internet about generic methods in C#).

namespace _15.NumberCalculations
{
    class NumberCalculations
    {
        static void Main(string[] args)
        {
            var minimum = CalculateMinimum(1, 2, 3, 4, 5, 6);
            var maximum = CalculateMaximum(1.2, 1.3, 1.4, 1.5, 1.6);
            var average = CalculateAverage(2, 3, 2.2, 3, 4);
            var sum = CalculateSum(1, 2, 3, 4, 5, 6);
            var product = CalculateProduct(1, 2.5, 2.0, 3.0);

            Console.WriteLine("Minimum element = {0}", minimum);
            Console.WriteLine("Maximum element = {0}", maximum);
            Console.WriteLine("Average = {0}", average);
            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Product = {0}", product);
        }

        private static T CalculateProduct<T>(params T[] numsArray) where T : IComparable<T>
        {
            dynamic product = numsArray[0];

            for (int i = 1; i < numsArray.Length; i++)
            {
                product *= numsArray[i];
            }
            return product;
        }

        private static T CalculateSum<T>(params T[] numsArray) where T : IComparable<T>
        {
            return numsArray.Aggregate<T, dynamic>(0, (current, t) => current + t);
        }

        private static T CalculateAverage<T>(params T[] numsArray) where T : IComparable<T>
        {
            dynamic averageSum = numsArray.Aggregate<T, dynamic>(0, (current, t) => current + t);

            return averageSum / numsArray.Length;
        }

        private static T GetMax<T>(params T[] numsArray) where T : IComparable<T>
        {
            int maxIndex = 0;
            for (int i = 1; i < numsArray.Length; i++)
            {
                if (numsArray[i].CompareTo(numsArray[maxIndex]) == 1) maxIndex = i;
            }
            return numsArray[maxIndex];
        }

        private static T CalculateMaximum<T>(params T[] numbers) where T : IComparable<T>
        {
            int maxIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i].CompareTo(numbers[maxIndex]) == 1) maxIndex = i;
            }

            return numbers[maxIndex];
        }

        private static T CalculateMinimum<T>(params T[] numsArray) where T : IComparable<T>
        {
            dynamic minimum = numsArray[0];

            for (int i = 0; i < numsArray.Length; i++)
            {
                if (numsArray[i] < minimum)
                {
                    minimum = numsArray[i];
                }
            }
            return minimum;
        }
    }
}