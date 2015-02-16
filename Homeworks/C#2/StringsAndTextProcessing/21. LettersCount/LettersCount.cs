using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found.

namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            Console.Write("Write a string: ");
            string input = Console.ReadLine().ToLower();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {
                    if (!dictionary.ContainsKey(letter))
                    {
                        dictionary.Add(letter, 1);
                    }
                    else
                    {
                        dictionary[letter]++;
                    }
                }
            }

            foreach (KeyValuePair<char, int> pair in dictionary)
            {
                Console.WriteLine("The letter {0} = {1} times.", pair.Key, pair.Value);
            }
        }
    }
}
