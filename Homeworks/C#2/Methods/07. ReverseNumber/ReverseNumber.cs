using System;
using System.Text;

//Write a method that reverses the digits of given decimal number.

namespace _07.ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            string number = Console.ReadLine();

            Console.WriteLine("The number with reversed digits is: {0}.", ReverseDigits(number));
        }

        private static StringBuilder ReverseDigits(string number)
        {
            StringBuilder reversedNum = new StringBuilder();
            for (int i = number.Length - 1; i >= 0; i--)
            {
                reversedNum.Append(number[i]);
            }

            return reversedNum;
        }
    }
}
