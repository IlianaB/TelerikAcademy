using System;

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

namespace CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write the value of index p: ");
            int p = Int32.Parse(Console.ReadLine());
            int mask = 1 << p;

            Console.WriteLine((n & mask) == mask);
        }
    }
}
