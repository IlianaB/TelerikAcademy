using System;

// Write an expression that checks if given integer is odd or even.

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int n = Int32.Parse(Console.ReadLine());
            bool Odd = (n % 2 == 1);

            Console.WriteLine(Odd);
        }
    }
}
