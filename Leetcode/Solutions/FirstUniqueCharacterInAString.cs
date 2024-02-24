using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (result.ContainsKey(c))
                {
                    result[c]++;
                }
                else
                {
                    result.Add(c, 1);
                }
            }
            if (result.ContainsValue(1))
            {
                for(int i=0; i<s.Length; i++)
                {
                    if (result[s[i]] == 1)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
        public int FirstUniqChar1(string s)
        {
            // cant find the first unique char until you span the whole string 
            // span the whole string
            // add each char to dictionary with the index
            Dictionary<char, int> result = new Dictionary<char, int>();
            int index = 0;
            string no = "";
            foreach (char c in s)
            {
                // if char repeats then remove char from dictionary and remove it from the string 
                if (!result.ContainsKey(c) && !no.Contains(c))
                {
                    result.Add(c, index);
                }
                else
                {
                    result.Remove(c);
                    no = new string(no.Append(c).ToArray());
                }
                index++;
            }
            // after spanning all get the key for the laest value of index  
            int[] values = result.Values.ToArray();
            Array.Sort(values);
            return (values.Length > 0) ? values[0] : -1;
        }
    }
}
