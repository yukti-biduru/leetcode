using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class LeastNumberofUniqueIntegersAfterKRemovals
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (counts.ContainsKey(i))
                {
                    counts[i]++;
                }
                else
                {
                    counts.Add(i, 1);
                }
            }
            
            var sortedDict = counts.OrderBy(pair => pair.Value).ToList();
            foreach (var kvp in sortedDict)
            {
                if(k>0)
                {
                    if(k>= kvp.Value)
                    {
                        k -= kvp.Value;
                        counts.Remove(kvp.Key);
                    }
                    else
                    {
                        counts[kvp.Key] -= k;
                        k = 0;
                    }
                }
                else
                {
                    break;
                }
            }
            return counts.Count;
        }
    }
}
