using System;
using System.Collections.Generic;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
//with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

namespace _07.EncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.Write("Write a message to encode: ");
            string input = Console.ReadLine();
            string cipher = "AbC";
            List<char> result = new List<char>();

            for (int i = 0, j = 0; i < input.Length; i++, j++)
            {
                if (j < cipher.Length)
                {
                    result.Add((char)(input[i] ^ cipher[j]));
                }
                else
                {
                    j = 0;
                    result.Add((char)(input[i] ^ cipher[j]));
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
