using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class MinimumBitFlipssToConvertNumber
    {
        public int MinBitFlips(int start, int goal)
        {
            // convert number to bits  
            // bits to string
            string bin1 = Convert.ToString(start, 2);
            string bin2 = Convert.ToString(goal, 2);

            // compare difference
            int n = bin1.Length, m = bin2.Length, count = 0, i, j;
            for (i = n - 1, j = m - 1; i >= 0 && j >= 0; i--, j--)
            {
                if (bin1[i] != bin2[j])
                {
                    count++;
                }
            }
            for (; i >= 0; i--)
            {
                if (bin1[i] != '0')
                { count++; }
            }
            for (; j >= 0; j--)
            {
                if (bin2[j] != '0')
                { count++; }
            }
            return count;
        }
    }
}
