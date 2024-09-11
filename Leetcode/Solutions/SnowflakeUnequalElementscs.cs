public class SnowflakeUnequalElementscs
{
    public int FindMaxLength(int[] skills, int k)
    {
        int n = skills.Length;

        // Initialize dp array with zeros
        int[] dp = new int[n + 1];

        // Iterate through the skills array
        for (int i = 0; i < n; i++)
        {
            // Try to extend the subsequence ending at i
            for (int j = i - k; j < i; j++) // Adjust the range based on k
            {
                if (j >= 0)
                {
                    dp[i + 1] = Math.Max(dp[i + 1], dp[j + 1] + 1);
                }
            }
        }

        // Return the maximum length found
        int maxLength = 0;
        for (int i = 0; i <= n; i++)
        {
            maxLength = Math.Max(maxLength, dp[i]);
        }

        return maxLength;
    }


}
