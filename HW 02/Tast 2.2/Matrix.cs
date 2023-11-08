namespace Tast_2._2
{
    public class Matrix
    {
        private int size;
        private int[] array;

        public Matrix(params int[] diagonal)
        {
            if (diagonal != null)
            {
                size = diagonal.Length;
                array = new int[size * size];
                GenerateMatrix(diagonal);
            }
            else
            {
                size = 0;
                array = new int[0];
            }
        }

        public int Size
        {
            get { return size; }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= size || j < 0 || j >= size)
                {
                    return 0;
                }
                if (i == j)
                {
                    return array[i];
                }
                return 0;
            }
        }

        private void GenerateMatrix(int[] diagonal)
        {
            int count = 0;
            int d = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        array[count] = diagonal[d];
                        d++;
                    }
                    else
                    {
                        array[count] = 0;
                    }
                    count++;
                }
            }
        }

        public int Track()
        {
            int sum = 0;
            int c = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        sum += array[c];
                    }
                    c++;
                }
            }
            return sum;
        }

        public override string ToString()
        {
            String text = $"Matrix (Size: {Size}, Trace: {Track()})\n";
            int c = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    text += array[c].ToString() + " ";
                    c++;
                }
                text += "\n";
            }
            return text;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Matrix other = (Matrix)obj;
            if (Size != other.Size)
            {
                return false;
            }
            for (int i = 0; i < size * size; i++)
            {
                if (array[i] != other.array[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}


