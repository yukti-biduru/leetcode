namespace Leetcode.Solutions
{
    internal class DivideArrayIntoEqualPairs
    {
        public bool DivideArray(int[] nums)
        {
            Dictionary<int, int> kps = new Dictionary<int, int>();
            foreach (int i in nums)
            {
                if (kps.ContainsKey(i))
                {
                    kps[i]++;
                }
                else
                {
                    kps.Add(i, 1);
                }
            }
            foreach (int i in kps.Values)
            {
                if (i % 2 != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
