namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DiagonalMatrix<int> matrix1 = new DiagonalMatrix<int>(3);
            matrix1[0, 0] = 1;
            matrix1[1, 1] = 2;
            matrix1[2, 2] = 3;

            DiagonalMatrix<int> matrix2 = new DiagonalMatrix<int>(3);
            matrix2[0, 0] = 4;
            matrix2[1, 1] = 5;
            matrix2[2, 2] = 6;

            Func<int, int, int> additionFunction = (a, b) => a + b;

            DiagonalMatrix<int> resultMatrix = matrix1.Add(matrix2, additionFunction);

            Console.WriteLine("Result Matrix:");
            for (int i = 0; i < resultMatrix.Size; i++)
            {
                for (int j = 0; j < resultMatrix.Size; j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            DiagonalMatrix<int> matrix = new DiagonalMatrix<int>(3);
            matrix[0, 0] = 1;
            matrix[1, 1] = 2;
            matrix[2, 2] = 3;

            MatrixTracker<int> matrixTracker = new MatrixTracker<int>(matrix);

            matrix[0, 0] = 10;
            matrix[1, 1] = 20;

            matrixTracker.Undo();

        }
    }
}


