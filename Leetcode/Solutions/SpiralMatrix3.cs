namespace Leetcode.Solutions
{
    internal class SpiralMatrix3
    {
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int count = rows * cols;
            int i = 1, i1 = 0, j1 = 0;
            List<int[]> result = new List<int[]>();

            if (rStart < rows && rStart >= 0 && cStart >= 0 && cStart < cols)
            {
                result.Add(new int[] { rStart, cStart });
                count--;
            }
            while (count > 0)
            {
                // right    row, col+1
                while (i1 < i)
                {
                    cStart++;
                    i1++;
                    if (rStart < rows && rStart >= 0 && cStart >= 0 && cStart < cols)
                    {
                        result.Add(new int[] { rStart, cStart });
                        count--;
                    }
                }
                i1 = 0;
                // down     row+1, col 
                while (i1 < i)
                {
                    rStart++;
                    i1++;
                    if (rStart < rows && rStart >= 0 && cStart >= 0 && cStart < cols)
                    {
                        result.Add(new int[] { rStart, cStart });
                        count--;
                    }
                }
                i1 = 0;
                i++;
                // left     row, col-1
                while (i1 < i)
                {
                    cStart--;
                    i1++;
                    if (rStart < rows && rStart >= 0 && cStart >= 0 && cStart < cols)
                    {
                        result.Add(new int[] { rStart, cStart });
                        count--;
                    }
                }
                i1 = 0;
                // up       row-1, col
                while (i1 < i)
                {
                    rStart--;
                    i1++;
                    if (rStart < rows && rStart >= 0 && cStart >= 0 && cStart < cols)
                    {
                        result.Add(new int[] { rStart, cStart });
                        count--;
                    }
                }
                i1 = 0;
                i++;
            }
            return result.ToArray();

        }
    }
}