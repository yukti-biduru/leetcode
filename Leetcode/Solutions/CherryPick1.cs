using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class CherryPick1
    {
        private int?[,,] dp;
        public int CherryPickup(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;

            // definitely DP
            // probably need to do make sure DP goes through both robots 
            // we will need to use recursion 
            // what will be recurring? 
            // the calculation of value when each robot moves a row 

            dp = new int?[m, n, n];
            return MaxsizeSum(grid, m, n, 0, 0, n - 1);


        }

        // current state of the grid, total rows, total columns, current row where both robots are, col for robot1, col for robot2
        private int MaxsizeSum (int[][] grid, int m, int n, int row, int col, int col2)
        {
            // keep robots inside grid and stop when grid area finishes
            if (row >= m || col < 0 || col2 < 0 || col >= n || col2 >= n)
                return 0;

            // if previous value exists return the value
            if (dp[row,col,col2].HasValue)
                return dp[row,col,col2].Value;

            // add current value to val from robot1
            int val = grid[row][col];

            // only add robot2 value if r1 and r2 are not on the same square
            if(col !=col2)
            {
                val += grid[row][col2];
            }

            int max = MaxsizeSum(grid, m, n, row + 1, col - 1, col2);

            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col - 1, col2 + 1));
            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col - 1, col2 - 1));


            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col + 1, col2));

            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col + 1, col2 + 1));
            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col + 1, col2 - 1));


            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col, col2));

            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col, col2 + 1));
            max = Math.Max(max, MaxsizeSum(grid, m, n, row + 1, col, col2 - 1));

            //memoization
            dp[row, col, col2] = max + val;
            return dp[row, col, col2].Value;
        }
    }
}
