using System;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.Write("Write a string with maximum 20 characters: ");
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder();

            if (input.Length > 20)
            {
                Console.WriteLine("You have entered a string, longer than 20 characters!");
            }
            if (input.Length <= 20)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (i <= input.Length - 1)
                    {
                        text.Append(input[i]);
                    }
                    else
                    {
                        text.Append('*');
                    }
                }

                Console.WriteLine("The result is: {0}", text.ToString());
            }
        }
    }
}
