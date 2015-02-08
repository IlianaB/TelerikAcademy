using System;

//Write a program that finds the maximal sequence of equal elements in an array.

namespace _4.MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int[] myArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int sequence = 1;
            int maxsequence = 0;
            int element = 0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                if (myArray[i] == myArray[i + 1])
                {
                    sequence++;

                    if (maxsequence < sequence)
                    {
                        maxsequence = sequence;
                    }
                    element = myArray[i];
                }
                else
                {
                    sequence = 1;
                }                
            }

            for (int i = 0; i < maxsequence; i++)
			{
                if (i != maxsequence - 1)
                {
                    Console.Write("{0}, ", element);
                }
                else
                {
                    Console.WriteLine("{0}", element);
                }

			}
        }
    }
}
