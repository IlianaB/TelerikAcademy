using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order

namespace _09.SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int[] myArray = { 11, 2, 5, 3, 22, 15, 7, 10, 18, 9 };
            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.Write("Start index for the search = ");
            int index = int.Parse(Console.ReadLine());
            int max = 0;
            
            max = MaxElement(index, myArray);

            if (index >= 0 && index < myArray.Length)
            {
                Console.WriteLine("The biggest number in the array after index [{0}] is {1}.", index, max);
            }
            else
            {
                Console.WriteLine("The index is outside of the boundaries of the array!");
            }


            int[] ascending = new int[myArray.Length];
            int[] descending = new int[myArray.Length];
            
            ascending = SortAscending(myArray);
            descending = SortDescending(myArray);

            Console.Write("Array in ascending order: ");

            for (int i = 0; i < ascending.Length; i++)
            {
                Console.Write("{0}", ascending[i]);
                if (i != ascending.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();

            Console.Write("Array in descending order: ");
            for (int i = 0; i < descending.Length; i++)
            {
                Console.Write("{0}", descending[i]);
                if (i != descending.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        private static int[] SortDescending(int[] myArray)
        {
            int max = int.MinValue;
            int[] cloned = myArray.Clone() as int[];
            int[] descending = new int[cloned.Length];
            int index = 0;

            for (int i = 0, k = 0; i < cloned.Length; i++, k++)
            {
                for (int j = 0; j < cloned.Length; j++)
                {
                    if (cloned[j] > max)
                    {
                        max = cloned[j];
                        index = j;
                    }
                }
                descending[k] = max;
                max = int.MinValue;
                cloned[index] = int.MinValue;
            }

            return descending;
        }

        private static int[] SortAscending(int[] myArray)
        {
            int min = int.MaxValue;
            int[] cloned = myArray.Clone() as int[];
            int[] ascending = new int[cloned.Length];
            int index = 0;

            for (int i = 0, k = 0; i < cloned.Length; i++, k++)
            {
                for (int j = 0; j < cloned.Length; j++)
                {
                    if (cloned[j] < min)
                    {
                        min = myArray[j];
                        index = j;
                    }
                }
                ascending[k] = min;
                min = int.MaxValue;
                cloned[index] = int.MaxValue;
            }

            return ascending;
        }

        private static int MaxElement(int index, int[] myArray)
        {
            int max = int.MinValue;

            for (int i = index; i < myArray.Length; i++)
            {
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            return max;
        }
    }
}
