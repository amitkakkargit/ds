using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a 2D integer array matrix, return the transpose of matrix.
//The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.
namespace DataStructure.Matrix
{
    //Given a 2D integer array matrix, return the transpose of matrix.
    //The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.
    class transpose_matrix
    {
        public int[][] Transpose(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            int[][] transposed = new int[cols][];
            for (int i = 0; i < cols; i++)
            {
                transposed[i] = new int[rows];
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j][i] = matrix[i][j];
                }
            }
            return transposed;
        }
    }
}
