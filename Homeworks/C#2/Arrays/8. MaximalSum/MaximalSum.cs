using System;
using System.Collections.Generic;

//Write a program that finds the sequence of maximal sum in given array.

namespace _8.MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int[] myArray = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int startIndex = 0;
            int currentSum = 0;
            int bestSum = int.MinValue;
            int bestStart = 0;
            int bestEnd = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (currentSum <= 0)
                {
                    startIndex = i;
                    currentSum = 0;
                }

                currentSum += myArray[i];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = startIndex;
                    bestEnd = i;
                }
            }

            Console.Write("The sequence of maximal sum in the given array is: ");
            for (int i = bestStart; i <= bestEnd; i++)
            {
                if (i != bestEnd)
                {
                    Console.Write("{0}, ", myArray[i]);
                }
                else
                {
                    Console.WriteLine("{0}", myArray[i]);
                }
            }

        }
    }
}
