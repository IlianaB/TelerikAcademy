using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	output
//aaaaabbbbbcdddeeeedssaa	abcdedsa

namespace _23.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            //string input = "aaaaabbbbbcdddeeeedssaa";

            List<char> result = new List<char>();
            result.Add(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result.Add(input[i]);
                }
            }

            Console.WriteLine("Original string is {0}, and the result is {1}", input, String.Join("", result));
        }
    }
}
