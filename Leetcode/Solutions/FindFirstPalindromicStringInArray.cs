using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class FindFirstPalindromicStringInArray
    {
        public string FirstPalindrome(string[] words)
        {
            
            foreach (var word in words)
            {
                if(isPalindrome(word))
                {
                    return word;
                }
            }
            return "";
        }
        public bool isPalindrome (string word)
        {
            int n = word.Length;
            for (int i = 0; i < n/2; i++)
            {
                if (word[i] != word[n-i-1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
