using System;

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

namespace _17.SubsetKWithSumS
{
    class SubsetKWithSumS
    {
        static void Main()
        {
            Console.Write("Write the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Write integer numbers for the array, each on a separate line:");

            int[] myArray = new int[n];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("s = ");
            int s = int.Parse(Console.ReadLine());

            bool isSubsetSum = false;
            int max = (int)Math.Pow(2, myArray.Length);
            int count = 0;

            for (int i = 0; i < max - 1; i++)
            {
                int currentSum = 0;
                int counter = 0;
                for (int j = 0; j < myArray.Length && !isSubsetSum; j++)
                {
                    int mask = 1 << j;         
                    int nAndMask = i & mask;   
                    int bit = (nAndMask >> j); 
                    if (bit == 1)
                    {
                        currentSum += myArray[j];
                        counter++;               
                    }
                }
                if (counter == k && currentSum == s)
                {
                    isSubsetSum = true;
                    count += counter;
                }
            }
            Console.WriteLine("Result is :");
            Console.WriteLine(isSubsetSum == true ? "Yes" : "No");
            Console.WriteLine("The sum ({0}) contains {1} numbers from the array", s, count);
        }
    }
}
