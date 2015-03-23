//Problem 3. Range Exceptions

//Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
//It should hold error message and a range definition [start … end].
//Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> 
//by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace _03.RangeExceptions
{
    using System;

    class Test
    {
        static void Main()
        {
            try
            {
                int testNumber = 666;

                if (testNumber < 1 || testNumber > 100)
                {
                    throw new InvalidRangeException<int>(string.Format("The value of the number should be between {0} and {1}!", 1, 100));
                }

            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                DateTime date = new DateTime(2015, 2, 28);

                if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>(string.Format("The date should be between {0} and {1}!", 
                        new DateTime(1980, 1, 1), new DateTime(2013, 12, 31)));
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
