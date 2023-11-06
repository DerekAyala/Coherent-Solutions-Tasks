using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two integers a and b:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

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
