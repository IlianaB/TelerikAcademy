using System;

//  Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

namespace PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[10];

            for (int i = 2; i < 12; i++)
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
