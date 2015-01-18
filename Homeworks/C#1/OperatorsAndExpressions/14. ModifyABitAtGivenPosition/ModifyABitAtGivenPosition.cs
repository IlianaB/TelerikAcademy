using System;

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p 
//from the binary representation of n while preserving all other bits in n.

namespace ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.Write("Write an integer number: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Write the value of index p: ");
            int p = Int32.Parse(Console.ReadLine());
            Console.Write("Write a bit value of 1 or 0: ");
            int v = Int32.Parse(Console.ReadLine());
            int mask = 1 << p;
            bool isOne = (mask & n) == mask;

            if (isOne)
            {
                if (v == 0)
                {
                    Console.WriteLine(n = mask ^ n);
                }
                else
                {
                    Console.WriteLine(n);
                }
            }

            if (!isOne)
            {
                if (v == 0)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine(n = mask | n);
                }
            }
        }
    }
}
