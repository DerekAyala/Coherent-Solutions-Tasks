using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] originalArray = new int[n];
        int[] uniqueArray = new int[n];
        int uniqueCount = 0;

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            int element = int.Parse(Console.ReadLine());
            originalArray[i] = element;

            if (!ArrayContains(uniqueArray, uniqueCount, element))
            {
                uniqueArray[uniqueCount] = element;
                uniqueCount++;
            }
        }

        Console.WriteLine("Original Array:");
        PrintArray(originalArray, originalArray.Length);

        Console.WriteLine("New Array with Unique Values:");
        PrintArray(uniqueArray, uniqueCount);
    }

    static bool ArrayContains(int[] array, int length, int value)
    {
        for (int i = 0; i < length; i++)
        {
            if (array[i] == value)
            {
                return true;
            }
        }
        return false;
    }

    static void PrintArray(int[] array, int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}