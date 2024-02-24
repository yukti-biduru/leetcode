using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class Modifymatrix
    {
        public int[][] ModifiedMatrix(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            Console.WriteLine(m); // col length
            Console.WriteLine(n); // row length
            int max = 0;
            Queue<int> row_save = new Queue<int>();
            int row = -1;
            //bool change = false; 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[j][i] == -1)
                    {
                        row_save.Enqueue(j);
                    }
                    if (max < matrix[j][i])
                    {
                        max = matrix[j][i];
                    }
                }
                while(row_save.Count > 0)
                {
                    row = row_save.Dequeue();
                    matrix[row][i] = max;
                }
                max = 0;

            }
            return matrix;
        }
    }
}
