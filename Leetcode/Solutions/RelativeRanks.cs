namespace Leetcode.Solutions
{
    internal class RelativeRanks
    {
        public string[] FindRelativeRanks(int[] score)
        {
            // https://leetcode.com/problems/relative-ranks/description/
            int n = score.Length;
            Dictionary<int, int> kps = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                kps.Add(score[i], i);
            }

            int[] keys = kps.Keys.ToArray();
            Array.Sort(keys);
            Array.Reverse(keys);
            int index = 0, j = 1;
            string[] result = new string[keys.Length];
            foreach (int key in keys)
            {
                for (int i = 0; i < n; i++)
                {
                    if (key == score[i])
                    {
                        result[i] = j.ToString();
                    }
                }
                j++;

            }

            for (int i = 0; i < n; i++)
            {
                if (result[i] == "1")
                {
                    result[i] = "Gold Medal";
                }
                if (result[i] == "2")
                {
                    result[i] = "Silver Medal";
                }
                if (result[i] == "3")
                {
                    result[i] = "Bronze Medal";
                }
            }

            return result;

        }
    }
}
