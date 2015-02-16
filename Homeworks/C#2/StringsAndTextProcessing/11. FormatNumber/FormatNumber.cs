using System;

//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            Console.Write("Write a number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:F2}", input);
            Console.WriteLine("{0,15:X}", input);
            Console.WriteLine("{0,15:P}", (double)input / 100);
            Console.WriteLine("{0,15:E}", input);
        }
    }
}
