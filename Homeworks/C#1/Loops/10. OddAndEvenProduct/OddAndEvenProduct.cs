using System;

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

namespace OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            Console.Write("Write integers, separated by space: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddProduct *= Int32.Parse(numbers[i]);
                }
                else
                {
                    evenProduct *= Int32.Parse(numbers[i]);
                }
            }

            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("Product: {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("Odd product: {0}", oddProduct);
                Console.WriteLine("Even product: {0}", evenProduct);
            }
        }
    }
}
