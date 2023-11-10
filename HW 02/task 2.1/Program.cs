namespace task_2._1
{
    class Program
    {
        static void Main()
        {
            Point point1 = new Point(1, 2, 3, 5.0);
            Point point2 = new Point(4, 5, 6, 8.0);

            Console.WriteLine($"Point 1: X = {point1.X}, Y = {point1.Y}, Z = {point1.Z}, Mass = {point1.Mass}");
            Console.WriteLine($"Point 2: X = {point2.X}, Y = {point2.Y}, Z = {point2.Z}, Mass = {point2.Mass}");

            double distance = point1.CalculateDistance(point2);
            Console.WriteLine($"Distance between Point 1 and Point 2: {distance}");

            bool isPoint1Zero = point1.IsZero();
            bool isPoint2Zero = point2.IsZero();
            Console.WriteLine($"Is Point 1 a zero point? {isPoint1Zero}");
            Console.WriteLine($"Is Point 2 a zero point? {isPoint2Zero}");
        }
    }
}
