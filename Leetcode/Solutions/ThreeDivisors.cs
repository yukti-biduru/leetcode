namespace Leetcode.Solutions
{
    internal class ThreeDivisors
    {
        public bool IsThree(int n)
        {
            int z = n / 2;
            List<int> factors = new List<int>();

            for (int i = 1; i <= z; i++)
            {
                if (n % i == 0)
                {
                    factors.Add(i);
                    factors.Add(n / i);
                }
            }
            if (factors.Distinct().ToList().Count == 3)
                return true;
            else return false;
        }
    }
}
