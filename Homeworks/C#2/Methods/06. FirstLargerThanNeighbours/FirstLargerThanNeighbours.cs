using System;

//Write a method that returns the index of the first element in array 
//that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

namespace _06.FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        private static bool isLarger = false;

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 4, 5, 3, 7, 3, 4, 7, 8, 9, 1, 3 };
            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (CheckElement(myArray, i))
                {
                    result = i;
                    break;
                }
                else
                {
                    result = -1;
                }
            }

            if (result != -1)
            {
                Console.WriteLine("The index of the first element that is larger than its neighbours is {0}.\nThe numbers is {1}", result, myArray[result]);
            }
            else
            {
                Console.WriteLine("There is no such an element in array that is larger than its neighbours");
            }
        }

        private static bool CheckElement(int[] myArray, int position)
        {
            if (position > 0 && position < myArray.Length - 1)
            {
                if (myArray[position] > myArray[position + 1] && myArray[position] > myArray[position - 1])
                {
                    isLarger = true;
                }
            }
            else if (position == 0)
            {
                if (myArray[position] > myArray[position + 1])
                {
                    isLarger = true;
                }
            }
            else if (position == myArray.Length - 1)
            {
                if (myArray[position] > myArray[position - 1])
                {
                    isLarger = true;
                }
            }

            return isLarger;
        }
    }
}
