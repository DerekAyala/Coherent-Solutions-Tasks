using System;
namespace Task_3._1
{
    public class Queue<T> : IQueue<T>
    {
        private T[] elements;
        private int front;
        private int rear;

        public Queue(int capacity)
        {
            elements = new T[capacity];
            front = -1;
            rear = -1;
        }

        public void Enqueue(T item)
        {
            if (rear == elements.Length - 1)
            {
                throw new InvalidOperationException("The Queue is full");
            }

            if (IsEmpty())
            {
                front = rear = 0;
            }
            else
            {
                rear++;
            }

            elements[rear] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Queue is empty");
            }

            T item = elements[front];

            if (front == rear)
            {
                front = rear = -1;
            }
            else
            {
                front++;
            }

            return item;
        }

        public bool IsEmpty()
        {
            return front == -1;
        }
    }
}

