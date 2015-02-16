using System;

//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Forbidden words: PHP, CLR, Microsoft
//The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string[] forbiddenWords = { "PHP", "CLR", "Microsoft" };
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                if (text.Contains(forbiddenWords[i]))
                {
                    text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
