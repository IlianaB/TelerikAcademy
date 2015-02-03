using System;
using System.Linq;

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

namespace _12.RandomizeTheNumbersOneToN
{
    class RandomizeTheNumbersOneToN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 1; i <= n; i++)
            {
                array[i - 1] = i.ToString();                                
            }

            Random rnd = new Random();
            string[] myRandomArray = array.OrderBy(x => rnd.Next()).ToArray();
            string result = String.Join(" ", myRandomArray);

            Console.WriteLine(result);
        }
    }
}
