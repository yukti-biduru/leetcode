namespace Leetcode.Solutions
{
    internal class LargestLocalValuesInAMatrix
    {
        public int[][] LargestLocal(int[][] grid)
        {
            int max = 0, n = grid.Length;
            int[][] result = new int[n - 2][];
            int i = 0, j = 0, k = 0, l = 0;
            while (i != n && j != n)
            {
                for (i = k; i < n - 1; i++)
                {
                    for (j = l; j < l + n - 1; j++)
                    {
                        Console.WriteLine(grid[i][j]);
                    }
                    Console.WriteLine();
                }
                if (j != n - 1)
                {
                    l++;
                }
            }

            return result;

        }
    }
}
