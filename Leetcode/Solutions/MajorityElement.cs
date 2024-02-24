using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class MajorityElement
    {
        public int MajorityElements(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }
            Array.Sort(nums);
            int count=1, max=0, val = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i-1])
                {
                    count++;
                }
                if (nums[i] != nums[i-1] || i== nums.Length-1)
                {
                    //precount = count;
                    if(count> max)
                    {
                        max = count;
                        val = nums[i-1];
                    }
                    count = 1;
                }
            }
            return val;

        }
    }
}
