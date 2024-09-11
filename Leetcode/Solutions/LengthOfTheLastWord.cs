using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class LengthOfTheLastWord
    {
        public int LengthOfLastWord(string s)
        {
            s = new string(s.Reverse().ToArray());
            s = s.Trim();
            bool stop = false;
            int ct = 0,i=0;
            while (s[i] != ' ' && i<s.Length)
            {
                ct++;
                i++;
            }
            return ct;
        }
    }
}
