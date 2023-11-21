namespace Task_3._1
{
    public class Program
    {
        static void Main()
        {
            IQueue<int> myQueue = new Queue<int>(5);

            myQueue.Enqueue(10);
            myQueue.Enqueue(20);
            myQueue.Enqueue(30);

            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Dequeue(); // Trying to dequeue from an empty queue

            Console.ReadLine();
        }
    }
}