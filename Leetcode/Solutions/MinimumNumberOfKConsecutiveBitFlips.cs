namespace Leetcode.Solutions
{
    internal class MinimumNumberOfKConsecutiveBitFlips
    {
        public int MinKBitFlips(int[] nums, int k)
        {
            /// for given nums array take subarray of length k such that the subarray bits are flipped 
            /// once all such possible bit flips are done, the nums array should not contain any zeroes 
            /// return number of such operations, else if not possible return -1

            int n = nums.Length;
            int flipCount = 0;
            Queue<int> flipQueue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                if (flipQueue.Count > 0 && flipQueue.Peek() + k <= i)
                {
                    flipQueue.Dequeue();
                }
                if (flipQueue.Count % 2 == nums[i])
                {
                    if (i + k > n)
                    {
                        return -1;
                    }
                    flipQueue.Enqueue(i);
                    flipCount++;
                }
            }
            return flipCount;
        }
    }
}
