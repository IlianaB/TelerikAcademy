using System;
using System.Text;
using System.Text.RegularExpressions;

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18.ExtractEmails
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "Hello, osama@bin-laden.af, you have been using this@email.com in your registration.";
            Regex pattern = new Regex(@"\b[A-Z0-9._-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase);

            MatchCollection emailMatches = pattern.Matches(text);

            StringBuilder result = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                result.AppendLine(emailMatch.Value);
            }

            Console.WriteLine(result);
        }
    }
}
