namespace Leetcode.Solutions
{
    internal class FindFirstPalindromicStringInArray
    {
        // https://leetcode.com/problems/find-first-palindromic-string-in-the-array/description/
        public string FirstPalindrome(string[] words)
        {

            foreach (var word in words)
            {
                if (isPalindrome(word))
                {
                    return word;
                }
            }
            return "";
        }
        public bool isPalindrome(string word)
        {
            int n = word.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (word[i] != word[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
