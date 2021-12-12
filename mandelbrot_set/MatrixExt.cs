using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mandelbrot_set
{
    static class MatrixExt
    {
        public static int RowsCount(this float[,] matrix)
        {
            return matrix.GetUpperBound(0) + 1;
        }

        public static int ColumnsCount(this float[,] matrix)
        {
            return matrix.GetUpperBound(1) + 1;
        }
    }
}
