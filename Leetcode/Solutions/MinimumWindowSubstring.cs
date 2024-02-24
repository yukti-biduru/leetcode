using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class MinimumWindowSubstring
    {
        public string MinWindow(string s, string t)
        {
            int left = 0, right = 0;
            if (s.Length < t.Length)
            {
                return "";
            }
            char[] str_s = s.ToCharArray();
            Array.Sort(str_s);
            char[] str_t = t.ToCharArray();
            Array.Sort(str_t);
            if (s.Length == t.Length)
            {
                return str_s.SequenceEqual(str_t) ? s : "";
            }
            while(right<s.Length && !Check(s.Substring(left, right), t))
            {
                right++;
            }
            while(Check(s.Substring(left,right),t))
            {
                left++;
            }
            return s.Substring(left, right);
        }

        public bool Check (string subString, string t)
        {
            foreach(char c in subString)
            {
                if (t.Contains(c))
                {
                    t = t.Remove(t.IndexOf(c), 1);
                }
                if (t.Length == 0)
                {
                    return true;
                }
            }
            return t.Length == 0;
        }
    }
}
