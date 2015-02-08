using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

namespace _1.AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int[] intArray = new int[20];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i * 5;
            }

            foreach (var number in intArray)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();
        }
    }
}
