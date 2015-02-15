using System;
using System.Globalization;
using System.Linq;

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

namespace _05.Workdays
{
    class Workdays
    {
        static readonly DateTime[] holidays =
	    {
		new DateTime(2015, 3, 2), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
		new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
		new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
		new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
	    };

        static void Main()
        {
            Console.Write("Write date in the format dd/MM/yyyy: ");
            string input = Console.ReadLine();
            string format = "dd/MM/yyyy";
            DateTime givenDate = new DateTime();

            if (DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out givenDate) && givenDate > DateTime.Now)
            {
                int workingDays = GetWorkingDays(DateTime.Today, givenDate);
                Console.WriteLine("The working days between today and {0} are {1}.", input, workingDays);

            }
            else
            {
                Console.WriteLine("You have entered an invalid date or the format is wrong!");
            }
        }

        private static int GetWorkingDays(DateTime dateTime, DateTime givenDate)
        {
            int workingDays = 0;

            if (dateTime > givenDate)
            {
                DateTime swap = dateTime;
                dateTime = givenDate;
                givenDate = swap;
            }

            while (dateTime <= givenDate)
            {
                if (!holidays.Contains(dateTime)
                && dateTime.DayOfWeek != DayOfWeek.Saturday
                && dateTime.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
                dateTime = dateTime.AddDays(1);
            }

            return workingDays;
        }
    }
}
