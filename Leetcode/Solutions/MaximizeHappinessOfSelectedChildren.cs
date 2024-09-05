namespace Leetcode.Solutions
{
    internal class MaximizeHappinessOfSelectedChildren
    {
        // time limit exceeded
        public long MaximumHappinessSum1(int[] happiness, int k)
        {
            Array.Sort(happiness);
            Array.Reverse(happiness);
            long res = 0;
            List<int> happ = happiness.ToList();
            res += happ.First();
            happ.RemoveAt(0);
            k--;
            while (k != 0)
            {
                happ = happ.Select(h => h = Decrement(h)).ToList();
                res += happ.First();
                k--;
                happ.RemoveAt(0);
            }
            return res;
        }
        public int Decrement(int h)
        {
            return h > 0 ? h - 1 : h;
        }

        // new
        public long MaximumHappinessSum2(int[] happiness, int k)
        {
            long res = 0;
            int index;
            List<int> happ = happiness.ToList();
            while (k > 0)
            {
                index = happ.FindIndex(h => h == happ.Max());
                res += happ.Max();
                happ.RemoveAt(index);
                k--;
                happ = happ.Select(h => h > 0 ? h - 1 : h).ToList();
            }
            return res;
        }

        // again 
        public long MaximumHappinessSum(int[] happiness, int k)
        {
            int j = 0;
            long res = 0;
            int n = happiness.Length;
            Array.Sort(happiness);
            for (int i = n - 1; i >= 0 && k > 0; i--)
            {
                res += Math.Max(happiness[i] - j++, 0);
                k--;
            }
            return res;
        }

    }
}
