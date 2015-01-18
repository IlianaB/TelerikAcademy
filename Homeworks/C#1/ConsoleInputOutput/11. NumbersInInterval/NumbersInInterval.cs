using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

namespace NumbersInInterval
{
    class NumbersInInterval
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int startNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Write a number: ");
            int endNumber = Int32.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = startNumber; i <= endNumber; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("There are {0} numbers between {1} and {2} that can be devided by 5 with reminder of 0", counter, startNumber, endNumber);
        }
    }
}
