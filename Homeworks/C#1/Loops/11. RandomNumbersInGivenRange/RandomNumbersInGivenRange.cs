using System;

//Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].

namespace RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.Write("Write a positive integer: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write the minimum value of the range: ");
            int min = Int32.Parse(Console.ReadLine());
            Console.Write("Write the maximum valie of the range: ");
            int max = Int32.Parse(Console.ReadLine());
            int number;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                number = rnd.Next(min, max + 1);
                Console.Write(number + " ");
            }
        }
    }
}
