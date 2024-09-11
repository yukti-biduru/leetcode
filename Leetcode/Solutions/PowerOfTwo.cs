namespace Leetcode.Solutions
{
    internal class PowerOfTwo
    {
        // https://leetcode.com/problems/power-of-two/description/
        public bool IsPowerOfTwo(int n)
        {
            return (Math.Log2(n) % 2 == 0);
        }
    }
}
