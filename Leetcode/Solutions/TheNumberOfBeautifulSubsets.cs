namespace Leetcode.Solutions
{
    internal class TheNumberOfBeautifulSubsets
    {
        public int BeautifulSubsets(int[] nums, int k)
        {
            /// Brute force is going through all subsets and checking all subset of 2 values to see if their absolute difference is k
            /// count the number where they dont have any two elements where abs diff is k 
            /// lets start by trying to list out the subsets

            List<int> subset = new List<int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                count++;
                for (int j = i; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[j] - nums[i]) != k && nums[j] - nums[i] != 0)
                    {
                        subset.Add(nums[j]);
                        count++;
                    }

                }
                subset = new List<int>();
            }
            return count;
        }
    }
}
