using System;

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

namespace _06.SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            Console.WriteLine("Write a sequence of positive integer values, separated by spaces: ");
            string input = Console.ReadLine();
            int sum = CalculateSum(input);

            Console.WriteLine("The sum of the numbers you have entered is {0}.", sum);

        }

        private static int CalculateSum(string input)
        {
            string[] numsArray = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            for (int i = 0; i < numsArray.Length; i++)
            {
                sum += int.Parse(numsArray[i]);
            }

            return sum;
        }
    }
}
