using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below:

namespace _01.FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] myArrayA = new int[n, n];
            int[,] myArrayB = new int[n, n];
            int[,] myArrayC = new int[n, n];

            Console.WriteLine("a)");
            //Initializing the a) array
            for (int row = 0; row < myArrayA.GetLength(1); row++)
            {
                for (int col = 0; col < myArrayA.GetLength(0); col++)
                {
                    myArrayA[row, col] = row + 1 + col * n;
                }
            }

            //Printing the array
            PrintArray(myArrayA);

            Console.WriteLine("b)");
            //Initializing the b) array
            int number = 1;

            for (int col = 0; col < myArrayB.GetLength(1); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < myArrayB.GetLength(0); row++)
                    {
                        myArrayB[row, col] = number;
                        number++;
                    }
                }
                else
                {
                    for (int row = myArrayB.GetLength(0) - 1; row >= 0; row--)
                    {
                        myArrayB[row, col] = number;
                        number++;
                    }
                }
            }

            //Printing the array
            PrintArray(myArrayB);

            Console.WriteLine("c)");
            //Initializing the c) array
            number = 1;
            for (int row = myArrayC.GetLength(0) - 1; number <= myArrayC.GetLength(0) * myArrayC.GetLength(1); row--)
            {
                for (int currentCol = (row >= 0 ? 0 : -row), currentRow = (row >= 0 ? row : 0);
                    currentCol < (myArrayC.GetLength(1) - (row >= 0 ? row : 0)); )
                {
                    myArrayC[currentRow++, currentCol++] = number++;
                }
            }

            //Printing the array
            PrintArray(myArrayC);
        }

        private static void PrintArray(int[,] myArray)
        {
            for (int row = 0; row < myArray.GetLength(0); row++)
            {
                for (int col = 0; col < myArray.GetLength(1); col++)
                {
                    Console.Write(" {0} ", myArray[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
