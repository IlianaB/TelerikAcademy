using System;
using System.Linq;
using System.Text;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string text = "Hi!";

            Console.Write("The result is: ");
            foreach (char symbol in text)
            {
                Console.Write("\\u{0:X4}", (int)symbol);
            }
            Console.WriteLine();

            //Another variant:
            //byte[] stringBytes = Encoding.Unicode.GetBytes(text);
            //char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            //StringBuilder builder = new StringBuilder();

            //Array.ForEach<char>(stringChars, c => builder.AppendFormat("\\u{0:X4}", (int)c));
            //Console.WriteLine(builder);
        }
    }
}
