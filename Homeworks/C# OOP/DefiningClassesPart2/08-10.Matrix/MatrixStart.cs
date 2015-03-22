namespace _08_10.Matrix
{
    using System;

    class MatrixStart
    {
        static void Main()
        {
            Matrix<int> testMatrix = new Matrix<int>(4, 3);

            testMatrix[1, 2] = 7; 
            Console.WriteLine("Matrix[1, 2] = {0}", testMatrix[1, 2]); //returns 7

            Matrix<int> matrix1 = new Matrix<int>(3, 3); 
            Matrix<int> matrix2 = new Matrix<int>(3, 3);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Cols; j++)
                {
                    matrix1[i, j] = (i + 3) * (j + 1) + 5;
                    matrix2[i, j] = (i + 1) * (j + 2);
                }
            }

            Console.WriteLine("Matrix 1:\n{0}", matrix1);
            Console.WriteLine("Matrix 2:\n{0}", matrix2);

            Matrix<int> resultOfAddition = matrix1 + matrix2;
            Matrix<int> resultOfSubtraction = matrix1 - matrix2;
            Matrix<int> resultOfMultiplication = matrix1 * matrix2;

            Console.WriteLine("Matrix1 + Matrix2 =\n{0}", resultOfAddition);
            Console.WriteLine("Matrix1 - Matrix2 =\n{0}", resultOfSubtraction);
            Console.WriteLine("Matrix1 * Matrix2 =\n{0}", resultOfMultiplication);
        }
    }
}
