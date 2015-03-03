using System;

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(0, 100);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void ReadNumber(int start, int end)
        {
            Console.Write("Enter a number between {0} and {1}: ", start, end);
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number > start && number < end)
            {
                Console.WriteLine("{0} is in range.", number);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
