using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
    //Integers in each row are sorted from left to right.
    //The first integer of each row is greater than the last integer of the previous row.
namespace DataStructure.Matrix
{
    class search_a_2d_matrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int lastNum = 0;
            bool isFound = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                if (i != 0 && matrix[i][0] <= lastNum)
                {
                    return false;
                }
                int max = matrix[i][0];
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (max > matrix[i][j])
                    {
                        return false;
                    }
                    else
                    {
                        max = matrix[i][j];
                    }
                    lastNum = matrix[i][j];
                    if (matrix[i][j] == target)
                        isFound = true;
                }
            }
            return isFound;
        }
    }
}
