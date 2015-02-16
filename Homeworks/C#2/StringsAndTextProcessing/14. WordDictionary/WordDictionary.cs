using System;
using System.Collections.Generic;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

namespace _14.WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            Console.Write("Write one of the three words in the example: ");
            string input = Console.ReadLine();
            string result = string.Empty;

            if (dictionary.ContainsKey(input))
            {
                Console.WriteLine(dictionary[input]);
            }
            else
            {
                Console.WriteLine("You have entered an invalid word!");
            }
        }
    }
}
