using System;

// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
// You might need to learn how to use loops in C# (search in Internet).

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[1000];

            for (int i = 2; i < 1002; i++)
            {
                if (i % 2 == 0)
                {
                    sequence[i - 2] = i;
                }
                else
                {
                    sequence[i - 2] = -i;
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
