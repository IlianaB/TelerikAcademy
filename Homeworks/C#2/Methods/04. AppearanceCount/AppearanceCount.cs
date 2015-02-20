using System;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

namespace _04.AppearanceCount
{
    class AppearanceCount
    {
        private static int appearances = 0;

        static void Main(string[] args)
        {
            Console.Write("Write the length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] myArray = new int[length];

            Console.WriteLine("Write the elements of the array, each on a separate line: ");
            for (int i = 0; i < length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Number to check = ");
            int number = int.Parse(Console.ReadLine());

            appearances = CountAppearances(myArray, number);

            Console.WriteLine("The number {0} appears {1} times in the array.", number, appearances);
        }

        private static int CountAppearances(int[] myArray, int number)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == number)
                {
                    appearances++;
                }
            }
            return appearances;
        }
    }
}
