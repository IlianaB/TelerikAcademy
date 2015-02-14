using System;
using System.Text;

//Write a program to convert decimal numbers to their binary representation.

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int number = int.Parse(Console.ReadLine());

            string binaryNum = ConvertToBinary(number);

            Console.WriteLine("The number {0} in binary format is {1}", number, binaryNum);

        }

        private static string ConvertToBinary(int number)
        {
            StringBuilder numToBin = new StringBuilder();
            string binaryNum = string.Empty;

            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    numToBin.Insert(0, '0');
                    number /= 2;
                }
                else
                {
                    numToBin.Insert(0, '1');
                    number /= 2;
                }
            }
            binaryNum = numToBin.ToString();

            return binaryNum;
        }
    }
}
