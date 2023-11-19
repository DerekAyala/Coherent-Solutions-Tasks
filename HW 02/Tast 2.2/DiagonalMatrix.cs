using System;
using System.Text;

namespace Task_2._2
{
    public class DiagonalMatrix
    {
        private int _size;
        private int[] _array;

        public DiagonalMatrix(params int[] diagonal)
        {
            if (diagonal != null)
            {
                _size = diagonal.Length;
                _array = diagonal;
            }
            else
            {
                _size = 0;
                _array = new int[0];
            }
        }

        public int Size
        {
            get { return _size; }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= _size || j < 0 || j >= _size || i != j)
                {
                    return 0;
                }
                return _array[i];
            }
        }

        public int Track()
        {
            int sum = 0;
            for (int i = 0; i < _size; i++)
            {
                sum += _array[i];
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder($"DiagonalMatrix (Size: {Size}, Track: {Track()})\n");
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    text.Append(this[i, j].ToString()).Append(" ");
                }
                text.AppendLine();
            }
            return text.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj is not DiagonalMatrix || this.Size != ((DiagonalMatrix)obj).Size)
            {
                return false;
            }

            DiagonalMatrix other = (DiagonalMatrix)obj;
            for (int i = 0; i < _size; i++)
            {
                if (this[i, i] != other[i, i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
