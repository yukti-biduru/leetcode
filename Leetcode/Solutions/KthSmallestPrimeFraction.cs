namespace Leetcode.Solutions
{
    internal class KthSmallestPrimeFraction
    {
        public int[] KthSmallestPrimeFraction1(int[] arr, int k)
        {
            if (arr.Length == 2) return arr;
            Dictionary<float, string> fractions = new Dictionary<float, string>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        fractions.Add((float)arr[i] / arr[j], arr[i] + "/" + arr[j]);
                    }
                }
            }
            float[] temp = fractions.Keys.ToArray();
            Array.Sort(temp);
            float val = temp[k];
            string val_str = fractions[val];
            string[] res = val_str.Split("/").ToArray();
            List<int> result = new List<int>();
            foreach (string s in res)
            {
                result = result.Append(Convert.ToInt32(s)).ToList();
            }
            return result.ToArray();
        }
    }
}
