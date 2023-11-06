using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first 9 digits of the ISBN:");
        string input = Console.ReadLine();

        int checkDigit = CalculateCheckDigit(input);
        string isbn = input + (checkDigit == 10 ? "X" : checkDigit.ToString());
        Console.WriteLine("Resulting ISBN: " + isbn);
    }

    static int CalculateCheckDigit(string input)
    {
        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += (10 - i) * int.Parse(input[i].ToString());
        }

        int checkDigit = (11 - (sum % 11)) % 11;
        return checkDigit;
    }
}