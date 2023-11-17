using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class LongestSubarrayOfOnes
    {
        public int LongestSubarray(int[] nums)
        {
            int left = 0, z_cnt = 0, max = 0, result = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                //z_cnt += nums[right] == 0 ? 1 : 0;
                if (nums[right] == 0)
                {
                    z_cnt++;
                }
                else
                {
                    max++;
                }
                if (z_cnt > 1)
                {
                    if (nums[left] == 0)
                    {
                        z_cnt -= 1;
                    }
                    else
                    {
                        max -= 1;
                    }
                    left++;
                }
                if (result < max)
                {
                    result = max;
                }
                if(max == nums.Length)
                {
                    result--;
                }
            }
            return result;
        }
    }
}
