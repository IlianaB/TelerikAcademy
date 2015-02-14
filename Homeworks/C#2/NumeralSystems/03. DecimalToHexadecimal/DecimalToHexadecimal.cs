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
            int input = int.Parse(Console.ReadLine());
            string hexNum = ConvertToHex(input);

            Console.WriteLine("The decimal representation of {0} is {1}.", input, hexNum);
        }

        private static string ConvertToHex(int input)
        {
            StringBuilder number = new StringBuilder();
            int result = 0;

            while (input > 0)
            {
                result = input % 16;

                if (result > 9)
                {
                    number.Insert(0, (char)('A' + result - 10));
                }
                else
                {
                    number.Insert(0, result);
                }
                input /= 16;
            }
            string hexNum = number.ToString();

            return hexNum;
        }
    }
}
