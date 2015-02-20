using System;

//Write a method that checks if the element at given position in given array of integers
//is larger than its two neighbours (when such exist).

namespace _05.LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        private static bool isLarger = false;

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 4, 5, 3, 7, 3, 4, 7, 8, 9, 1, 3 };
            Console.Write("Position of the element to check = ");
            int position = int.Parse(Console.ReadLine());

            isLarger = CheckElement(myArray, position);

            Console.WriteLine("Is {0} larger than its neighbours: {1}", myArray[position], isLarger);
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
