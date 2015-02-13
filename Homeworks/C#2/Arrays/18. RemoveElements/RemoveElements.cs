using System;
using System.Collections.Generic;
using System.Linq;

//Write a program that reads an array of integers and removes from it a minimal number of elements 
//in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

namespace _18.RemoveElements
{
    class RemoveElements
    {
        static void Main()
        {
            int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            List<List<int>> sequences = new List<List<int>>();
            List<int> currentSequence = new List<int>();
            int counter = 1;
            int start = 0;
            int end = sequences.Count;
            int bestSequenceLength = 1;

            for (int i = 0; i < array.Length; i++) 
            {
                List<int> temp1 = new List<int>(1);
                temp1.Add(i);
                sequences.Add(temp1);
            }

            while (counter <= array.Length) 
            {                               
                end = sequences.Count;
                for (int i = start; i < end; i++)  
                {
                    currentSequence = new List<int>();
                    currentSequence.AddRange(sequences[i]);
                    for (int j = currentSequence.Last() + 1; j < array.Length; j++) 
                    {                                                               
                        if (array[j] >= array[currentSequence.Last()])  
                        {                                               
                            List<int> temp = new List<int>();           
                            temp.AddRange(currentSequence);             
                            temp.Add(j);                                
                            sequences.Add(temp);
                        }
                    }
                }
                start = end;
                counter++;
            }

            for (int i = 0; i < sequences.Count; i++)
            {
                if (sequences[i].Count >= bestSequenceLength)
                {
                    bestSequenceLength = sequences[i].Count; 
                }
            }
            for (int i = 0; i < sequences.Count; i++)
            {
                if (sequences[i].Count == bestSequenceLength)
                {
                    Console.Write("Best increasing sequence looks like this: ");
                    for (int j = 0; j < bestSequenceLength; j++)
                    {
                        Console.Write(array[sequences[i][j]]);  
                        if (j < bestSequenceLength - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }

            }
        }

    }
}
