using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class LargestDivisibleSubset
    {
        public IList<int> LargestDivisibleSubsets(int[] nums)
        {
            int[] dp = new int[nums.Length];
            int maxSize = 1, maxIndex = 0;
            Array.Fill(dp, 1);
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        Console.WriteLine("(" + nums[i] + "," + nums[j] + ")");
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                        Console.WriteLine("dp[i] = " + dp[i]);
                        if (dp[i] > maxSize)
                        {
                            maxSize = dp[i];
                            maxIndex = i;

                        }
                        Console.WriteLine("maxSize = " + maxSize);

                    }
                }
            }
            List<int> result = new List<int>();
            int num = nums[maxIndex];
            for (int i = maxIndex; i >= 0; i--)
            {
                if (num % nums[i] == 0 && dp[i] == maxSize)
                {
                    result.Add(nums[i]);
                    num = nums[i];
                    maxSize--;
                }
            }
            return result;
        }
        public IList<int> LargestDivisibleSubsets1(int[] nums)
        {
            int n = nums.Length;
            int[] dp = new int[n];
            Array.Fill(dp, 1);
            Array.Sort(nums);

            int maxSize = 1, maxIndex = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] % nums[j] == 0)
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                        if (dp[i] > maxSize)
                        {
                            maxSize = dp[i];
                            maxIndex = i;
                        }
                    }
                }
            }
            List<int> result = new List<int>();
            int num = nums[maxIndex];
            for (int i = maxIndex; i >= 0; i--)
            {
                if (num % nums[i] == 0 && dp[i] == maxSize)
                {
                    result.Add(nums[i]);
                    num = nums[i];
                    maxSize--;
                }
            }
            return result;
        }
    }
}
