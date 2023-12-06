using System;
namespace Task_4._1
{
    public class DiagonalMatrix<T>
    {
        private T[] _diagonalElements;
        private int _size;

        public DiagonalMatrix(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("Size can't be negative");
            }

            _size = size;
            _diagonalElements = new T[Size];

        }

        public int Size
        {
            get { return _size; }
        }

        public T this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException("I or J is out of Range.");
                }
                if (i == j)
                {
                    return _diagonalElements[i];
                }
                else
                {
                    return default(T);
                }
            }
            set
            {
                if (i < 0 || j < 0 || i >= Size || j >= Size)
                {
                    throw new IndexOutOfRangeException("I or J is out of Range.");
                }
                if (i == j)
                {
                    T oldValue = _diagonalElements[i];
                    _diagonalElements[i] = value;
                    OnElementChanged(i, j, oldValue, value);
                }
            }
        }

        public delegate void ElementChangedEventHandler(int row, int column, T oldValue, T newValue);

        public event ElementChangedEventHandler ElementChanged;

        private void OnElementChanged(int row, int column, T oldValue, T newValue)
        {
            ElementChanged?.Invoke(row, column, oldValue, newValue);
        }
    }
}

