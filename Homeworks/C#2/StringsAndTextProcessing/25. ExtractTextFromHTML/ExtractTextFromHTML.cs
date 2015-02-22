using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _25.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            string text = "<html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
            MatchCollection tags = Regex.Matches(text, @"((?<=^|>)[^><]+?(?=<|$))");
            int count = 1;

            StringBuilder result = new StringBuilder();

            foreach (Match tag in tags)
            {
                if (count == 1)
                {
                    result.AppendLine("Title: " + tag);
                    result.Append("Text: ");
                }
                else
                {
                    result.Append(tag + " ");
                }
                count++;
            }
            Console.WriteLine(result);
        }
    }
}
