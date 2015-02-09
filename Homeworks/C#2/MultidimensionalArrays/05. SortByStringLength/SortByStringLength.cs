using System;

//You are given an array of strings. Write a method that sorts the array 
//by the length of its elements (the number of characters composing them).

namespace _05.SortByStringLength
{
    class SortByStringLength
    {
        static void Main()
        {
            string[] myArray = { "apple", "strawberry", "banana", "coconut", "lime" };
            string temp = " ";

            //Sorting the array
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i].Length > myArray[j].Length)
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }

            //Printing the array
            Console.WriteLine("The array, sorted by the length of its elements, looks like this: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i != myArray.Length - 1)
                {
                    Console.Write("{0}, ", myArray[i]);
                }
                else
                {
                    Console.WriteLine(myArray[i]);
                }
            }
        }
    }
}
