using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Matrix
{
    class matrix_diagonal_sum
    {
        public int DiagonalSum(int[][] mat)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            int indexPlus = 0;
            int sum = 0;
            while (indexPlus < rows)
            {
                if (indexPlus != (rows / 2) || rows % 2 == 0)
                    sum += mat[indexPlus][indexPlus];
                indexPlus += 1;
            }
            indexPlus = 0;
            int indexMinus = rows - 1;
            while (indexMinus >= 0)
            {
                sum += mat[indexMinus][indexPlus];
                indexMinus -= 1;
                indexPlus += 1;
            }
            return sum;
        }
    }
}
