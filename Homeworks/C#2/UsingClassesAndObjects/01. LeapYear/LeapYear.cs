using System;

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Write a year: ");
            int year = int.Parse(Console.ReadLine());
            
            if (year >= 0 && year <= 2015)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("The year is leap!");
                }
                else
                {
                    Console.WriteLine("The year is not leap!");
                }                
            }
            else
            {
                Console.WriteLine("You have entered an invalid year!");
            }
        }
    }
}
