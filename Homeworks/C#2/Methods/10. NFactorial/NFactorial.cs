using System;
using System.Collections.Generic;
using System.Linq;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.

namespace _09.NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            Console.Write("Enter a not negative number: ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = CalculateNumbers(n);
            List<int> factorial = CalculateFactorial(numbers);
            Console.WriteLine("\n{0}! = {1}\n", n, string.Join("", factorial));
        }

        static int[] CalculateNumbers(int n)
        {
            int[] factorial = { 1 };
            int left = 0;

            for (int i = 2; i <= n; i++, left = 0)
            {
                int[] currentNumber = ConvertToArray(i.ToString());
                int[] resultNumber = new int[factorial.Length + currentNumber.Length];

                for (int k = factorial.Length - 1; k >= 0; k--)
                {
                    for (int j = currentNumber.Length - 1; j >= 0; j--)
                    {
                        resultNumber[factorial.Length - k + currentNumber.Length - j - 2] += factorial[k] * currentNumber[j];
                    }
                }

                for (int j = 0; j < resultNumber.Length; j++)
                {
                    var digits = resultNumber[j] + left;
                    resultNumber[j] = digits % 10;
                    left = digits / 10;
                }
                factorial = resultNumber;
                Array.Reverse(resultNumber);
            }

            return factorial;
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

        private static List<int> CalculateFactorial(int[] numbers)
        {
            int start = 0;
            while (numbers[start] == 0) start++;

            List<int> result = new List<int>();
            for (int i = start; i < numbers.Length; i++)
            {
                result.Add(numbers[i]);
            }

            return result;
        }
    }
}