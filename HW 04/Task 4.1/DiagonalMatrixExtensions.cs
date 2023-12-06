using System;
namespace Task_4._1
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix<T> Add<T>(this DiagonalMatrix<T> matrix1, DiagonalMatrix<T> matrix2, Func<T, T, T> additionFunction)
        {
            if (matrix1 == null || matrix2 == null)
            {
                throw new ArgumentNullException("Both matrices must not be null.");
            }

            if (matrix1.Size != matrix2.Size)
            {
                throw new ArgumentException("Matrices must be of the same size for addition.");
            }

            if (additionFunction == null)
            {
                throw new ArgumentNullException(nameof(additionFunction), "Addition function must be provided.");
            }

            DiagonalMatrix<T> resultMatrix = new DiagonalMatrix<T>(matrix1.Size);

            for (int i = 0; i < matrix1.Size; i++)
            {
                T sum = additionFunction(matrix1[i, i], matrix2[i, i]);
                resultMatrix[i, i] = sum;
            }

            return resultMatrix;
        }
    }
}

