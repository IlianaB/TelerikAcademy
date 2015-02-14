using System;
using System.Text;

//Write a program to convert decimal numbers to their hexadecimal representation.

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            string input = Console.ReadLine().ToUpper();
            int number = ConvertToHex(input);

            Console.WriteLine("The decimal representation of {0} is {1}.", input, number);
        }

        private static int ConvertToHex(string input)
        {
            int sum = 0;

            for (int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if (Char.IsDigit(input[i]))
                {
                    sum += (input[i] - 48) * (int)Math.Pow(16, j);
                }
                else
                {
                    sum += (input[i] - 55) * (int)Math.Pow(16, j);
                }
            }

            return sum;
        }
    }
}
