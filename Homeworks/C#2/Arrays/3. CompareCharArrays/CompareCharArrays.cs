using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

namespace _3.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            bool areTheSame = true;

            Console.Write("Write the length of the first array: ");
            int firstLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Write chars for the first array, each on a separate line:");

            char[] firstArray = new char[firstLength];

            for (int i = 0; i < firstLength; i++)
            {
                firstArray[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.Write("Write the length of the second array: ");
            int secondLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Write chars for the second array, each on a separate line:");

            char[] secondArray = new char[secondLength];

            for (int i = 0; i < secondLength; i++)
            {
                secondArray[i] = Convert.ToChar(Console.ReadLine());
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
