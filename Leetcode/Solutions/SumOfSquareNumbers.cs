namespace Leetcode.Solutions
{
    internal class SumOfSquareNumbers
    {
        public bool JudgeSquareSum(int c)
        {
            long n = (long)Math.Sqrt(c);
            long left = 0, right = n, a = 0;
            while (left <= right)
            {
                a = (left * left) + (right * right);
                if (a == c)
                {
                    Console.WriteLine(left);
                    Console.WriteLine(right);
                    return true;
                }
                else if (a < c)
                {
                    left++;
                }
                else if (a > c)
                {
                    right--;
                }
            }
            return false;
        }
    }
}
