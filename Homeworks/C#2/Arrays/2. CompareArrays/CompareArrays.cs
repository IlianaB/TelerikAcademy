using System;

//Write a program that reads two integer arrays from the console and compares them element by element.

namespace _2.CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            bool areTheSame = true;

            Console.Write("Write the length of the first array: ");
            int firstLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Write integer numbers for the first array, each on a separate line:");

            int[] firstArray = new int[firstLength];

            for (int i = 0; i < firstLength; i++)
            {
                firstArray[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Write the length of the second array: ");
            int secondLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Write integer numbers for the second array, each on a separate line:");

            int[] secondArray = new int[secondLength];

            for (int i = 0; i < secondLength; i++)
            {
                secondArray[i] = Int32.Parse(Console.ReadLine());
            }

            if (firstLength == secondLength)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areTheSame = false;
                        break;
                    }
                }
            }
            else
            {
                areTheSame = false;
            }

            Console.WriteLine("Are the two integer arrays the same: {0}", areTheSame);
        }
    }
}
