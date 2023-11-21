namespace Task_2._2
{
    public static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix Add(this DiagonalMatrix matrix1, DiagonalMatrix matrix2)
        {
            int maxSize = Math.Max(matrix1.Size, matrix2.Size);
            int[] resultArray = new int[maxSize];

            for (int i = 0; i < maxSize; i++)
            {
                int value1 = (i < matrix1.Size) ? matrix1[i, i] : 0;
                int value2 = (i < matrix2.Size) ? matrix2[i, i] : 0;
                resultArray[i] = value1 + value2;
            }

            return new DiagonalMatrix(resultArray);
        }
    }
}

