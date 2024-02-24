using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class PalindromicSubstrings
    {
        public int CountSubstrings(string s)
        {
            int n = s.Length;
            int count = 0;
            bool[,] dp = new bool[n, n];

            // initialize and count all single chars 
            for (int i = 0; i < n; i++)
            {
                dp[i, i] = true;
                count++;
            }

            for (int i = 0; i < n - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    dp[i, i + 1] = true;
                    count++;
                }
            }
            for (int len = 3; len <= n; len++)
            {
                for( int i=0; i<=n-len; i++)
                {
                    int j = i + len - 1;
                    if (s[i] == s[j] && dp[i+1, j-1])
                    {
                        dp[i, j] = true;
                        count++;
                    }
                }
            }
            return count; 
        }
    }
}
