using System;

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

namespace DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Write a decimal number: ");
            long input = long.Parse(Console.ReadLine());
            long number = 0;
            string result = "";

            while (input > 0)
            {
                number = input % 2;
                input = input / 2;
                result = number + result;
            }

            Console.WriteLine(result);
        }
    }
}
