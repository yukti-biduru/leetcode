using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Solutions
{
    internal class DecodeStrings
    {
        public string DecodeString(string s)
        {
            Stack<char> stk = new Stack<char>();
            string curr = "";
            int i = 0;
            string res = "";
            string val = "";
            foreach (char c in s)
            {
                stk.Push(c);
                if (c == ']')
                {
                    stk.Pop();

                    while (stk.Peek() != '[')
                    {
                        curr += stk.Pop();
                    }
                    stk.Pop();
                    while(stk.Count > 0 && stk.Peek() <58 && stk.Peek()>47)
                    {
                        val += stk.Pop();
                    }
                    i = Int32.Parse(String.Join("",val.Reverse()));
                    val = "";
                    Console.WriteLine(curr);
                    Console.WriteLine(i);
                    curr = new string(curr.Reverse().ToArray());
                    for (int j = 0; j < i; j++)
                    {
                        curr.ToList().ForEach(x => stk.Push(x));
                    }
                    Console.WriteLine(curr);

                    curr = "";
                    Console.WriteLine("curr reset "+ curr);

                }
                char[] result = stk.ToArray();
                res = new string(result.Reverse().ToArray());
            }
            return res;
        }
    }
}
