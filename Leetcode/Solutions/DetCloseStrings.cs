using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class DetCloseStrings
    {
        public bool CloseStrings(string word1, string word2)
        {
            if (word1.Length != word2.Length) 
            {
                return false;
            }
            char[] w1_array = word1.ToCharArray();
            char[] w2_array = word2.ToCharArray();
            Array.Sort(w1_array);
            Array.Sort(w2_array);
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            foreach(char c in w1_array)
            {
                if(dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (char c in w2_array)
            {
                if (dict2.ContainsKey(c))
                {
                    dict2[c]++;
                }
                else
                {
                    dict2.Add(c, 1);
                }
            }

            string w1 = new(w1_array);
            string w2 = new(w2_array);
            if(w1 == w2)
            {
                return true;
            }



            return false;
        }
    }
}
