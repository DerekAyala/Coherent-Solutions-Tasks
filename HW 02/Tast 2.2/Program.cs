using System;
using Tast_2._2;

namespace task_2._2
{
    class Program
    {
        static void Main()
        {
            Matrix matrix1 = new Matrix(new int[] { 1, 2, 3, 4 });
            Matrix matrix2 = new Matrix(new int[] { 1, 2, 3, 4 });
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine(matrix2.ToString());
            Console.WriteLine(matrix1.Equals(matrix2));

        }
    }
}
