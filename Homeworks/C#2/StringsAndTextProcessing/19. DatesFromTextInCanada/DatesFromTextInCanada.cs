using System;
using System.Globalization;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

namespace _19.DatesFromTextInCanada
{
    class DatesFromTextInCanada
    {
        static void Main()
        {
            string text = "Enter the first date: 27.02.2006. Enter the second date: 3.03.2006";
            //Note that the second date does NOT match the pattern! It should be 03.03.2006 to match it!

            Regex pattern = new Regex(@"\b[0-9]{2}\.[0-9]{2}\.[0-9]{4}\b");

            MatchCollection result = pattern.Matches(text);

            var culture = new CultureInfo("en-CA");
            string format = "YYYY-MM-DD";
            DateTime canadianDate = new DateTime();

            foreach (Match dateMatch in result)
            {
                if (DateTime.TryParseExact(dateMatch.Value, format, culture, DateTimeStyles.None, out canadianDate))
                {
                    canadianDate = DateTime.ParseExact(dateMatch.Value, format, culture);
                    Console.WriteLine(canadianDate);
                }
            }


        }
    }
}
