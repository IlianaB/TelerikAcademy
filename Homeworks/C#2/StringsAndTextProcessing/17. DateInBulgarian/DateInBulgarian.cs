using System;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main()
        {
            Console.WriteLine("Please write a start date in the format: day.month.year hour:minute:second: ");
            string date = Console.ReadLine();
            string format = "dd.MM.yyyy HH:mm:ss";
            DateTime parsedDate = new DateTime();
            var culture = new CultureInfo("bg-BG");

            if (DateTime.TryParseExact(date, format, culture, DateTimeStyles.None, out parsedDate))
            {
                parsedDate = DateTime.ParseExact(date, format, culture);
                parsedDate = parsedDate.AddHours(6).AddMinutes(30);

                Console.WriteLine("After 6 hours and 30 minutes it will be: {0:dd.MM.yyyy HH:mm:ss}", parsedDate);
                Console.WriteLine("The day will be {0}", culture.DateTimeFormat.GetDayName(parsedDate.DayOfWeek));
            }
            else
            {
                Console.WriteLine("You have entered an invalid date!");
            }
        }
    }
}
