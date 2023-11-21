using System;

namespace Task_2._2
{
    class Program
    {
        static void Main()
        {
            DiagonalMatrix matrix1 = new DiagonalMatrix(new int[] { 1, 2, 3, 4 });
            DiagonalMatrix matrix2 = new DiagonalMatrix(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine(matrix2.ToString());
            Console.WriteLine(matrix1.Equals(matrix2));

        }
    }
}
