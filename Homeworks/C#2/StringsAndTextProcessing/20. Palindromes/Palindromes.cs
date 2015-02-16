using System;
using System.Text;

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string text = "We made it to the next level! So now we know that ABBA, lamal and exe are palindromes!";
            string[] array = text.Split(new char[] { ' ', '.', ',', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            foreach (string word in array)
            {
                if (IsPalindrome(word))
                {
                    result.AppendLine(word);
                }
            }

            Console.WriteLine(result);
        }

        public static bool IsPalindrome(string word)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
