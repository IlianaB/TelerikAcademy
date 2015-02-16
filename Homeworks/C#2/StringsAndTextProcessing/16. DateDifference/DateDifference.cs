using System;
using System.Globalization;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

namespace _16.DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Please write a start date in the format: day.month.year: ");
            string startDate = Console.ReadLine();
            Console.Write("Please write an end date in the format: day.month.year: ");
            string endDate = Console.ReadLine();
            DateTime firstDate = new DateTime();
            DateTime secondDate = new DateTime();
            double result = 0;
            string format = "d.M.yyyy";

            if (DateTime.TryParseExact(startDate, format, null, DateTimeStyles.None, out firstDate) 
                && DateTime.TryParseExact(endDate, format, null, DateTimeStyles.None, out secondDate))
            {
                DateTime.ParseExact(startDate, format, null);
                DateTime.ParseExact(endDate, format, null);
                result = (secondDate - firstDate).TotalDays;

                Console.WriteLine("Days between {0:dd.MM.yyyy} and {1:dd.MM.yyyy} are {2}.", firstDate, secondDate, Math.Abs(result));
            }
            else
            {
                Console.WriteLine("You have entered invalid dates!");
            }
        }
    }
}
