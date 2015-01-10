using System;

// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

namespace AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.Write("Your birthday date is: ");
            string input = Console.ReadLine();
            DateTime birthDate = Convert.ToDateTime(input);

            DateTime timeNow = DateTime.Now;
            int ageNow = timeNow.Year - birthDate.Year;
            int currentAge = 0;

            if (((birthDate.Month >= timeNow.Month) && (birthDate.Day > timeNow.Day)) || (birthDate.Month > timeNow.Month))
            {
                currentAge = ageNow - 1;
            }
            else
            {
                currentAge = ageNow;
            }

            Console.WriteLine("Your age now: {0}", currentAge);
            Console.WriteLine("Your age after 10 years: {0}", currentAge + 10);
        }
    }
}
