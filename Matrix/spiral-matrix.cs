using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Matrix
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> spiral = new List<int>();
            int rows = matrix.Length - 1;
            int cols = matrix[0].Length - 1;
            spiral = GetSpiral(matrix, 0, cols, cols, rows, rows, 0, rows, 1, spiral);
            return spiral;
        }
        public IList<int> GetSpiral(int[][] matrix, int tStart, int tEnd, int rStart, int rEnd, int bStart, int bEnd, int uStart, int uEnd, IList<int> spiral)
        {
            for (int i = tStart; i <= tEnd; i++)
            {
                spiral.Add(matrix[tStart][i]);
            }
            for (int i = rStart; i <= rEnd; i++)
            {
                spiral.Add(matrix[i][rStart]);
            }
            for (int i = bStart; i >= bEnd; i--)
            {
                spiral.Add(matrix[bStart][i]);
            }
            for (int i = uStart; i >= uEnd; i--)
            {
                spiral.Add(matrix[uStart][i]);
            }
            GetSpiral(matrix, tStart + 1, tEnd - 1, rStart + 1, rEnd - 1, bStart - 1, bEnd + 1, uStart - 1, uEnd - 1, spiral);
            return spiral;
        }
    }
}
