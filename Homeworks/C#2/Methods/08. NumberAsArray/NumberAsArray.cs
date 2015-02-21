using System;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays of digits
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

namespace _08.NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            Console.Write("Enter first not negative number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Enter second not negative number: ");
            string secondNumber = Console.ReadLine();

            List<int> resultList = CalculateSum(ConvertToArray(firstNumber), ConvertToArray(secondNumber));
            PrintResult(resultList);
        }

        static int[] ConvertToArray(string number)
        {
            int[] result = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                result[number.Length - 1 - i] = number[i] - '0';
            }

            return result;
        }

        static List<int> CalculateSum(int[] firstArray, int[] secondArray)
        {
            List<int> result = new List<int>(Math.Max(firstArray.Length, secondArray.Length));

            int left = 0;

            for (int i = 0; i < result.Capacity; i++)
            {
                int num = (i < firstArray.Length ? firstArray[i] : 0) + (i < secondArray.Length ? secondArray[i] : 0) + left;
                left = num / 10;
                result.Add(num % 10);
            }

            if (left > 0) result.Add(left);

            return result;
        }

        static void PrintResult(List<int> result)
        {
            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
