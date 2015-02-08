using System;

//Write a program that sorts an array of strings using the Quick sort algorithm.

class QuickSort
{

    static public int Partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
                left++;

            while (numbers[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void QuickSort_Recursive(int[] arr, int left, int right)
    {
        // For Recursion
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
                QuickSort_Recursive(arr, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort_Recursive(arr, pivot + 1, right);
        }
    }

    static void Main()
    {
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
        int len = numbers.Length;

        Console.WriteLine("QuickSort By Recursive Method");
        QuickSort_Recursive(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

 
