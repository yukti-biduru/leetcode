namespace Leetcode.Solutions
{
    internal class KInversePairsDP
    {
        public int KInversePairs(int n, int k)
        {
            // initialize dp array
            int[,] dp = new int[n + 1, k + 1];
            int temp;

            // take care of the base cases 
            if (n == 0)
            {
                return 0;
            }
            if (k == 0)
            {
                return 1;
            }


            for (int i = 1; i <= n; i++)
            {
                dp[i, 0] = 1;
                for (int j = 1; j <= k; j++)
                {
                    temp = 0;
                    for (int p = 0; p <= Math.Min(i - 1, j); p++)
                    {
                        temp = (temp + dp[i - 1, j - p]) % 1000_000_007;
                    }
                    dp[i, j] = temp;
                }
            }
            return dp[n, k];
        }

    }
}
