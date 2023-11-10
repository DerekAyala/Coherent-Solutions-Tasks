using System.Text;

namespace Tast_2._2
{
    public class Matrix
    {
        private int _size;
        private int[] _array;

        public Matrix(int[] diagonal)
        {
            if (diagonal != null)
            {
                _size = diagonal.Length;
                _array = diagonal.ToArray();
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
                if (i < 0 || i >= _size || j < 0 || j >= _size)
                {
                    return 0;
                }
                if (i == j)
                {
                    return _array[i];
                }
                return 0;
            }
        }

        public int Track()
        {
            int sum = 0;
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    sum += this[i, j];
                }
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder($"Matrix (Size: {Size}, Trace: {Track()})\n");
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
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Matrix other = (Matrix)obj;
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
