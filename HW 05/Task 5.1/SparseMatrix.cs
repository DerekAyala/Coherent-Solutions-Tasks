using System;
using System.Text;

namespace Task_5._1
{
    public class SparseMatrix : IEnumerable<long>
    {
        private List<Tuple<int, int, long>> _nonZeroElements;
        private readonly int _rows;
        private readonly int _columns;

        public SparseMatrix(int numRows, int numColumns)
        {
            if (numRows <= 0 || numColumns <= 0)
                throw new ArgumentException("Number of rows and columns must be strictly greater than zero.");

            _rows = numRows;
            _columns = numColumns;
            _nonZeroElements = new List<Tuple<int, int, long>>();
        }

        public long this[int i, int j]
        {
            get
            {
                ValidateIndices(i, j);
                return GetElement(i, j);
            }
            set
            {
                ValidateIndices(i, j);
                SetElement(i, j, value);
            }
        }

        private long GetElement(int i, int j)
        {
            foreach (var tuple in _nonZeroElements)
            {
                if (tuple.Item1 == i && tuple.Item2 == j)
                    return tuple.Item3;
            }
            return 0;
        }

        private void SetElement(int i, int j, long value)
        {
            // Remove existing entry if present
            _nonZeroElements.RemoveAll(tuple => tuple.Item1 == i && tuple.Item2 == j);

            // Add the new value if it's not zero
            if (value != 0)
                _nonZeroElements.Add(new Tuple<int, int, long>(i, j, value));
        }

        public IEnumerator<long> GetEnumerator()
        {
            // Iterate through rows and columns
            for (int j = 0; j < _columns; j++)
            {
                for (int i = 0; i < _rows; i++)
                {
                    yield return GetElement(i, j);
                }
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<(int, int, long)> GetNonzeroElements()
        {
            return (IEnumerable<(int, int, long)>)_nonZeroElements.OrderBy(tuple => tuple.Item2).ThenBy(tuple => tuple.Item1);
        }

        public int GetCount(long x)
        {
            if (x == 0)
            {
                // Contar la cantidad de ceros
                return _rows * _columns - _nonZeroElements.Count;
            }
            else
            {
                // Contar la cantidad de elementos no cero con el valor x
                return _nonZeroElements.Count(tuple => tuple.Item3 == x);
            }
        }

        private void ValidateIndices(int i, int j)
        {
            if (i < 0 || i >= _rows || j < 0 || j >= _columns)
                throw new IndexOutOfRangeException("Indices are out of range.");
        }

            public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    sb.Append(GetElement(i, j));
                    sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

