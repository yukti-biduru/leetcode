using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    public class UniqueOccurances
    {
        public bool UniqueOccurrences(int[] arr)
        {
            // loop through list
            Dictionary<int,int> pairs = new Dictionary<int,int>();
            int curr_value;
            foreach(int num in arr)
            {
                if (pairs.ContainsKey(num))
                {
                    curr_value = pairs[num];
                    pairs[num] = curr_value + 1;
                }
                else
                {
                    pairs.Add(num, 1);
                }
            }
            int[] values = pairs.Values.ToArray();
            Array.Sort(values);
            if(values.Distinct().Count() != values.Length )
            {
                return false;
            }
            return true;
            // count of all the elements added to a hash map 
            // element -> count
        }
    }
}
