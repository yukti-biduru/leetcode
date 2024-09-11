using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class LengthOfLongestSubArrayWithAtMostKFrequency
    {
        public int MaxSubarrayLength(int[] nums, int k)
        {
            int i = 0;
            int j = 0;
            int n = nums.Length;
            int ans = 1;
            Dictionary<int,int> dict = new Dictionary<int,int>();

            while(i<n)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }

                while (dict[nums[i]] > k)
                {
                    dict[nums[j]]--;
                    j++;
                }
                ans = Math.Max(ans, i - j + 1);
                i++;
            }
            return ans;
        }
    }
}
