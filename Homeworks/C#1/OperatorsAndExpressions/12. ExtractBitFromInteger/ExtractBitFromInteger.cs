using System;

//Write an expression that extracts from given integer n the value of given bit at index p

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write the value of index p: ");
            int p = Int32.Parse(Console.ReadLine());
            int mask = 1 << p;

            Console.WriteLine((n & mask) == mask ? 1 : 0);
        }
    }
}
