using System;

//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

namespace _16.SubsetWithSumS
{
    class SubsetWithSumS
    {
        static void Main()
        {
            int[] myArray = { 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.Write("S = ");
            int s = int.Parse(Console.ReadLine());

            bool isSubsetSum = false;
            int max = (int)Math.Pow(2, myArray.Length);

            for (int i = 0; i < max - 1; i++)
            {
                int currentSum = 0;
                for (int j = 0; j < myArray.Length; j++)
                {
                    int mask = 1 << j;         
                    int iAndMask = i & mask;   
                    int bit = (iAndMask >> j); 
                    if (bit == 1)
                    {
                        currentSum += myArray[j];
                    }
                }
                if (currentSum == s)
                {
                    isSubsetSum = true;
                }
            }
            Console.WriteLine(isSubsetSum == true ? "Yes" : "No");
        }
    }
}
