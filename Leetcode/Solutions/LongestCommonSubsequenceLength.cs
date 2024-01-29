using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class LongestCommonSubsequenceLength
    {
        public int LongestCommonSubsequence(string word1, string word2)
        {
            int m = word1.Length;
            int n = word2.Length;
            int[,] calcs = new int[m + 1, n + 1];

            for (int i = m - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (word1[i] == word2[j])
                    {
                        calcs[i, j] = calcs[i + 1, j + 1] + 1;
                    }
                    else
                    {
                        calcs[i, j] = Math.Max(calcs[i + 1, j], calcs[i, j + 1]);
                    }
                    Console.WriteLine("i = " + i + " j = " + j + " calcs[i,j]" + calcs[i, j]);
                }
            }
            Console.WriteLine(calcs[0, 0]);
            return calcs[0, 0];
        }
    }
}
