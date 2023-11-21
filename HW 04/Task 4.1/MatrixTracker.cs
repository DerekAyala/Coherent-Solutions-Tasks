namespace Task_4._1
{
    public class MatrixTracker<T>
    {
        private DiagonalMatrix<T> _matrix;
        private int _lastChangedRow;
        private int _lastChangedColumn;
        private T _lastChangedOldValue;

        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            _matrix = matrix ?? throw new ArgumentNullException(nameof(matrix));
            _matrix.ElementChanged += Matrix_ElementChanged;
        }

        private void Matrix_ElementChanged(int row, int column, T oldValue, T newValue)
        {
            _lastChangedRow = row;
            _lastChangedColumn = column;
            _lastChangedOldValue = oldValue;
        }

        public void Undo()
        {
            _matrix[_lastChangedRow, _lastChangedColumn] = _lastChangedOldValue;
        }
    }
}

