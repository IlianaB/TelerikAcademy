using System;

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

namespace _03.DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Today is: {0}", today.DayOfWeek);
        }
    }
}
