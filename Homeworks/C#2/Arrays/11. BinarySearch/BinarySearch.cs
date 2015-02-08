using System;
using System.Collections.Generic;

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int[] myArray = { 1, 4, 24, 54, 22, 17, 8, 20, 29, 3, 15, 34, 23, 11 };

            //the sorted array looks like this: { 1, 3, 4, 8, 11, 15, 17, 20, 22, 23, 24, 29, 34, 54}

            Array.Sort(myArray);
            int start = 0;
            int end = myArray.Length - 1;
            int middle = myArray.Length / 2;
            int number = int.Parse(Console.ReadLine());

            while (start < end)
            {
                if (number < myArray[start] || number > myArray[end])
                {
                    Console.WriteLine("There is no such number in the array!");
                    break;
                }
                else if (number < myArray[middle])
                {
                    end = middle;
                    middle = (end - start) / 2 + start;

                    if (middle == end)
                    {
                        middle--;
                    }
                }
                else if (number > myArray[middle])
                {
                    start = middle;
                    middle = (end - start) / 2 + start;

                    if (middle == start)
                    {
                        middle++;
                    }
                }
                else if (number == myArray[middle])
                {
                    Console.WriteLine("The index of {0} in the array is: {1}", number, middle);
                    break;
                }
            }
        }
    }
}
