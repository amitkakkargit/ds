using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Matrix
{
    class reshape_the_matrix
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int rows = mat.Length;
            int cols = mat[0].Length;
            if (rows * cols != r * c)
            {
                return mat;
            }
            var reshaped = new int[r][];
            for (int k = 0; k < r; k++)
            {
                reshaped[k] = new int[c];
            }
            int indexR = 0;
            int indexC = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    reshaped[indexR][indexC] = mat[i][j];
                    if (indexC == c - 1)
                    {
                        indexR += 1;
                        indexC = 0;
                    }
                    else
                    {
                        indexC += 1;
                    }
                }
            }
            return reshaped;
        }
    }
}
