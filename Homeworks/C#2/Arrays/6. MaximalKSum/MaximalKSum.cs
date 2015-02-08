using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

namespace _6.MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            List<int> intList = new List<int>();
            int max = 0;
            long sum = 0;

            Console.WriteLine("Write the elements of the array, each on a separate line: ");

            for (int i = 0; i < n; i++)
            {
                intList.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < k; i++)
            {
                max = intList.Max();
                sum += max;
                intList.Remove(max);
            }

            Console.WriteLine("The maximal sum of {0} elements is: {1}.", k, sum);
        }
    }
}
