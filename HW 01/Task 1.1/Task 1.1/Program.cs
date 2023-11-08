using System;

class Program
{
    static void Main()
    {
        int a, b;
        do
        {
            Console.WriteLine("Enter two integers a and b (a < b, both non-negative):");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a < 0 || b < 0)
            {
                Console.WriteLine("Both a and b must be non-negative.");
            }
            if (a >= b)
            {
                Console.WriteLine("b must be greater than a.");
            }
        } while (a < 0 || b < 0 || a >= b);

        Console.WriteLine($"Numbers in the range from {a} to {b} with exactly two 'A's in their duodecimal representation:");

        for (int num = a; num <= b; num++)
        {
            string duodecimalRepresentation = ConvertToDuodecimal(num);
            int aCount = CountAsInDuodecimal(duodecimalRepresentation);

            if (aCount == 2)
            {
                Console.WriteLine($"{num} (Decimal) = {duodecimalRepresentation} (Duodecimal)");
            }
        }
    }

    static string ConvertToDuodecimal(int num)
    {
        if (num == 0)
        {
            return "0"; // El caso especial para 0 en duodecimal
        }

        string duodecimalSymbols = "0123456789AB";
        string duodecimalRepresentation = "";

        while (num > 0)
        {
            int remainder = num % 12;
            duodecimalRepresentation = duodecimalSymbols[remainder] + duodecimalRepresentation;
            num /= 12;
        }

        return duodecimalRepresentation;
    }


    static int CountAsInDuodecimal(string duodecimalRepresentation)
    {
        int count = 0;

        foreach (char c in duodecimalRepresentation)
        {
            if (c == 'A')
            {
                count++;
            }
        }

        return count;
    }
}
