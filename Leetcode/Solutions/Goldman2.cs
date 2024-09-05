namespace Leetcode.Solutions
{
    internal class Goldman2
    {
        public List<int> encryptionValidity(int instructionCount, int validityPeriod, List<int> keys)
        {
            Dictionary<int, int> keys_dict = new Dictionary<int, int>();
            int max_val = 0;

            foreach (int i in keys)
            {
                if (keys_dict.ContainsKey(i))
                {
                    keys_dict[i]++;
                }
                else
                {
                    keys_dict[i] = 1;
                }
            }

            for (int i = 0; i < keys.Count; i++)
            {
                int nums = keys[i];
                int count = 0;

                for (int j = 1; j <= Math.Sqrt(nums); j++)
                {
                    if (nums % j == 0)
                    {
                        if (keys_dict.ContainsKey(j))
                        {
                            count += keys_dict[j];
                        }
                        if (j != nums / j && keys_dict.ContainsKey(nums / j))
                        {
                            count += keys_dict[nums / j];
                        }
                    }
                }
                max_val = Math.Max(count, max_val);
            }
            long secret = (long)instructionCount * validityPeriod;

            if (secret >= max_val * 100000)
            {
                return new List<int> { 1, (int)(max_val * 100000) };
            }

            return new List<int> { 0, (int)(max_val * 100000) };
        }

    }

}
