using System;
namespace Task_3._1
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
        bool IsEmpty();
    }
}

