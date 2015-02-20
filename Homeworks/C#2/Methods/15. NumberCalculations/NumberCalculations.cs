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
            Console.Write("How many numbers do you want to use for the calculations: ");
            int numbers = int.Parse(Console.ReadLine());
            dynamic[] numsArray = new dynamic[numbers];

            Console.WriteLine("Write the numbers, each on a separate line: ");
            for (int i = 0; i < numbers; i++)
            {
                numsArray[i] = Console.ReadLine();
            }

            var minimum = CalculateMinimum(numsArray);
            var maximum = CalculateMaximum(numsArray);
            var average = CalculateAverage(numsArray);
            var sum = CalculateSum(numsArray);
            dynamic product = CalculateProduct(numsArray);

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
            for (int i = 0; i < numsArray.Length; i++)
            {
                sum += numsArray[i];
            }
            return sum;
        }

        private static T CalculateAverage<T>(params T[] numsArray) where T : IComparable<T>
        {
            for (int i = 0; i < numsArray.Length; i++)
            {
                average += numsArray[i];
            }
            average /= numsArray.Length;

            return average;
        }

        private static T CalculateMaximum<T>(params T[] numsArray) where T : IComparable<T>
        {
            dynamic maximum = numsArray[0];
            for (int i = 0; i < numsArray.Length; i++)
            {
                if (numsArray[i] > maximum)
                {
                    maximum = numsArray[i];
                }
            }
            return maximum;
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

//private static T Test<T>(params T[] value)
//{
//    dynamic test = 0;

//    for (int i = 0; i < value.Length; i++)
//    {
//        test += (dynamic)value[i];
//    }

//    return test;
//}