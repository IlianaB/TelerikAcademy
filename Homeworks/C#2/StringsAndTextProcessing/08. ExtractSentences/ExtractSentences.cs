using System;
using System.Text;

//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = " in ";
            int index = 0;
            string subString = string.Empty;
            int start = 0;
            StringBuilder result = new StringBuilder();

            while (index != -1)
            {
                index = text.IndexOf('.', start);

                if (index != -1)
                {
                    subString = text.Substring(start, index - start + 1);

                    if (subString.Contains(word))
                    {
                        result.Append(subString);
                    }
                    start = index + 1;
                }
            }

            if (result.Length > 0)
            {
                Console.WriteLine("The result is: ");
                Console.WriteLine(result.ToString());
            }
            else
            {
                Console.WriteLine("There is no sentences which contains {0}.", word.Trim(' '));
            }

        }
    }
}
