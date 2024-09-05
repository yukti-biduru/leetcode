namespace Leetcode.Solutions
{
    internal class TwoSum
    {
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.Write(i + " " + j);
                        return new int[] { i, j };
                    }
                }
            }
            Console.WriteLine("newps");
            return null;

        }
    }
}
