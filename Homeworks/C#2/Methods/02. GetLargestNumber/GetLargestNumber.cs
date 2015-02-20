using System;

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

namespace _02.GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            
            int currentMax = GetMax(a, b);
            int max = GetMax(currentMax, c);

            Console.WriteLine("The biggest number is: {0}", max);
        }

        private static int GetMax(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


    }
}
