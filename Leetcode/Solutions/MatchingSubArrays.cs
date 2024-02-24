using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class MatchingSubArrays
    {
        public int CountMatchingSubarrays(int[] nums, int[] pattern)
        {
            int n = nums.Length;
            int m = pattern.Length;
            int j = m + 1;
            int count = 0;
            Queue<int> sub = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (i < m + 1)
                {
                    sub.Enqueue(nums[i]);
                }
                else
                {
                    if (CheckPattern(sub.ToArray(), pattern))
                    {
                        count++;
                    }
                    sub.Dequeue();
                    sub.Enqueue(nums[i]);
                }
            }
            if (CheckPattern(sub.ToArray(), pattern))
            {
                count++;
            }
            return count;
        }
        public bool CheckPattern(int[] sub, int[] pattern)
        {
            for (int k = 0; k < pattern.Length; k++)
            {
                if (pattern[k] == 1 && sub[k + 1] <= sub[k])
                {
                    return false;
                }
                else if (pattern[k] == 0 && sub[k + 1] != sub[k])
                {
                    //sub[k + 1] = sub[k]
                    return false;
                }
                else if (pattern[k] == -1 && sub[k + 1] >= sub[k])
                {
                    //sub[k + 1] < sub[k]
                    return false;
                }
            }
            return true;
        }
    }
}
