namespace Task_4._2
{
    class Program
    {
        static void Main()
        {

            RationalNumber r1 = new RationalNumber(1, 2);
            RationalNumber r2 = new RationalNumber(2, 4);

            RationalNumber sum = r1 + r2;
            RationalNumber difference = r1 - r2;
            RationalNumber product = r1 * r2;
            RationalNumber quotient = r1 / r2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
        }
    }
}