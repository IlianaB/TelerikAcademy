using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

namespace _08.BinaryShort
{
    class BinaryShort
    {
        static void Main(string[] args)
        {
            Console.Write("Write a short number: ");
            int input = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            string binary = string.Empty;

            if (input >= 0)
            {
                result = DecToBin(input);
                result.Reverse();
                binary = string.Join("", result);
            }
            else
            {
                int number = input;
                number += 32768;
                result = DecToBin(number);
                int[] arrResult = new int[16];
                for (int j = 0; j < result.Count; j++)
                {
                    arrResult[j] = result[j];
                }
                for (int i = result.Count; i < 15; i++)
                {
                    arrResult[i] = 0;
                }
                arrResult[15] = 1;
                result = arrResult.OfType<int>().ToList();
                result.Reverse();
                binary = string.Join("", result);
            }

            Console.WriteLine("The binary representation of {0} is {1}.", input, binary);
        }

        private static List<int> DecToBin(int num)
        {
            List<int> result = new List<int>();
            if (num == 0)
            {
                result.Add(0);
            }
            else
            {
                while (num > 0)
                {
                    result.Add(num % 2);
                    num /= 2;
                }
            }
            return result;
        }
    }
}
