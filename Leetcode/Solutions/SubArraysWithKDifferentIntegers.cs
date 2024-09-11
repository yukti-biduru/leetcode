using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class SubArraysWithKDifferentIntegers
    {
        public int SubarraysWithKDistinct(int[] nums, int k)
        {
            return AtMostDisticnt(nums, k) - AtMostDisticnt(nums, k-1);
        }
        private int AtMostDisticnt(int[] nums, int k)
        {
            int count = 0;
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
            int left = 0;

            for(int right = 0; right < nums.Length; right++)
            {
                int num = nums[right];
                if(!frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num] = 0;
                }
                frequencyMap[num]++;

                while(frequencyMap.Count > k)
                {
                    frequencyMap[nums[left]]--;
                    if (frequencyMap[nums[left]] == 0)
                    {
                        frequencyMap.Remove(nums[left]);
                    }
                    left++;
                }
                count += right - left + 1;
            }
            return count;
        }
    }
}
