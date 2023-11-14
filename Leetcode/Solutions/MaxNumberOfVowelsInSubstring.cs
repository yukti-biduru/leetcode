using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class MaxNumberOfVowelsInSubstring
    {
        public int MaxVowels(string s, int k)
        {
            int cnt = 0, max = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    cnt++;
                }
            }
            max = cnt;
            for (int i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i - k]))
                {
                    cnt--;
                }
                if (vowels.Contains(s[i]))
                {
                    cnt++;
                }
                if (max < cnt)
                {
                    max = cnt;
                }
            }
            return max;
        }
        public int MaxVowels1(string s, int k)
        {
            int cnt = 0, max = 0;
            // find the maximum substring that is continuously vowels only (m) 
            foreach (char c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    cnt++;
                }
                else
                {
                    if (cnt > max)
                        max = cnt;
                    cnt = 0;
                }
            }
            if (max == 0)
            {
                max = cnt;
            }
            // if k < m return k else return m  
            if (k < max)
            {
                return k;
            }
            return max;
        }

    }
}
