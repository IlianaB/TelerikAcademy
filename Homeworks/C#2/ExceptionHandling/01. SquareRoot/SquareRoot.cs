using System;

//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a non-negative number: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception("Invalid number");
                }

                Console.WriteLine("Square root of {0} is {1}.", number, Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
            
        }
    }
}
