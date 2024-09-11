namespace Leetcode.Solutions
{
    internal class EqualPairsRowCol
    {
        // https://leetcode.com/problems/equal-row-and-column-pairs/description/
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
