namespace Leetcode.Solutions
{
    internal class CheckIfAllAsAppearBeforeAllBs
    {
        public bool CheckString(string s)
        {
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            int i = 0;
            foreach (char c in s)
            {
                if (c == 'a')
                {
                    one.Add(i);
                }
                if (c == 'b')
                {
                    two.Add(i);
                }
                i++;
            }
            int j = 0, k = 0;
            while (one.Count > j && two.Count > k)
            {
                if (one[j] > two[k])
                {
                    return false;
                }
                j++;
                k++;
            }
            return true;
        }
    }
}
