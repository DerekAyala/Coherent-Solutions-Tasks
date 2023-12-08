using Task_5._1;

class Program
{
    static void Main()
    {
        // Crear una matriz dispersa 10x10
        SparseMatrix matrix = new SparseMatrix(5, 5);

        // Establecer algunos elementos no cero
        matrix[1, 1] = 5;
        matrix[3, 3] = 8;
        matrix[2, 2] = 3;

        // Obtener la cantidad de ceros en la matriz
        int countZeros = matrix.GetCount(0);

        // Imprimir resultados
        Console.WriteLine("Matriz:");
        Console.WriteLine(matrix);

        Console.WriteLine("\nCantidad de ceros en la matriz: " + countZeros);
        
    }
}