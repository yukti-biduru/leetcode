namespace Leetcode.Solutions
{
    internal class RearrageArrayBySign
    {
        // https://leetcode.com/problems/rearrange-array-elements-by-sign/description/
        public int[] RearrangeArray(int[] nums)
        {
            Queue<int> pos = new Queue<int>();
            Queue<int> neg = new Queue<int>();
            foreach (int i in nums)
            {
                if (i < 0)
                {
                    neg.Enqueue(i);
                }
                else { pos.Enqueue(i); }
            }
            Queue<int> output = new Queue<int>();
            while (pos.Count > 0 || neg.Count > 0)
            {
                if (pos.Count == 0)
                {
                    output.Enqueue(neg.Dequeue());
                }
                if (neg.Count == 0)
                {
                    output.Enqueue(pos.Dequeue());
                }
                else
                {
                    output.Enqueue(pos.Dequeue());
                    output.Enqueue(neg.Dequeue());
                }
            }
            return output.ToArray();
        }
    }
}
