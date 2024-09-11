namespace Leetcode.Solutions
{
    internal class BitwiseANDofNumbers
    {
        // it just works. IDK how.
        public int RangeBitwiseAnd(int left, int right)
        {
            var count = 0;

            while (left != right)
            {
                count++;
                Console.WriteLine(count);
                left = left >> 1;
                Console.WriteLine(left);
                right = right >> 1;
                Console.WriteLine(right);
            }

            return left << count;
        }
    }
}
