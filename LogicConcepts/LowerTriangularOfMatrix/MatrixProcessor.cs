using System;

namespace LowerTriangularOfMatrix
{
    public class MatrixProcessor
    {
        private readonly int[,] _matrix;
        private readonly int _order;

        public MatrixProcessor(int n)
        {
            _order = n;
            _matrix = new int[n, n];
            FillMatrix();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < _order; i++)
            {
                for (int j = 0; j < _order; j++)
                {
                    _matrix[i, j] = i + j;
                }
            }
        }

        public void DisplayFull()
        {
            for (int i = 0; i < _order; i++)
            {
                for (int j = 0; j < _order; j++)
                {
                    Console.Write($"{_matrix[i, j],-4}");
                }
                Console.WriteLine();
            }
        }

        public void DisplayLowerTriangular()
        {
            for (int i = 0; i < _order; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{_matrix[i, j],-4}");
                }
                Console.WriteLine();
            }
        }
    }
}