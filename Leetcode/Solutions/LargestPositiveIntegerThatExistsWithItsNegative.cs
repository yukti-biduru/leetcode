namespace Leetcode.Solutions
{
    internal class LargestPositiveIntegerThatExistsWithItsNegative
    {
        public int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            int m = nums.Length - 1, i = 0;

            while (true)
            {
                if (nums[i] < 0)
                {

                    if (nums[m] == Math.Abs(nums[i]))
                    {
                        break;
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    m--;
                    if (m < 0)
                    {
                        return -1;
                    }
                    i = 0;
                }
                if (nums[m] < 0)
                {
                    return -1;
                }

            }
            return nums[m];
        }
    }
}
