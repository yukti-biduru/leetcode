using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class EqualPairsRowCol
    {
        public int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            int count = 0;
            int[][] transpose = new int[n][];
            for (int i = 0; i < n; i++)
            {
                transpose[i] = new int[n];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    transpose[j][i] = grid[i][j];
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i].ToList().SequenceEqual(transpose[j].ToList()))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
