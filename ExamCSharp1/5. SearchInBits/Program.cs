using System;

namespace Problem5
{
    class Program
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int count = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());

                for (int j = 0; j < 27; j++)
                {
                    for (int k = 0, y = j; k < 4; y++, k++)
                    {
                        int mask = 1 << y;
                        int numberAndMask = number & mask;
                        int bit = numberAndMask >> y;

                        int mask2 = 1 << k;
                        int sAndMask = s & mask2;
                        int bit2 = sAndMask >> k;

                        if (bit == bit2)
                        {
                            count++;
                        }
                        if (count == 4)
                        {
                            result++;
                            count = 0;
                        }
                    }
                    count = 0;
                }
            }

            Console.WriteLine(result);
        }
    }
}