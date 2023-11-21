using System;
namespace Task_3._1
{
    public class Queue<T> : IQueue<T>
    {
        private T[] _elements;
        private int _frontIndex;
        private int _rearIndex;
        private int _capacity;

        public Queue(int capacity)
        {
            _capacity = capacity;
            _elements = new T[_capacity];

            // -1 means that the Queue is empty
            _frontIndex = -1;
            _rearIndex = -1;
        }

        public void Enqueue(T item)
        {
            if (_rearIndex == _capacity - 1)
            {
                throw new InvalidOperationException("The Queue is full");
            }

            if (IsEmpty())
            {
                _frontIndex = _rearIndex = 0;
            }
            else
            {
                _rearIndex++;
            }

            _elements[_rearIndex] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The Queue is empty");
            }

            T item = _elements[_frontIndex];

            if (_frontIndex == _rearIndex)
            {
                // -1 means that the Queue is empty
                _frontIndex = _rearIndex = -1;
            }
            else
            {
                _frontIndex++;
            }

            return item;
        }

        public bool IsEmpty()
        {
            return _frontIndex == -1;
        }
    }
}
