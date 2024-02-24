using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class FindPolygonWithTheLargestPerimeter
    {
        public long LargestPerimeter(int[] nums)
        {
            long sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            Array.Sort(nums);
            int n = nums.Length;
            for (int i=n-1; i>=0; i--)
            {
                sum -= nums[i];
                if(sum > nums[i])
                {
                    return sum + nums[i];
                }
            }
            return -1;
        }
    }
}
