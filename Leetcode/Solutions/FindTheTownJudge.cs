using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class FindTheTownJudge
    {
        public int FindJudge(int n, int[][] trust)
        {
            int[] log = new int[n+1];
            foreach (int[] t in trust)
            {
                log[t[0]]--;
                log[t[1]]++;
            }
            for(int i=1; i<=n; i++)
            {
                if (log[i] == n-1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}