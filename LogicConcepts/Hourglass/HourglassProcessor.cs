using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    public class HourglassProcessor
    {
        private readonly int[,] _matrix;
        private readonly int _n;

        public HourglassProcessor(int n)
        {
            if (n % 2 == 0)
            {
                throw new ArgumentException("El valor ingresado debe ser impar.");
            }

            _n = n;
            _matrix = new int[n, n];
            FillMatrix();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    _matrix[i, j] = (2 * i) + j;
                }
            }
        }

        public void DisplayFull()
        {
            Console.WriteLine("Matriz completa:");
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    Console.Write($"{_matrix[i, j],-4}");
                }
                Console.WriteLine();
            }
        }

        public void DisplayHourglass()
        {
            Console.WriteLine("\nReloj de arena:");
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    
                    bool isTopHalf = (j >= i && j <= _n - 1 - i);
                    bool isBottomHalf = (j <= i && j >= _n - 1 - i);

                    if (isTopHalf || isBottomHalf)
                    {
                        Console.Write($"{_matrix[i, j],-4}");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
