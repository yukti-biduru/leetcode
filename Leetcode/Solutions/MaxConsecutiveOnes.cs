using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class MaxConsecutiveOnes
    {
        public int LongestOnes(int[] nums, int k)
        {
            // start from the left and end at the right 
            int left = 0, right = 0, z_cnt = 0, max = 0;
            // loop through the array 
            // count the number of consecutive ones while skipping k zeroes 
            while (left != nums.Length && right != nums.Length)
            {
                if (right - left > max)
                {
                    max = right - left;
                }
                if (nums[right] == 1)
                {
                    right++;
                }
                else if (nums[right] == 0)
                {
                    z_cnt++;
                    right++;
                }
                if (z_cnt > k)
                {
                    z_cnt = 0;
                    left++;
                    right = left;
                }

            }
            if (right - left > max)
            {
                max = right - left;
            }
            return max;
        }

        public int LongestOnes1(int[] nums, int k)
        {
            // start with left and right counters
            // move right until you cross two zeroes 
            // on the third zero -> move the left counter until there are again only two zeroes 
            // once left counter gets to a zero remove it and then move right counter again 
            int left = 0, right = 0, zero_cnt = 0, max = 0;
            while (right < nums.Length && left < nums.Length && left <= right)
            {
                if (nums[right] == 0)
                {
                    zero_cnt++;
                }
                if (nums[right] == 1 && zero_cnt < 2)
                {
                    right++;
                }
                else
                {
                    left++;
                    if (nums[left] == 0)
                    {
                        zero_cnt--;
                    }
                }
                if (right - left > max)
                {
                    max = right - left;
                }
            }
            return max;
        }
    }
}
