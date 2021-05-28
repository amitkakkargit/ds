using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Matrix
{
    class lucky_numbers_in_a_matrix
    {
        public IList<int> LuckyNumbers(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            Dictionary<int, List<int>> minInRow = new Dictionary<int, List<int>>();
            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i][0];
                int x = 0;
                int y = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] < min)
                    {
                        min = matrix[i][j];
                        x = i;
                        y = j;
                    }
                }
                var c = new List<int>();
                c.Add(x);
                c.Add(y);
                minInRow.Add(min, c);
            }
            var final = new List<int>();
            foreach (var item in minInRow)
            {
                int min = item.Key;
                int max = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i][item.Value[1]] > max)
                    {
                        max = matrix[i][item.Value[1]];
                    }
                }
                if (min == max)
                {
                    final.Add(min);
                }
            }
            return final;
        }
    }
}
