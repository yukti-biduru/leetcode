namespace Leetcode.Solutions
{
    internal class FindPathsUsingDP
    {
        // https://leetcode.com/problems/out-of-boundary-paths/description/
        public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
        {
            // initialize an array m*n that will contain the number of paths for each point in the grid
            int[,,] dp = new int[m, n, maxMove + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k <= maxMove; k++)
                    {
                        dp[i, j, k] = -1;
                    }
                }
            }
            return ComputePaths(maxMove, startRow, startColumn, m, n, dp);

        }

        public int ComputePaths(int moves, int p_row, int p_col, int m, int n, int[,,] dp)
        {
            int mod = 1000000007;

            if (p_row < 0 || p_row >= m || p_col < 0 || p_col >= n)
            {
                return 1;
            }
            if (moves <= 0)
            {
                return 0;
            }
            if (dp[p_row, p_col, moves] != -1)
            {
                return dp[p_row, p_col, moves];
            }

            int res = 0;

            res = (res + ComputePaths(moves - 1, p_row, p_col + 1, m, n, dp)) % mod; // up
            res = (res + ComputePaths(moves - 1, p_row, p_col - 1, m, n, dp)) % mod; // down
            res = (res + ComputePaths(moves - 1, p_row - 1, p_col, m, n, dp)) % mod; // left
            res = (res + ComputePaths(moves - 1, p_row + 1, p_col, m, n, dp)) % mod; // right

            dp[p_row, p_col, moves] = res;
            return res;
        }
    }
}

// create dp array 
// initialize Dp array 
// return for top case

// exhaust all base cases  
// recursion if needed (usually needed in top down approach)
// might not be needed in bottom up approach 

// save value gotten 
// return value gotten
