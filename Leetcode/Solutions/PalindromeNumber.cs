namespace Leetcode.Solutions
{
    internal class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            int reverse = 0;
            int temp = x;
            while (temp != 0)
            {
                int digit = temp % 10;
                reverse = reverse * 10 + digit;
                temp /= 10;
            }
            if (x == reverse)
                return true;
            return false;
        }
    }
}
