using System;
using System.Collections.Generic;

//Write a program that reads a string from the console and lists all different words in the string
//along with information how many times each word is found.

namespace _22.WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            Console.Write("Write a sentence: ");
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { ' ', ',', '.', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, 1);
                }
                else
                {
                    dictionary[word]++;
                }
            }

            foreach (KeyValuePair<string, int> item in dictionary)
            {
                Console.WriteLine("Word \"{0}\" = {1}", item.Key, item.Value);
            }
        }
    }
}
