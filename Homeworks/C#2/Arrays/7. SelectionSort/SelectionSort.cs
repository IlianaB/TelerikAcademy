using System;

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

namespace _7.SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int[] numbers = Sort(12, 3, 2, 5, -1, 7, 0, -14);
            PrintNumbers(numbers);
        }

        static int[] Sort(params int[] numbers)
        {
            // The sorting logic:
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                // Loop that is operating over the un-sorted part of the array
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    // Swapping the values
                    if (numbers[i] > numbers[j])
                    {
                        int helper = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = helper;
                    }
                }
            } // End of the sorting logic
            return numbers;
        }
        static void PrintNumbers(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("{0}", numbers[i]);
                if (i < (numbers.Length - 1))
                {
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
        }
    }
}
