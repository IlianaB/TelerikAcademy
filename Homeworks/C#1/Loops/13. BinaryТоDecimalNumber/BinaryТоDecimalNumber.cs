using System;

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

namespace BinaryТоDecimalNumber
{
    class BinaryТоDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Write a binary number: ");
            string input = Console.ReadLine();
            long sum = 0;

            for (int i = 1; i <= input.Length; i++)
            {
                int inputNumber = Int32.Parse(input[input.Length - i].ToString());
		        sum += inputNumber * (long)Math.Pow(2, (i - 1));
            }

            Console.WriteLine(sum);
        }
    }
}
