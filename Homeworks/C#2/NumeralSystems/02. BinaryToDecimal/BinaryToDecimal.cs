using System;

//Write a program to convert binary numbers to their decimal representation.

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Write a binary number: ");
            string input = Console.ReadLine();
            int number = 0;

            number = ConvertToDecimal(input);

            Console.WriteLine("The decimal represantation of {0} is {1}.", input, number);
        }

        private static int ConvertToDecimal(string input)
        {
            int sum = 0;

            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                sum += (input[i] - 48) * (int)Math.Pow(2, j);
            }
            return sum;
        }
    }
}
