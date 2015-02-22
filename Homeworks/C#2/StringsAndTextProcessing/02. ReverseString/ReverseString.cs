using System;
using System.Text;

//Write a program that reads a string, reverses it and prints the result at the console.

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            Console.Write("Write a string: ");
            string input = Console.ReadLine();
            StringBuilder reversed = Reverse(input);

            Console.WriteLine("The reversed string looks like this: {0}.", reversed.ToString());
        }

        private static StringBuilder Reverse(string input)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed.Append(input[i]);
            }
            return reversed;
        }
    }
}