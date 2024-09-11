namespace Leetcode.Solutions
{
    internal class DivideArraysIntoArraysWithMaxDifference
    {
        // https://leetcode.com/problems/divide-array-into-arrays-with-max-difference/description/

        public int[][] DivideArray(int[] nums, int k)
        {
            if (nums.Length % 3 != 0)
            {
                return new int[0][];
            }
            // sort the array
            Array.Sort(nums);
            // take three elements at a time
            int i = 0, j = 0, x = 0;
            int[] each = new int[3];
            int[][] output = new int[nums.Length / 3][];

            while (i < nums.Length)
            {
                while (j < 3)
                {
                    each[j] = nums[i];
                    i++;
                    j++;
                }
                // check the differences 
                if (Math.Abs(each[0] - each[1]) <= k && Math.Abs(each[1] - each[2]) <= k && Math.Abs(each[0] - each[2]) <= k)
                {
                    output[x] = each;
                    x++;
                }
                else
                {
                    // exit if any doesnt satisfy
                    return new int[0][];
                }
                each = new int[3];
                //i++;
                j = 0;
            }
            return output;
        }
    }
}
