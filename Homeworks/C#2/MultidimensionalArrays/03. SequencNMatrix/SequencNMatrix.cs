using System;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.

namespace _03.SequencNMatrix
{
    class SequencNMatrix
    {
        static int max = 0;
        static int current = 1;
        static string element = " ";
        static string position = " ";

        static void Main()
        {
            string[,] matrix = { { "ha", "fifi", "ho", "hi" },
                                 { "fo", "ha", "hi", "xx" },
                                 { "xxx", "ho", "ha", "xx" } };
            //string[,] matrix = { { "s", "qq", "s" },
            //                     { "pp", "pp", "s" },
            //                     { "pp", "qq", "s" } };
            

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    RightCheck(matrix, row, col);
                    DownCheck(matrix, row, col);
                    DiagonalCheck(matrix, row, col);
                }
            }

            Console.WriteLine("The longest sequence of equal strings in the matrix is: ");
            for (int i = 0; i < max; i++)
            {
                if (i != max - 1)
                {
                    Console.Write("{0}, ", element);
                }
                else
                {
                    Console.WriteLine(element);
                }
            }
            Console.WriteLine("It can be found {0}.", position);
        }

        private static void DiagonalCheck(string[,] matrix, int row, int col)
        {
            for (int i = row,  j = col; i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1; i++, j++)
            {
                if (matrix[i, j] == matrix[i + 1, j + 1])
                {
                    current++;

                    if (max < current)
                    {
                        max = current;
                        element = matrix[i, j];
                        position = "diagonally";
                    }
                }
                else
                {
                    current = 1;
                    continue;
                }
            }

            current = 1;
        }

        private static void DownCheck(string[,] matrix, int row, int col)
        {
            for (int j = col; j < matrix.GetLength(1); j++)
            {
                for (int i = row; i < matrix.GetLength(0) - 1; i++)
                {
                    if (matrix[i, j] == matrix[i + 1, j])
                    {
                        current++;

                        if (max < current)
                        {
                            max = current;
                            element = matrix[i, j];
                            position = "vertically";
                        }
                    }
                    else
                    {
                        current = 1;
                        continue;
                    }
                }
            }
            current = 1;
        }

        private static void RightCheck(string[,] matrix, int row, int col)
        {
            for (int i = row; i < matrix.GetLength(0); i++)
            {
                for (int j = col; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1])
                    {
                        current++;

                        if (max < current)
                        {
                            max = current;
                            element = matrix[i, j];
                            position = "horizontally";
                        }
                    }
                    else
                    {
                        current = 1;
                        continue;
                    }
                }
            }
            current = 1;
        }
    }
}
