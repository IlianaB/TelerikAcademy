using System;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].

namespace _20.VariationsOfSet
{
    class VariationsOfSet
    {
        static void Main()
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Permutatons:\n");

            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }

            Variations(array, new int[K], 0);

        }

        private static void Variations(int[] numbers, int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(", ", array));
                return;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                array[index] = numbers[i];
                Variations(numbers, array, index + 1);
            }
        }
    }
}
