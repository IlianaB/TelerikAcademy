using System;

namespace _12.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] myArray = new char[26];

            for (int i = 0; i < 26; i++)
            {
                myArray[i] = (char)(65 + i);
            }

            Console.Write("Write a word: ");
            string word = Console.ReadLine().ToUpper();
            int index = -2;

            for (int i = 0; i < word.Length; i++)
            {
                index = Array.IndexOf(myArray, word[i]);
                Console.WriteLine("The index of {0} is {1}", word[i], index);
            }
        }
    }
}
