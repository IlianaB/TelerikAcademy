using System;
using System.IO;
using System.Text;

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	output
//4 
//2 3 3 4 
//0 2 3 4    17
//3 7 1 2 
//4 3 3 2

namespace _05.MaximumAreaSum
{
    class MaximumAreaSum
    {
        private static int[,] matrix;
        private static int sum = int.MinValue;

        static void Main()
        {
            ReadMatrix();
            FindMaxSum();
            WriteResult();
            Console.WriteLine("Maximum sum is calculated and writed into result.txt file: ");
            ReadFile(@"..\..\result.txt");
        }

        private static void ReadMatrix()
        {
            using (StreamReader reader = new StreamReader(@"..\..\file.txt"))
            {
                string rowText;
                int n = int.Parse(reader.ReadLine());
                matrix = new int[n, n];

                for (int row = 0; row < n; row++)
                {
                    rowText = reader.ReadLine();
                    string[] colText = rowText.Split(' ');

                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(colText[col]);
                    }
                }
            }
        }

        private static void FindMaxSum()
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                    }
                }
            }
        }

        private static void WriteResult()
        {
            using (StreamWriter result = new StreamWriter(@"..\..\result.txt", false))
            {
                result.WriteLine(sum);
            }
        }

        private static void ReadFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                StringBuilder result = new StringBuilder();

                while (line != null)
                {
                    result.AppendLine(line);
                    line = reader.ReadLine();
                }

                Console.WriteLine(result);
            }
        }
    }
}
