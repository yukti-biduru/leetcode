namespace Leetcode.Solutions
{
    internal class KthDistinctStringInAnArray
    {
        public string KthDistinct(string[] arr, int k)
        {
            //https://leetcode.com/problems/kth-distinct-string-in-an-array/


            int count = 0;
            Dictionary<string, int> kp = new Dictionary<string, int>();
            foreach (string s in arr)
            {
                if (kp.Keys.Contains(s))
                {
                    kp[s]++;
                }
                else
                {
                    kp.Add(s, 1);
                }
            }

            foreach (string s in kp.Keys)
            {
                if (kp[s] == 1)
                {
                    count++;
                }
                if (count == k)
                {
                    return s;
                }
            }
            return "";

        }
    }
}
