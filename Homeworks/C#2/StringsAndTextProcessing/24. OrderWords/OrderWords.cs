using System;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Write a list of words, separated by spaces: ");
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            Console.WriteLine("Words in alphabetical order: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
