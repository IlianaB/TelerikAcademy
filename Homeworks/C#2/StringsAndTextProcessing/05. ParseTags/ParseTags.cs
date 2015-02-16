using System;
using System.Text;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            //string text = "C# is intended to be a <upcase>simple</upcase>, modern, general-purpose, <upcase>object-oriented</upcase> programming language. Its <upcase>development team</upcase> is led by <upcase>Anders Hejlsberg</upcase>.";
            int startIndex = 0;
            int lastIndex = 0;
            StringBuilder newText = new StringBuilder();
            newText.Append(text);
            string subString = string.Empty;
            int index = 0;
            int index2 = 0;
            string clearText = string.Empty;

            while (startIndex != -1)
            {
                startIndex = text.IndexOf("<upcase>", index);
                index = startIndex + 1;

                if (startIndex != -1)
                {
                    lastIndex = text.IndexOf("</upcase>", index2);
                    index2 = lastIndex + 1;
                    subString = text.Substring(startIndex + 8, lastIndex - (startIndex + 8));

                    newText.Replace(subString, subString.ToUpper());
                }
            }

            newText.Replace("<upcase>", "");
            newText.Replace("</upcase>", "");

            clearText = newText.ToString();

            Console.WriteLine("The result is: ");
            Console.WriteLine(clearText);
        }
    }
}
